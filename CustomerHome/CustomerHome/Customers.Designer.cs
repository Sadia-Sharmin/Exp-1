namespace CustomerHome
{
    partial class Customers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDistrict = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "District";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(338, 20);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(93, 20);
            this.textBoxCode.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(338, 47);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(93, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(338, 79);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(93, 20);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(338, 114);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContact.MaxLength = 11;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(93, 20);
            this.textBoxContact.TabIndex = 4;
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DataSource = this.districtBindingSource;
            this.comboBoxDistrict.DisplayMember = "Districts";
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(338, 149);
            this.comboBoxDistrict.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(93, 21);
            this.comboBoxDistrict.TabIndex = 5;
            this.comboBoxDistrict.ValueMember = "Id";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(459, 22);
            this.labelCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(0, 13);
            this.labelCode.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(459, 49);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 4;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(459, 79);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(0, 13);
            this.labelAddress.TabIndex = 4;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(459, 114);
            this.labelContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(0, 13);
            this.labelContact.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(261, 197);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(71, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(363, 197);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(71, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewCustomer.DataSource = this.customerViewModelBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(37, 232);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowTemplate.Height = 28;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(643, 171);
            this.dataGridViewCustomer.TabIndex = 6;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick_1);
            // 
            // Sl
            // 
            this.Sl.DataPropertyName = "Id";
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "District";
            this.dataGridViewTextBoxColumn6.HeaderText = "District";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // customerViewModelBindingSource
            // 
            this.customerViewModelBindingSource.DataSource = typeof(CustomerHome.Model.CustomerViewModel);
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Location = new System.Drawing.Point(459, 151);
            this.labelDistrict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(0, 13);
            this.labelDistrict.TabIndex = 4;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(462, 197);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(65, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 448);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customers";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

