using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序
{
   public interface IDeviceTag
    {
      Dictionary<string, Tag> WindfarmTagList { get; set; }
      Dictionary<string, string> DeviceTagList { get; set; } 
      double GetTagValue(string key );
      string GetSetTagValueSqlString(string PropetyKey, string Value);

      bool SetTagValue(string PropetyKey, string Value);
    }
}
