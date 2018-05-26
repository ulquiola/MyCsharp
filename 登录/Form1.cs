using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace re登录
{
    
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.Focus();
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                MessageBox.Show("欢迎你！");
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重试！");
                count++;
            }
            if(count==3)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
