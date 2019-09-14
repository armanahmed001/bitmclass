using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = customernametextBox.Text;
            string contact = contacttextBox.Text;
            string address = addresstextBox.Text;
            string order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantitytextBox.Text);
            int unitPrice = 0;

            if( order == "Black-120")
            {
                unitPrice = 120;
            }
            else if( order == "Cold-100")
            {
                unitPrice = 100;
            }
            else if(order == "Hot-90")
            {
                unitPrice = 90;
            }
            else if( order == "Reguler-80")
            {
                unitPrice = 80;
            }
            else
            {
                unitPrice = 0;
            }

            
            int totalPrice = quantity * unitPrice;

            listBox1.Items.Add("Customer Name: " + name);
            listBox1.Items.Add("Contact No: " + contact);
            listBox1.Items.Add("Address: " + address);
            listBox1.Items.Add("Order: " + order);
            listBox1.Items.Add("Quantity: " + quantity);
            listBox1.Items.Add("Total Price: " + totalPrice);

        }


        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
