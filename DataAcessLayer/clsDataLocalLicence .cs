using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class clsDataLocalLicence
    {
        public static float FeesOfLocalLicence()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = "select ApplicationFees from ApplicationTypes where  ApplicationTypeID=1;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            try
            {
                sqlConnection.Open();
                object result = sqlCommand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return result is float ? (float)result : Convert.ToSingle(result);
                }
                else
                {
                    return 0; // or handle as needed
                }
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
        public static bool CheckIfPersonHasActiveLocalLicenceApplicationInSameClass(int PersonID, int LicenseClassID)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = " select count(*) from Applications app inner join LocalDrivingLicenseApplications local on app.ApplicationID=local.ApplicationID \r\n  inner join People on PersonID=app.ApplicantPersonID where PersonID=@PersonID and LicenseClassID=@LicenseClassID And app.ApplicationStatus=1;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
            sqlCommand.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                sqlConnection.Open();
                int count = (int)sqlCommand.ExecuteScalar();
                return count > 0; // Returns true if the person has a local driving application
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
       
        public static int AddNewLocalDrivingApplicationDetails(int ApplicationID, int LicenseClassID)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) " +
                           "VALUES (@ApplicationID, @LicenseClassID); " +
                           "SELECT SCOPE_IDENTITY();";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            sqlCommand.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static DataTable GetDataOfLocalDriverLicencesApplications()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = @"
	SELECT 
  l.LocalDrivingLicenseApplicationID,
  lc.ClassName,
  P.NationalNo,
  P.FirstName + ' ' + P.SecondName + ' ' + ISNULL(P.ThirdName,' ')+ P.LastName AS FullName,
  app.ApplicationDate,
  COUNT(CASE WHEN te.TestResult = 1 THEN 1 END) AS PassedTests,
    CASE 
    WHEN app.ApplicationStatus = 1 THEN 'New'
    WHEN app.ApplicationStatus = 2 THEN 'Canceled'
    WHEN app.ApplicationStatus = 3 THEN 'Completed'
  END AS Status
FROM 
  LocalDrivingLicenseApplications l
  INNER JOIN LicenseClasses lc ON lc.LicenseClassID = l.LicenseClassID
  INNER JOIN Applications app ON app.ApplicationID = l.ApplicationID
  INNER JOIN People P ON P.PersonID = app.ApplicantPersonID
  left JOIN TestAppointments t ON t.LocalDrivingLicenseApplicationID = l.LocalDrivingLicenseApplicationID
  LEFT JOIN Tests te ON te.TestAppointmentID = t.TestAppointmentID
GROUP BY 
  l.LocalDrivingLicenseApplicationID,
  lc.ClassName,
  P.NationalNo,
  P.FirstName,
  P.SecondName,
  P.ThirdName,
  P.LastName,
  app.ApplicationDate,
  app.ApplicationStatus;
";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            DataTable dt = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);
                return dt;
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
        public static bool FindLocalLicencesDetails(int LocalDrivingLicenseApplicationID, ref int LicenseClassID, ref int AppID)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = @"  select LicenseClasses.LicenseClassID,app.ApplicationID from LocalDrivingLicenseApplications 
inner join Applications app on app.ApplicationID=LocalDrivingLicenseApplications.ApplicationID 
  inner join LicenseClasses on LicenseClasses.LicenseClassID=LocalDrivingLicenseApplications.LicenseClassID
  where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    AppID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    return true;
                }
                else
                {
                    return false; // No data found
                }
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
        public static bool FindLocalLicencesDetailsByApplicationID(int ApplicationID, ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = @"SELECT LocalDrivingLicenseApplicationID, LicenseClassID 
                             FROM LocalDrivingLicenseApplications 
                             WHERE ApplicationID = @ApplicationID";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    return true;
                }
                else
                {
                    return false; // No data found
                }
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
        public static bool UpdateLocalLicences(int DLapp,int LiceneceClass)
        {
            string query = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
   SET 
   LicenseClassID = @LicenseClassID
 WHERE LocalDrivingLicenseApplicationID=@DLapp";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@LicenseClassID", LiceneceClass);
            sqlCommand.Parameters.AddWithValue("@DLapp", DLapp);
            try
            {
                sqlConnection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                return rowsAffected > 0; // Returns true if the update was successful
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
        public static bool CancelApplicationStatusByLocalappID(int localID)
        {
            string query = @"
        UPDATE Applications
        SET ApplicationStatus = 2
        WHERE ApplicationID = (
            SELECT ApplicationID
            FROM LocalDrivingLicenseApplications
            WHERE LocalDrivingLicenseApplicationID = @LocalID
        )";

            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            {
                sqlCommand.Parameters.AddWithValue("@LocalID", localID);

                sqlConnection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public static bool DeleteLocalDrivingApplication(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                sqlConnection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                return rowsAffected > 0; // Returns true if the deletion was successful
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
        public static DataTable GetLicenseClassAndTests(int localAppID)
        {
            string query = @"
        SELECT ClassName, PassedTestCount
        FROM LocalDrivingLicenseApplications_View
        WHERE LocalDrivingLicenseApplicationID = @ID";

            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", localAppID);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static DataTable GetLocalLicencesByID(int personID)
        {
            string query = @"select LicenseID,ApplicationID,IssueDate,ExpirationDate,IsActive from Licenses inner join Drivers d on d.DriverID=Licenses.DriverID 
                                 where d.PersonID=@PersonID";
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", personID);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


    }
}
