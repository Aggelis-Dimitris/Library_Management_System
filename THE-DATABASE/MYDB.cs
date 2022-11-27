using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_Management_System.THE_DATABASE
{
    //Open XAMPP
    //Create the database
    //Create table users
    //Add mySQL connector

    internal class MYDB
    {
        //the connection

        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_lms_db;");
        
        //create a function to open a connection 
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create a function to close a connection 
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //create a function to return the connection 

        public MySqlConnection getConection()
        {
            return connection;
        }

    }
}
