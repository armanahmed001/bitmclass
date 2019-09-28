using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment6App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-PGSVAVG\MSSQLSERVER2014; Database=CoffeeShop; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"INSERT INTO customer (name, contact,address) VALUES('" + customerNameTextBox.Text + "'," + contactNoTextBox.Text + ",'" + addressTextBox + "');INSERT INTO Items (name, price) VALUES('" + itemNameTextBox.Text + "'," + priceTextBox.Text + ");INSERT INTO orders (quantity) VALUES('" + Convert.ToInt32(quantityTextBox.Text) + "');INSERT INTO Items(name) VALUES(@name);";
            SqlCommand sqlParameter = new SqlCommand(commandString, sqlConnection);




            //Open
            sqlConnection.Open();

            sqlParameter.Parameters.AddWithValue("@name",itemComboBox.Text.ToString());

            sqlParameter.ExecuteNonQuery();
            

            //Close
            sqlConnection.Close();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-PGSVAVG\MSSQLSERVER2014; Database=CoffeeShop; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM orders";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            showDataGridView.DataSource = dataTable;

            //Close
            sqlConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDataSet1.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.coffeeShopDataSet1.orders);
            // TODO: This line of code loads data into the 'coffeeShopDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.coffeeShopDataSet.Items);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBy(this.coffeeShopDataSet.Items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
