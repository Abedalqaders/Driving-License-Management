using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class clsDataCountries
    {
        public static DataTable GetAllCountry()
        {
            SqlConnection connection = new SqlConnection(ConnectionString._connectionString);
            SqlCommand command = new SqlCommand("SELECT CountryID,CountryName FROM Countries", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public static string GetCountryByID(int countryID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString._connectionString);
            SqlCommand command = new SqlCommand("SELECT CountryName FROM Countries WHERE CountryID = @CountryID", connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@CountryID", countryID);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return string.Empty; // or handle as needed
                }
            }
            catch(Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine("Error: " + ex.Message);
                return string.Empty; // or handle as needed
            }
            finally
            {
                connection.Close();
            }
        }
        
    }
}
