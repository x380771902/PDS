using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序.ControlStrategy
{
    public class LowPowerOutageStrategy : IControlStrategy
    {
        public string controlName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
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
            throw new NotImplementedException();
        }
    }
}
