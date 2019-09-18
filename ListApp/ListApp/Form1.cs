using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> names = new List<string> {"Ali"};
        string message= "";
        private void nameButton_Click(object sender, EventArgs e)
        {
            names.Add(nameTextBox.Text);

            ShowCustomer();

            

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        
        private void ShowCustomer()
        {
            foreach (string name in names)
            {
                message += ("Name: " + name + "\n");
            }

            MessageBox.Show(message);
            names.Clear();
        }
    }
}
