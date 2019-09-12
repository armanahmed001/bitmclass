namespace FirstApp
{
    partial class ConditionUI
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
            this.itemcomboBox = new System.Windows.Forms.ComboBox();
            this.showbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemcomboBox
            // 
            this.itemcomboBox.FormattingEnabled = true;
            this.itemcomboBox.Items.AddRange(new object[] {
            "Pen ",
            "Box",
            "Pencil"});
            this.itemcomboBox.Location = new System.Drawing.Point(176, 76);
            this.itemcomboBox.Name = "itemcomboBox";
            this.itemcomboBox.Size = new System.Drawing.Size(121, 21);
            this.itemcomboBox.TabIndex = 0;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(384, 73);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 1;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // ConditionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.itemcomboBox);
            this.Name = "ConditionUI";
            this.Text = "ConditionUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox itemcomboBox;
        private System.Windows.Forms.Button showbutton;
    }
}