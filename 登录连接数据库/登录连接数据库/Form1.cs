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

namespace 登录连接数据库
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
            string Sql = "Data Source=localhost;Initial Catalog=users;Integrated Security=True";
            con = new SqlConnection(Sql);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from users where username='" + textBox1.Text.Trim()
                + "'and password='" + textBox2.Text.Trim() + "'";
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                MessageBox.Show("登陆成功！！！");
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重试！！！");
            }
            sdr.Close();
        }        
    }
}
