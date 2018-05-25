using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog a=new OpenFileDialog())
            {
                a.Filter = "txt文件(*.txt)|*.txt";
                if (a.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(File.OpenRead(a.FileName));
                    textBox.Text = reader.ReadToEnd();
                    reader.Dispose();
                }
                this.Text = a.FileName;
            }
            
        }
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog a = new SaveFileDialog())
            {
                a.Filter = "文本文件(*.txt)|*.txt";
                if (a.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(File.Create(a.FileName));
                    writer.Write(textBox.Text);
                    writer.Dispose();
                }
                this.Text = a.FileName;
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Text = "无标题";
            textBox.Clear();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
