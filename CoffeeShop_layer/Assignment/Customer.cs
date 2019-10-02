using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment9.BLL;


namespace Assignment9
{
    public partial class Customer : Form
    {
        CustomerManagement _customerManagement = new CustomerManagement();
        public Customer()
        {
            InitializeComponent();
        }
        

        private void Coffee_Shop_Load(object sender, EventArgs e)
        {

        }
        //Insert Button
        private void addButton_Click(object sender, EventArgs e)
        {
          
            if (_customerManagement.UniqueCustomerName(customerNameTextBox.Text))
            {
                MessageBox.Show("Name already exits");
                return;
            }
            //add Customer
            bool isAdded = _customerManagement.InsertCustomer(customerNameTextBox.Text,Convert.ToInt32(customerNoTextBox.Text), addressTextBox.Text,Convert.ToInt32(codeTextBox.Text));
            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
            //show
            showDataGridView.DataSource = _customerManagement.ShowCustomerInfo();

        }

        //Delete Button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Delete
            if (_customerManagement.DeleteCustomer(Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            //show
            showDataGridView.DataSource = _customerManagement.ShowCustomerInfo();

        }

        //Show Button
        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManagement.ShowCustomerInfo();
        }
        //update Button
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            if(_customerManagement.UpdateCustomer(customerNameTextBox.Text, Convert.ToInt32(customerNoTextBox.Text),addressTextBox.Text,Convert.ToInt32(codeTextBox.Text), Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Updated");
                _customerManagement.ShowCustomerInfo();
            }
            //show
            showDataGridView.DataSource = _customerManagement.ShowCustomerInfo();

        }
        //Search Button
        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManagement.SearchCustomer(customerNameTextBox.Text);
        }

       

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        


    }
}


