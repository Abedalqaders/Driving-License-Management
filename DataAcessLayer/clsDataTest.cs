using DataAcessLayer;
using System;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsDataTest
    {
        public static int InsertTest(int appointmentTestId, byte testResult, string note, int createdByUserId)
        {
            string query = @"
                INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)";

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TestAppointmentID", appointmentTestId);
                    cmd.Parameters.AddWithValue("@TestResult", testResult);
                    cmd.Parameters.AddWithValue("@Notes", note ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);

                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("SQL Error inserting test data: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("General error inserting test data: " + ex.Message, ex);
            }
        }
    }
}
