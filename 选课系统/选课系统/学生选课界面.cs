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
    public partial class Form4 : Form
    {
        string Sql;
        SqlConnection con;
        string Cid, Cname, Cteacher;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(Sql);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select courseid,coursename,teacher from courseinfo", con);
            DataSet myds = new DataSet();
            sda.Fill(myds);
            dataGridView1.DataSource = myds.Tables[0];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;                           
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (dgvr.Index % 2 == 0)
                {
                    dataGridView1.Rows[dgvr.Index].DefaultCellStyle.BackColor = Color.LightYellow;
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
            if (e.RowIndex >= 0)
            {
                int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                con = new SqlConnection(Sql);
                SqlDataAdapter sda = new SqlDataAdapter("select * from courseinfo where courseid=" + intID + "", con);
                DataSet myds = new DataSet();
                sda.Fill(myds);
                if (myds.Tables[0].Rows.Count > 0)
                {
                    richTextBox1.Text = myds.Tables[0].Rows[0][3].ToString();
                    Cid = myds.Tables[0].Rows[0][0].ToString();
                    Cname = myds.Tables[0].Rows[0][1].ToString();
                    Cteacher = myds.Tables[0].Rows[0][2].ToString();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string Sql1 = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
          SqlConnection conn = new SqlConnection(Sql1);
          if (conn.State == ConnectionState.Closed)
          {
              conn.Open();
          }
          SqlCommand com = new SqlCommand();
          com.Connection = conn;
          com.CommandText = "select * from studentselectinfo where courseid='"+Cid+"'";
          SqlDataReader sdr = com.ExecuteReader();
          sdr.Read();
          if (sdr.HasRows)
          {
              MessageBox.Show("您已添加，请勿进行重复操作！！！");
          }
            else
          {
              com.CommandText = "insert into studentselectinfo values('"+Form2.Sid+"','" + Cid + "','" + Cname + "','" + Cteacher + "')";
              MessageBox.Show("添加成功！！！");
              sdr.Close();
              com.ExecuteNonQuery();
          }
        }
    }
}
