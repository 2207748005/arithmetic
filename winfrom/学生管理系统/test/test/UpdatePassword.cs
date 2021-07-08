using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string confimpassword = textBox3.Text.Trim();
            string sql = string.Format("select * from T_user where user_name='{0}'", username);
            DataTable table = DBHelper.GetDataTable(sql);
            if (table==null)
            {
                MessageBox.Show("用户名输入错误请重新输入！");
            }
            else
            {
                if (password!=confimpassword)
                {
                    MessageBox.Show("两次输入密码不一致！");
                }
                else
                {
                    if ((int)(MessageBox.Show("确认修改密码吗？","修改密码",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)) != -1)
                    {
                        string updsql = string.Format("update T_user set user_password='{0}' where user_name='{1}'",password,username);
                        bool upd = DBHelper.ExecuteNonQuery(updsql);
                        if (upd)
                        {
                            MessageBox.Show("修改成功");
                        }
                        else
                        {
                            MessageBox.Show("修改失败！");
                        }
                    }
                    
                }
            }
        }
    }
}
