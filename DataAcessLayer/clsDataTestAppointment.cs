using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAcessLayer
{
    public class clsDataTestAppointment
    {
        public static DataTable GetAllTestAppoitmentofTest(int TestType, int DLappID)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString._connectionString);
            string query = "select t.TestAppointmentID,t.AppointmentDate,t.PaidFees,t.IsLocked from TestAppointments t where t.TestTypeID = @TestType and t.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestType", TestType);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", DLappID);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return
                    dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetAllTestAppoitmentofTest: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public static int InsertAppointment(int testTypeID, int localAppID, DateTime date, decimal fees,
         int userID, bool isLocked, int? retakeID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(@"INSERT INTO TestAppointments 
            (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
            VALUES (@TestTypeID, @LocalAppID, @Date, @Fees, @UserID, @Locked, @RetakeID);
            SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@TestTypeID", testTypeID);
                cmd.Parameters.AddWithValue("@LocalAppID", localAppID);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Fees", fees);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@Locked", isLocked);
                cmd.Parameters.AddWithValue("@RetakeID", (object)retakeID ?? DBNull.Value);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static bool UpdateAppointment(int id, DateTime date, decimal fees, bool isLocked)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(@"UPDATE TestAppointments SET 
            AppointmentDate = @Date, PaidFees = @Fees, IsLocked = @Locked WHERE TestAppointmentID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Fees", fees);
                cmd.Parameters.AddWithValue("@Locked", isLocked);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool GetAppointmentDetails(int id, ref int testTypeID, ref int localAppID, ref DateTime date,
            ref decimal fees, ref int userID, ref bool isLocked, ref int? retakeID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM TestAppointments WHERE TestAppointmentID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        testTypeID = (int)reader["TestTypeID"];
                        localAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                        date = (DateTime)reader["AppointmentDate"];
                        fees = (decimal)reader["PaidFees"];
                        userID = (int)reader["CreatedByUserID"];
                        isLocked = (bool)reader["IsLocked"];
                        retakeID = reader["RetakeTestApplicationID"] == DBNull.Value ? null : (int?)reader["RetakeTestApplicationID"];
                        return true;
                    }
                    return false;
                }
            }
        }
        public static bool GetAppointmentDetailsByDLID(int localAppID, int testTypeID, ref int TestAppoitmentID, ref DateTime date,
         ref decimal fees, ref int userID, ref bool isLocked, ref int? retakeID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID =@localAppID and TestTypeID=@testTypeID", conn))
            {
                cmd.Parameters.AddWithValue("@localAppID", localAppID);
                cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        TestAppoitmentID = (int)reader["TestAppointmentID"];
                        date = (DateTime)reader["AppointmentDate"];
                        fees = (decimal)reader["PaidFees"];
                        userID = (int)reader["CreatedByUserID"];
                        isLocked = (bool)reader["IsLocked"];
                        retakeID = reader["RetakeTestApplicationID"] == DBNull.Value ? null : (int?)reader["RetakeTestApplicationID"];
                        return true;
                    }
                    return false;
                }
            }
        }
        public static bool DeleteAppointment(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM TestAppointments WHERE TestAppointmentID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static bool IsThereActiveAppoitment(int TestType, int DLAppId)
        {

            string query = @"  select count(*) from TestAppointments where TestTypeID=@TestType and LocalDrivingLicenseApplicationID=@DLAppId and IsLocked=0;";


            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TestType", TestType);
                        cmd.Parameters.AddWithValue("@DLAppId", DLAppId);
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error " + ex.Message);
                return false;
            }
          
        }
        public static bool IamPassedTest(int TestType, int DLAppId)
        {
            string query = @"select count(*) from Tests t inner join TestAppointments ta on t.TestAppointmentID=ta.TestAppointmentID where ta.TestTypeID=@TestType and ta.LocalDrivingLicenseApplicationID=@DLAppId and t.TestResult=1;";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestType", TestType);
                    cmd.Parameters.AddWithValue("@DLAppId", DLAppId);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in IamPassedTest: " + ex.Message);
            }
        }
        public static int CountOfTrail(int DLAppID, int TestType)
        {
            string query = @"select  count(*) from TestAppointments t where t.LocalDrivingLicenseApplicationID=@DLAppID and t.TestTypeID=@TestType";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DLAppID", DLAppID);
                    cmd.Parameters.AddWithValue("@TestType", TestType);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in CountOfTrail: " + ex.Message);
            }

        }
        public static bool LockTestAppointment(int TestAppoitmentID)
        {
            string query = @"UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @TestAppoitmentID";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestAppoitmentID", TestAppoitmentID);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in LockTestAppointment: " + ex.Message);
            }
        }
    }
}

