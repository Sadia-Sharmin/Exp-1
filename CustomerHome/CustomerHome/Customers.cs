﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerHome.Model;
using CustomerHome.Bill;
namespace CustomerHome
{
    public partial class Customers : Form
    {
        CustomerManager _customerManager=new CustomerManager();
        Customer _customer=new Customer();
        public Customers()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.Code = textBoxCode.Text;
                _customer.Name = textBoxName.Text;
                _customer.Address = textBoxAddress.Text;
                _customer.Contact = textBoxContact.Text;
                _customer.DistrictId = Convert.ToInt32(comboBoxDistrict.SelectedValue);

                List<Customer> customers = _customerManager.SearchCustomers(_customer);
                if (customers.Contains(_customer))
                {
                    labelCode.Text = "Code Exists";
                }
                else if (_customer.Code.Length == 0)
                {
                    labelCode.Text = "Code Can't Be Empty";
                }
                else if (_customer.Code.Length < 4)
                {
                    labelCode.Text = "Code Must Be 4 Character";
                }
                else if (_customer.Code.Length > 4)
                {
                    labelCode.Text = "Code Must Not Exceed 4 Character";
                }
                else if (_customer.Name.Length == 0)
                {
                    labelName.Text = "Name Can't Be Empty";
                }
                else if (_customer.Contact.Length==0)
                {
                    labelContact.Text = "Contact Is Mandatory";
                }
                else if (_customer.Contact.Length < 11)
                {
                    labelContact.Text = "Contact Is 11 Digit";
                }
                else if (_customer.Contact.Length > 11)
                {
                    labelContact.Text = "Contact Is Not More Than 11 Digit";
                }
                else if (_customer.DistrictId == 0)
                {
                    labelDistrict.Text = "You Must Select A District";
                }
                else
                {
                   // _customer.DistrictId =Convert.ToInt32( comboBoxDistrict.SelectedValue);
                    bool isSaved = _customerManager.SaveInfo(_customer);
                    if (isSaved)
                    {
                        MessageBox.Show("Saved");
                        dataGridViewCustomer.DataSource = _customerManager.ShowAllCustomers(_customer);
                    }
                }
                /* if (customers.Count > 0)
                 {
                     //label6.Text = "Saved";
                   //  dataGridViewCustomer.DataSource = _customerManager.SaveInfo(_customer);
                     MessageBox.Show("Customer Name Exists");
                 }
                 else
                 {
                     dataGridViewCustomer.DataSource = _customerManager.SaveInfo(_customer);
                 }*/
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = _customerManager.ShowAllCustomers(_customer);
            comboBoxDistrict.DataSource = _customerManager.ComboBoxDistricts();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _customer.Code = textBoxCode.Text;
            _customer.Contact = textBoxContact.Text;
            List<Customer> customers = _customerManager.SearchCustomers(_customer);
            if (customers.Count==0)
            {
                MessageBox.Show("Not Exists");
                dataGridViewCustomer.DataSource ="";

            }
            else
            {
               // MessageBox.Show("Customer Exists");
                dataGridViewCustomer.DataSource = _customerManager.ShowCustomers(_customer);
            }
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow dataGridViewRow = dataGridViewCustomer.Rows[e.RowIndex];
                textBoxCode.Text = dataGridViewRow.Cells["Code"].Value.ToString();
                textBoxName.Text= dataGridViewRow.Cells["Name"].Value.ToString();
                textBoxAddress.Text= dataGridViewRow.Cells["Address"].Value.ToString();
                textBoxContact.Text= dataGridViewRow.Cells["Contact"].Value.ToString();
                comboBoxDistrict.Text= dataGridViewRow.Cells["District"].Value.ToString();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = _customerManager.ShowAllCustomers(_customer);
        }

        private void dataGridViewCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
