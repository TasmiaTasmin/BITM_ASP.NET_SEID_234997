using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class BookShop : Form
    {        
        //string customerName;
        //string contactNo;
        //string address;
        //string order;
        //int quantity;
        //int totalPrice;
        //int tempTotalPrice;

        public BookShop()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustomerName.Text;
            string contactNo = textBoxContactNo.Text;
            string address = textBoxAddress.Text;
            string order = comboBoxOrder.Text;
            int quantity = Convert.ToInt32(textBoxQuantity.Text);
            int tempTotalPrice;

         
            int price = 0;
            
            if (order.Equals("Bangla"))
            {
                price = 90;
            }
            else if (order.Equals("English"))
            {
                price = 100;
            }
            else if (order.Equals("Math"))
            {
                price = 120;
            }
            else if (order.Equals("Art"))
            {
                price = 80;
            }
            tempTotalPrice = price * quantity;

            
            string message = "";                      
            message += "\nName: " + customerName;         
            message += "\nContact No. : " + contactNo;
            message += "\nAddress: " + address;
            message += "\nOrder: " + order;
            message += "\nQuantity : " + Convert.ToString(quantity);
            message += "\nTotal Price : " + Convert.ToString(tempTotalPrice);                       
            richTextBoxOutput.Text = message;
        }
    }
}
