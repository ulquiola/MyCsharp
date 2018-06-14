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

namespace WindowsFormsApplication10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            //使用DBHelper
            string sql = "insert into users values(@user_id,@password)";
            SqlParameter[] sp = new SqlParameter[]{
                
                new SqlParameter("@user_id",textBox1.Text.Trim()),
                new SqlParameter("@password",textBox2.Text.Trim())            
            };
            int result=DBHelper.GetExcuteNonQuery(sql, sp);
            if (result > 0)
            {
                MessageBox.Show("添加成功");
            }
            dataGridView1.DataSource = DBHelper.GetFillData("select * from users");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBHelper.GetFillData("select * from users");
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            string sql = "update users  set password=@password where user_id=@user_id";
            SqlParameter[] sp = new SqlParameter[]{                
                new SqlParameter("@user_id",textBox1.Text.Trim()),
                new SqlParameter("@password",textBox2.Text.Trim())                            
            };
            int result = DBHelper.GetExcuteNonQuery(sql, sp);
            if (result > 0)
            {
                MessageBox.Show("修改成功");
            }
            dataGridView1.DataSource = DBHelper.GetFillData("select * from users");
        }
        private void button3_Click(object sender, EventArgs e)
        {        
            string sql = "delete users  where user_id=@user_id";
            SqlParameter[] sp = new SqlParameter[]{                
                new SqlParameter("@user_id",textBox1.Text.Trim())                          
            };
            int result = DBHelper.GetExcuteNonQuery(sql, sp);
            if (result > 0)
            {
                MessageBox.Show("删除成功");
            }
            dataGridView1.DataSource = DBHelper.GetFillData("select * from users");
        }       
    }
}
