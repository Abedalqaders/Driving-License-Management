using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAcessLayer;
namespace DataBuessinesLayer
{
    public class clsManagmentApplicationTypes
    {
      public  int ApplicationTypeID
        {
            set;
            get;
        }
      public  string ApplicationTypeTitle
        {
            set;
            get;    
        }
       public float ApplicationFees
        {
            set;
            get;
        }
        public clsManagmentApplicationTypes()
        {
            ApplicationTypeID = 0;
            ApplicationTypeTitle = string.Empty;
            ApplicationFees = 0.0f;
        }
        public clsManagmentApplicationTypes(int applicationTypeID, string applicationTypeTitle, float applicationFees)
        {
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypeTitle;
            ApplicationFees = applicationFees;
        }
        public static List<clsManagmentApplicationTypes> GetApplicationTypesWithList()
        {
            DataTable dt = clsDataManagmentApplicationTypes.GetApplicationTypesFromDB();

            List<clsManagmentApplicationTypes> list = new List<clsManagmentApplicationTypes>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new clsManagmentApplicationTypes
                {
                    ApplicationTypeID = (int)row["ApplicationTypeID"],
                    ApplicationTypeTitle = row["ApplicationTypeTitle"].ToString()
                });
            }

            return list;
        }
        public static DataTable GetApplicationTypes()
        {
            return DataAcessLayer.clsDataManagmentApplicationTypes.GetApplicationTypes();
        }
        public static bool UpdateApplicationType(int applicationTypeID, string applicationTypeTitle, float applicationFees)
        {
            return clsDataManagmentApplicationTypes.UpdateApplicationType(applicationTypeID, applicationTypeTitle, applicationFees);
        }
        public static clsManagmentApplicationTypes FindApplicationType(int applicationTypeID)
        {
            string applicationTypeTitle = string.Empty;
            float applicationFees = 0.0f;
            if (clsDataManagmentApplicationTypes.FindApplicationType(applicationTypeID, ref applicationTypeTitle,ref applicationFees))
            {
                return new clsManagmentApplicationTypes(applicationTypeID, applicationTypeTitle, applicationFees);
            }
            else
            {
                return null;
            }
        }
       public static int NumberOfApplicationTypes() {
           return  clsManagmentApplicationTypes.NumberOfApplicationTypes();
        }
        
    }
}
