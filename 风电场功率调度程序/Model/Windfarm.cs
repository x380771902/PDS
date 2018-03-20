using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 风电场功率调度程序
{
   public class Windfarm
    {
        public Windfarm()
        {
            this.ListTurbines = new List<Turbine>();
        }

        public Windfarm(string windFarmNameint ,int turbineNumber)
        {
            WindfarmName = windFarmNameint;
            ListTurbines = null;
            ListTurbines = new List<Turbine>();
            for (int i = 0; i < turbineNumber; i++)
            {
                Turbine  t = new Turbine(i + 1);
                Thread.Sleep(10);
                ListTurbines.Add(t);
             } 
            startQueue = new List<Turbine>();
            stopQueue = new List<Turbine>();
        }

        public List<Turbine> ListTurbines
        {
            get; set; }

       public List<Turbine> stopQueue
        {
            get; set;
        }

        public List<Turbine> startQueue
        {
            get; set;
        }
        
        public string WindfarmName
        {
            get ; set ;
        }

        public int TatolActivePower
        {
            get
            {
                float a=0f;
                for (int i = 0; i < ListTurbines.Count; i++)
                {
                    a = a + ListTurbines[i].ActivePower;
                 
                }
                return (int) a;
            }
            set { ; }
        }

       public int TheoreticalPower
       {
            get
            {
                float a = 0f;
                for (int i = 0; i < ListTurbines.Count; i++)
                {
                    a = a + (float)ListTurbines[i].getActivePowerFromWindSpeed((double)ListTurbines[i].WSpeedNac);
                }
                return (int)a;
            }
            set {; } 
        } 

        private int limitActivePower;
        public int LimitActivePower
        {
            get
            {
                float a = 0f;
                for (int i = 0; i < ListTurbines.Count; i++)
                {
                    a = a + ListTurbines[i].LimitActivePower;
                }

                limitActivePower = (int)a;
                return limitActivePower;
            }
            set
            {

              var a = (float)value / GridCapacity;  //获取比例系数
              if (value == this.GridCapacity)//设定值等于并网容量，全场风机给定可发有功最大值MaxActivePowerSp
                {
                    foreach (var i in ListTurbines)
                    {
                       i.LimitActivePower = i.MaxActivePowerSp; 
                    }
                }
                else if (value==0f)
                {
                    foreach (var i in ListTurbines)
                    { 
                        i.RunState = Turbine.turbineStatu.limitedPowerStop;
                    }
                }
                else
                {
                    foreach (var i in ListTurbines)
                    {
                       i.LimitActivePower = i.MaxActivePowerSp * a;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public float AvgWindSpeed
        {
            get { return (float)ListTurbines.Average(e => Math.Round(e.WSpeedNac, 1)); }
            set{}
        }

        private void limitstopturbine()
       {
          
           if (this.LimitActivePowerSp < TatolActivePower)
           {
                stopQueue.Clear();
                for (int i = 0; i < ListTurbines.Count; i++)
               {
                   if (ListTurbines[i].LimitActivePower <= ListTurbines[i].MiniActivePowerSp && ListTurbines[i].RunState != Turbine.turbineStatu.limitedPowerStop)
                   {
                       this.stopQueue.Add(ListTurbines[i]);
                   }
                   
               } 
           }
       }

       public void  StartLimitTurbine()
       {

            limitstartturbine();
            if (startQueue.Count > 0)
            {
                ListTurbines.Find(e => e.TurbineID == startQueue.First<Turbine>().TurbineID).RunState = Turbine.turbineStatu.limitedPowerRunning;
               // startQueue.RemoveAt(0);
            }

           stopQueue.Clear();

        }

        public void StopLimitTurbine()
        {
            limitstopturbine(); 
            if (stopQueue.Count > 0)
            {


                ListTurbines.Find(e => e.TurbineID == stopQueue.First<Turbine>().TurbineID).RunState = Turbine.turbineStatu.limitedPowerStop;


               // stopQueue.RemoveAt(0);
                
            }

            startQueue.Clear();
        }

        private void limitstartturbine()
        {
            startQueue.Clear();
                for (int i = 0; i < ListTurbines.Count; i++)
                {
                    if (ListTurbines[i].RunState ==  Turbine.turbineStatu.limitedPowerStop)
                    {
                        this.startQueue.Add(ListTurbines[i]);
                    }
                } 
        }

        public int GridCapacity
        {
            get; 
            set;
        }

        public float ActivePower10MinitueMaxRate
        {
            get;

            set;
        }

        public float ActivePower1MinitueMaxRate
        {
            get;
            set;
        }
        public int LimitActivePowerSp { get; internal set; }

        /// <summary>
        /// 不可控无功
        /// </summary>
        public float UnControlActivePowerValue
        {
            get;set;
        }

        /// <summary>
        /// 不可控无功
        /// </summary>
        public int UnControlReactivePowerValue
        {
            get; set;
        }

        /// <summary>
        /// 可控无功
        /// </summary>
        public float ControllableActivePowerValue
        {
            get; set;
        }

        /// <summary>
        /// 可控无功
        /// </summary>
        public int ControllableReactivePowerValue
        {
            get; set;
        }




        public int SettingCycle
        {
            get;
            set;
        }
    }
}
