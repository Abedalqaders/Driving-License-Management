using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBuessinesLayer
{
    public class clsPeopel
    {
       public int PersonID
        {
            set;
            get;
        }
        public string NationalNo
        {
            set;
            get;
        }
        public string FirstName
        {
            set;
            get;
        }
        public string SecondName
        {
            set;
            get;
        }
        public string ThirdName
        {
            set;
            get;
        }
        public string LastName
        {
            set;
            get;    
        }
        public DateTime DateOfBirth
        {
            set;
            get;
        }
       public bool Gendor
        {
            set;
            get;
        }
        public string Address
        {
            set;
            get;
        }
        public string Phone
        {
            set;
            get;
        }
        public string Email
        {
            set;
            get;
        }
        public int NationalityCountryID
        {
            set;
            get;
        }
        public string ImagePath
        {
            set;
            get;
        }
     
        enum AddUpdate
        {
            Add = 1,
            Update = 2
        }
        AddUpdate _AddUpdateStatus;
       public clsPeopel() {
        PersonID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor= false;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NationalityCountryID = 0;
            ImagePath = string.Empty;
            _AddUpdateStatus = AddUpdate.Add;
        }
        public clsPeopel(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, bool Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            _AddUpdateStatus = AddUpdate.Update;
        }
        public static clsPeopel Find(int personID)
        {
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            string NationalNo = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            bool gendor = false;
            string address = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            int nationalityCountryID = 0;
            string imagePath = string.Empty;
            if(clsDataPeople.FindPersonByID(personID, ref NationalNo, ref firstName, ref secondName, ref thirdName, ref lastName,
                                        ref gendor, ref dateOfBirth, ref nationalityCountryID, ref phone,  ref email, ref imagePath,ref address)){

                return new clsPeopel(personID, NationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath);

            }
            else
            {
                return new clsPeopel();
            }
        }
        public bool AddNewPerson()
        {


            this.PersonID = clsDataPeople.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth,
                                                         NationalityCountryID, Phone, Email, ImagePath,Address);
            if (this.PersonID == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool UpdatePerson()
        {
            bool result = clsDataPeople.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth,
                                                     NationalityCountryID, Phone, Email, ImagePath,Address);
            return result;
        }
        public bool Save()
        {
            if (_AddUpdateStatus == AddUpdate.Add)
            {
                _AddUpdateStatus = AddUpdate.Update;
                return AddNewPerson();
            }
            else if (_AddUpdateStatus == AddUpdate.Update)
            {
               return  UpdatePerson();
            }
            return false;
        }
        public string FullName()
        {
            return $"{FirstName} {SecondName} {ThirdName} {LastName}";
        }
        public static bool DeletePerson(int PersonID)
        {
            return DataAcessLayer.clsDataPeople.DeletePerson(PersonID);
        }
        public static DataTable GetAllPeople()
        {
         return DataAcessLayer.clsDataPeople.GetALLPeople();
        }
        public static int GetNumberOfPeople()
        {
            return DataAcessLayer.clsDataPeople.GetNumberOfPeople();
        }
        public static DataTable GetPeoplebyNationalNo(string NationalNo)
        {
            return DataAcessLayer.clsDataPeople.GetPeoplebyNationalNo(NationalNo);
        }
        public static DataTable GetPeoplebyName(string FullName)
        {
            return DataAcessLayer.clsDataPeople.GetPeoplebyName(FullName);
        }
        public static DataTable GetPeoplebyGendor(string Gendor)
        {
            return DataAcessLayer.clsDataPeople.GetPeoplebyGendor(Gendor);

        }
        public static DataTable GetPeoplebyPersonID(int PersonID)
        {
            return DataAcessLayer.clsDataPeople.GetPeoplebyPersonID(PersonID);
        }
        public static bool NatonalNoIsExist(string NationalNo)
        {
            return DataAcessLayer.clsDataPeople.NatonalNoIsExist(NationalNo);
        }
    }
}
