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

namespace 选课系统
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(radioButton1.Checked)
           {
               if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
               {
                   MessageBox.Show("请输入完整信息，再进行注册操作！！！");
               }
               else
               {
                   SqlCommand cmd = new SqlCommand();
                   cmd.Connection = con;
                   cmd.CommandText = "select * from studentinfo where StudentID='" + textBox1.Text.Trim() + "'";
                   SqlDataReader sdr = cmd.ExecuteReader();
                   sdr.Read();
                   if (sdr.HasRows)
                   {
                       MessageBox.Show("您已注册，请进行登录操作！！！");
                   }
                   else
                   {
                       cmd.CommandText = "insert into studentinfo values('" + textBox1.Text.Trim()
                                   + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim()
                                   + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim()
                                   + "','" + textBox6.Text.Trim() + "')";
                       MessageBox.Show("注册成功！！！");
                       Form2 frm2 = new Form2();
                       frm2.Show();
                       this.Hide();
                       sdr.Close();
                       cmd.ExecuteNonQuery();
                   }
               }
           }
            if(radioButton2.Checked)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("请输入完整信息，再进行注册操作！！！");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select * from teacherinfo where TeacherID='" + textBox1.Text.Trim() + "'";
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    if (sdr.HasRows)
                    {
                        MessageBox.Show("您已注册，请进行登录操作！！！");
                    }
                    else
                    {
                        cmd.CommandText = "insert into teacherinfo values('" + textBox1.Text.Trim()
                                    + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim()
                                    + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim()
                                    + "','" + textBox6.Text.Trim() + "')";
                        MessageBox.Show("注册成功！！！");
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();
                        sdr.Close();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string SqlStr="Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox6.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.Focus();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "学号：";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "工号";
        }               
    }
}
