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

namespace 教务系统
{
    public partial class Form2 : Form
    {
        static public string  Sid;
        SqlConnection con;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from studentinfo where StudentID='" +
                    textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    Form4 frm4 = new Form4();
                    frm4.Show();
                    this.Hide();
                    Sid =textBox1.Text;
                    sdr.Close();
                }
                else
                {
                    MessageBox.Show("密码错误，请重试");
                    sdr.Close();
                }
            }          
            if(radioButton2.Checked)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from teacherinfo where TeacherID='" +
                    textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {  
                    Form9 frm9 = new Form9();
                    frm9.Show();
                    this.Hide();
                    sdr.Close();
                }
                else
                {
                    MessageBox.Show("密码错误，请重试");
                    sdr.Close();
                }
            }
            if(radioButton3.Checked)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from administrtors where adminID='" +
                    textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    Form7 frm7 = new Form7();
                    frm7.Show();
                    this.Hide();
                    sdr.Close();                    
                }
                else
                {
                    MessageBox.Show("密码错误，请重试");
                    sdr.Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string SqlStr = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {            
                label1.Text = "工号：";            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
                label1.Text = "管理员号：";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "学号：";
        }
    }
}
