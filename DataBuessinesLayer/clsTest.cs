using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAcessLayer;
namespace DataBuessinesLayer
{
    public class clsTest
    {
      public  int TestID
        {
            set; get;
        }
        public int TestAppointmentID
        {
            set; get;
        }
        public int CreatedByUserID
        {
            set; get;
        }
        public byte TestResult
        {
            set; get;
        }
        public string Note
        {
            set; get;
        }
        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            CreatedByUserID = -1;
            TestResult = 0;
            Note = string.Empty;
        }
        public clsTest(int testID, int testAppointmentID, byte testResult, string note, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Note = note;
            CreatedByUserID = createdByUserID;
        }
        public  int InsertTest()
        {
            return clsDataTest.InsertTest(TestAppointmentID, TestResult, Note, CreatedByUserID);
        }
    }
}
