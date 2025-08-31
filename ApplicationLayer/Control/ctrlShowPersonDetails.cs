using DataBuessinesLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace ApplicationLayer.People
{
    public partial class ctrlShowPersonDetails : UserControl
    {
        int _PersonID;

        // Constructor بدون باراميتر – لازم للمصمم
        public ctrlShowPersonDetails()
        {
            InitializeComponent();

            // تجنب تشغيل كود وقت التصميم
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
        }


        public ctrlShowPersonDetails(int personID)
        {
            InitializeComponent();
            if (personID == -1)
            {
                
                return; 
            }
            _PersonID = personID;

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            LoadData(personID);
        }

        // تحميل البيانات حسب ID
        public void LoadData(int personID)
        {
         
            clsPeopel people = clsPeopel.Find(personID);

            // تحقق إن البيانات موجودة
            if (people == null||personID==-1)
            {
                if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                    MessageBox.Show("Person not found.");
                return;
            }

            // تأكد إن العنصر موجود قبل التعديل عليه
            _PersonID = people.PersonID;
                labCountryName.Text = clsCountries.GetCountryNameByID(people.NationalityCountryID);
                labPersonID.Text = people.PersonID.ToString();
                labNationalNo.Text = people.NationalNo;
                 labFullNameofPerson.Text = $"{people.FirstName} {people.SecondName} {people.ThirdName} {people.LastName}";
            labDateOfBirth.Text = people.DateOfBirth.ToShortDateString();
            if (people.Gendor == false)
            {
                labGednor.Text = "Male";
            }
            else
            {
                labGednor.Text = "Female";
            }
            labPhone.Text = people.Phone;
            labEmail.Text = people.Email;
            labAddress.Text = people.Address;
           
            if (!string.IsNullOrEmpty(people.ImagePath) && System.IO.File.Exists(people.ImagePath))
            {
                pbPersonalPicture.Image = Image.FromFile(people.ImagePath);
            }
            else
            {
                pbPersonalPicture.Image = Properties.Resources.man_4086624; // أو صورة افتراضية
            }

        }

        private void ctrlShowPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();
             LoadData(_PersonID); // إعادة تحميل البيانات بعد التحديث
            
        }
    }
}
