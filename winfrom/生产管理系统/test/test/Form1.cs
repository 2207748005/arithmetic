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
    public partial class Form1 : Form
    {
        public Form1(string p)
        {
            InitializeComponent();
            this.label2.Text = "欢饮老板"+p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            select();
            com();
        }
        public void select() 
        {
            string sql = $"select * from T_product";
            DataTable table = DBHelper.GetDataTable(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = table;
            
        }
        public void com() 
        {
            string sql = $"select category_name from T_category ";
            DataTable table = DBHelper.GetDataTable(sql);
            //this.comboBox1.Text = "全部";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.comboBox1.Items.Add(table.Rows[i]["category_name"]);
            }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"select * from T_product p,T_category c where p.category_id=c.category_id and category_name='{comboBox1.Text}'";
            DataTable table = DBHelper.GetDataTable(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            parent parent = new parent();
            parent.Show();
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridView1.SelectedCells[3].Value);
            string sql = $"delete from T_product where Product_id={id}";
            bool bl = DBHelper.ExecuteNonQuery(sql);
            if (bl)
            {
                MessageBox.Show("删除成功！");
                select();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}
