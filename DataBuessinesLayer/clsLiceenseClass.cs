using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuessinesLayer
{
    public class clsLiceenseClass
    {
       public int LiceenseClassID { get; set; }
     public   string ClassName { get; set; }
      public  string ClassDescription { get; set; }
      public int MinimumAllowedAge { get; set; }
       public int DefaultValidityLength { get; set; }
      public  decimal ClassFees { get; set; }
        clsLiceenseClass(int LiceenseClassID, string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, decimal ClassFees)
        {
            this.LiceenseClassID = LiceenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }
        public static clsLiceenseClass GetLiceenseClassByID(int LiceenseClassID)

        {
            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            int MinimumAllowedAge = 0;
            int DefaultValidityLength = 0;
            decimal ClassFees = 0;
            if (DataAcessLayer.clsDataLiceenseClass.GetLiceenseClassByID(LiceenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLiceenseClass(LiceenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
          
        }
        public static DataTable GetLiceenseClass()
        {
            return DataAcessLayer.clsDataLiceenseClass.GetLiceenseClass();
        }
    
    }
}
