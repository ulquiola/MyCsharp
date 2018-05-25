using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList1;
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
            listView1.Items[2].ImageIndex = 2;
            listView1.Items[3].ImageIndex = 3;
            listView1.Items[4].ImageIndex = 4;
            listView1.Items[5].ImageIndex = 5;
            listView1.Items[6].ImageIndex = 6;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                label3.Text = listView1.SelectedItems[0].Text;
            }

        }
    }
}
