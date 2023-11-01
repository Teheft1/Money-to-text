namespace Money_to_text
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
            this.MoneyIN = new System.Windows.Forms.TextBox();
            this.TextConvert = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoneyIN
            // 
            this.MoneyIN.Location = new System.Drawing.Point(161, 144);
            this.MoneyIN.Name = "MoneyIN";
            this.MoneyIN.Size = new System.Drawing.Size(100, 20);
            this.MoneyIN.TabIndex = 0;
            this.MoneyIN.TextChanged += new System.EventHandler(this.MoneyIN_TextChanged);
            // 
            // TextConvert
            // 
            this.TextConvert.Location = new System.Drawing.Point(161, 189);
            this.TextConvert.Name = "TextConvert";
            this.TextConvert.Size = new System.Drawing.Size(296, 20);
            this.TextConvert.TabIndex = 1;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(336, 160);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "button1";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(632, 461);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.TextConvert);
            this.Controls.Add(this.MoneyIN);
            this.Name = "Form1";
            this.Text = "Money To Text Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MoneyIN;
        private System.Windows.Forms.TextBox TextConvert;
        private System.Windows.Forms.Button Convert;
    }
}

