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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if(radioButton1.Checked)
            {
                string Sql = "Data Source=localhost;Initial Catalog=administrators;Integrated Security=True";
                SqlConnection con = new SqlConnection(Sql);
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from administrators where name='" + textBox1.Text.Trim()
                    + "'and psw='" + textBox2.Text.Trim() + "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if(sdr.HasRows)                
                {
                    MessageBox.Show("登陆成功！！！");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重试！！！");
                }
                sdr.Close();
            }
            if(radioButton2.Checked)
            {
                string Sql = "Data Source=localhost;Initial Catalog=users;Integrated Security=True";
                SqlConnection con = new SqlConnection(Sql);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from users where name='" + textBox1.Text.Trim()
                    + "'and psw='" + textBox2.Text.Trim() + "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重试！！！");
                }
                sdr.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                textBox2.Focus();
            }
        }

      
    }
}
