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
    public partial class Form5 : Form
    {
        SqlConnection con;
        public Form5()
        {
            InitializeComponent();
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from courseinfo where courseid='" + textBox1.Text.Trim() + "'";
            SqlDataReader sda=cmd.ExecuteReader();
            sda.Read();
            if(sda.HasRows)
            {
                cmd.CommandText = "update  courseinfo set coursename='" + textBox2.Text.Trim()
                    + "',teacher='" + textBox3.Text.Trim() + "',instructions='" + richTextBox1.Text
                    + "'where courseid='" +textBox1.Text.Trim() + "'";
                sda.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功！");
            }
            else
            {
                cmd.CommandText = "insert into courseinfo(courseid,coursename,teacher,instructions) values('" +
                textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + richTextBox1.Text + "')";               
                sda.Close();
                MessageBox.Show("提交成功！");
                cmd.ExecuteNonQuery();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string SqlStr = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
    }
}
