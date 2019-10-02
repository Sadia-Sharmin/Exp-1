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
    public partial class Order : Form
    {
        OrderManagement _orderManagement = new OrderManagement();

        public Order()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isAdded = _orderManagement.addOrder(customerNameTextBox.Text, itemNameTextBox.Text,Convert.ToInt32(quantityTextBox.Text), Convert.ToInt32(totalPriceTextBox.Text));
            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
            //show
            showDataGridView.DataSource = _orderManagement.ShowCustomerInfo();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _orderManagement.ShowCustomerInfo();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Delete
            if (_orderManagement.DeleteOrder(Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            //show
            showDataGridView.DataSource = _orderManagement.ShowCustomerInfo();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            if (_orderManagement.UpdateOrder(customerNameTextBox.Text, itemNameTextBox.Text, Convert.ToInt32(quantityTextBox.Text), Convert.ToInt32(totalPriceTextBox.Text), Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Updated");
                _orderManagement.ShowCustomerInfo();
            }
            //show
            showDataGridView.DataSource = _orderManagement.ShowCustomerInfo();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _orderManagement.SearchOrder(customerNameTextBox.Text);
        }
       

        
    }
}
