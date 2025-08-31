using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class clsDataDrivers
    {
        public static DataTable GetDrivers()
        {
            string query = @"  select DriverID,Drivers.PersonID,(FirstName+' '+SecondName+' '+ThirdName+' '+LastName)FullName,(select  count(*) from Licenses where Drivers.DriverID=Licenses.DriverID) 'Active Licences' from Drivers inner join People on People.PersonID=Drivers.PersonID ";
            try
            {
                using(SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("Error while fetching drivers data: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message, ex);
            }          
        }
        public static int AddNewDriver(int personid,int CreatedByUser,DateTime CreatedDate)
        {
            string query = @"INSERT INTO Drivers (PersonID,CreatedByUserID,CreatedDate) 
                             VALUES (@PersonID,@CreatedByUser,@CreatedDate);
                             SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", personid);
                        cmd.Parameters.AddWithValue("@CreatedByUser", CreatedByUser);
                        cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                        con.Open();
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while adding new driver: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message, ex);
            }
        }
        public static int GetDriverIDByPersonID(int personID)
        {
            string query = "SELECT DriverID FROM Drivers WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", personID);
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while fetching driver ID: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message, ex);
            }
        }
        public static bool Find(int driverID, ref int personID, ref DateTime createdDate, ref int createdByUser)
        {
            string query = @"SELECT PersonID, CreatedDate, CreatedByUserID 
                     FROM Drivers 
                     WHERE DriverID = @DriverID";

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DriverID", driverID);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personID = Convert.ToInt32(reader["PersonID"]);
                            createdDate = Convert.ToDateTime(reader["CreatedDate"]);
                            createdByUser = Convert.ToInt32(reader["CreatedByUserID"]);
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while finding driver: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message, ex);
            }
        }
    }
}
