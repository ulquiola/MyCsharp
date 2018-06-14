using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from users where user_id=@user_id and password=@password";
            SqlParameter[] sp = new SqlParameter[]{
                
                new SqlParameter("@user_id",textBox1.Text.Trim()),
                new SqlParameter("@password",textBox2.Text.Trim())            
            };
            SqlDataReader dr= DBHelper.GetDataReader(sql,sp);
            if (dr.Read())
            {
                MessageBox.Show("登录成功");
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                count++;
                if (count == 3)
                {
                    MessageBox.Show("对不起，你已经试过三次了。");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("用户名或密码错，请重新登录！", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();                    
                }                              
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}