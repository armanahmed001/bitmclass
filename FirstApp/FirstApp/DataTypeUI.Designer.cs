namespace FirstApp
{
    partial class DataTypeUI
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
            this.showbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.firstnumbertextBox = new System.Windows.Forms.TextBox();
            this.secondnumbertextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(527, 226);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 0;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second Number";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(319, 41);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 4;
            // 
            // firstnumbertextBox
            // 
            this.firstnumbertextBox.Location = new System.Drawing.Point(319, 79);
            this.firstnumbertextBox.Name = "firstnumbertextBox";
            this.firstnumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnumbertextBox.TabIndex = 5;
            // 
            // secondnumbertextBox
            // 
            this.secondnumbertextBox.Location = new System.Drawing.Point(319, 117);
            this.secondnumbertextBox.Name = "secondnumbertextBox";
            this.secondnumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.secondnumbertextBox.TabIndex = 6;
            // 
            // DataTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 296);
            this.Controls.Add(this.secondnumbertextBox);
            this.Controls.Add(this.firstnumbertextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showbutton);
            this.Name = "DataTypeUI";
            this.Text = "DataTypeUI";
            this.Load += new System.EventHandler(this.DataTypeUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox firstnumbertextBox;
        private System.Windows.Forms.TextBox secondnumbertextBox;
    }
}