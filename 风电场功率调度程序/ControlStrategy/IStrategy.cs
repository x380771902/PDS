using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序.ControlStrategy
{
    public interface IControlStrategy
    {


        /// <summary>
        /// 定义策略名称
        /// </summary>
        string controlName { get; set; }

        /// <summary>
        /// 给定当前风场工况,初始化测率参数
        /// </summary>
        /// <param name="wf">当前风场工况</param>
        void Init(Windfarm wf);

        /// <summary>
        /// 执行计算
        /// </summary>
        /// <returns></returns>
        bool Caculate(string setActivcPowerLimitValue);

        /// <summary>
        /// 生成指令集
        /// </summary>
        /// <param name="setActivcPowerLimitValue"></param>
        /// <returns></returns>
        string GetCommandSqlString(string setActivcPowerLimitValue);
             


    }
}
