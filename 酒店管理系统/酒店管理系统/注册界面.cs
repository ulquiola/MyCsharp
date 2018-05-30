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

namespace 酒店管理系统
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sql = "Data Source=localhost;Initial Catalog=users;Integrated Security=True";
            SqlConnection con = new SqlConnection(Sql);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("请输入用户名或密码！！！");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from users where name='" + textBox1.Text.Trim() + "'";
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
                        + "','" + textBox3.Text.Trim() + "')";
                    MessageBox.Show("注册成功！！！");
                    sdr.Close();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

