using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuessinesLayer
{
    public class clsDetainedLicense
    {

       public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public byte IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        enum enMode
        {
            Add = 1,
            Edit = 2,
        }
        enMode _Mode=enMode.Add;
        public clsDetainedLicense()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = 0;
            ReleaseDate = DateTime.Now;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
            _Mode = enMode.Add;
        }
        public clsDetainedLicense(int detainID, int licenseID, DateTime? detainDate, decimal? fineFees, int? createdByUserID, byte? isReleased, int? releasedByUserID, int? releaseApplicationID, DateTime? releaseDate)
        {
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate ?? DateTime.Now;
            FineFees = fineFees ?? 0;
            CreatedByUserID = createdByUserID ?? -1;
            IsReleased = isReleased ?? 0;
            ReleaseDate = releaseDate ?? DateTime.Now;
            ReleasedByUserID = releasedByUserID ?? -1;
            ReleaseApplicationID = releaseApplicationID ?? -1;
            _Mode = enMode.Edit;
        }
        
        public static bool IsLicenseDetained(int licenseId)
        {
            return clsDataDetainedLicense.IsLicenseDetained(licenseId);
        }
        private bool AddNewDetained()
        {
             DetainID=clsDataDetainedLicense.AddNewDetained( LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased);
            return DetainID>0;
        }
        private bool EditDetained()
        {
            bool result = new clsDataDetainedLicense().UpdateDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            return result;
        }
        public bool Save()
        {
            if(_Mode == enMode.Add)
            {   
                _Mode = enMode.Edit;
                return AddNewDetained();
             
            }
            else if (_Mode == enMode.Edit)
            {
                return EditDetained();
            }
            return false;
        }
  
    public static clsDetainedLicense GetDetainedLicense(int DetiendID)
        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0;
            int CreatedByUserID = -1;
            byte IsReleased = 0;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;
            bool result = clsDataDetainedLicense.FindDetainedByDetainedID(DetiendID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);
            if (result)
            {
                return new clsDetainedLicense(DetiendID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleasedByUserID, ReleaseApplicationID, ReleaseDate);
            }
            else
            {
                return new clsDetainedLicense();
            }
        }
        public static clsDetainedLicense GetDetainedLicenseByLicenseID(int licenseID)
        {

            int DetiendID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0;
            int CreatedByUserID = -1;
            byte IsReleased = 0;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;
            bool result = clsDataDetainedLicense.GetDetainedLicenseByLicenseID(licenseID, ref DetiendID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);
            if (result)
            {
                return new clsDetainedLicense(DetiendID, licenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleasedByUserID, ReleaseApplicationID, ReleaseDate);
            }
            else
            {
                return new clsDetainedLicense();
            }
        }
        public static DataTable GetDataOfDetainedClass()
        {
            return clsDataDetainedLicense.GetDataOfDetainedClass();
        }

    }
}
