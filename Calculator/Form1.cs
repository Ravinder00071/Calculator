using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        String operationPermormed = "";
        bool isOperationproformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationproformed))
                textBox_result.Clear();
            isOperationproformed = false;
            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void operater_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPermormed = button.Text;
            resultvalue = Double.Parse(textBox_result.Text);
            Labelcurrentoperation.Text = resultvalue + " " + operationPermormed;
            isOperationproformed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultvalue = 0;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch(operationPermormed)
            {
                case "+":
                    textBox_result.Text = (resultvalue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultvalue - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultvalue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultvalue / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
