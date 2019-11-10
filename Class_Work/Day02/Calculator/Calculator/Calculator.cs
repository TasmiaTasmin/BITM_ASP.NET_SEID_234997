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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int result;
            result = firstNumber + secondNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int result;
            result = firstNumber - secondNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int result;
            result = firstNumber * secondNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int result;
            result = firstNumber / secondNumber;
            resultTextBox.Text = Convert.ToString(result);
        }
    }
}
