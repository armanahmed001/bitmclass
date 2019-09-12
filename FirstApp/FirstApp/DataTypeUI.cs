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
    public partial class DataTypeUI : Form
    {

        public DataTypeUI()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            //int age = 0;
            //double Salary = 5000.00;
            //String name = "Hasan";
            //bool isDone = true;

            string name = nametextBox.Text;

            int firstnumber = Convert.ToInt32(firstnumbertextBox.Text);
            int secondnumber = Convert.ToInt32(secondnumbertextBox.Text);

            int result = firstnumber + secondnumber;

            MessageBox.Show("Name: " + name + "\n result =" + result.ToString());

        }

        private void DataTypeUI_Load(object sender, EventArgs e)
        {

        }
    }
}
