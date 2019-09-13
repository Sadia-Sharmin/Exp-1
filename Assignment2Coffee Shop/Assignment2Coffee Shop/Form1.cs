using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Coffee_Shop
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ordercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
                
            string name = customerNameTextBox.Text;
            int contact = Convert.ToInt32(contactTextBox.Text);
           string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int unit =0;
            
           if(orderComboBox.Text== "Black coffee ")
            {
               unit = 120;
            }
           else if (orderComboBox.Text == "cold coffee ")
            {
                unit = 100;
          
            }
            else if (orderComboBox.Text == "Hot coffee ")
            {
                unit = 90;
            }
            else if (orderComboBox.Text == "Regular coffee ")
            {
                unit = 80;
            }
           else
            {
                MessageBox.Show("Please select an item");
            }

            int Totalcost = unit * quantity;

            richTextBox.AppendText("customer Name=" + name + "\nContact NO=" + contact + "\nAddress=" + address +
                "\nOrder=" + order + "\nQuantity=" + quantity + "\nPer unit =" + unit + "\nTotal cost=" + Totalcost );
        }
    }
}
