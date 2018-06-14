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
        //SqlConnection con;
        //SqlDataAdapter da;
       // DataSet ds = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //方式一
            //string SqlStr = "Data Source=localhost;Initial Catalog=student;Integrated Security=True";
            //SqlConnection con = new SqlConnection(SqlStr);
            //SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            //try
            //{
            //    if (con.State == ConnectionState.Closed)//判断连接是否打开
            //    {
            //        con.Open();
            //    }
            //    string sql = "insert into users values('" + textBox1.Text.Trim() + "','"
            //    + textBox2.Text.Trim() + "')";
            //    da.InsertCommand = new SqlCommand(sql, con);
            //    int num = da.InsertCommand.ExecuteNonQuery();
            //    if (num > 0)
            //    {
            //        MessageBox.Show("添加成功");
            //        textBox1.Clear();
            //        textBox2.Clear();
            //        dataGridView1.DataSource = FillTable("select * from users");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("添加失败,错误原因：" + ex.Message);
            //}
            //finally
            //{
            //    if (con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }
            //}
            //方式二
            string SqlStr = "Data Source=localhost;Initial Catalog=student;Integrated Security=True";
            SqlConnection con = new SqlConnection(SqlStr);
            SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            string sql = "insert into users values(@user_id,@password)";
            da.InsertCommand = new SqlCommand(sql, con);
            DataTable dtStu = new DataTable();
            da.Fill(dtStu);
            da.InsertCommand.Parameters.AddWithValue("@user_id", textBox1.Text.Trim());
            da.InsertCommand.Parameters.AddWithValue("@password", textBox2.Text.Trim());

            //增加新记录
            DataRow dr = dtStu.NewRow();
            //给记录赋值
            dr[0] = textBox1.Text.Trim();
            dr[1] = textBox2.Text.Trim();
            dtStu.Rows.Add(dr);
            //提交更新
            da.Update(dtStu);
            MessageBox.Show("添加成功");
            dataGridView1.DataSource = FillTable("select * from users"); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= FillTable("select * from users");         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string SqlStr = "Data Source=localhost;Initial Catalog=student;Integrated Security=True";
            //SqlConnection con = new SqlConnection(SqlStr);
            //SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            //try
            //{
            //    if (con.State == ConnectionState.Closed)//判断连接是否打开
            //    {
            //        con.Open();
            //    }
            //    string sql = "update users  set password='" + textBox2.Text.Trim() + "' where user_id='" + textBox1.Text.Trim() + "'";
            //    da.UpdateCommand = new SqlCommand(sql, con);
            //    int num = da.UpdateCommand.ExecuteNonQuery();
            //    if (num > 0)
            //    {
            //        MessageBox.Show("修改成功");
            //        textBox1.Clear();
            //        textBox2.Clear();
            //        dataGridView1.DataSource = FillTable("select * from users");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("修改失败,错误原因：" + ex.Message);
            //}
            //finally
            //{
            //    if (con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }
            //}            
            //方式二
            string SqlStr = "Data Source=localhost;Initial Catalog=student;Integrated Security=True";
            SqlConnection con = new SqlConnection(SqlStr);
            SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            string sql = "update users  set password=@password where user_id=@user_id";
            da.UpdateCommand = new SqlCommand(sql, con);
            DataTable dtStu = new DataTable();
            da.Fill(dtStu);
            da.UpdateCommand.Parameters.AddWithValue("@user_id", textBox1.Text.Trim());
            da.UpdateCommand.Parameters.AddWithValue("@password", textBox2.Text.Trim());
            dtStu.PrimaryKey = new DataColumn[] { dtStu.Columns["user_id"] };
            //根据txtStuNo文本框的输入查询相应的记录，以便修改
            DataRow row = dtStu.Rows.Find(textBox1.Text.Trim());
            //如果存在相应记录，则修改并更新到数据库
            if (row != null)
            {
                //修改记录值
                row.BeginEdit();
                row[0] = textBox1.Text.Trim();
                row[1] = textBox2.Text.Trim();
                row.EndEdit();
                //提交更新         
                da.Update(dtStu);
                MessageBox.Show("修改成功！");
                //重新绑定
                dataGridView1.DataSource = FillTable("Select * from users");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
        //    //SqlCommand cmd = new SqlCommand();
        //    //cmd.Connection = con;
        //    //cmd.CommandText = "delete users  where user_id='" + textBox1.Text.Trim() + "'";
            //string SqlStr = "Data Source=localhost;Initial Catalog=student;Integrated Security=True";
            //SqlConnection con = new SqlConnection(SqlStr);
            //SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            //string strsql = "delete users  where user_id='" + textBox1.Text.Trim() + "'";
            //da.DeleteCommand= new SqlCommand(strsql, con);
            //try
            //{
            //    if (con.State == ConnectionState.Closed)//判断连接是否打开
            //    {
            //        con.Open();
            //    }
            //    int num = da.DeleteCommand.ExecuteNonQuery();
            //    if (num > 0)
            //    {
            //        MessageBox.Show("删除成功");
            //        textBox1.Clear();
            //        textBox2.Clear();
            //        dataGridView1.DataSource = FillTable("select * from users");
            //    }
            //}
            //catch
            //{ }
            //finally
            //{
            //    if (con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }
            //}
            //方式二
            string SqlStr = "Data Source=localhost;Initial Catalog=student;Integrated Security=True";
            SqlConnection con = new SqlConnection(SqlStr);
            SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            string sql = "delete users  where user_id=@user_id";
            da.DeleteCommand = new SqlCommand(sql, con);
            DataTable dtStu = new DataTable();
            da.Fill(dtStu);
            da.DeleteCommand.Parameters.AddWithValue("@user_id", textBox1.Text.Trim());
            dtStu.PrimaryKey = new DataColumn[] { dtStu.Columns["user_id"] };
            //根据txtStuNo文本框的输入查询相应的记录，以便修改
            DataRow row = dtStu.Rows.Find(textBox1.Text.Trim());
            //如果存在相应记录，则修改并更新到数据库
            if (row != null)
            {
                //修改记录值
                row.Delete();
                //提交更新         
                da.Update(dtStu);
                MessageBox.Show("删除成功！");
                //重新绑定
                dataGridView1.DataSource = FillTable("Select * from users");
            }
        }

        private DataTable FillTable(string sql)
        {
            string SqlStr = "Data Source=localhost;Initial Catalog=student;Integrated Security=True";//创建数据库连接字符串         
            using (SqlConnection con = new SqlConnection(SqlStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
