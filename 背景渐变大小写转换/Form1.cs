using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 背景渐变大小写转换
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics a = e.Graphics;
            Color b = Color.White;
            Color c = Color.Green;
            Brush d = new LinearGradientBrush(this.ClientRectangle, b, c,
                LinearGradientMode.ForwardDiagonal);
            a.FillRectangle(d, this.ClientRectangle);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char t1 = char.Parse(textBox1.Text);
            int t2=0;
            if(t1>='a'&&t1<='z')
            {
                t2 = Convert.ToInt32(t1)-32;//t2为t1的ascll值
            }
            textBox2.Text=Convert.ToString((char)(t2));//int型ascll值转字符型，难！
            
        }

       
        

       
    }
}
