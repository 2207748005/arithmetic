using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Models;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            T_user user = new T_user()
            {
                name = this.name.Value,
                pwd = this.password.Value
            };
            DataTable table = UserBLL.GetLogin(user);
            if (table.Rows.Count>0)
            {
                Session["name"] = this.name.Value;
                Response.Write("<script>alert('登录成功！');location.href='Home.aspx'</script>");
               
            }
            else
            {
                Response.Write("<script>alert('登录失败！')</script>");
            }
        }
    }
}