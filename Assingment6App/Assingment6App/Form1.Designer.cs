namespace Assingment6App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet = new Assingment6App.CoffeeShopDataSet();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Assingment6App.CoffeeShopDataSetTableAdapters.ItemsTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.coffeeShopDataSet1 = new Assingment6App.CoffeeShopDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Assingment6App.CoffeeShopDataSetTableAdapters.ordersTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contactNoTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(161, 56);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(140, 20);
            this.contactNoTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(161, 98);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(140, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(161, 24);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(225, 386);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(125, 386);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(318, 386);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(27, 386);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(98, 58);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(140, 20);
            this.quantityTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order";
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(440, 91);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(328, 309);
            this.showDataGridView.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(484, 36);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(284, 20);
            this.searchTextBox.TabIndex = 16;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(693, 62);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.itemNameTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(27, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 79);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items Information";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(119, 48);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(108, 20);
            this.priceTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Price";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(119, 19);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Item Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.quantityTextBox);
            this.groupBox3.Location = new System.Drawing.Point(27, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Information";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource1, "name", true));
            this.itemComboBox.DataSource = this.ordersBindingSource;
            this.itemComboBox.DisplayMember = "itemName";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(98, 21);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemComboBox.TabIndex = 9;
            this.itemComboBox.ValueMember = "itemsID";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.coffeeShopDataSet;
            // 
            // coffeeShopDataSet
            // 
            this.coffeeShopDataSet.DataSetName = "CoffeeShopDataSet";
            this.coffeeShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.coffeeShopDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 18;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // coffeeShopDataSet1
            // 
            this.coffeeShopDataSet1.DataSetName = "CoffeeShopDataSet";
            this.coffeeShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.coffeeShopDataSet1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CoffeeShop6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox itemComboBox;
        private CoffeeShopDataSet coffeeShopDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private CoffeeShopDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private CoffeeShopDataSet coffeeShopDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CoffeeShopDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
    }
}

