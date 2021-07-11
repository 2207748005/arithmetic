using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using Models;

namespace WebApplication2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                serch();
            }
        }
        public void serch() 
        {
            T_user user = new T_user();
            this.Repeater1.DataSource = UserBLL.select(user);
            this.Repeater1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            T_user u = new T_user();
            u.id = int.Parse(e.CommandArgument.ToString());
            if (UserBLL.delete(u))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                serch();
            }
            else
            {
                Response.Write("<script>alert('删除失败！')</script>");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            T_user u = new T_user();
            u.name = this.TextBox1.Text.Trim();
            
        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect($"adit.aspx?id={e.CommandArgument.ToString()}");
        }
    }
}