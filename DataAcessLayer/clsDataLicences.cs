using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using System.ComponentModel;
namespace DataAcessLayer
{
    public class clsDataLicences
    {
        public static int AddNewLocalLicences(int ApplicationID,int driverID,int LicenseClass,DateTime IssueDate,DateTime ExpirationDate,string Notes,decimal PaidFees,byte IsActive,byte IssueReason,int CreatedByUserID)
        {
            string query = @"insert into Licenses(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
  values(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID)
SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        cmd.Parameters.AddWithValue("@DriverID", driverID);
                        cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                        cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                        cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        cmd.Parameters.AddWithValue("@Notes", Notes);
                        cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                        cmd.Parameters.AddWithValue("@IsActive", IsActive);
                        cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
                        cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        con.Open();
                       return Convert.ToInt32(cmd.ExecuteScalar());
                       
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while adding new local licence: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message, ex);
            }
        }
        public static bool GetLicencesByApplicationID(
     int applicationID,
     ref int LicenceID,
     ref int driverID,
     ref int licenseClass,
     ref DateTime issueDate,
     ref DateTime expirationDate,
     ref string notes,
     ref decimal paidFees,
     ref byte isActive,
     ref byte issueReason,
     ref int createdByUserID)
        {
            string query = @"
        SELECT 
            LicenseID,
            DriverID,
            LicenseClass,
            IssueDate,
            ExpirationDate,
            Notes,
            PaidFees,
            IsActive,
            IssueReason,
            CreatedByUserID
        FROM Licenses
        WHERE ApplicationID = @ApplicationID";

            using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

              
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LicenceID = Convert.ToInt32(reader["LicenseID"]);
                            driverID = Convert.ToInt32(reader["DriverID"]);
                            licenseClass = Convert.ToInt32(reader["LicenseClass"]);
                            issueDate = Convert.ToDateTime(reader["IssueDate"]);
                            expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                            notes = reader["Notes"]?.ToString() ?? string.Empty;
                            paidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToDecimal(reader["PaidFees"]) : 0m;
                            isActive = reader["IsActive"] != DBNull.Value ? Convert.ToByte(reader["IsActive"]) : (byte)0;
                            issueReason = reader["IssueReason"] != DBNull.Value ? Convert.ToByte(reader["IssueReason"]) : (byte)0;
                            createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                
             
            }
        }


        public static bool GetLicencesByLicenceID(

         int LicenseID, 
     ref int applicationID,
     ref int driverID,
     ref int licenseClass,
     ref DateTime issueDate,
     ref DateTime expirationDate,
     ref string notes,
     ref decimal paidFees,
     ref byte isActive,
     ref byte issueReason,
     ref int createdByUserID)
        {
            string query = @"
        SELECT 
            LicenseID,
            ApplicationID,
            DriverID,
            LicenseClass,
            IssueDate,
            ExpirationDate,
            Notes,
            PaidFees,
            IsActive,
            IssueReason,
            CreatedByUserID
        FROM Licenses
        WHERE LicenseID = @LicenseID";

            using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);


                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        applicationID = Convert.ToInt32(reader["ApplicationID"]);
                        driverID = Convert.ToInt32(reader["DriverID"]);
                        licenseClass = Convert.ToInt32(reader["LicenseClass"]);
                        issueDate = Convert.ToDateTime(reader["IssueDate"]);
                        expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                        notes = reader["Notes"]?.ToString() ?? string.Empty;
                        paidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToDecimal(reader["PaidFees"]) : 0m;
                        isActive = reader["IsActive"] != DBNull.Value ? Convert.ToByte(reader["IsActive"]) : (byte)0;
                        issueReason = reader["IssueReason"] != DBNull.Value ? Convert.ToByte(reader["IssueReason"]) : (byte)0;
                        createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
        }
        public static bool CheckIfPersonHasActiveLocalLicenceInSameClass(int personID,int LicenceClass)
        {
            string query = "  select count(*) from Licenses inner join Drivers d on d.DriverID=Licenses.DriverID inner join People p on p.PersonID=d.PersonID where d.PersonID=@personID and LicenseClass=@LicenceClass;";
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                {
                    SqlCommand comand = new SqlCommand(query, con);
                    comand.Parameters.AddWithValue("@personID", personID);
                    comand.Parameters.AddWithValue("@LicenceClass", LicenceClass);
                    con.Open();
                    return Convert.ToInt32(comand.ExecuteScalar()) > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message, ex);
            }
           
        }
       public static bool IsTheDateIsVaild(int  LicenceID)
        {
            string query = @"SELECT * FROM Licenses WHERE ExpirationDate >= GETDATE() and LicenseID=@LicenseID";
            using (SqlConnection connection = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection)) {
                cmd.Parameters.AddWithValue("@LicenseID", LicenceID);
                connection.Open();
                return Convert.ToInt32(cmd.ExecuteScalar())>0;

                    }
           
        }
        public static bool DisActiveLocalLicences(int LicenceID)
        {
            string query = @"update Licenses set IsActive=0 where LicenseID=@LicenseID";
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@LicenseID", LicenceID);
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while disactivating the licence: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message, ex);
            }
        }

        public static bool ActiveLocalLicences(int LicenceID)
        {
            string query = @"update Licenses set IsActive=1 where LicenseID=@LicenseID";
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@LicenseID", LicenceID);
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while disactivating the licence: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message, ex);
            }
        }

    }
}
