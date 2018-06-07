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
            cmd.CommandText = "insert into courseinfo(courseid,coursename,teacher,instructions) values('" +
                textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','"+richTextBox1.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("提交成功！");
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
