using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class clsDataManagmentTestTypes
    {
        public static DataTable GetTestTypes()
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees FROM TestTypes";
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
        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "UPDATE TestTypes SET TestTypeTitle=@TestTypeTitle,TestTypeDescription=@TestTypeDescription,TestTypeFees=@TestTypeFees WHERE TestTypeID=@TestTypeID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle); 
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
           
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
        public static bool FindTestType(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref float TestTypeFees)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT TestTypeTitle,TestTypeDescription,TestTypeFees FROM TestTypes WHERE TestTypeID=@TestTypeID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TestTypeTitle = reader["TestTypeTitle"].ToString();
                    TestTypeDescription = reader["TestTypeDescription"].ToString();
                    TestTypeFees = Convert.ToSingle(reader["TestTypeFees"]);
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
       
    }
}
