using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Assignment9.Repository
{
    public class CustomerRepository
    {
        //Insert Method
        public bool InsertCustomer(string name, int number, string address, int code)
        {
            bool isAdded = false;
            try

            {
                //Connection
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"INSERT INTO Customer (Name, Contact, Address, Code) Values ('" + name + "', " + number + "," +
                    " + '" + address + "', " + code + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    //MessageBox.Show("Saved");
                    isAdded = true;
                }
                //else
                //{
                //    //MessageBox.Show("Not Saved");
                //}

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Insert Item Information");
            }
            return isAdded;

        }
        //Delete Method
        public bool DeleteCustomer(int id)
        {
            try
            {
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //DELETE FROM Items WHERE ID = 3
                string commandString = @"DELETE FROM Customer WHERE ID = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Delete
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }


                //Close
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Which ID!!");
            }
            return false;
        }

        //Show Method
        public DataTable ShowCustomerInfo()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    //showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //   // MessageBox.Show("No Data Found");
            //}
            //Close
            sqlConnection.Close();
            return dataTable;
        }
        //Update Method
        public bool UpdateCustomer(string name, int number, string address, int code, int id)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"UPDATE Customer SET Name= '" + name + "',Contact= " + number + ",Address = '" + address + "',Code= " + code + "  WHERE ID = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Update
                sqlCommand.ExecuteNonQuery();

                //Close
                sqlConnection.Close();
                
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Input update Information with ID.");
            }
            return exists;
        }
        //Search method
        public DataTable SearchCustomer(string name)
        {
            
                //Connection
               
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Customer  WHERE Name = '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
               // showDataGridView.DataSource = dataTable;

                //Close
                sqlConnection.Close();
                return dataTable;
        }

        public bool UniqueCustomerName(string name)
        {
            bool exists = false;
            try
            {
                //Connection
                
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Customer  WHERE Name = '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //showDataGridView.DataSource = dataTable;

                //Close
                sqlConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);  
            }
            return exists;
        }
    }
}
