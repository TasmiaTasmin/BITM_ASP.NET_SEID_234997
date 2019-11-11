using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfo
{
    public partial class PersonalInfo : Form
    {
        public static string firstName;
        public static string lastName;
        public static string name;
        public static string fathersName;
        public static string mothersName;
        public static string address;

        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //string firstName = firstNameTextBox.Text;
            //string lastName = lastNameTextBox.Text;
            //string name = firstName + lastName;
            //string fathersName = fathersNameTextBox.Text;
            //string mothersName = mothersNameTextBox.Text;
            //string address = addressTextBox.Text;

            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            name = firstName + " " + lastName;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;
        }
    

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "";
            //message += "First Name: " + firstName + "\n";
            //message += "Last Name: " + lastName + "\n";
            message += "Name: " + name + "\n";
            message += "Father's Name: " + fathersName + "\n";
            message += "Mother's Name: " + mothersName + "\n";
            message += "Address: " + address + "\n";

            MessageBox.Show(message);

        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message += "Name: " + name + "\n";
                       
            MessageBox.Show(message);

        }

        private void ParentsNameButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message += "Father's Name: " + fathersName + "\n";
            message += "Mother's Name: " + mothersName + "\n";
            
            MessageBox.Show(message);

        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            string message = "";
           
            message += "Address: " + address + "\n";

            MessageBox.Show(message);

        }
    }
}
