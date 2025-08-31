using ApplicationLayer.Properties;
using DataBuessinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer.Control
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID;
        private clsInterNationalLIcences _InternationalLicense;
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void ctrlDriverInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }

        private void _LoadPersonImage()
        {
            if (_InternationalLicense.Drivers.person.Gendor == false)
                pbPersonImage.Image = Resources.man_4086624;
            else
                pbPersonImage.Image = Resources.woman_4086693;

            string ImagePath = _InternationalLicense.Drivers.person.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInterNationalLIcences.GetInternationalLicenseByID(_InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not find Internationa License ID = " + _InternationalLicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblFullName.Text = _InternationalLicense.Drivers.person.FullName();
            lblNationalNo.Text = _InternationalLicense.Drivers.person.NationalNo;
            lblGendor.Text = _InternationalLicense.Drivers.person.Gendor == false ? "Male" : "Female";
            lblDateOfBirth.Text = _InternationalLicense.Drivers.person.DateOfBirth.ToString("g");

            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToString("g");
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToString("g");

            _LoadPersonImage();



        }
    }
}
