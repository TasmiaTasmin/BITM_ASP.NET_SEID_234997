using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayWindowsForms
{
    public partial class HomeApplication : Form
    {
        public HomeApplication()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            textBoxDisplayCategory.Text = comboBoxCategory.Text;
            labelDisplayName.Text = textBoxName.Text;
        }
    }
}
