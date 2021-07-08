using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace test
{
    public class DBHelper
    {
        //设置连接字符串
        public static string str = "Data Source=.;Initial Catalog=StudentDB;Integrated Security=True";
        //创建连接对象
        public static SqlConnection conn = null;

        public static void init() 
        {
            if (conn==null)
            {
                conn = new SqlConnection(str);
            }
            if (conn.State==ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //查询方法
        public static DataTable GetDataTable(string sql) 
        {
            init();
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            adp.Fill(table);
            conn.Close();
            return table;
        }

        public static bool ExecuteNonQuery(string sql) 
        {
            init();
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
    }
}
