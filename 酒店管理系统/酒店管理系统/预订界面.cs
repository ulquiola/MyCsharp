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
    public partial class Form4 : Form
    {
        SqlConnection con;
        string Sql = "Data Source=localhost;Initial Catalog=HotelManagementSystem;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {            
            con = new SqlConnection(Sql);
            SqlDataAdapter sda = new SqlDataAdapter("select * from room",con);
            DataSet myds = new DataSet();
            sda.Fill(myds);
            dataGridView1.DataSource = myds.Tables[0];
            for (int i = 0; i < dataGridView1.Columns.Count;i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach(DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if(dgvr.Index%2==0)
                {
                    dataGridView1.Rows[dgvr.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridView1.Rows[dgvr.Index].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                dataGridView1.ReadOnly = true;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            }            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                con = new SqlConnection(Sql);
                SqlDataAdapter sda = new SqlDataAdapter("select * from room where Idroom="+intID+"", con);
                DataSet myds = new DataSet();
                sda.Fill(myds);
                if(myds.Tables[0].Rows.Count>0)
                {
                    textBox1.Text = myds.Tables[0].Rows[0][0].ToString();
                    textBox2.Text = myds.Tables[0].Rows[0][1].ToString();
                }

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
          textBox3.Text = Convert.ToString(dateTimePicker2.Value.Day - dateTimePicker1.Value.Day);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          textBox4.Text = Convert.ToString(double.Parse(textBox2.Text) * double.Parse(textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Sql);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "select * from room where using='yes'";
            //MessageBox.Show("该房间正在使用中，请更换!"); 
            //切换用户预定房间表users
            //
            string Bsql = "Data Source=localhost;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Bsql);
            SqlCommand Bcmd = new SqlCommand();
            Bcmd.Connection = conn;
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }            
            Bcmd.CommandText = "update users set Bidroom='"+textBox1.Text+"',Bday='"+textBox3.Text+
                "',Bmoney='"+textBox4.Text+"'where username='"+textBox5.Text.Trim()+"'";
            Bcmd.ExecuteNonQuery();
            MessageBox.Show("预订成功！");
            //cmd.CommandText = "update room set using='yes'where idroom='"+textBox1.Text+"'";
        }
    }
}
