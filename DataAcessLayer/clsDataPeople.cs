using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class clsDataPeople
    {
        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, bool Gendor, DateTime DateOfBirth, int NationalityCountryID, string Phone, string Email,string ImagePath,string Address)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth, NationalityCountryID, Phone, Email,ImagePath,Address) " +
                 "VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @Gendor, @DateOfBirth, @NationalityCountryID, @Phone, @Email,@ImagePath,@Address); " +
                 "SELECT SCOPE_IDENTITY();";

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@SecondName", SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Gendor", Gendor);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                    cmd.Parameters.AddWithValue("@Address",Address);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int newPersonId))
                    return newPersonId;
                else
                    return -1;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, bool Gendor, DateTime DateOfBirth, int NationalityCountryID, string Phone, string Email,string ImagePath,string Address)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "UPDATE People SET NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, " +
                "ThirdName = @ThirdName, LastName = @LastName, Gendor = @Gendor, DateOfBirth = @DateOfBirth, " +
                "NationalityCountryID = @NationalityCountryID, Phone = @Phone, Email = @Email,ImagePath=@ImagePath,Address=@Address WHERE PersonID = @PersonID";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@SecondName", SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Gendor", Gendor);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                cmd.Parameters.AddWithValue("@Address", Address);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
           
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public static bool DeletePerson(int PersonID)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "DELETE FROM People WHERE PersonID = @PersonID";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
           
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public static bool FindPersonByID(int personID ,ref string NationalNo,ref string FirstName,ref string SecondName,ref string ThirdName,ref string LastName,ref bool Gendor,ref DateTime DateOfBirth,ref int NationalityCountryID,ref string Phone,ref string Email, ref string ImagePath,ref string Address)
        {
            SqlConnection con=new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth, NationalityCountryID, Phone, Email, ImagePath,Address FROM People WHERE PersonID = @PersonID";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PersonID", personID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NationalNo = reader["NationalNo"].ToString();
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName = reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();
                    Gendor = Convert.ToBoolean(reader["Gendor"]);
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    Phone = reader["Phone"].ToString();
                    Email = reader["Email"].ToString();
                    ImagePath = reader["ImagePath"].ToString();
                    Address = reader["Address"].ToString();
                    return true;
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return false;
        }
        public static DataTable GetALLPeople()
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = $"SELECT PersonID,NationalNo,FirstName,SecondName,ThirdName,LastName, CASE Gendor\r\n                 WHEN 0 THEN 'Male'  \r\n                WHEN 1 THEN 'Female'  \r\n                ELSE 'Unknown' END AS Gender,\r\n\t\t\t\tDateOfBirth,CountryName,Phone,Email,ImagePath,Address from People \r\n                inner join Countries on Countries.CountryID=People.NationalityCountryID";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }
        public static int GetNumberOfPeople()
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT COUNT(*) FROM People";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public static DataTable GetPeoplebyNationalNo(string nationalNo)
        {
            string query = @"
        SELECT 
            PersonID,
            NationalNo,
            FirstName,
            SecondName,
            ThirdName,
            LastName,
            CASE Gendor
                WHEN 0 THEN 'Male'
                WHEN 1 THEN 'Female'
                ELSE 'Unknown'
            END AS Gender,
            DateOfBirth,
            CountryName,
            Phone,
            Email,
            Address,
            ImagePath
        FROM People
        INNER JOIN Countries ON Countries.CountryID = People.NationalityCountryID
        WHERE NationalNo LIKE @NationalNo";

            using (SqlConnection con = new SqlConnection(ConnectionString._connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@NationalNo", "%" + nationalNo + "%");

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();

                    try
                    {
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        // Optional: log the exception or rethrow
                        return null;
                    }
                }
            }
        }

        public static bool NatonalNoIsExist(string NatonalNo)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = "SELECT COUNT(*) FROM People WHERE NationalNo = @NationalNo";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NationalNo", NatonalNo);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public static DataTable GetPeoplebyPersonID(int PersonID)
        {
            SqlConnection con = new SqlConnection(ConnectionString._connectionString);
            string query = $"SELECT PersonID,NationalNo,FirstName,SecondName,ThirdName,LastName, CASE Gendor\r\n                 WHEN 0 THEN 'Male'  \r\n                WHEN 1 THEN 'Female'  \r\n                ELSE 'Unknown' END AS Gender,\r\n\t\t\t\tDateOfBirth,CountryName,Phone,Email,Address from People \r\n                inner join Countries on Countries.CountryID=People.NationalityCountryID" +
             $" where PersonID=@PersonID";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public static DataTable GetPeoplebyGendor(string Gendor)
        {
            SqlConnection connection = new SqlConnection(ConnectionString._connectionString);
            string query = $"SELECT PersonID,NationalNo,FirstName,SecondName,ThirdName,LastName, CASE Gendor\r\n                 WHEN 0 THEN 'Male'  \r\n                WHEN 1 THEN 'Female'  \r\n                ELSE 'Unknown' END AS Gender,\r\n\t\t\t\tDateOfBirth,CountryName,Phone,Email,Address from People \r\n                inner join Countries on Countries.CountryID=People.NationalityCountryID" +
            $" where Gendor=@Gendor";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Gendor", Gendor);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        public static DataTable GetPeoplebyName(string FullName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString._connectionString);
            string query = @"
SELECT 
    PersonID,
    NationalNo,
    FirstName,
    SecondName,
    ThirdName,
    LastName,
    CASE Gendor       
        WHEN 0 THEN 'Male' 
        WHEN 1 THEN 'Female'  
        ELSE 'Unknown' 
    END AS Gender,
    DateOfBirth,
    CountryName,
    Phone,
    Email,Address
FROM 
    People
INNER JOIN 
    Countries ON Countries.CountryID = People.NationalityCountryID
WHERE 
    ISNULL(FirstName, '') + ' ' + ISNULL(SecondName, '') + ' ' + ISNULL(ThirdName, '') + ' ' + ISNULL(LastName, '') 
    LIKE @SearchText;
";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SearchText", "%" + FullName + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }
        

    }
}
