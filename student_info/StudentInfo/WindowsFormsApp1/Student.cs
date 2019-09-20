using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {
        List<string> Ids = new List<string> { };
        List<string> names = new List<string> { };
        List<string> numbers = new List<string> { };
        List<int> ages = new List<int> { };
        List<string> addresses = new List<string> { };
        List<double> gpas = new List<double> { };

        private void ShowInfo()
        {

        }
        public Student()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (Ids.Contains(idTextBox.Text) == true)
            {
                MessageBox.Show("Id Already Exists");
            }
            else if (numbers.Contains(mobileTextBox.Text) == true)
            {
                MessageBox.Show("Contact Already Exists");
            }
            else if (idTextBox.Text.Length != 4)
            {
                MessageBox.Show("Id must be 4 digites");
            }
            else if (mobileTextBox.Text.Length != 11)
            {
                MessageBox.Show("Contact must be 11 digites");
            }
            else if (nameTextBox.Text.Length > 30)
            {
                MessageBox.Show("Name must be with in 30 characters");
            }
            else if ((Convert.ToDouble(gpaTextBox.Text) >= 0 && Convert.ToDouble(gpaTextBox.Text) > 4))
            {
                MessageBox.Show("Enter valid gpa");
            }
            else if (String.IsNullOrEmpty(idTextBox.Text) && String.IsNullOrEmpty(nameTextBox.Text) &&
               String.IsNullOrEmpty(mobileTextBox.Text))
            {
                MessageBox.Show("Id Can't Be Empty");
                MessageBox.Show("Name Can't Be Empty");
                MessageBox.Show("Contact Can't Be Empty");
            }
            else
            {
                AddStudentInfo (idTextBox.Text, nameTextBox.Text,
                    mobileTextBox.Text, addressTextBox.Text,
                    Convert.ToInt32(ageTextBox.Text),
                     Convert.ToDouble(gpaTextBox.Text));
                richTextBox.Text = "";
            }
        }

        private void AddStudentInfo(string id, string name, string number, string address, int age, double gpa)
        {
            Ids.Add(id);
            names.Add(name);
            numbers.Add(number);
            addresses.Add(address);
            ages.Add(age);
            gpas.Add(gpa);
        }
        private void ShowStudentInfo()
        {
            richTextBox.Text = "";
            for (int i = 0; i < names.Count(); i++)
            {
                richTextBox.Text += "Student ID:" + Ids[i] + "\n" + "Student Name:" + names[i] + "\nContact Number:"
                     + numbers[i] + "\nAddress:" + addresses[i] +
                     "\nAge:" + ages[i] + "GPA:" + gpas[i] + "\n\n";
            }

            double max = gpas.Max();
            maxGpaTextBox.Text = max.ToString();

            int index = gpas.IndexOf(max);
            string name = names[index];
            maxNameTextBox.Text = name;


            double min = gpas.Min();
            minGpaTextBox.Text = min.ToString();


            int index2 = gpas.IndexOf(min);
            string name2 = names[index2];
            minNameTextBox.Text = name2;

            double avg = gpas.Average();
            avgTextBox.Text = avg.ToString();

            double total = gpas.Sum();
            totalTextBox.Text = total.ToString();


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowStudentInfo();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
          
       
            try
            {
               richTextBox.Text = "";
                for (int j = 0; j < Ids.Count(); j++)
                {
                    if (idRadioButton.Checked == true)
                    {
                        if (idTextBox.Text == Ids[j])
                        {
                            richTextBox.Text = "Student ID:" + Ids[j] + "\n" + "Student Name:" + names[j] + "\nContact Number:"
                  + numbers[j] + "\nAddress:" + addresses[j] +
                     "\nAge:" + ages[j] + "\nGPA:" + gpas[j] + "\n\n";
                        }
                    }
                    else if (nameRadioButton.Checked == true)
                    {
                        if (nameTextBox.Text == names[j])
                        {
                            richTextBox.Text = "Student ID:" + Ids[j] + "\n" + "Student Name:" + names[j] + "\nContact Number:"
                 + numbers[j] + "\nAddress:" + addresses[j] +
                    "\nAge:" + ages[j] + "\nGPA:" + gpas[j] + "\n\n";
                        }
                    }
                    else if (mobileRadioButton.Checked == true)
                    {
                        if (mobileTextBox.Text == numbers[j])
                        {
                            richTextBox.Text = "Student ID:" + Ids[j] + "\n" + "Student Name:" + names[j] + "\nContact Number:"
                  + numbers[j] + "\nAddress:" + addresses[j] +
                     "\nAge:" + ages[j] + "\nGPA:" + gpas[j] + "\n\n";
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message); return;

            }

        }
    }

}
