using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuessinesLayer
{
    public class clsTestAppointment
    {
        public enum TestType
        {
            Vision = 1,
            Writing = 2,
            Street = 3
        }
        public static DataTable GetAllTestAppointments(TestType testType, int DLappID)
        {
            return DataAcessLayer.clsDataTestAppointment.GetAllTestAppoitmentofTest((int)testType, DLappID);
        }
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int? RetakeTestApplicationID { get; set; }

        public clsTestAppointment()
        {
            TestAppointmentID = 0;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.MinValue;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
            RetakeTestApplicationID = null;

            Mode = enMode.AddNew;
        }

        public clsTestAppointment(int id, int testTypeID, int localAppID, DateTime date, decimal fees,
            int userID, bool isLocked, int? retakeID)
        {
            TestAppointmentID = id;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localAppID;
            AppointmentDate = date;
            PaidFees = fees;
            CreatedByUserID = userID;
            IsLocked = isLocked;
            RetakeTestApplicationID = retakeID;

            Mode = enMode.Update;
        }

        public static clsTestAppointment FindByID(int localAppID, int TestTypeID)
        {
           
            int testappoitmentID = 0;
            DateTime date = DateTime.MinValue;
            decimal fees = 0;
            int userID = 0;
            bool isLocked = false;
            int? retakeID = null;

            if (clsDataTestAppointment.GetAppointmentDetailsByDLID(localAppID,  TestTypeID, ref testappoitmentID, ref date,
                ref fees, ref userID, ref isLocked, ref retakeID))
            {
                return new clsTestAppointment(testappoitmentID, TestTypeID, localAppID, date, fees, userID, isLocked, retakeID);
            }
            else
            {
                return null;
            }
        }
        public static clsTestAppointment FindByTestAppoitmentID(int TestAppoitmentID)
        {
            int localAppID = 0;
            int TestTypeID = 0;
            DateTime date = DateTime.MinValue;
            decimal fees = 0;
            int userID = 0;
            bool isLocked = false;
            int? retakeID = null;

            if (clsDataTestAppointment.GetAppointmentDetails(TestAppoitmentID,ref TestTypeID, ref localAppID, ref date,
                ref fees, ref userID, ref isLocked, ref retakeID))
            {
                return new clsTestAppointment(TestAppoitmentID, TestTypeID, localAppID, date, fees, userID, isLocked, retakeID);
            }
            else
            {
                return null;
            }
        }
        public bool AddNew()
        {
            int newID = clsDataTestAppointment.InsertAppointment(TestTypeID, LocalDrivingLicenseApplicationID,
                AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);

            if (newID > 0)
            {
                TestAppointmentID = newID;
                return true;
            }
            return false;
        }

        public bool Update()
        {
            return clsDataTestAppointment.UpdateAppointment(TestAppointmentID, AppointmentDate, PaidFees, IsLocked);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return Update();

                default:
                    return false;
            }
        }
        public static bool IsThereActiveAppoitment(int TestType,int DLAppID)
        {
            return clsDataTestAppointment.IsThereActiveAppoitment(TestType, DLAppID);
        }
        public static bool IamPassedTest(int TestType,int DLAppID)
        {
            return clsDataTestAppointment.IamPassedTest( TestType, DLAppID);
        }
        public static int CountOfTrail(int DLAppID, int TestType)
        {
            return clsDataTestAppointment.CountOfTrail(DLAppID, TestType);
        }
        public static bool LockTestAppointment(int testAppoitmentID)
        {
            return clsDataTestAppointment.LockTestAppointment(testAppoitmentID);
        }
    }
}
