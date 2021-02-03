using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Phonebook.DataAccessLayer
{
    public class DataReader
    {
        private SqlConnection Connection;

        private SqlCommand Command;

        private readonly string _connStr = @"Data Source = JHAY\MSSQLSERVER01;Initial Catalog = Phonebook; Integrated Security = True";

        public DataReader()
        {
            Command = new SqlCommand();
            Connection = new SqlConnection(_connStr);
        }

        public async Task<bool> WriteToDatabase(string cmdtxt)
        {
            try
            {
                using (Connection)
                {
                    if (Connection == null)
                    {
                        throw new Exception("Failed to connect!");
                    }
                    Command.CommandText = cmdtxt;
                    Command.Connection = Connection;
                    Connection.Open(); ///opens up the connection to perform the insertion
                    try
                    {
                        await Command.ExecuteNonQueryAsync();
                        return true;
                    }
                    catch (InvalidCastException)
                    {
                        throw new InvalidCastException("Type cast error!");
                    }
                    catch (TimeoutException)
                    {
                        throw new TimeoutException("Process took too long!");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ReadFromDatabase(string cmdtxt)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            try
            {
                using (Connection)
                {
                    if (Connection == null)
                    {
                        throw new Exception("Failed to connect!");
                    }
                    Command.CommandText = cmdtxt;
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.Text;
                    Connection.Open(); ///opens up the connection to perform the insertion
                    try
                    {
                        dataAdapter.SelectCommand = Command;
                        dataAdapter.Fill(dt);
                    }
                    catch (TimeoutException)
                    {
                        throw new TimeoutException("Process took too long!");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public async Task<bool> UpdateDatabase(string cmdtxt)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            try
            {
                using (Connection)
                {
                    if (Connection == null)
                    {
                        throw new Exception("Failed to connect!");
                    }
                    Command.CommandText = cmdtxt;
                    Command.Connection = Connection;
                    Connection.Open();
                    try
                    {
                        dataAdapter.InsertCommand = Command;
                        await dataAdapter.InsertCommand.ExecuteNonQueryAsync();
                        return true;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteFromDatabaseAsync(string cmdtxt)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            try
            {
                using (Connection)
                {
                    if (Connection == null)
                    {
                        throw new Exception("Failed to connect!");
                    }
                    Command.CommandText = cmdtxt;
                    Command.Connection = Connection;
                    Connection.Open();
                    try
                    {
                        dataAdapter.DeleteCommand = Command;
                        await dataAdapter.DeleteCommand.ExecuteNonQueryAsync();
                        return true;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
