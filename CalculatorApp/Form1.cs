using System;
using System.Windows.Forms;
using CalculateLib;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private string currentExpression = "";
        private Calculate calculate;

        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result.Text == "0")
                result.Clear();

            if (button.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text += button.Text;
            }
            else
            {
                result.Text += button.Text;
            }
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentExpression += result.Text + " " + button.Text + " ";
            result.Clear();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            currentExpression += result.Text;
            result.Text = calculate.Evaluate(currentExpression).ToString();
            currentExpression = "";
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0)
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            currentExpression = "";
        }
    }
}
