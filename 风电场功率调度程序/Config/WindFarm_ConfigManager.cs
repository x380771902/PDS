using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; 
using System.Timers;

namespace 风电场功率调度程序
{
    public class WindFarm_ConfigManager
    {


        public XmlDocument doc = null;
        private RedisHelper rh = null;
        public MysqlDBHelper Mysqldbhelp { get; set; } 
        private Timer timer_GetTagList = null;
        public WindFarm_ConfigManager() { 
            LoadConfigFile();
        }


        public WindFarm_ConfigManager(string path) { }

        public Windfarm ConfigWindfarm { get; set; }

        public Dictionary<string, Tag> TagList { get; set; }

        private bool GetTagList()
        {
            try
            { 
                
                if (TagList!=null)
                {
                   
                } 
                TagList = rh.StringGet<Dictionary<string, Tag>>("RealTimeData:");
                foreach (var item in this.ConfigWindfarm.ListTurbines)
                {
                    item.WindfarmTagList = TagList;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            } 
            finally
            {   
            } 
        }

        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <returns></returns>
        private bool LoadConfigFile()
        {
            try
            { 
                doc = new XmlDocument(); 
                doc.Load(@"WindFarm_Config.xml"); 
                ConfigWindfarm = new Windfarm();
                //加载风场配置信息

                //连接实时数据驱动
                rh = new RedisHelper(1, "127.0.0.1");

                load_Windfarm(doc);
                //加载设备信息
                load_Devices(doc);

                
                //初始化数据更新计时器
                InitTimer();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex ; 
            }
        } 
         
        /// <summary>
        /// 加载风场信息
        /// </summary>
        /// <param name="doc"></param>
        private void load_Windfarm(XmlDocument doc)
        { 
             XmlNode windfarminfonode =  doc.SelectSingleNode("ServerConfig/WindFarmInfo") ;  
             ConfigWindfarm.WindfarmName = windfarminfonode.SelectSingleNode("Title").InnerText;
             ConfigWindfarm.GridCapacity = int.Parse( windfarminfonode.SelectSingleNode("GridCapacity").InnerText);
             ConfigWindfarm.ActivePower1MinitueMaxRate = float.Parse(windfarminfonode.SelectSingleNode("ActivePower1MinitueMaxRate").InnerText);
             ConfigWindfarm.ActivePower10MinitueMaxRate = float.Parse(windfarminfonode.SelectSingleNode("ActivePower10MinitueMaxRate").InnerText);          
             ConfigWindfarm.SettingCycle = int.Parse(windfarminfonode.SelectSingleNode("SettingCycle").InnerText.Trim());
        }

        /// <summary>
        /// 加载设备列表
        /// </summary>
        private void load_Devices(XmlDocument doc)
        {
            foreach (XmlNode i in doc.GetElementsByTagName("Device"))
            { 
                Turbine t = null;
                if (i.Attributes.GetNamedItem("Enable").Value.ToLower() == "true")
                {
                    t = new Turbine(Int32.Parse(i.Attributes.GetNamedItem("TurbineID").Value));

                    t.Enable = true;
                    t.DeviceType = i.Attributes.GetNamedItem("DeviceType").Value;

                    t.MaxActivePowerSp = Int32.Parse(i.Attributes.GetNamedItem("MaxActivePowerSp").Value);
                    t.MiniActivePowerSp = Int32.Parse(i.Attributes.GetNamedItem("MiniActivePowerSp").Value);

                    t.MaxCnvPhiSp = float.Parse(i.Attributes.GetNamedItem("MaxCnvPhiSp").Value);
                    t.MiniCnvPhiSp = float.Parse(i.Attributes.GetNamedItem("MiniCnvPhiSp").Value);

                    t.MaxReactivePowerSp = Int32.Parse(i.Attributes.GetNamedItem("MaxReactivePowerSp").Value);
                    t.MiniReactivePowerSp = Int32.Parse(i.Attributes.GetNamedItem("MiniReactivePowerSp").Value);

                    t.Priority = Int32.Parse(i.Attributes.GetNamedItem("Priority").Value);

                    t.AutoStart = bool.Parse(i.Attributes.GetNamedItem("AutoStart").Value);
                    t.AutoStop = bool.Parse(i.Attributes.GetNamedItem("AutoStart").Value);

                    t.ChangeLimit = Int32.Parse(i.Attributes.GetNamedItem("ChangeLimit").Value);
                    t.IsSample = bool.Parse(i.Attributes.GetNamedItem("IsSample").Value);

                    t.DeviceTagList = new Dictionary<string, string>();
                    foreach (XmlNode item in i.ChildNodes)
                    {
                        string tagkey = item.Attributes.GetNamedItem("PropertyName").Value;
                        string tagvalue = item.Attributes.GetNamedItem("TagName").Value; ;
                        t.DeviceTagList.Add(tagkey, tagvalue);
                    } 
               }
                this.ConfigWindfarm.ListTurbines.Add(t);

            }
        }

        private void InitTimer()
        {
            this.timer_GetTagList = new Timer();
            this.timer_GetTagList.Interval = 1000;
            this.timer_GetTagList.Elapsed += Timer_GetTagList_Elapsed;
            this.timer_GetTagList.Enabled = true;
          
          
        }

        private void Timer_GetTagList_Elapsed(object sender, ElapsedEventArgs e)
        {
            GetTagList();
        }
    }
}
