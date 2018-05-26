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
          //另一种方式实现操作
         //
        //
      /*  private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case"1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case ".":
                    point.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    mul.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }*/

    }
}
