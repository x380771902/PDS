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

        /// <summary>
        /// 风场模拟器构造函数
        /// </summary>
        /// <param name="windFarmNameint"></param>
        /// <param name="turbineNumber"></param>
        public Windfarm(string windFarmNameint, int turbineNumber)
        {
            WindfarmName = windFarmNameint;
            ListTurbines = null;
            ListTurbines = new List<Turbine>();
            for (int i = 0; i < turbineNumber; i++)
            {
                Turbine t = new Turbine(i + 1);
                Thread.Sleep(10);
                ListTurbines.Add(t);
            }
            startQueue = new List<Turbine>();
            stopQueue = new List<Turbine>();
        }

        public List<Turbine> ListTurbines
        {
            get; set;
        }

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
            get; set;
        }

        public int TatolActivePower
        {
            get
            {
                float a = 0f;
                for (int i = 0; i < ListTurbines.Count; i++)
                {
                    a = a + ListTurbines[i].ActivePower;

                }
                return (int)a;
            }
            set {; }
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

        /// <summary>
        /// 风场功率限定值
        /// </summary>
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
                //if (value == this.limitActivePower)//重复值不处理
                //    return;
                var a = (float)value / GridCapacity;  //获取比例系数
                if (value == this.GridCapacity)//设定值等于并网容量，全场风机给定可发有功最大值MaxActivePowerSp
                {
                    foreach (var i in ListTurbines)
                    {
                        i.LimitActivePower = i.MaxActivePowerSp;
                    }
                }
                else if (value == 0f)
                {
                    foreach (var i in ListTurbines)
                    {
                        //i.RunState = Turbine.turbineStatu.limitedPowerStop;
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
        /// 全场平均分数
        /// </summary>
        public float AvgWindSpeed
        {
            get { return (float)ListTurbines.Average(e => Math.Round(e.WSpeedNac, 1)); }
            set { }
        }

        private void limitstopturbine()
        { 
            if (this.LimitActivePower < TatolActivePower)
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

        public void StartLimitTurbine()
        { 
            limitstartturbine();
            if (startQueue.Count > 0)
            {
                //ListTurbines.Find(e => e.TurbineID == startQueue.First<Turbine>().TurbineID).RunState = Turbine.turbineStatu.limitedPowerRunning;
                // startQueue.RemoveAt(0);
            } 
            stopQueue.Clear(); 
        }

        public void StopLimitTurbine()
        {
            limitstopturbine();
            if (stopQueue.Count > 0)
            { 
                //ListTurbines.Find(e => e.TurbineID == stopQueue.First<Turbine>().TurbineID).RunState = Turbine.turbineStatu.limitedPowerStop; 
                // stopQueue.RemoveAt(0); 
            } 
            startQueue.Clear();
        }


        private void limitstartturbine()
        {
            startQueue.Clear();
            for (int i = 0; i < ListTurbines.Count; i++)
            {
                if (ListTurbines[i].RunState == Turbine.turbineStatu.limitedPowerStop)
                {
                    this.startQueue.Add(ListTurbines[i]);
                }
            }
        }

        /// <summary>
        /// 全场并网容量
        /// </summary>
        public int GridCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// 10分钟变化速率
        /// </summary>
        public float ActivePower10MinitueMaxRate
        {
            get;

            set;
        }

        /// <summary>
        /// 1分钟变化速率
        /// </summary>
        public float ActivePower1MinitueMaxRate
        {
            get;
            set;
        }

        /// <summary>
        /// 全场功率设定值
        /// </summary>
      

        /// <summary>
        /// 不可控无功
        /// </summary>
        public float UnControlActivePowerValue
        {
            get; set;
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


        /// <summary>
        /// 是否忽略样板机
        /// </summary>
        public bool IsIgnoreSample { get; set; }

        /// <summary>
        /// 控制整定周期
        /// </summary>
        public int SettingCycle
        {
            get; set;
        }


        /// <summary>
        /// 是否开启低功率自动
        /// </summary>
        public bool EnableAutoStopTurbine
        {
            get; set;
        }

        /// <summary>
        /// 是否开启自动开机
        /// </summary>
        public bool EnableAutoStartTurbine
        {
            get; set;
        }

        /// <summary>
        /// 是否启用速率控制模式
        /// </summary>
        public bool EnableLimitActivePowerSpeed
        {
            get;  set; 
        }

        /// <summary>
        /// 控制策略模式
        /// </summary>
        public int ControlStrategy
        { get; set; }

        private bool pwrAtEnable = false;
     
        /// <summary>
        /// 全场有功使能信号
        /// </summary>
        public bool PwrAtEnable
        {
            get
            {
                return pwrAtEnable;
            } 
            set
            {
                pwrAtEnable = value;
                foreach (var i in this.ListTurbines)
                { 
                    i.PwrAtEnable = value;
                }
            }
        }

        private bool pwrRtEnable = false;

        /// <summary>
        /// 全场无功使能信号
        /// </summary>
        public bool PwrRtEnable
        {
            get
            {
                return pwrRtEnable;
            }
            set
            {
                pwrRtEnable = value;
                foreach (var i in this.ListTurbines)
                {
                    i.PwrAtEnable = value;
                }
            }
        }

        /// <summary>
        /// 连接状态
        /// </summary>
        public int ConnectState
        {
            get;set;
        }
    }
}
