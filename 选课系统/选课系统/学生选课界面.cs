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
        SqlConnection con;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string Sql = "Data Source=localhost;Initial Catalog=CourseSelectionSystem;Integrated Security=True";
            con = new SqlConnection(Sql);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }            
            SqlDataAdapter sda = new SqlDataAdapter("select * from courseinfo", con);
            DataSet myds = new DataSet();
            sda.Fill(myds);
            dataGridView1.DataSource = myds.Tables[0];
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)            
                for(int j=0;j<dataGridView1.Columns.Count;j++)
                {
                    dataGridView1.Rows[0].Cells[2].Value = DataGridViewColumnSortMode.NotSortable;
                }            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (dgvr.Index % 2 == 0)
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
            /*if (e.RowIndex >= 0)
            {
                int intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                con = new SqlConnection(Sql);
                SqlDataAdapter sda = new SqlDataAdapter("select * from room where Idroom=" + intID + "", con);
                DataSet myds = new DataSet();
                sda.Fill(myds);
                if (myds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = myds.Tables[0].Rows[0][0].ToString();
                    textBox2.Text = myds.Tables[0].Rows[0][1].ToString();
                }

            }*/
        }
    }
}
