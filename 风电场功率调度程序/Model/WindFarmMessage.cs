using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序
{
    public class WindFarmMessage
    {

        public static bool AddOperateMessage(string message,string userName)
        {
            try
            {
               string sqlstring = string.Format("insert into operatelog (logtime,username,logContext) " +
                " VALUES( '{0}', '{1}', '{2}')",  DateTime.UtcNow.ToString(), userName, message);  
                int i = MysqlDBHelper.ExecuteCommand(sqlstring);
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                } 
            }
            catch  
            {
               return false ; 
            } 
        } 

        public static bool AddErrorlogMessage(string message, string userName)
        {
            try
            {
                string sqlstring = string.Format("insert into errorlog(logtime,username,logContext) " +
                 " VALUES( '{0}', '{1}', '{2}')", DateTime.UtcNow.ToString(), userName, message);
                int i = MysqlDBHelper.ExecuteCommand(sqlstring);
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public static bool AddSystemlogMessage(string message, string userName)
        {
            try
            {
                string sqlstring = string.Format("insert into Systemlog(logtime,username,logContext) " +
                 " VALUES( '{0}', '{1}', '{2}')", DateTime.UtcNow.ToString(), userName, message);
                int i = MysqlDBHelper.ExecuteCommand(sqlstring);
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }




    }
}
