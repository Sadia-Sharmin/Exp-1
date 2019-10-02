using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment9.Repository
{
    public class OrderRepository
    {
        //Insert Method
        public bool addOrder(string name, string item, int quantity, int totalPrice)
        {
            bool isAdded = false;
            try
            {
                
                //Connection
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"INSERT INTO Orders (CustomerName, ItemName, Quantity,TotalPrice) Values ('" + name + "',  '" + item + "'," + quantity + ", " + totalPrice + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                
            }
            return isAdded;
        }
        //Delete Method
        public bool DeleteOrder(int id)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command    
                string commandString = @"DELETE FROM  Orders WHERE ID = " + id + "";
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
                //MessageBox.Show("Whice ID!!");
            }
            return false;
        }

        //Show Method
        public DataTable ShowCustomerInfo()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM  Orders";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           
            //Close
            sqlConnection.Close();
            return dataTable;
        }
        //Update Method
        public bool UpdateOrder(string name, string item, int quantity, int totalPrice, int id)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"UPDATE  Orders SET CustomerName= '" + name + "',ItemName = '" + item + "',Quantity= " + quantity + ",TotalPrice= " + totalPrice + "  WHERE ID = " + id + "";
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
               // MessageBox.Show("Input values for update with ID.");
            }
            return exists;
        }
        //Search method
        public DataTable SearchOrder(string name)
        {
              //Connection
                string connectionString = @"Server=DESKTOP-O7V3738; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Orders  WHERE CustomerName = '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //showDataGridView.DataSource = dataTable;

                //Close
                sqlConnection.Close();
               return dataTable;
        }
    }
}
