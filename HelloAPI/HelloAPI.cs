using System;
using System.Data.SqlClient;

namespace HelloAPI
{
    // Base class to provide basic message set/get functionality with rule enforcment
    public abstract class HelloAPIBase
    {
        // Base message for the class to display or send
        public string Message { get; set; }

        // Method to enforce 
        // Can be overridden in child class
        public virtual void SetMessage(string new_message)
        {
            if (string.IsNullOrEmpty(new_message))
                throw new System.ArgumentException("Message can not be null nor empty");
            Message = new_message;
        }
    }

    // Child class to display message to console
    public class HelloAPIConsole : HelloAPIBase
    {
        // Default constructor
        public HelloAPIConsole() { }

        // Constructor that takes message string as argument to set the class Message
        public HelloAPIConsole(string new_message)
        {
            base.SetMessage(new_message);
        }

        // Method to write the class Message to the console
        public void WriteMessage()
        {
            Console.WriteLine(base.Message);
        }
    }

    // Child class to display message in mobile application
    public class HelloAPIMobile : HelloAPIBase
    {
        // Default constructor
        public HelloAPIMobile() { }
    }

    // Child class to display message in desktop application
    public class HelloAPIDesktop : HelloAPIBase
    {
        // Default constructor
        public HelloAPIDesktop() { }
    }

    // Child class to send message to SQL Server instance and manage connection
    public class HelloAPIDatabase : HelloAPIBase
    {
        // Connection to a SQL Server instance
        public SqlConnection DBConn { get; set; }

        // Default constructor
        public HelloAPIDatabase() { }

        // Constructor that takes connection string as argument to set up the DBConn member
        public HelloAPIDatabase(string db_conn_string)
        {
            Init(db_conn_string);
        }

        // Initializer method that takes a database connection string
        public void Init(string db_conn_string)
        {
            if (string.IsNullOrEmpty(db_conn_string))
                throw new System.ArgumentException("Database connection string can not be null nor empty");
            DBConn = new SqlConnection(db_conn_string);
        }
    }
}
