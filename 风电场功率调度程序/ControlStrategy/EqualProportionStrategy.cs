using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序.ControlStrategy
{
    public class EqualProportionStrategy : IControlStrategy
    {

        /// <summary>
        /// 等比例调节
        /// </summary>
        public EqualProportionStrategy()
        {
            ;
        }
        public string controlName
        {
            get; set;
        }

        public bool Caculate(string setActivcPowerLimitValue)
        {
            throw new NotImplementedException();
        }

        public string GetCommandSqlString(string setActivcPowerLimitValue)
        {
            throw new NotImplementedException();
        }

        public void Init(Windfarm wf)
        {
            

        }
    }
}
