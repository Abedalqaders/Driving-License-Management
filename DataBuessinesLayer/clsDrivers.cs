using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataBuessinesLayer
{
    public class clsDrivers
    {
       public int DriverID { get; set; }
       public int PersonID { get; set; }
       public DateTime CreatedDate { get; set; }
       public int CreatedByUser { get; set; }
       public clsPeopel person;
        clsDrivers()
        {
            DriverID = 0;
            PersonID = 0;
            CreatedDate = DateTime.MinValue;
            CreatedByUser = 0;
        }
        clsDrivers(int driverID, int personID, DateTime createdDate, int createdByUser)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedDate = createdDate;
            CreatedByUser = createdByUser;
            person = clsPeopel.Find(personID);
        }
        public static clsDrivers Find(int driverID)
        {
            int personID = 0;
            DateTime createdDate = DateTime.MinValue;
            int createdByUser = 0;

            bool found = DataAcessLayer.clsDataDrivers.Find(driverID, ref personID, ref createdDate, ref createdByUser);

            if (found)
            {
                return new clsDrivers(driverID,personID,createdDate,createdByUser);
               
            }

            return null;
        }
        public static DataTable GetDrivers()
        {
            return DataAcessLayer.clsDataDrivers.GetDrivers();
        }
        public static int AddNewDriver(int personid, int CreatedByUser, DateTime CreatedDate)
        {
            return DataAcessLayer.clsDataDrivers.AddNewDriver(personid, CreatedByUser, CreatedDate);
        }
        public static int GetDriverIDByPersonID(int personid)
        {
            return DataAcessLayer.clsDataDrivers.GetDriverIDByPersonID(personid);
        }
    }
}
