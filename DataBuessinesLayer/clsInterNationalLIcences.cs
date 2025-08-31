using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataBuessinesLayer
{
    public class clsInterNationalLIcences
    {
      public  clsDrivers Drivers;
       public clsUsers Users;
       public clsApplications Applications;
     public   clsLicences licences;
        enum enMode
        {
            AddNew = 1,
            Edit = 2
        }
        enMode Mode = enMode.AddNew;
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public clsInterNationalLIcences()
        {
            InternationalLicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            IssuedUsingLocalLicenseID = 0;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            IsActive = false;
            CreatedByUserID = 0;
        }
        public clsInterNationalLIcences(int internationalLicenseID, int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
            Applications= clsApplications.GetApplicationByID(applicationID);
            Drivers = clsDrivers.Find(driverID);
            Users = clsUsers.Find(createdByUserID);
            licences = clsLicences.GetLicencesByID(issuedUsingLocalLicenseID);
        }

        private bool AddNewInterNationalLicence()
        {

            InternationalLicenseID=DataAcessLayer.clsDataInterNationalLIcences.AddNewInternationalLicense(DriverID, ApplicationID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            return InternationalLicenseID > 0;
        }
        public static clsInterNationalLIcences GetInternationalLicenseByID(int internationalLicenseID)
        {
            int applicationID = 0;
            int driverID = 0;
            int issuedUsingLocalLicenseID = 0;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            bool isActive = false;
            int createdByUserID = 0;
            bool found = DataAcessLayer.clsDataInterNationalLIcences.FindInternationalLicense(internationalLicenseID, ref driverID, ref applicationID,  ref issuedUsingLocalLicenseID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID);
            if (found)
            {
                return new clsInterNationalLIcences(internationalLicenseID, applicationID, driverID, issuedUsingLocalLicenseID, issueDate, expirationDate, isActive, createdByUserID);
            }
            return null;
        }
        public bool Save()
        {
            if (Mode==enMode.AddNew)
            {
               
                return AddNewInterNationalLicence();
            }
            else
            {
             //   return DataAcessLayer.clsDataInterNationalLIcences.UpdateInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            return false;
        }
        public static DataTable GetInterNationalLicecesForPerson(int personID)
        {
            return DataAcessLayer.clsDataInterNationalLIcences.GetInterNationalLicecesForPerson(personID);
        }
        public static bool IsThereActiveInterNationalLicences(int LicencesID)
        {
            return DataAcessLayer.clsDataInterNationalLIcences.IsThereActiveInterNationalLicences(LicencesID);
        }
        public static DataTable GetAllInternationalLicenses()
        {
            return DataAcessLayer.clsDataInterNationalLIcences.GetAllInternationalLicenses();
        }
    }
}
