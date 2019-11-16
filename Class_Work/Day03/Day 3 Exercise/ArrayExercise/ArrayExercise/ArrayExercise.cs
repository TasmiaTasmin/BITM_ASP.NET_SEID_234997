using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayExercise
{
    public partial class ArrayExercise : Form
    {
        int index = 0;
        const int size = 10;
        int[] array = new int[size];

        public ArrayExercise()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            array[index] = Convert.ToInt32(textBoxNumber.Text);
            index++;
            for (int index = 0; index < 10; index++)
            {
                if (array[index] != 0)
                    message = message + "values of index " + index + " is " + array[index] + "\n";

            }
            richTextBoxDisplay.Text = message.ToString();
            textBoxNumber.Text = string.Empty;
        }
        private void buttonDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            string message = "";
            for (int index = 0; index < 10; index++)
            {
                if (array[index] != 0)
                    message = message + "values of index " + index + " is " + array[index] + "\n";

            }
            for (int index = array.Length - 1; index >= 0; index--)
            {
                if (array[index] != 0)
                    message = message + "values of index " + index + " is " + array[index] + "\n";
            }
            richTextBoxDisplay.Text = message.ToString();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {

        }

        private void buttonDuplicate_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnique_Click(object sender, EventArgs e)
        {

        }

        private void buttonMaximum_Click(object sender, EventArgs e)
        {

        }

        private void buttonMinimum_Click(object sender, EventArgs e)
        {

        }

        private void buttonMaxMin_Click(object sender, EventArgs e)
        {

        }

        private void buttonOdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonEven_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeparate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAscDes_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
