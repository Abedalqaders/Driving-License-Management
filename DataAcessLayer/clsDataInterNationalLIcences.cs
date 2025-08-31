using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAcessLayer
{
    public class clsDataInterNationalLIcences
    {
        public static DataTable GetInterNationalLicecesForPerson(int personID)
        {
            string query = @"select InternationalLicenseID,ApplicationID,IssueDate,ExpirationDate,IsActive from InternationalLicenses  inner join Drivers d on d.DriverID=InternationalLicenses.DriverID 
                                 where d.PersonID=@PersonID";
            using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@PersonID", personID);
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return dt;
            }
        }
        public static bool IsThereActiveInterNationalLicences(int LicencesID)
        {
            string query = @"select count(*) from InternationalLicenses where IssuedUsingLocalLicenseID=@LicencesID and IsActive=1;";
            using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@LicencesID", LicencesID);
                try
                {
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public static int AddNewInternationalLicense(
      int driverID,
      int applicationID,
      int issuedUsingLocalLicenseID,
      DateTime issueDate,
      DateTime expirationDate,
      bool isActive,
      int createdByUserID)
        {
            string query = @"
        INSERT INTO InternationalLicenses 
        (DriverID, ApplicationID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
        VALUES 
        (@DriverID, @ApplicationID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
        SELECT SCOPE_IDENTITY();";

            using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
                cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                try
                {
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()); // returns new InternationalLicenseID
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while adding international license: " + ex.Message, ex);
                }
            }
        }
        public static bool FindInternationalLicense(
    int internationalLicenseID,
    ref int driverID,
    ref int applicationID,
    ref int issuedUsingLocalLicenseID,
    ref DateTime issueDate,
    ref DateTime expirationDate,
    ref bool isActive,
    ref int createdByUserID)
        {
            string query = @"
        SELECT 
            DriverID,
            ApplicationID,
            IssuedUsingLocalLicenseID,
            IssueDate,
            ExpirationDate,
            IsActive,
            CreatedByUserID
        FROM InternationalLicenses
        WHERE InternationalLicenseID = @InternationalLicenseID";

            using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            driverID = Convert.ToInt32(reader["DriverID"]);
                            applicationID = Convert.ToInt32(reader["ApplicationID"]);
                            issuedUsingLocalLicenseID = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);
                            issueDate = Convert.ToDateTime(reader["IssueDate"]);
                            expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                            isActive = Convert.ToBoolean(reader["IsActive"]);
                            createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            return true;
                        }
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error while finding international license: " + ex.Message, ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("Unexpected error: " + ex.Message, ex);
                }
            }
        }
        public static DataTable GetAllInternationalLicenses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString._connectionString);

            string query = @"
            SELECT    InternationalLicenseID, ApplicationID,DriverID,
		                IssuedUsingLocalLicenseID , IssueDate, 
                        ExpirationDate, IsActive
		    from InternationalLicenses 
                order by IsActive, ExpirationDate desc";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

    }
}
