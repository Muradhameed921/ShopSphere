using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace EComm.DatabaseUtil
{
    class DatabaseMySQLProvider : DatabaseProvider
    {

        private SqlConnection connection = null;

        public override DbConnection GetConnection()
        {
            if (connection == null)
            {
                //string host = Util.GetConfig("host");
                //string user = Util.GetConfig("user");
                //string pass = Util.GetConfig("pass");
                //string db = Util.GetConfig("db");
                //string host = "DESKTOP-7D6QQ5C\\SQLEXPRESS";
                //string user = "sa";
                //string pass = "1122";
                //string db = "EComm3DB";
                //string connection_strng = "SERVER=" + host + ";DATABASE=" + db + ";UID=" + user + ";PASSWORD=" + pass + ";";
                string connection_strng = ConfigurationManager.AppSettings["ConnectionString"];
                //string connection_strng = "Data Source=DESKTOP-7D6QQ5C\\SQLEXPRESS;Initial Catalog=EComm3DB;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
                connection = new SqlConnection(connection_strng);
            }
            return connection;
        }

        //public override DbConnection GetConnection()
        //{
        //    if (connection == null)
        //    {
        //        string host = "DESKTOP-7D6QQ5C\\SQLEXPRESS";
        //        string user = "sa";
        //        string pass = "1122";
        //        string db = "EComm3DB";

        //        string connection_strng = "Data Source=" + host +
        //                                  ";Initial Catalog=" + db +
        //                                  ";User ID=" + user +
        //                                  ";Password=" + pass +
        //                                  ";TrustServerCertificate=True;";
        //        connection = new SqlConnection(connection_strng);
        //    }
        //    return connection;
        //}


        public override DbCommand CreateCommand(string query)
        {
            return new SqlCommand(query, GetConnection() as SqlConnection);
        }

        public override void BindParameters(DbCommand _cmd, params object[] parameters)
        {
            SqlCommand cmd = _cmd as SqlCommand;
            cmd.Parameters.Clear();
            cmd.Parameters.Clear();
            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue("@p" + (i+1), parameters[i]);
            }
        }

        //public override bool IsExist(string table, string column, object value)
        //{
        //    bool result = false;
        //    using (var cmd = CreateCommand("SELECT COUNT(*) FROM " + table + " WHERE " + column + " = ?"))
        //    {
        //        BindParameters(cmd, value);
        //        GetConnection().Open();
        //        result = int.Parse(cmd.ExecuteScalar().ToString()) > 0;
        //        GetConnection().Close();
        //    }
        //    return result;
        //}

        public override bool IsExist(string table, string column, object value)
        {
            bool result = false;
            using (var cmd = CreateCommand("SELECT COUNT(*) FROM " + table + " WHERE " + column + " = @p1"))
            {
                BindParameters(cmd, value);
                GetConnection().Open();
                result = int.Parse(cmd.ExecuteScalar().ToString()) > 0;
                GetConnection().Close();
            }
            return result;
        }


        //public override void ImportTables()
        //{
        //    using (var cmd = CreateCommand(Properties.Settings.Default.MySQLTables))
        //    {
        //        GetConnection().Open();
        //        cmd.ExecuteNonQuery();
        //        GetConnection().Close();
        //    }
        //}

        //public override void ImportTables()
        //{
        //    using (var connection = GetConnection())
        //    {
        //        connection.Open();
        //        using (var cmd = new SqlCommand("Select * FROM [users]", (SqlConnection)connection))
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    connection.Close();
        //}

        public override void ImportTables()
        {
            // Define your SQL Server connection string
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            // Example: A command to verify the connection
            string sqlCommands = @"
        -- Example command to verify connection
        SELECT 1 AS 'Connection Successful'
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlCommands, connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Connection Successful and tables are ready.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public override string FormatShortDate(DateTime day)
        {
            return day.ToString("yyyy-MM-dd");
        }

        public override string QUERY_SALES_BETWEEN_1{
            get{ return "SELECT * FROM SalesView WHERE day BETWEEN  CAST('@@from' AS DATE) AND CAST('@@to' AS DATE)"; }
        }

        public override string FormatDateTime(DateTime date)
        {
            return date.ToString("YYYY-MM-DD HH:MM:SS");
        }

        public override string QUERY_GET_TRANSACTIONS{
            get { return "SELECT * FROM [TransactionsView] WHERE DATE([date_created])=@p1"; }
        }

        public override string QUERY_GENERATE_TRANSACTION_ID {
            get { return "SELECT COUNT(*) FROM [transactions] WHERE DATE([date_created])=DATE(NOW())"; }
        }
    }
}
