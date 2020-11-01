using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int choice = 0; 
        private void button_Plus_Click(object sender, EventArgs e)
        {
            choice = 0;
            Calculate(choice); 
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            choice = 1;
            Calculate(choice);
        }

        private void button_mutiple_Click(object sender, EventArgs e)
        {
            choice = 2;
            Calculate(choice);
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            choice = 3;
            Calculate(choice);
        }
        private void Calculate(int x)
        {
            double num1 = double.Parse(textBox_Num1.Text);
            double num2 = double.Parse(textBox_Num2.Text);
            double ans = 0;
            switch (x)
            {
                case 0:
                    ans = num1 + num2; 
                    break;
                case 1:
                    ans = num1 - num2;
                    break;
                case 2:
                    ans = num1 * num2;
                    break;
                case 3:
                    if (num2 != 0)
                    {
                        ans = num1 / num2;
                    }
                    break; 
                default:
                    break;
            }
            textBox_Ans.Text = ans.ToString(); 
        }
    }
}
