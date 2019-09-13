namespace Assignment2Coffee_Shop
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
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNamelabel = new System.Windows.Forms.Label();
            this.contactNolabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.orderlabel = new System.Windows.Forms.Label();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Location = new System.Drawing.Point(20, 14);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(200, 24);
            this.customerInfoGroupBox.TabIndex = 0;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information";
            // 
            // customerNamelabel
            // 
            this.customerNamelabel.AutoSize = true;
            this.customerNamelabel.Location = new System.Drawing.Point(47, 54);
            this.customerNamelabel.Name = "customerNamelabel";
            this.customerNamelabel.Size = new System.Drawing.Size(82, 13);
            this.customerNamelabel.TabIndex = 1;
            this.customerNamelabel.Text = "Customer Name";
            // 
            // contactNolabel
            // 
            this.contactNolabel.AutoSize = true;
            this.contactNolabel.Location = new System.Drawing.Point(47, 88);
            this.contactNolabel.Name = "contactNolabel";
            this.contactNolabel.Size = new System.Drawing.Size(61, 13);
            this.contactNolabel.TabIndex = 2;
            this.contactNolabel.Text = "Contact No";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(47, 133);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(45, 13);
            this.addresslabel.TabIndex = 3;
            this.addresslabel.Text = "Address";
            // 
            // orderlabel
            // 
            this.orderlabel.AutoSize = true;
            this.orderlabel.Location = new System.Drawing.Point(47, 178);
            this.orderlabel.Name = "orderlabel";
            this.orderlabel.Size = new System.Drawing.Size(33, 13);
            this.orderlabel.TabIndex = 4;
            this.orderlabel.Text = "Order";
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(47, 227);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(46, 13);
            this.quantitylabel.TabIndex = 5;
            this.quantitylabel.Text = "Quantity";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(149, 51);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.customerNameTextBox.TabIndex = 6;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(149, 85);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(149, 130);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(149, 224);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 10;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(286, 276);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 11;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black coffee ",
            "cold coffee ",
            "Hot coffee ",
            "Regular coffee"});
            this.orderComboBox.Location = new System.Drawing.Point(149, 175);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderComboBox.TabIndex = 13;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.ordercomboBox_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(445, 36);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(175, 222);
            this.richTextBox.TabIndex = 14;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.quantitylabel);
            this.Controls.Add(this.orderlabel);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.contactNolabel);
            this.Controls.Add(this.customerNamelabel);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.Label customerNamelabel;
        private System.Windows.Forms.Label contactNolabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label orderlabel;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

