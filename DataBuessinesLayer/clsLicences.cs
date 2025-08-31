using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataBuessinesLayer.clsLicences;
using static System.Net.Mime.MediaTypeNames;

namespace DataBuessinesLayer
{
    public class clsLicences
    {
       public clsDrivers Drivers;
      public  clsApplications _Applications;
        public clsLiceenseClass LiceenseClass;
      public  enum enIssueReason
        {
            FirstTime=1, 
            Renew=2, 
            ReplacementforDamaged=3,
            ReplacementforLost=4
        }
       public enum enIsActive
        {
            Yes = 1,
            No = 0
        }

        public static enIssueReason? GetIssueReasonById(byte issueReasonId)
        {
            if (Enum.IsDefined(typeof(enIssueReason), (int)issueReasonId))
                return (enIssueReason)issueReasonId;
            else
                return null;
        }

        public int LicenceID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public byte IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        clsLocalLicence _licences;
        public clsLicences()
        {
            LicenceID = 0;
            ApplicationID = 0;
            DriverID = 0;
            LicenseClass = 0;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            Notes = string.Empty;
            PaidFees = 0.0m;
            IsActive = (byte)enIsActive.Yes;
            IssueReason = (byte)enIssueReason.FirstTime;
            CreatedByUserID = 0;
        }
    public clsLicences(int LicenceID,int applicationID, int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, byte isActive, byte issueReason, int createdByUserID)
        {
            this.LicenceID = LicenceID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            _Applications=clsApplications.GetApplicationByID(applicationID);
            Drivers=clsDrivers.Find(driverID);
            LiceenseClass=clsLiceenseClass.GetLiceenseClassByID(licenseClass);
        }
        public static clsLicences GetLicencesByApplicationID(int applicationID)
        {
            int _LicenceID = 0;
            int _DriverID = 0;
            int _LicenseClass = 0;
            DateTime _IssueDate = DateTime.MinValue;
            DateTime _ExpirationDate = DateTime.MinValue;
            string _Notes = string.Empty;
            decimal _PaidFees = 0.0m;
            byte _IsActive = (byte)enIsActive.Yes;
            byte _IssueReason = (byte)enIssueReason.FirstTime;
            int _CreatedByUserID = 0;

            bool result = clsDataLicences.GetLicencesByApplicationID(
                applicationID,
                ref _LicenceID,
                ref _DriverID,
                ref _LicenseClass,
                ref _IssueDate,
                ref _ExpirationDate,
                ref _Notes,
                ref _PaidFees,
                ref _IsActive,
                ref _IssueReason,
                ref _CreatedByUserID
            );

            if (result)
            {
                return new clsLicences(
                    _LicenceID,
                    applicationID,
                    _DriverID,
                    _LicenseClass,
                    _IssueDate,
                    _ExpirationDate,
                    _Notes,
                    _PaidFees,
                    _IsActive,
                    _IssueReason,
                    _CreatedByUserID
                );
            }

            return null;
        }
        public static clsLicences GetLicencesByID(int LicencesID)
        {
            int applicationID = 0;
            int _DriverID = 0;
            int _LicenseClass = 0;
            DateTime _IssueDate = DateTime.MinValue;
            DateTime _ExpirationDate = DateTime.MinValue;
            string _Notes = string.Empty;
            decimal _PaidFees = 0.0m;
            byte _IsActive = (byte)enIsActive.Yes;
            byte _IssueReason = (byte)enIssueReason.FirstTime;
            int _CreatedByUserID = 0;
            bool result = clsDataLicences.GetLicencesByLicenceID(
                LicencesID,
                ref applicationID,
                ref _DriverID,
                ref _LicenseClass,
                ref _IssueDate,
                ref _ExpirationDate,
                ref _Notes,
                ref _PaidFees,
                ref _IsActive,
                ref _IssueReason,
                ref _CreatedByUserID
            );

            if (result)
            {
                return new clsLicences(
                    LicencesID,
                    applicationID,
                    _DriverID,
                    _LicenseClass,
                    _IssueDate,
                    _ExpirationDate,
                    _Notes,
                    _PaidFees,
                    _IsActive,
                    _IssueReason,
                    _CreatedByUserID
                );
            }

            return null;

        }
        public bool AddNewLocalLicences()
        {

           

            this.LicenceID = clsDataLicences.AddNewLocalLicences(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            if(LicenceID>0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool CheckIfPersonHasActiveLocalLicenceInSameClass(int personID, int LicencesClass)
        {
            return clsDataLicences.CheckIfPersonHasActiveLocalLicenceInSameClass(personID, LicencesClass);
        }
        public static bool IsTheDateIsVaild(int LicenceID)
        {
            return clsDataLicences.IsTheDateIsVaild(LicenceID);
        }
        public static bool DisActiveLocalLicences(int LicenceID)
        {
            return clsDataLicences.DisActiveLocalLicences(LicenceID);
        }
        public static bool ActiveLocalLicences(int LicenceID)
        {
            return clsDataLicences.ActiveLocalLicences(LicenceID);
        }
    }

}
