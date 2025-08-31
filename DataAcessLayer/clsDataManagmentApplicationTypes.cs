using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAcessLayer
{
    public class clsDataManagmentApplicationTypes
    {

        public static DataTable GetApplicationTypes()
        {
           SqlConnection con=new SqlConnection(ConnectionString._connectionString);
            string query= "SELECT ApplicationTypeID,ApplicationTypeTitle,ApplicationFees FROM ApplicationTypes";
            SqlCommand cmd = new SqlCommand(query, con);
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
        
            public static DataTable GetApplicationTypesFromDB()
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString._connectionString))
                {
                    string query = "SELECT ApplicationTypeID, ApplicationTypeTitle FROM ApplicationTypes";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
       
        public static bool UpdateApplicationType(int ApplicationTypeID,string ApplicationTypeTitle,float ApplicationFees)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "UPDATE ApplicationTypes SET ApplicationTypeTitle=@ApplicationTypeTitle,ApplicationFees=@ApplicationFees WHERE ApplicationTypeID=@ApplicationTypeID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
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
        public static bool  FindApplicationType(int ApplicationTypeID,ref string ApplicationTypeTitle,ref float ApplicationFees)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT ApplicationTypeTitle,ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID=@ApplicationTypeID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationTypeTitle = reader["ApplicationTypeTitle"].ToString();
                    ApplicationFees = Convert.ToSingle(reader["ApplicationFees"]);
                    return true;
                }
                else
                {
                    return false;
                }
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
        public static int NumberOfApplicationTypes()
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT COUNT(*) FROM ApplicationTypes";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
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
}
