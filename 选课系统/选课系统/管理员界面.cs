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
    public partial class Form7 : Form
    {
        string Sql;
        SqlConnection con;
        string Cid,Sid,Tid;
        int i1=0, j=0, k=0, l=0;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(Sql);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i1 = 1;
            j = 0; k = 0; l = 0;
            Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(Sql);            
                con.Open();           
            SqlDataAdapter sda = new SqlDataAdapter("select * from studentinfo", con);
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
            j = 1;
            i1 = 0; k = 0; l = 0;
            Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(Sql);            
                con.Open();            
            SqlDataAdapter sda = new SqlDataAdapter("select * from teacherinfo", con);
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

        private void button3_Click(object sender, EventArgs e)
        {
            k = 1;
            i1 = 0; j = 0; l = 0;
            Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(Sql);            
                con.Open();           
            SqlDataAdapter sda = new SqlDataAdapter("select * from studentselectinfo", con);
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

        private void button4_Click(object sender, EventArgs e)
        {
            l = 1;
            i1 = 0; j = 0; k = 0;
            Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(Sql);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from courseinfo", con);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(i1>0)
            {
                if (e.RowIndex >= 0)
                {
                    int ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    con = new SqlConnection(Sql);
                    SqlDataAdapter sda = new SqlDataAdapter("select * from studentinfo where ID=" + ID + "", con);
                    DataSet myds = new DataSet();
                    sda.Fill(myds);
                    if (myds.Tables[0].Rows.Count > 0)
                    {
                        Sid = myds.Tables[0].Rows[0][1].ToString();
                    }
                }
            }
            if(j>0)
            {
                string ID = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                con = new SqlConnection(Sql);
                SqlDataAdapter sda = new SqlDataAdapter("select * from teacherinfo where teacherid=" + ID + "", con);
                DataSet myds = new DataSet();
                sda.Fill(myds);
                if (myds.Tables[0].Rows.Count > 0)
                {
                    Tid = myds.Tables[0].Rows[0][0].ToString();
                }
            }
            if(k>0)
            {
                if (e.RowIndex >= 0)
                {
                    int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                    con = new SqlConnection(Sql);
                    SqlDataAdapter sda = new SqlDataAdapter("select * from studentselectinfo where courseid=" + intID + "", con);
                    DataSet myds = new DataSet();
                    sda.Fill(myds);
                    if (myds.Tables[0].Rows.Count > 0)
                    {
                        Cid = myds.Tables[0].Rows[0][1].ToString();
                    }
                }
            }
            if(l>0)
            {
                if (e.RowIndex >= 0)
                {
                    int ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    con = new SqlConnection(Sql);
                    SqlDataAdapter sda = new SqlDataAdapter("select * from courseinfo where courseid=" + ID + "", con);
                    DataSet myds = new DataSet();
                    sda.Fill(myds);
                    if (myds.Tables[0].Rows.Count > 0)
                    {
                        Cid = myds.Tables[0].Rows[0][0].ToString();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(i1>0)
            {
                Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
                con = new SqlConnection(Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from studentinfo where studentid='" + Sid + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除学生成功！");
                //
                //刷新
                //
                SqlDataAdapter sda = new SqlDataAdapter("select * from studentinfo", con);
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
            if(j>0)
            {
                Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
                con = new SqlConnection(Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from teacherinfo where teacherid='" + Tid + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除教师成功！");
                //
                //
                //
                SqlDataAdapter sda = new SqlDataAdapter("select * from teacherinfo", con);
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
            if(k>0)
            {
                Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
                con = new SqlConnection(Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from studentselectinfo where courseid='" + Cid + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("退课成功！");
                //
                //
                //
                SqlDataAdapter sda = new SqlDataAdapter("select * from studentselectinfo", con);
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
            if(l>0)
            {
                Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
                con = new SqlConnection(Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from courseinfo where courseid='" + Cid + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("删课成功！");
                //
                //
                //
                SqlDataAdapter sda = new SqlDataAdapter("select * from courseinfo", con);
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (l == 1)
            {
                Form5 frm5 = new Form5();
                frm5.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(l==1)
            {
                Form5 frm5 = new Form5();
                frm5.Show();
            }
        }
    }
}
