using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Assignment9.Repository
{
    public class ItemRepository
    {
        //Insert Method
        public bool InsertCustomer(string item, int price)
        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-PNN68QT; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Command
                string commandString = @"INSERT INTO Item (Item,Price) Values ('" + item + "',  " + price + ")";
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


        public bool UniqueItemName(string name)
        {
            bool exists = false;
            try
            {
                string connectionString = @"Server=DESKTOP-PNN68QT; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Item WHERE Item = '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //showDataGridView.DataSource = dataTable;

                //Close
               
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


        //Update Method
        public bool UpdateItem(string item, int price, int id)
        {
            bool exists = false;
            try
            {
                string connectionString = @"Server=DESKTOP-PNN68QT; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"UPDATE  Item SET Item = '" + item + "',Price= " + price + "  WHERE ID = " + id + "";
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
                //MessageBox.Show("Input values for Update with ID.");
            }
            return exists;
        }

        //Delete Method
        public bool DeleteItem(int id)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-PNN68QT; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"DELETE FROM  Item WHERE ID = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Delete
                int isExecuted=sqlCommand.ExecuteNonQuery();
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


        //Search method
        public DataTable SearchItem(string item)
        {
            
                //Connection
                string connectionString = @"Server=DESKTOP-PNN68QT; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Item  WHERE Item = '" + item + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
               // showDataGridView.DataSource = dataTable;

                //Close
                sqlConnection.Close();
            
               return dataTable;
        }

        //Show Method
        public DataTable ShowItemInfo()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-PNN68QT; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM  Item";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            // MessageBox.Show("No Data Found");
            //}
            //Close
            sqlConnection.Close();
            return dataTable;
        }

    }
}
