using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAcessLayer
{
    public class clsDataDetainedLicense
    {
        public static int AddNewDetained(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, byte IsReleased)
        {
            string query = "insert into DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased) values (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased); " +
                "SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                    cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
                    cmd.Parameters.AddWithValue("@FineFees", FineFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
                    conn.Open();
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    return newId;
                }
            }
        }
        public static bool IsLicenseDetained(int licenseId)
        {
            string query = "select count(*) from DetainedLicenses where LicenseID=@licenseId and IsReleased=0;";
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@licenseId", licenseId);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool UpdateDetainedLicense(int DetainedID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, byte IsReleased, DateTime relaseDate, int RelasedByUserID, int ReleaseApplicationID)
        {
            string query = "update DetainedLicenses set LicenseID=@LicenseID,DetainDate=@DetainDate,FineFees=@FineFees,CreatedByUserID=@CreatedByUserID,IsReleased=@IsReleased,ReleaseDate=@ReleaseDate,ReleasedByUserID=@ReleasedByUserID,ReleaseApplicationID=@ReleaseApplicationID where DetainID=@DetainedID;";
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DetainedID", DetainedID);
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                    cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
                    cmd.Parameters.AddWithValue("@FineFees", FineFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
                    if (IsReleased == 1)
                    {
                        cmd.Parameters.AddWithValue("@ReleaseDate", relaseDate);
                        cmd.Parameters.AddWithValue("@ReleasedByUserID", RelasedByUserID);
                        cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                        cmd.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
                    }
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static bool FindDetainedByDetainedID(int DetainedID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref byte IsReleased, ref DateTime relaseDate, ref int RelasedByUserID, ref int ReleaseApplicationID)
        {
            string query = "select * from DetainedLicenses where DetainID=@DetainedID;";
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DetainedID", DetainedID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                            DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                            FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                            CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                            IsReleased = reader.GetByte(reader.GetOrdinal("IsReleased"));
                            if (!reader.IsDBNull(reader.GetOrdinal("ReleaseDate")))
                                relaseDate = reader.GetDateTime(reader.GetOrdinal("ReleaseDate"));
                            if (!reader.IsDBNull(reader.GetOrdinal("ReleasedByUserID")))
                                RelasedByUserID = reader.GetInt32(reader.GetOrdinal("ReleasedByUserID"));
                            if (!reader.IsDBNull(reader.GetOrdinal("ReleaseApplicationID")))
                                ReleaseApplicationID = reader.GetInt32(reader.GetOrdinal("ReleaseApplicationID"));
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
        public static bool GetDetainedLicenseByLicenseID(int LicenseID, ref int DetainedID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref byte IsReleased, ref DateTime relaseDate, ref int RelasedByUserID, ref int ReleaseApplicationID)
        {
            string query = "select * from DetainedLicenses where LicenseID=@LicenseID;";
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DetainedID = reader.GetInt32(reader.GetOrdinal("DetainID"));
                            DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                            FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                            CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                            IsReleased = (byte)(reader.GetBoolean(reader.GetOrdinal("IsReleased")) ? 1 : 0); 
                            if (!reader.IsDBNull(reader.GetOrdinal("ReleaseDate")))
                                relaseDate = reader.GetDateTime(reader.GetOrdinal("ReleaseDate"));
                            if (!reader.IsDBNull(reader.GetOrdinal("ReleasedByUserID")))
                                RelasedByUserID = reader.GetInt32(reader.GetOrdinal("ReleasedByUserID"));
                            if (!reader.IsDBNull(reader.GetOrdinal("ReleaseApplicationID")))
                                ReleaseApplicationID = reader.GetInt32(reader.GetOrdinal("ReleaseApplicationID"));
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
        public static DataTable GetDataOfDetainedClass()
        {
            DataTable dt = new DataTable();
            string query = @"  select DetainID 'D.ID',dl.LicenseID 'L.ID',DetainDate 'D.Date', IsReleased,FineFees,ReleaseDate,p.NationalNo 'N.No',
	p.FirstName+' '+p.SecondName+' '+p.ThirdName+' '+p.LastName 'Full Name',ReleaseApplicationID from DetainedLicenses dl inner join Licenses Li on Li.LicenseID=dl.LicenseID
  inner join Drivers d on Li.DriverID=d.DriverID inner join People p on d.PersonID=p.PersonID";
            using (SqlConnection conn = new SqlConnection(ConnectionString._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }    
    }
}
