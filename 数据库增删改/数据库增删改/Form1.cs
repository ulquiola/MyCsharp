using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库增删改
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Sql = "Data Source=localhost;Initial Catalog=userinfo;Integrated Security=True";
            con = new SqlConnection(Sql);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into userinfo values('"+textBox1.Text.Trim()+"','"+textBox2.Text.Trim()+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from userinfo where userName='" + textBox1.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("删除成功！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update userinfo set userPassword='"+textBox2.Text.Trim()+"' where userName='" + textBox1.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("修改成功！");
        }
    }
}
