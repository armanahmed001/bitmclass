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
    public partial class Exercese2 : Form
    {
        public Exercese2()
        {
            InitializeComponent();
        }

        List<string> numbers = new List<string> { };

        string reverse = " ";

        string message = " ";


        private void addButton_Click(object sender, EventArgs e)
        {

            int size = int.Parse(sizeTextBox.Text);
            
            if (size!= 0)
            {
                numbers.Add(inputTextBox.Text);
            }
            else
            {
                MessageBox.Show("Add the input size.");
            }
           

        }
        private void ShowNumber()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                message += ("Number: " + numbers + "\n");
            }

            for (int i = 0; i > numbers.Count; i--)
            {
                reverse += ("\nNumber: " + numbers + "\n");
            }

            MessageBox.Show(message + reverse);
            numbers.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowNumber();
        }
    }
}
