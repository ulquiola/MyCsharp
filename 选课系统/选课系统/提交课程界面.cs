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
    public partial class Form9 : Form
    {
        SqlConnection con;
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location = comboBox1.SelectedItem.ToString();
            string time="";            
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    time += checkedListBox1.GetItemText(checkedListBox1.Items[i])+ ",";
                }
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select location, time from course where location='" + location + "'and time='" + time + "' ";
            SqlDataReader sda = cmd.ExecuteReader();
            sda.Read();
            if (sda.HasRows)
            {
                MessageBox.Show("该教室在时间段已有其他课程！");
                sda.Close();
            }
            else
            {
                cmd.CommandText = "insert into course(coursename,teacher,instructions,location,time) values('" +
                textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + richTextBox1.Text + "','" + location + "','" + time + "')";
                sda.Close();
                MessageBox.Show("提交成功！");
                cmd.ExecuteNonQuery();
            }
            
        }

        private void Form9_Load(object sender, EventArgs e)
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
