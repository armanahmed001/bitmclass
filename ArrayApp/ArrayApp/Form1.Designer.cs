namespace ArrayApp
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
            this.showbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.ExtextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(311, 121);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 0;
            this.showbutton.Text = "Exercise 1";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(311, 179);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 1;
            this.savebutton.Text = "Add Number";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // ExtextBox
            // 
            this.ExtextBox.Location = new System.Drawing.Point(429, 182);
            this.ExtextBox.Name = "ExtextBox";
            this.ExtextBox.Size = new System.Drawing.Size(100, 20);
            this.ExtextBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find Array";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExtextBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.showbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox ExtextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

