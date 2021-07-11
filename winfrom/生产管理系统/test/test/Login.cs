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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text.Trim();
            string password = this.textBox2.Text.Trim();
            string sql = $"select * from T_user where username='{username}' and password='{password}'";
            DataTable table = DBHelper.GetDataTable(sql);
            if (table.Rows.Count>0)
            {
                MessageBox.Show("恭喜老板登录成功");
                Form1 form1 = new Form1(table.Rows[0][1].ToString());
                form1.Show();
            }
            else
            {
                MessageBox.Show("账号或密码错误！");
            }
        }
    }
}
