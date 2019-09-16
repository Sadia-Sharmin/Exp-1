using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopwithArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        { 

        
            const int size = 5;
            //int index = 0;
            string[] a = new string[size];
            int[] ar2 = new int[size];
            a[0] = customerNameTextBox.Text;
            a[1] = contactTextBox.Text;
            a[2] = addressTextBox.Text;
            a[3] = orderComboBox.Text;
            ar2[0] = Convert.ToInt32(quantityTextBox.Text);
            int totalPrice = 0;

            if (a[3] == "Black")
            {
                totalPrice = ar2[0] * 120;
            }
            else if (a[3] == "Cold")
            {
                totalPrice = ar2[0] * 100;
            }
            else if (a[3] == "Hot")
            {
                totalPrice = ar2[0] * 90;
            }
            else if (a[3] == "Regular")
            {
                totalPrice = ar2[0] * 80;
            }
            else
            {
                MessageBox.Show("Please Select An Item");
            }
            richTextBox.AppendText("\n\nName: " + a[0] + "\nContact: "
                + a[1] + "\nAddress: " + a[2] + "\nOrder: " + a[3] + "\nQuantity: "
                + ar2[0] + "\nTotal Price " + totalPrice);

            customerNameTextBox.Text = " ";
            contactTextBox.Text = " ";
            addressTextBox.Text = " ";
            orderComboBox.Text = " ";
            quantityTextBox.Text = " ";



        }
    }
}
