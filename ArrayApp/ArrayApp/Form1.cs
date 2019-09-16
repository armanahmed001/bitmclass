using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            const int size = 10;

            string [] element = new string[size];

            element[0] = "1";
            element[1] = "1";
            element[2] = "2";
            element[3] = "3";
            element[4] = "4";
            element[5] = "5";
            element[6] = "6";
            element[7] = "7";
            element[8] = "8";
            element[9] = "9";

            string number = "";
            

            for (int i = 0; i<10; i++)
            {
                number += element[i];
                
            }

            MessageBox.Show("Element of Result: " + number);

        }


        private void savebutton_Click(object sender, EventArgs e)
        {

            const int size = 10;
            int[] element = new int[size];
            int usersize = 0;

            if(usersize < size)
            {
              
            }

            
            
            
        }
    }
}
