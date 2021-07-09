using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
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

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string operation = operations.Text;

            switch (operation)
            {
                case "+":
                    result.Text = (num1.Value + num2.Value).ToString();
                    break;
                case "-":
                    result.Text = (num1.Value - num2.Value).ToString();
                    break;
                case "*":
                    result.Text = (num1.Value * num2.Value).ToString();
                    break;
                case "/":
                    result.Text = (num1.Value / num2.Value).ToString();
                    break;
                case "%":
                    result.Text = (num1.Value % num2.Value).ToString();
                    break;
                default:
                    MessageBox.Show("You didn't choose valid operation");
                    break;
            }
        }
    }
}
