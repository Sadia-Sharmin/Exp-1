using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopby_list
{
    public partial class Form1 : Form
    {

        List<string> names = new List<string> { };
        List<string> numbers = new List<string> { };
        List<string> addresses = new List<string> { };
        List<string> orderItems = new List<string> { };
        List<int> quantities = new List<int> { };
        List<int> totalPrices = new List<int> { };


        private void ShowInfo()
        {
            richTextBox.Text = "Purchase Information";
            string see = " ";
            for (int i = 0; i < names.Count(); i++)
            {
                see += "\nName: " + names[i] + "\n";
                see += "Number: " + numbers[i] + "\n";
                see += "Address: " + addresses[i] + "\n";
                see += "Order: " + orderItems[i] + "\n";
                see += "Quantity: " + quantities[i] + "\n";
                see += "Total Price: " + totalPrices[i] + "\n";
            }
              richTextBox.AppendText(see);
        }


        private void AddInfo(string cNumber, int quantity, string order)
        {
            //int totalPrice = 0;
            names.Add(nameTextBox.Text);
            numbers.Add(cNumber);
            addresses.Add(addressTextBox.Text);
            orderItems.Add(order);
            quantities.Add(quantity);

            if (order == "Black")
            {
                totalPrices.Add(quantity * 120);
            }
            else if (order== "Cold")
            {

                totalPrices.Add(quantity * 100);
            }
            else if (order == "Hot")
            {
                totalPrices.Add(quantity * 90);

            }
            else if (order == "Regular")
            {
                totalPrices.Add(quantity * 80);

            }
            string seeInfo = " ";

            for (int i = 0; i < names.Count(); i++)
            {
                seeInfo += "\nName: " + names[i] + "\n";
                seeInfo += "Number: " + numbers[i] + "\n";
                seeInfo += "Address: " + addresses[i] + "\n";
                seeInfo += "Order: " + orderItems[i] + "\n";
                seeInfo += "Quantity: " + quantities[i] + "\n";
                seeInfo += "Total Price: " + totalPrices[i] + "\n";

            }
            richTextBox.AppendText(seeInfo);
            // MessageBox.Show("\n" + seeInfo + "\nTotal Price: " + totalPrice);
            // purchaseRichTextBox.Text = "Purchase Information\n";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowInfo();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (numbers.Contains(contactTextBox.Text) == true)
            {
                MessageBox.Show("Number Already Exists");
            }
            else if (orderComboBox.Text == "Select An Item")
            {
                MessageBox.Show("Items Must Be Selected");
            }
            else if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Quantity Can't Be Empty");

            }

            else
            {
                // Convert.ToInt32(quantityTextBox.Text);
                AddInfo(contactTextBox.Text, Convert.ToInt32(quantityTextBox.Text), orderComboBox.Text);


            }
            // RichTextBox.Text = "Purchase Information";
            nameTextBox.Text = " ";
            contactTextBox.Text = " ";
            addressTextBox.Text = " ";
            orderComboBox.Text = "Select An Item";
            quantityTextBox.Text = " ";
          

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ////nameTextBox.Text();
            ////contactTextBox.Text();
            ////addressTextBox.Text();
            ////orderComboBox.Text();
            ////quantityTextBox.Text();
            richTextBox.Clear();
        }
    }
}
