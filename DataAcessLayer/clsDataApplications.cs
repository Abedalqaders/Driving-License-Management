using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class clsDataApplications
    {
        public static bool GetApplicationDataDetails(int applicationID, ref int applicantPersonID, ref DateTime applicationDate, ref int applicationTypeID, ref byte applicationStatus, ref DateTime lastStatusDate, ref float paidFees, ref int createdByUserID)
        {
     SqlConnection sqlConnection=new SqlConnection(ConnectionString._connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID FROM Applications WHERE ApplicationID = @ApplicationID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ApplicationID", applicationID);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    applicantPersonID = reader.GetInt32(0);
                    applicationDate = reader.GetDateTime(1);
                    applicationTypeID = reader.GetInt32(2);
                    applicationStatus = reader.GetByte(3);
                    lastStatusDate = reader.GetDateTime(4);
                    paidFees = (float)reader.GetDecimal(5);
                    createdByUserID = reader.GetInt32(6);
                    return true;
                }
                else
                {
                    applicationStatus = 0; // Default value if no record found
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine("Error: " + ex.Message);
                applicationStatus = 0; // Default value in case of error
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
       
        }
        public static int AddNewApplication(int PersonID, int ApplicationType, DateTime ApplicationDate, DateTime LastStatusDate, float PaidFees, string CreatedByUserID)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = "INSERT INTO Applications (ApplicantPersonID,  ApplicationDate, ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID) " +
                           "VALUES (@ApplicantPersonID, @ApplicationDate,@ApplicationTypeID, @ApplicationStatus, @LastStatusDate,@PaidFees, @CreatedByUserID); " +
                           "SELECT SCOPE_IDENTITY();"; // Assuming ApplicationTypeID for local driving is 1
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            sqlCommand.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            sqlCommand.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            sqlCommand.Parameters.AddWithValue("PaidFees", PaidFees);
            sqlCommand.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            sqlCommand.Parameters.AddWithValue("@ApplicationTypeID", ApplicationType); // Assuming ApplicationTypeID for local driving is 1
            sqlCommand.Parameters.AddWithValue("@ApplicationStatus", 1); // Default status is New
            try
            {
                sqlConnection.Open();
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public static bool UpdateApplication(int applicationID, int applicantPersonID, DateTime applicationDate,
    int applicationTypeID, byte applicationStatus, DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            bool isUpdated = false;

            string query = @"
        UPDATE Applications
        SET 
            ApplicantPersonID = @ApplicantPersonID,
            ApplicationDate = @ApplicationDate,
            ApplicationTypeID = @ApplicationTypeID,
            ApplicationStatus = @ApplicationStatus,
            LastStatusDate = @LastStatusDate,
            PaidFees = @PaidFees,
            CreatedByUserID = @CreatedByUserID
        WHERE ApplicationID = @ApplicationID";

            using (SqlConnection connection = new SqlConnection(ConnectionString._connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isUpdated = (rowsAffected > 0);
                }
            }

            return isUpdated;
        }
    }
}
