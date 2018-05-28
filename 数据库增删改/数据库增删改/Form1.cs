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
            string SqlStr = "Data Source=localhost;Initial Catalog=student;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Student values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            cmd.ExecuteNonQuery();             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from Student where Sno='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Student set Sname='"+textBox2.Text+"',Sage='"
                +textBox3.Text+"'where Sno='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery(); 
        }
    }
}
