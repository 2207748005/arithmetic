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
    public partial class parent : Form
    {
        public parent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chlid c = new chlid(this);
            c.str = this.button1.Text;
            c.Show();
        }

        private void parent_Load(object sender, EventArgs e)
        {
            serch();
        }
        public  void serch()
        {
            string sql = "select * from T_product p,T_category c where p.category_id=c.category_id";
            DataTable table = DBHelper.GetDataTable(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int category_id = 1;
            if (this.textBox1.Text.Trim()=="数码类")
            {
                category_id = 2;
            }
            if (this.textBox1.Text.Trim() == "食品类")
            {
                category_id = 3;
            }
            
            string product_name = this.textBox2.Text.Trim();
            string price = this.textBox3.Text.Trim();
            string remark = this.textBox4.Text.Trim();
            string sql = $"insert into T_product values({category_id},'{product_name}',{price},'{remark}',getdate())";
            bool bl = DBHelper.ExecuteNonQuery(sql);
            if (bl)
            {
                MessageBox.Show("添加成功！");
                serch();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}
