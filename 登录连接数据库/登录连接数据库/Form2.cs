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
    public partial class Form2 : Form
    {
        SqlConnection con;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请输入用户名或密码！！！");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from users where username='" + textBox1.Text.Trim()+ "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("用户名已使用，请重试！！！");
                    sdr.Close();
                }
                else
                {
                    cmd.CommandText = "insert into users values('" + textBox1.Text.Trim()
                        + "','" + textBox2.Text.Trim() + "')";
                    MessageBox.Show("注册成功！！！");
                    sdr.Close();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string Sql = "Data Source=localhost;Initial Catalog=users;Integrated Security=True";
            con = new SqlConnection(Sql);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
    }
}

