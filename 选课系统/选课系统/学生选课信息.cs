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
    public partial class Form6 : Form
    {
        string Sql;
        SqlConnection con;
        string Cid;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
           con = new SqlConnection(Sql);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select courseid,coursename,teacher from studentselectinfo where studentid='"+Form2.Sid+"'", con);
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
                int ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                con = new SqlConnection(Sql);
                SqlDataAdapter sda = new SqlDataAdapter("select * from studentselectinfo where courseid=" + ID + "", con);
                DataSet myds = new DataSet();
                sda.Fill(myds);
                if (myds.Tables[0].Rows.Count > 0)
                {                    
                    Cid = myds.Tables[0].Rows[0][1].ToString();                   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from studentselectinfo where courseid='" + Cid + "'and studentid='" + Form2.Sid + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("退课成功！");
            //
            //
            //
            SqlDataAdapter sda = new SqlDataAdapter("select courseid,coursename,teacher from studentselectinfo where studentid='" + Form2.Sid + "'", con);
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
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }
    }
}
