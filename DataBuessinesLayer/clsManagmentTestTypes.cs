using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuessinesLayer
{
    public class clsManagmentTestTypes
    {
      
            public int TestTypeID
            {
                set;
                get;
            }
            public string TestTypeTitle
        {
                set;
                get;
            }
        public string TestTypeDescription
        {
            set;
            get;    
        }
            public float TestFees
            {
                set;
                get;
            }
            public clsManagmentTestTypes()
            {
            TestTypeID = 0;
            TestTypeTitle = string.Empty;
            TestTypeDescription = string.Empty;
            TestFees = 0.0f;

        }
            public clsManagmentTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestFees)
            {
               this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestFees = TestFees;
        }
            public static DataTable GetTestTypes()
            {
               return clsDataManagmentTestTypes.GetTestTypes();
        }
            public static bool UpdateTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestFees)
            {
                return clsDataManagmentTestTypes.UpdateTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestFees);
        }
            public static clsManagmentTestTypes FindTestType(int TestTypeID)
            {
                string TestTypeTitle = string.Empty;
                string TestTypeDescription = string.Empty;
                float TestFees = 0.0f;
                if (clsDataManagmentTestTypes.FindTestType(TestTypeID, ref TestTypeTitle,ref TestTypeDescription,ref TestFees ))
                {
                    return new clsManagmentTestTypes(TestTypeID, TestTypeTitle, TestTypeDescription,TestFees);
                }
                else
                {
                    return null;
                }
            }
       
        }
}
