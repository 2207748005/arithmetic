using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Models;

namespace BLL
{
    public class UserBLL
    {
        public static DataTable select(T_user user) 
        {
            return UserDal.serch(user);
        }
        public static bool insertUser(T_user user) 
        {
            return UserDal.insert(user);
        }
        public static bool delete(T_user user) 
        {
            return UserDal.del(user);
        }
        //模糊查询
        public static DataTable likeTable(T_user user) 
        {
            return UserDal.table(user);
        }
        public static DataTable idSelect(T_user user) 
        {
            return UserDal.selectID(user);
        }
        public static bool update(T_user user) 
        {
            return UserDal.upd(user);
        }
        public static DataTable GetLogin(T_user user) 
        {
            return UserDal.Login(user);
        }
    }
}
