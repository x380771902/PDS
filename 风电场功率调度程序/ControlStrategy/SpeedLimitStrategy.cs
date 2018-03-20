using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序
{
    class SpeedLimitStrategy : IControlStrategy
    {

        /// <summary>
        /// 限速率模式
        /// </summary>
        public SpeedLimitStrategy()
        {
            ;
        }
        public string controlName
        {
            get;set;
            
        }

        public bool Caculate(string setActivcPowerLimitValue)
        {
            return false;
        }

        public string GetCommandSqlString(string setActivcPowerLimitValue)
        {
            return "";
        }

        public void Init(Windfarm wf)
        {
            ;
        }
    }
}
