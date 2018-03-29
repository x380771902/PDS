using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 风电场功率调度程序
{
    public class MysqlDBHelper
    {


        //引导数据库连接数据库调用Web.Config文件     
        private static MySqlConnection connection;
        private static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MysqleHosts"].ConnectionString;
        //创建连接
        public static MySqlConnection Connection
        {
            get
            {
                /// MySqlConnection myConn =  new MySqlConnection("server=10.128.2.1;user id=root;password=root;database=xemc_windfarm;CharSet=utf8;");
 
               
               // string connectionString = myConn.ConnectionString;
                if (connection == null)
                {
                    connection = new MySqlConnection(connectionString);
                    //打开连接
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }

        //（无参）返回执行的行数(删除修改更新)
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:检查 SQL 查询是否存在安全漏洞")]
        public static int ExecuteCommand(string safeSql)
        {
            MySqlCommand cmd = new MySqlCommand(safeSql, Connection);
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        //（有参）
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:检查 SQL 查询是否存在安全漏洞")]
        public static int ExecuteCommand(string sql, params MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }

        //（无参）返回第一行第一列(删除修改更新)
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:检查 SQL 查询是否存在安全漏洞")]
        public static int GetScalar(string safeSql)
        {
            MySqlCommand cmd = new MySqlCommand(safeSql, Connection);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        //（有参）
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:检查 SQL 查询是否存在安全漏洞")]
        public static int GetScalar(string sql, params MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        //返回一个DataReader（查询）
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:检查 SQL 查询是否存在安全漏洞")]
        public static MySqlDataReader GetReader(string safeSql)
        {
            MySqlCommand cmd = new MySqlCommand(safeSql, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:检查 SQL 查询是否存在安全漏洞")]
        public static MySqlDataReader GetReader(string sql, params MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        //返回一个DataTable
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:检查 SQL 查询是否存在安全漏洞")]
        public static DataTable GetDataSet(string safeSql)
        {
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(safeSql, Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:检查 SQL 查询是否存在安全漏洞")]
        public static DataTable GetDataSet(string sql, params MySqlParameter[] values)
        {
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }


        //存储过程操作

        /// <summary>
        /// 执行存储过程，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlDataReader</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters)
        {

            Connection.Open();
            MySqlCommand cmd = new MySqlCommand(storedProcName, connection);

            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (MySqlParameter parameter in parameters)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput ||
                         parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "ds");
                cmd.Parameters.Clear();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }
    }

 
}
 
