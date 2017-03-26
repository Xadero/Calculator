using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public String operation;
        public double value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void numberButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text += b.Text;
            label1.Text += b.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value += double.Parse(result.Text);
            label1.Text += b.Text;
            result.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            label1.Text = result.Text;
            value = 0;
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 1)
            {
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            else
            {
                label1.Text = value.ToString() + operation.ToString();
                result.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            label1.Text += "sqrt" + "(" + result.Text + ")";
            result.Text = (Math.Sqrt(double.Parse(result.Text))).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            label1.Text += result.Text + "²";
            result.Text = (Math.Pow(Double.Parse(result.Text), 2)).ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            value = 0;
            operation = " ";
            label1.Text = "";
            result.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = (double.Parse(result.Text) * -1).ToString();
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);

            if (double.Parse(result.Text) < 0)
                label1.Text += "(" + "-" + result.Text + ")";
            else
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 4);
                label1.Text += result.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            label1.Text += "/" + result.Text;
            result.Text = (1 / double.Parse(result.Text)).ToString();
        }

        private void dec_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result.Text.Contains(",") || result.Text == " ")
                return;
            result.Text += button.Text;
            label1.Text += button.Text;

        }
    }
}