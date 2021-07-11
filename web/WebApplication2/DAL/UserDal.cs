using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace DAL
{
    public class UserDal
    {
        public static DataTable serch(T_user user) 
        {
            string sql = $"select * from T_user";
            return DBHelper.GetDataTable(sql);
        }
        //新增
        public static bool insert(T_user user) 
        {
            string sql = $"insert into T_user(name,trueName,cardId,email,telephone,qqId)  values('{user.name}','{user.trueName}','{user.cardId}','{user.email}','{user.telephone}','{user.qqId}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //删除 
        public static bool del(T_user user) 
        {
            string sql = $"delete from T_user where id={user.id}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //模糊查询
        public static DataTable table(T_user user) 
        {
            string sql = $"select * from T_user where name like '%{user.name}%'";
            return DBHelper.GetDataTable(sql);
        }
        //根据id查找
        public static DataTable selectID(T_user user) 
        {
            string sql = $"select * from T_user where id={user.id}";
            return DBHelper.GetDataTable(sql);
        }
        //修改
        public static bool upd(T_user user) 
        {
            string sql = $"update T_user set name='{user.name}',trueName='{user.trueName}',email='{user.email}',cardId='{user.cardId}',telephone='{user.telephone}',qqId='{user.qqId}' where id={user.id}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //验证登录
        public static DataTable Login(T_user user) 
        {
            string sql = $"select * from T_user where name='{user.name}' and pwd='{user.pwd}'";
            return DBHelper.GetDataTable(sql);
        }
    }
}
