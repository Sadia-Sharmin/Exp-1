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
    public partial class Item : Form
    {
        ItemManagement _itemManagement = new ItemManagement();


        public Item()
        {
            InitializeComponent();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            //Check UNIQUE
            if (_itemManagement.UniqueItemName(itemTextBox.Text))
            {
                MessageBox.Show("Item already exits");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            //Add Item
            bool isAdded = _itemManagement.InsertCustomer(itemTextBox.Text, Convert.ToInt32(priceTextBox.Text));
            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _itemManagement.ShowItemInfo();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManagement.ShowItemInfo();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManagement.SearchItem(itemTextBox.Text);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            if (_itemManagement.UpdateItem(itemTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Updated");
                _itemManagement.ShowItemInfo();
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _itemManagement.ShowItemInfo();

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
            if(_itemManagement.DeleteItem(Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _itemManagement.ShowItemInfo();
        }

    }
}
