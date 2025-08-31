using DataAcessLayer;
using System;
using System.Collections.Generic;

namespace DataBuessinesLayer
{
    public class clsApplications
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
       public clsPeopel Person;
      public  clsManagmentApplicationTypes ApplicationType;
      public  clsUsers User;
        public enum enApplicationStatus
        {
            New = 1,
            Cancelled = 2,
            Completed = 3,
        }

        enApplicationStatus _ApplicationStatus = enApplicationStatus.New;

        public clsApplications()
        {
            ApplicationID = 0;
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.MinValue;
            ApplicationTypeID = 0;
            ApplicationStatus = (byte)_ApplicationStatus;
            LastStatusDate = DateTime.MinValue;
            PaidFees = 0.0f;
            CreatedByUserID = 0;

            Mode = enMode.AddNew;
        }

        public clsApplications(int applicationID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, byte applicationStatus, DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            Person=clsPeopel.Find(applicantPersonID);
            ApplicationType = clsManagmentApplicationTypes.FindApplicationType(applicationTypeID);
            User=clsUsers.Find(CreatedByUserID);
            Mode = enMode.Update;
        }

        public static string GetApplicationStatusName(byte applicationStatus)
        {
            switch ((enApplicationStatus)applicationStatus)
            {
                case enApplicationStatus.New:
                    return "New";
                case enApplicationStatus.Cancelled:
                    return "Cancelled";
                case enApplicationStatus.Completed:
                    return "Completed";
                default:
                    return "Unknown";
            }
        }

        public static clsApplications GetApplicationByID(int applicationID)
        {
            int _ApplicantPersonID = 0;
            DateTime _ApplicationDate = DateTime.MinValue;
            int _ApplicationTypeID = 0;
            byte _ApplicationStatus = 0;
            DateTime _LastStatusDate = DateTime.MinValue;
            float _PaidFees = 0.0f;
            int _CreatedByUserID = 0;

            if (clsDataApplications.GetApplicationDataDetails(applicationID, ref _ApplicantPersonID, ref _ApplicationDate,
                ref _ApplicationTypeID, ref _ApplicationStatus, ref _LastStatusDate, ref _PaidFees, ref _CreatedByUserID))
            {
                return new clsApplications(applicationID, _ApplicantPersonID, _ApplicationDate, _ApplicationTypeID,
                    _ApplicationStatus, _LastStatusDate, _PaidFees, _CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public bool AddNewApplication()
        {
            int applicationID = clsDataApplications.AddNewApplication(
                ApplicantPersonID, ApplicationTypeID, ApplicationDate, LastStatusDate, PaidFees, CreatedByUserID.ToString());

            if (applicationID > 0)
            {
                ApplicationID = applicationID;
                return true;
            }
            return false;
        }

        public bool UpdateApplication()
        {
            return clsDataApplications.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return UpdateApplication();

                default:
                    return false;
            }
        }
    }
}
