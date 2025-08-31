using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class clsDataLiceenseClass
    {
        public static bool GetLiceenseClassByID(int LiceenseClassID,ref string ClassName,ref string ClassDescription,ref int MinimumAllowedAge,ref int DefaultValidityLength,ref decimal ClassFees)
        {
            string query= @"select * from LicenseClasses where LicenseClassID=@LicenseClassID";
            using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@LicenseClassID", LiceenseClassID);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        ClassName = reader["ClassName"].ToString();
                        ClassDescription = reader["ClassDescription"].ToString();
                        MinimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]);
                        DefaultValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);
                        ClassFees = Convert.ToDecimal(reader["ClassFees"]);
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
            }
        }
        public static DataTable GetLiceenseClass()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT LicenseClassID, ClassName, ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees FROM LicenseClasses";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }
    }
}
