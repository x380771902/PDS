using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 风电场功率调度程序
{
   public class Config
    {

        public XmlDocument doc=null;
        public XmlNodeList xnlist = null; 
        public List<string> ItemList = null;
        public List<string> ItemTypeList = null;
        public Config() 
        {
            loadConfigFile();
        }

       private void loadConfigFile()
        { 
            doc = new XmlDocument();
            doc.Load(@"XEMC_WindFarm.xml"); 
            //-< servermain:ChannelList >
            //    < servermain:Name >
            // -< servermain:DeviceList > -< servermain:Device >< servermain:Name > Turbine_1 </ servermain:Name >
            //-< servermain:TagList > -
            //   < servermain:Tag >
            //    < servermain:Name > AirPressure </ servermain:Name >
            //    < servermain:Address > 400250 </ servermain:Address >
            //    < servermain:DataType > Word </ servermain:DataType >
            //    < servermain:ReadWriteAccess > Read / Write </ servermain:ReadWriteAccess >
            //    < servermain:ScanRateMilliseconds > 200 </ servermain:ScanRateMilliseconds >
            //    < servermain:Description /></ servermain:Tag >
            ItemList = new List<string>();
            ItemTypeList = new List<string>();
            foreach (XmlNode item in doc.GetElementsByTagName("servermain:ChannelList"))
            {
                string farmName = item.FirstChild.FirstChild.InnerText;
                XmlElement a = item as XmlElement;
                foreach (XmlNode i in a.GetElementsByTagName("servermain:Device"))
                {
                    string turbineName = i.FirstChild.InnerText;

                    XmlElement b = i as XmlElement;
                    foreach (XmlNode j in b.GetElementsByTagName("servermain:Tag"))
                    {
                        foreach (XmlNode k in j.ChildNodes)
                        {
                            if (k.Name == "servermain:Name")
                            {
                                string turbineTag = k.InnerText;
                                string turbineTagDataType = (j.FirstChild as XmlElement).GetElementsByTagName("servermain:DataType").ToString();
                                ItemList.Add(farmName + "." + turbineName + "." + turbineTag);
                            }
                            string ItemType = "";
                            if (k.Name == "servermain:DataType")
                            {
                                ItemType = k.InnerText;
                                ItemTypeList.Add(ItemType);
                            }
                            if (k.Name == "servermain:Scaling")
                            {
                                foreach (XmlNode l in k.ChildNodes)
                                {
                                    if (l.Name == "servermain:ScaledDataType")
                                    {
                                        ItemType = l.InnerText;
                                        ItemTypeList.RemoveAt(ItemTypeList.Count - 1);
                                        ItemTypeList.Add(ItemType);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
