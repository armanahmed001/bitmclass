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
    public partial class Exercese1 : Form
    {
        public Exercese1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int> { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string message = " ";
            for(int i = 0; i<numbers.Count; i++)
            {
                message += numbers[i].ToString();

            }

            MessageBox.Show("Number: " + message);
        }
    }
}
