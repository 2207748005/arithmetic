using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BLL;

namespace WebApplication2
{
    public partial class AddWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            T_user u = new T_user();
            u.name = this.name.Value;
            u.trueName = this.trueName.Value;
            u.cardId = this.cardId.Value;
            u.email = this.email.Value;
            u.telephone = this.telephone.Value;
            u.qqId = this.qqId.Value;
            bool bl = UserBLL.insertUser(u);
            if (bl)
            {
                Response.Write("<script>alert('添加成功！')</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败！')</script>");
            }
        }
    }
}