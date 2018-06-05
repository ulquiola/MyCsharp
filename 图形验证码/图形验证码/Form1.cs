using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图形验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string CheckCode()
        {
            int number;
            char code;
            string checkCode = String.Empty;
            Random random = new Random();
            for(int i=0;i<4;i++)
            {
                number = random.Next();
                if(number%2==0)
                {
                    code = (char)('0' + (char)(number % 10));                    
                }
                else
                {
                    code = (char)('A' + (char)(number % 26));
                    checkCode += " " + code.ToString();
                }
            }
            return checkCode;
        }
        private void CodeImage(string checkCode)
        {
            if(checkCode==null||checkCode.Trim()==String.Empty)
            {
                return;
                System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 9.5)), 22);
                Graphics g = Graphics.FromImage(image);	
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.CheckCode();
        }
    }
}
