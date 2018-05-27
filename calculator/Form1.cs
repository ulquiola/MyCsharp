using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if(a.Text==".")
            {
                if(!result.Text.Contains("."))
                {
                    result.Text = result.Text + a.Text;
                }
            }
            else
            result.Text = result.Text + a.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            value = double.Parse(result.Text);
            Button a = (Button)sender;
            operation = a.Text;
            equation.Text = result.Text + operation;
            result.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text=Convert.ToString(value+double.Parse(result.Text));
                    break;
                case "-":
                    result.Text = Convert.ToString(value - double.Parse(result.Text));
                    break;
                case "*":
                    result.Text = Convert.ToString(value * double.Parse(result.Text));
                    break;
                case "/":
                    result.Text = Convert.ToString(value / double.Parse(result.Text));
                    break;
                default:
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text ="";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }
    }
}
