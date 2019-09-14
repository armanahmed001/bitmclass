using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porsonal_InformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string firstName = firstnametextBox.Text;
            string secondName = secondnametextBox.Text;
            string fatherName = fathernametextBox.Text;
            string motherName = mothernametextBox.Text;
            string address = addresstextBox.Text;
        }

        private void showallbutton_Click(object sender, EventArgs e)
        {
            string firstName = firstnametextBox.Text;
            string secondName = secondnametextBox.Text;
            string fatherName = fathernametextBox.Text;
            string motherName = mothernametextBox.Text;
            string address = addresstextBox.Text;

            MessageBox.Show(" First Name: " + firstName.ToString() + "\n Second Name: " + secondName.ToString() + "\n Father Name: " + fatherName.ToString() + "\n Mother Name: " + motherName.ToString()+"\n Address: " + address.ToString()); 
        }

        private void namebutton_Click(object sender, EventArgs e)
        {
            string firstName = firstnametextBox.Text;
            string secondName = secondnametextBox.Text;
            

            MessageBox.Show(" First Name: " + firstName.ToString() +"\n Second Name: " + secondName.ToString());
        }

        private void parentsbutton_Click(object sender, EventArgs e)
        {
            string fatherName = fathernametextBox.Text;
            string motherName = mothernametextBox.Text;
            

            MessageBox.Show(" Father Name: " + fatherName.ToString() + "\n Mother Name: " + motherName.ToString());
        }

        private void addressbutton_Click(object sender, EventArgs e)
        {
            string address = addresstextBox.Text;

            MessageBox.Show(" Address: " + address.ToString());
        }
    }
}
