using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序
{
    public class Turbine:IDeviceTag
    {
        private DateTime lastdatetime;

        private double[] ws =
        {
            0, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5, 13, 14,
            15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,25.1, 30
        };

        private double[] activepower =
       {
            0, 1, 67, 108, 157, 225, 301, 402, 513, 645, 795, 969, 1167, 1388, 1628, 1869, 2000,
            2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000,0, 0
        };

        /// <summary>
        /// 风机构造函数
        /// </summary>
        public Turbine(int turid)
        {
            this.TurbineID = turid;
            //初始化风机最后一次停机时间
            lastdatetime = DateTime.Now;
            //初始化风机状态

            //初始化功率曲线对照表
            ws = Turbine.Interpolation(ws, 3600);
            activepower = Turbine.Interpolation(activepower, 3600);  
        }

        public Turbine()
        {
        }

        static T RandomEnumValue<T>(int maxValue)
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random().Next(maxValue));
        }
         
        private turbineStatu runstate; 

        private float limitActivePower;

        /// <summary>
        /// 风机有功功率限定值
        /// </summary>
        public float LimitActivePower
        {
            get { return (float)GetTagValue("PwrAtSp"); }
            set
            {
                if (value > this.MaxActivePowerSp)
                {
                    limitActivePower = 2000f;
                }
                else if (value <= MiniActivePowerSp) //功率设定最小值
                {
                    limitActivePower = MiniActivePowerSp;
                }
                else limitActivePower = value;

                var a  =  SetTagValue( "PwrAtSp", limitActivePower.ToString());

            }
        }

        /// <summary>
        /// 风机状态
        /// </summary>
        public enum turbineStatu
        {
            standby,
            running,
            stop,
            error,
            limitedPowerRunning,
            limitedPowerStop,
            unknown
        }



        #region 属性
        /// <summary>
        /// 当前风机状态
        /// </summary>
        public turbineStatu RunState
        {
            get { 
                int result = (int)GetTagValue("TurbineState"); 
                if (result == 6 ||result == 7) //运行
                {
                    runstate = turbineStatu.running;
                }
                else if (result == 2 || result == 3 || result == 8 || result == 9) //停机
                {
                    runstate = turbineStatu.stop;
                }
                else if (result == 1) //故障
                {
                    runstate = turbineStatu.error;
                }
                else if ( result == 4 || result == 5)//待机
                { runstate = turbineStatu.standby; }
                else  
                {
                  runstate = turbineStatu.unknown;
                } 
                return runstate; } 
        }

        /// <summary>
        /// 远程或者就地控制状态0=远程 1=本地
        /// </summary>
        public bool LocalOrRemote
        {
            get
            {
                return bool.Parse(GetTagValue("LocalOrRemote").ToString());
            }
        }

        /// <summary>
        /// 最后一次停机时间间隔
        /// </summary>
        public TimeSpan GnPwrLimDownTime
        {
            get
            ;
            set;
        }

        /// <summary>
        /// 最后一次风机停机时间
        /// </summary>
        public DateTime LastDateTime
        {
            get { return lastdatetime; }
            set { lastdatetime = value; }
        }
        private float wSpeedNac = 0;

        /// <summary>
        /// 机舱测量风速
        /// </summary>
        public float WSpeedNac
        {
            get { return (float)GetTagValue("WindSpeed"); }
            set { wSpeedNac = value; }

        }
        /// <summary>
        /// 风机风向绝对值
        /// </summary>
        public float WDirAbs { get; set; }
        /// <summary>
        /// 风机编号
        /// </summary>
        public int TurbineID { get; set; }


        /// <summary>
        /// 线路损耗
        /// </summary>
        public double LineLossActivePower
        {
            get; set;
        } 

        /// <summary>
        ///  风机名称
        /// </summary>
        public string TurbineName
        {
            get; set;
        }

        /// <summary>
        /// 是否启用设备
        /// </summary>
        public bool Enable
        {
            get;
            set;
        }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType
        {
            get; set;
        }

        /// <summary>
        /// 调度优先级
        /// </summary>
        public int Priority
        {
            get; set;
        }

        /// <summary>
        /// 最大功率限定值
        /// </summary>
        public int MaxActivePowerSp
        {
            get; set;
        }

        /// <summary>
        /// 最小功率限定值
        /// </summary>
        public int MiniActivePowerSp
        {
            get; set;
        }

        /// <summary>
        /// 最大无功限定值
        /// </summary>
        public int MaxReactivePowerSp
        {
            get; set;
        }

        /// <summary>
        /// 最小无功限定值
        /// </summary>
        public int MiniReactivePowerSp
        {
            get; set;
        }

        /// <summary>
        /// 最大功率因素
        /// </summary>
        public float MaxCnvPhiSp
        {
            get; set;
        }

        /// <summary>
        /// 功率曲线
        /// </summary>
        public PowerCurve Pc
        {
            get; set;
        }

        /// <summary>
        /// 自动开机是否启用
        /// </summary>
        public bool AutoStart
        {
            get; set;
        }

        /// <summary>
        /// 自动开机是否启用
        /// </summary>
        public bool AutoStop
        {
            get; set;
        }

        /// <summary>
        /// 限定幅值大小
        /// </summary>
        /// <value>200</value>
        public int ChangeLimit
        {
            get; set;
        }

        /// <summary>
        /// 是否为样板机
        /// </summary>
        public bool IsSample
        {
            get; set;
        } 
       
        /// <summary>
        /// 最小功率因素
        /// </summary>
        public float MiniCnvPhiSp
        {
            get;
            set;
        }

        /// <summary>
        /// 标记集合
        /// </summary>
        public Dictionary<string, string > DeviceTagList
        {
            get;
            set;
        }

        public Dictionary<string, Tag> WindfarmTagList
        {
            get;
            set;
        }

        public double PowerFactor
        {
            get
            {
                return ( GetTagValue("CnvPhiSp"));
            }

            set
            {
                ;
            }
        }

        #endregion
         

        #region 方法

        /// <summary>
        /// 启动风机
        /// </summary>
        public void startTurbuie()
        {
           
        }

        /// <summary>
        /// 获取机舱风速法-理论功率
        /// </summary>
        /// <param name="wdspeed"></param>
        /// <returns></returns>
        public double getActivePowerFromWindSpeed(double wdspeed)
        {
            for (int i = 0; i < 5000; i++)
            {
                if (Math.Round(wdspeed, 1) == Math.Round(ws[i], 1))
                {
                    return Math.Round(activepower[i], 0);
                }
            }
            return 0.0d;
        }
         
        /// <summary> 
        /// 分段线性插值，将一组数插值为所需点数 
        /// </summary> 
        /// <param name="dataIn">待插值的数据数组</param> 
        /// <param name="n">插值点数</param> 
        /// <returns>插值后的数据数组</returns> 
         
        public string GetSetTagValueSqlString(string PropetyKey, string Value)
        {
            try
            {
                string tagid = "";
                string sqlstring = "";
                if (this.DeviceTagList != null || this.DeviceTagList.ContainsKey(PropetyKey))
                {
                     DeviceTagList.TryGetValue(PropetyKey, out tagid); 
                    sqlstring = string.Format( "INSERT INTO writecommand (Tagid ,TagValue,TagTimestamp,SendResult)" +
                  " VALUES( '{0}', '{1}', '{2}', '{3}')", tagid, Value, DateTime.Now.ToString(),"N"); 
                }
                return sqlstring;
            }
            catch (Exception)
            { 
                return "";
            } 
        }

        /// <summary>
        /// 插值函数
        /// </summary>
        /// <param name="dataIn"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double[] Interpolation(double[] dataIn, int n)
        {
            double[] dataOut = new double[n];
            int lenIn = dataIn.Length;
            double[] a = new double[lenIn];
            double[] divIn = new double[lenIn];
            double[] divOut = new double[n];
            divIn[0] = 0;
            for (int i = 1; i < lenIn; i++)
            {
                divIn[i] = divIn[i - 1] + 1;
            }
            divOut[0] = 0;
            for (int i = 1; i < n; i++)
            {
                divOut[i] = divOut[i - 1] + lenIn / Convert.ToDouble(n);
            }
            int k = 0;
            for (int i = k; i < n; i++)
            {

                for (int j = 0; j < lenIn - 1; j++)
                {
                    if (divOut[i] >= divIn[j] && divOut[i] < divIn[j + 1])
                    {
                        dataOut[i] = (dataIn[j + 1] - dataIn[j]) * (divOut[i] - divIn[j]) / (divIn[j + 1] - divIn[j]) +
                                     dataIn[j];
                        k = i;
                    }
                }
            }
            return dataOut;
        }

        public double GetTagValue(string PropetyKey)
        { 
            try
            {
                string tagid = "";
                Tag result = new Tag();
                if (this.DeviceTagList != null || this.DeviceTagList.ContainsKey(PropetyKey))
                {
                    DeviceTagList.TryGetValue(PropetyKey, out tagid);
                    WindfarmTagList.TryGetValue(tagid, out result);
                    return result.TagValue;
                }
                return 0.0d;
            }
            catch (Exception)
            {

                return 0.0d;
            }

        }

        /// <summary>
        /// 设定属性值指令
        /// </summary>
        /// <param name="PropetyKey">属性名称</param>
        /// <param name="Value">属性数值</param>
        /// <returns>指令生产结果 true=成功 false=失败</returns>
        public bool SetTagValue(string PropetyKey, string Value)
        {
            try
            {
               string sqlString = GetSetTagValueSqlString(PropetyKey, Value);
               int result =  MysqlDBHelper.ExecuteCommand(sqlString);
               if (result > 0 )
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception  )
            {
                return false;
            }
        }


        /// <summary>
        /// 当前风速
        /// </summary>
        public float WindSpeed
        {
            get { return (float)GetTagValue("WindSpeed"); }
        }

        /// <summary>
        /// 当前有功功率
        /// </summary>
        public float ActivePower
        {
            get
            {
                return (float)GetTagValue("CnvGdPwrAt");
            }
        }


        /// <summary>
        /// 当前有功功率
        /// </summary>
        public int ReActivePower
        {
            get
            {
                return   (int)GetTagValue("CnvGdPwrRt");  
            }

        }
        #endregion


    }
}