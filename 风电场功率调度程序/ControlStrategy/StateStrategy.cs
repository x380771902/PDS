using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序 
{
    /// <summary>
    /// 风场可风机状态判定策略
    /// </summary>
    public class StateStrategy  
    {

        public StateStrategy()
        {
             
        }  

        /// <summary>
        /// 计算当前可控风机功率列表、获取有功不可控参数、无功不可控容量
        /// </summary>
        /// <returns>获取当前可控列表可控风机列别</returns>
        public static List<Turbine> Caculate(Windfarm wf)
        {
            List<Turbine> listTurbine = new List<Turbine>();
            float cac = 0;//可控有功功率
            float ucac = 0;//不可控有功功率
            int crac = 0;//可控无功功率
            int ucrac = 0;//不可控无功功率
            foreach (var item in listTurbine)
            {
                //判断是否是样板机、控制模式为远程、风机运行状态值为发电状态
                if (item.IsSample == false || item.LocalOrRemote == false || item.RunState == Turbine.turbineStatu.running)  
                { 
                    cac += item.ActivePower ;
                    crac += item.ReActivePower; 
                    listTurbine.Add(item);
                } 
                else
                {
                    ucac += item.ActivePower;
                    ucrac += item.ReActivePower; 
                }
            } 
            wf.ControllableActivePowerValue = cac;
            wf.ControllableReactivePowerValue = crac;
            wf.UnControlActivePowerValue = ucac;
            wf.UnControlReactivePowerValue = ucrac;

            return listTurbine;
        }
 

       
    }
}
