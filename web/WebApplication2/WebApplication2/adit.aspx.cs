using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Models;
using BLL;

namespace WebApplication2
{
    public partial class adit : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request["id"];
                T_user u = new T_user();
                u.id =Convert.ToInt32(id);
                DataTable table = UserBLL.idSelect(u);
                this.iid.Value= table.Rows[0][0].ToString();
                this.name.Value = table.Rows[0][1].ToString();
                this.trueName.Value =table.Rows[0][2].ToString();
                this.cardId.Value= table.Rows[0][3].ToString();
                this.email.Value= table.Rows[0][4].ToString();
                this.telephone.Value = table.Rows[0][5].ToString();
                this.qqId.Value= table.Rows[0][6].ToString();
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            //int id =Convert.ToInt32(e.CommandArgument.ToString());
            T_user u = new T_user()
            {
                id =Convert.ToInt32(this.iid.Value),
                name = this.name.Value,
                trueName = this.trueName.Value,
                cardId = this.cardId.Value,
                telephone = this.telephone.Value,
                email = this.email.Value,
                qqId = this.qqId.Value
            };
            if (UserBLL.update(u))
            {
                Response.Write("<script>alert('修改成功！')</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败！')</script>");
            }
        }
    }
}