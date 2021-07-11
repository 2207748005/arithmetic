using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {
        public static string str = "Data Source=.;Initial Catalog=shopDB;Integrated Security=True";
        public static SqlConnection conn = null;
        public static void init() 
        {
            if (conn==null)
            {
                conn = new SqlConnection(str);
            }
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            if (conn.State==ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }

        public static DataTable GetDataTable(string sql) 
        {
            init();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            adp.Fill(dt);
            conn.Close();
            return dt;
        }
        public static bool ExecuteNonQuery(string sql) 
        {
            init();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            return rs > 0;
        }
    }
}
