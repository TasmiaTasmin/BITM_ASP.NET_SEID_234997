using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
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

            if (order.Equals("Black"))
            {
                price = 120;
            }
            else if (order.Equals("Cold"))
            {
                price = 100;
            }
            else if (order.Equals("Hot"))
            {
                price = 90;
            }
            else if (order.Equals("Reguler"))
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
