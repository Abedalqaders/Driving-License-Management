using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
namespace DataAcessLayer
{
    public class clsDataUsers
    {
        public static int AddNewUser(int PersonID,string UserName,string Password,bool IsActive)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = $"INSERT INTO Users (PersonID,UserName,Password,IsActive) VALUES (@PersonID,@UserName,@Password,@IsActive)" +
                "SELECT SCOPE_IDENTITY();";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                
                sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
                sqlCommand.Parameters.AddWithValue("@UserName", UserName);
                sqlCommand.Parameters.AddWithValue("@Password", Password);
                sqlCommand.Parameters.AddWithValue("@IsActive", IsActive);
                object result = sqlCommand.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1; // Return the new UserID or -1 if insertion failed
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while adding a new user.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            
        }
        public static bool UpdateUser(int UserID,string UserName, string Password, bool IsActive)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "UPDATE Users SET UserName=@UserName, Password=@Password, IsActive=@IsActive WHERE UserID=@UserID";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                sqlCommand.Parameters.AddWithValue("@UserName", UserName);
                sqlCommand.Parameters.AddWithValue("@Password", Password);
                sqlCommand.Parameters.AddWithValue("@IsActive", IsActive);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                return rowsAffected > 0; // Return true if the update was successful
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while updating user data.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;
        }
        public static bool DeleteUser(int UserID)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "DELETE FROM Users WHERE UserID=@UserID";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                return rowsAffected > 0; // Return true if the deletion was successful
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while deleting user data.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public static  bool FindUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT PersonID,UserName,Password,IsActive FROM Users WHERE UserID=@UserID";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    UserName = reader["UserName"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while retrieving user data.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;
        }
        public static DataTable GetAllUsers()
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT UserID,PersonID,UserName,IsActive FROM Users";
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while retrieving user data.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return dt;
        }
        public static void GetDataUser(int UserId, ref string UserName, ref int personId, ref string Password, ref bool IsActive)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT UserName,PersonID,Password,IsActive FROM Users WHERE UserID=@UserId";

            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserID", UserId);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UserName = reader["UserName"].ToString();
                    personId = Convert.ToInt32(reader["PersonID"]);
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while retrieving user data.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        public static int CheckUserNameAndPassword(string UserName,string Password)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT UserID FROM Users WHERE UserName=@UserName AND Password=@Password";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserName", UserName);
                sqlCommand.Parameters.AddWithValue("@Password", Password);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    // User exists, you can return the UserID or any other information if needed
                    while (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["UserID"]);   
                        return userId;
                        // Do something with userId if needed
                    }
                }
             
             
            }
           
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                 
                }
            }
            return -1;
        }
        public static string GetPasswordOfUser(int UserID)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT Password FROM Users WHERE UserID=@UserId";
            string password = string.Empty;
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    password = reader["Password"].ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while retrieving the username.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return password;
        }
        public static bool IsAcitve(int userID)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT IsActive FROM Users WHERE UserID=@UserID";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserID", userID);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if(reader.Read())
                {
                    return Convert.ToBoolean(reader["IsActive"]);
                }
            }
            catch(Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while checking user activity status.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;
        }
        public static string GetUserNameByID(int UserId)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT UserName FROM Users WHERE UserID=@UserId";
            string userName = string.Empty;
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserID", UserId);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    userName = reader["UserName"].ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while retrieving the username.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return userName;
        }
        public static int GetPersonIDfromUser(int UserID)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT PersonID FROM Users WHERE UserID=@UserID";
            int personId = -1;
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    personId = Convert.ToInt32(reader["PersonID"]);
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while retrieving the person ID.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return personId;
        }
        public static bool ChangePasswordforUser(int userID, string password)
        {
            SqlConnection con= new SqlConnection(ConnectionString._connectionString);
            string query = $"UPDATE Users " +
                $" SET      Password=@Password " +
                $"WHERE UserID=@UserID";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@Password",password);
                sqlCommand.Parameters.AddWithValue("@UserID",userID);
                int row = sqlCommand.ExecuteNonQuery();
                return row > 0;

            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while changing the password.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;
        }
        public static bool IsUserExistsForPerson(int PersonID)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE PersonID=@PersonID";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
                int count = (int)sqlCommand.ExecuteScalar();
                return count > 0; // Return true if a user exists for the given person ID
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("An error occurred while checking if a user exists for the person.", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
