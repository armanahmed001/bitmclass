using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class ConditionUI : Form
    {
        public ConditionUI()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            if (itemcomboBox.Text == "")
            {
                MessageBox.Show("Please select item");
            }

            else
            {
                MessageBox.Show(itemcomboBox.Text + " is selected");
            }
        }
    }
}
