using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static DataBuessinesLayer.clsLocalLicence;

namespace DataBuessinesLayer
{
    public class clsLocalLicence
    {

       public clsApplications _application;
        public clsLiceenseClass _licencesclass;

            public int LocalDrivingApplicationID
        {
            set;get;
        }
            public int LocalClassID
        {
            set;get;
        }
        public int ApplicationID
        {
            set; get;
        }

      

        public clsLocalLicence()
        {
            LocalClassID = 0;
            LocalDrivingApplicationID = 0;
            _Mode = enMode.Add;
        }
     
        public clsLocalLicence(int DLappID,  int LicenseClassID, int  applicationID)
        {
          LocalDrivingApplicationID = DLappID;
       LocalClassID = LicenseClassID;
            ApplicationID = applicationID;
            _application =clsApplications.GetApplicationByID(applicationID);
            _licencesclass=clsLiceenseClass.GetLiceenseClassByID(LicenseClassID);
            _Mode = enMode.Update;
        }

        
        public bool AddNewLocalDrivingApplication()
        {
            try
            {
                LocalDrivingApplicationID = DataAcessLayer.clsDataLocalLicence.AddNewLocalDrivingApplicationDetails(ApplicationID, LocalClassID);
                if (LocalDrivingApplicationID > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      public bool UpdateLocalDrivingApplication()
        {

           if( clsDataLocalLicence.UpdateLocalLicences(LocalDrivingApplicationID, LocalClassID))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static DataTable GetLocalLicencesByID(int personID)
        {
            return DataAcessLayer.clsDataLocalLicence.GetLocalLicencesByID(personID);
        }
        public bool Save()
        {
            try
            {
                if (_Mode == enMode.Add)
                {
                    _Mode = enMode.Update;
                    return AddNewLocalDrivingApplication();
                }
                else if (_Mode == enMode.Update)
                {
                
                   return  UpdateLocalDrivingApplication();
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public enum enApplicationStatus
        {
            New = 1,
            Cancelled = 2,
            Completed = 3,
        }
        enum enMode
        {
            Add = 1,
            Update = 2
        }
        
        enMode _Mode = enMode.Add;

        public static float FeesOfLocalLicence()
        {
            return DataAcessLayer.clsDataLocalLicence.FeesOfLocalLicence();
        }
        public static bool CheckIfPersonHasActiveLocalLicenceInSameClass(int PersonID, int LicencesClass)
        {
            return DataAcessLayer.clsDataLocalLicence.CheckIfPersonHasActiveLocalLicenceApplicationInSameClass(PersonID, LicencesClass);
        }
        public static DataTable GetDataOfLocalDriverLicencesApplications()
        {
            return DataAcessLayer.clsDataLocalLicence.GetDataOfLocalDriverLicencesApplications();
        }
        public static clsLocalLicence FindLocalLicencesDetails(int DLappID)
        {
            int LicenseClassID = -1;
            int AppID = -1;
          
            if (clsDataLocalLicence.FindLocalLicencesDetails(DLappID,ref LicenseClassID, ref AppID))
            {
                return   new clsLocalLicence(DLappID, LicenseClassID ,AppID);
            }
            else
            {
                return null;
            }
        }
        public static clsLocalLicence FindLocalLicencesDetailsByApplicationID(int ApplicationID)
        {
            int LicenseClassID = -1;
            int DLappID = -1; 

            if (clsDataLocalLicence.FindLocalLicencesDetailsByApplicationID(ApplicationID, ref DLappID, ref LicenseClassID))
            {
                return new clsLocalLicence(DLappID, LicenseClassID, ApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static string GetStatusbyID(int statusID)
        {
            if(enApplicationStatus.New == (enApplicationStatus)statusID)
            {
                return "New";
            }
            else if (enApplicationStatus.Cancelled == (enApplicationStatus)statusID)
            {
                return "Cancelled";
            }
            else if (enApplicationStatus.Completed == (enApplicationStatus)statusID)
            {
                return "Completed";
            }
          return "Unknown Status";
        }
        public static bool CancelApplicationStatusByLocalappID(int localID)
        {
            return DataAcessLayer.clsDataLocalLicence.CancelApplicationStatusByLocalappID(localID);
        }
        public static bool DeleteApplicationStatusByLocalappID(int localID)
        {
            return DataAcessLayer.clsDataLocalLicence.DeleteLocalDrivingApplication(localID);
        }
        public static string GetClassName(int localAppID)
        {
            DataTable dt = clsDataLocalLicence.GetLicenseClassAndTests(localAppID);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["ClassName"].ToString();

            return null; // أو قيمة افتراضية
        }

        public static int GetPassedTestCount(int localAppID)
        {
            DataTable dt = clsDataLocalLicence.GetLicenseClassAndTests(localAppID);

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["PassedTestCount"]);

            return 0;
        }

    }
}
