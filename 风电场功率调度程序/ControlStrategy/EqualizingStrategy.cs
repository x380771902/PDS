﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序
{
   public class EqualizingStrategy : IControlStrategy
    {

        /// <summary>
        /// 均衡调节
        /// </summary>
        public EqualizingStrategy()
        {

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
            throw new NotImplementedException();
        }

        public void Init(Windfarm wf)
        {
            throw new NotImplementedException();
        }
    }
}
