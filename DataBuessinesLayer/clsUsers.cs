using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataBuessinesLayer
{
    public class clsUsers
    {
        public int _UserID
        {
            set;
            get;
        }
        public string _UserName
        {
            set;
            get;
        }
        public int _PersonId
        {
            set;
            get;
        }
        public string _Password
        {
            set;
            get;
        }
        public bool _IsActive
        {
            set;
            get;
        }
        enum enAddUpate
        {
            Add = 1,
            Update = 2
        }
        enAddUpate _AddUpdate;
        public clsUsers()
        {
            _UserID = -1;
            _UserName = string.Empty;
            _Password = string.Empty;
            _PersonId = -1;
            _IsActive = false;
            _AddUpdate = enAddUpate.Add;
        }
        public clsUsers(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {

            this._PersonId = PersonID;
            this._UserID = UserID;
            this._UserName = UserName;
            this._Password = Password;
            this._IsActive = IsActive;
            _AddUpdate = enAddUpate.Update;
        }
        public static clsUsers Find(int UserID)
        {
            int personID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsDataUsers.FindUserByID(UserID, ref personID, ref UserName, ref Password, ref IsActive))
            {

                return new clsUsers(UserID, personID, UserName, Password, IsActive);

            }
            else
            {
                return new clsUsers();
            }
        }
        public bool AddNewUser()
        {


            this._UserID = clsDataUsers.AddNewUser(_PersonId, _UserName, _Password, _IsActive);
            if (this._UserID == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool UpdateUser()
        {
            bool result = clsDataUsers.UpdateUser(_UserID, _UserName, _Password, _IsActive);
            return result;
        }
        public static bool DeleteUser(int UserID)
        {
            return clsDataUsers.DeleteUser(UserID);
        }   
        public bool Save()
        {
            if (enAddUpate.Add == _AddUpdate)
            {
                _AddUpdate = enAddUpate.Update;
                return AddNewUser();
            }
            else if (enAddUpate.Update == _AddUpdate)
            {
                return UpdateUser();
            }
            return false;
        }
        public static int GetPersonIDfromUser(int UserID)
        {
            return clsDataUsers.GetPersonIDfromUser(UserID);
        }
        public static bool IsActive(int UserId)
        {

            return DataAcessLayer.clsDataUsers.IsAcitve(UserId);

        }
        public static int CheckUserNameAndPassword(string UserName, string Password)
        {
            return DataAcessLayer.clsDataUsers.CheckUserNameAndPassword(UserName, Password);
        }
        public static string GetUserNameById(int UserId)
        {
            return DataAcessLayer.clsDataUsers.GetUserNameByID(UserId);
        }
        public static DataTable GetAllUsers()
        {
            return DataAcessLayer.clsDataUsers.GetAllUsers();
        }
        public static bool ChangePasswordforUser(int UserID, string NewPassword)
        {
            return DataAcessLayer.clsDataUsers.ChangePasswordforUser(UserID, NewPassword);
        }
        public static string GetPasswordOfUser(int UserID)
        {
            return DataAcessLayer.clsDataUsers.GetPasswordOfUser(UserID);
        }
        public static bool IsUserExistsForPerson(int PersonID)
        {
            return DataAcessLayer.clsDataUsers.IsUserExistsForPerson(PersonID);
        }
    }
}
