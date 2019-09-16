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
            string name = customerNameTextBox.Text;
            string contact = contactTextBox.Text;
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            string quantity = quantityTextBox.Text;
            double totalPrice = 0;
            if (quantity != "")
            {
                switch (order)
                {
                    case "Black":
                        totalPrice = int.Parse(quantity) * 120;
                        break;
                    case "Cold":
                        totalPrice = int.Parse(quantity) * 100;
                        break;
                    case "Hot":
                        totalPrice = int.Parse(quantity) * 90;
                        break;
                    case "Regular":
                        totalPrice = int.Parse(quantity) * 80;
                        break;
                }
                

                //const int size = 10;
                //int[] element = new int[size];

                //string[] customerinfo = new string[size];
                //string message = " ";
                //for (int i = 0; i < size; i++)
                //{
                //    element[i] = i;
                //    //message += "\n\nCustomer Information: " + element[i].ToString();
                //}

                //string sms = " ";
                //for (int j = 0; j < size; j++)
                //{
                //    customerinfo[j] += ("\nCustomer Name: " + name + "\nContact No: " + contact
                //    + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity
                //    + "\n\n\nTotal Price: " + totalPrice + " BDT");

                //}







                //for (int i = 1; i < size; i++)
                //{
                //    sms += "\n\nCustomer Information: " + element[i].ToString() + customerinfo[i] + " \n";

                //}




                if (order != "")
                {
                    int size = 15;
                    string[] customerinfo = new string[size];
                    int[] element = new int[size];
                    string sms = " ";
                    string message = " ";
                    for (int j = 1; j < size; j++)
                    {
                        message =  element[j].ToString() ;

                    }

                    for (int i = 0; i < size; i++)
                    {
                        
                        customerinfo[i] = ("\nCustomer Name: " + name + "\nContact No: " + contact
                         + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity
                         + "\n\n\nTotal Price: " + totalPrice + " BDT");
                        sms = customerinfo[i];
                        
                        
                    }

                    showInformationRichTextBox.Text += "\n\nCustomer Information: " + message + sms;

                    //showInformationRichTextBox.Text = "Customer Name: " + name + "\nContact No: " + contact
                    //+ "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity
                    //+ "\n\n\nTotal Price: " + totalPrice + " BDT";

                    MessageBox.Show("Order completed successfully.");
                }
                else 
                {
                    MessageBox.Show("Please Select an order item..");
                }
            }
            else
            {
                MessageBox.Show("Please select quantity!");
            }

        }


        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
