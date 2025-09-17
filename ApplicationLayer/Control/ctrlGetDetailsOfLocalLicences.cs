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
    public partial class ctrlGetDetailsOfLocalLicences : UserControl
    {
       
        clsLocalLicence _localLicenceApplication;
        clsLicences _licences;
        public ctrlGetDetailsOfLocalLicences()
        {
            InitializeComponent();
        }

        private void ctrlGetDetailsOfLocalLicences_Load(object sender, EventArgs e)
        {

        }
        
        private void LoadPictureBox()
        {
            try
            {
                string imagePath = _licences._Applications.Person.ImagePath;

                if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
                {
                    // Load default image based on gender
                    if (_licences._Applications.Person.Gendor == false)
                    {
                        pbPerson.Image = Properties.Resources.man_4086624;
                    }
                    else
                    {
                        pbPerson.Image = Properties.Resources.woman_4086693;
                    }
                }
                else
                {
                    pbPerson.Image = Image.FromFile(imagePath);
                }
            }
            catch (Exception ex)
            {
                // Optional: log the error or show a message
                pbPerson.Image = Properties.Resources.man_4086624; // fallback image
            }
        }


        public void LoadDateByLicencesID(int LicenceID)
        {
            _licences = clsLicences.GetLicencesByID(LicenceID);
            if (_licences == null)
            {
                MessageBox.Show("No local licence details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            SetThevalue();
        }

        private void SetThevalue()
        {
           
            lblClass.Text = _licences.LiceenseClass?.ClassName ?? "N/A";
            lblFullName.Text = _licences._Applications?.Person?.FullName() ?? "N/A";
            lblNationalNo.Text = _licences._Applications?.Person?.NationalNo ?? "N/A";
            lblDateOfBirth.Text = _licences._Applications?.Person?.DateOfBirth.ToString("yyyy-MM-dd") ?? "N/A";
            lblDriverID.Text = _licences.DriverID.ToString();
            lblExpirationDate.Text = _licences.ExpirationDate.ToString("yyyy-MM-dd");
            lblGendor.Text = _licences._Applications?.Person?.Gendor == false ? "Male" : "Female";
            lblIssueDate.Text = _licences.IssueDate.ToString("yyyy-MM-dd");
            lblIsActive.Text = _licences.IsActive == 1 ? "Yes" : "No";
            lblNotes.Text = string.IsNullOrEmpty(_licences.Notes) ? "No Notes" : _licences.Notes;
            lblLicenseID.Text = _licences.LicenceID.ToString();
            lblIsDetained.Text = clsDetainedLicense.IsLicenseDetained(_licences.LicenceID) ? "Yes" : "No";
            var reason = clsLicences.GetIssueReasonById(_licences.IssueReason);
            if (reason != null)
            {
                lblIssueReason.Text = reason.ToString(); // e.g., "Renew"
            }
            LoadPictureBox();
        }
        public void LoadData(int LDAppID)
        {
            _localLicenceApplication=clsLocalLicence.FindLocalLicencesDetails(LDAppID);
            _licences = clsLicences.GetLicencesByApplicationID(_localLicenceApplication.ApplicationID);
            if (_licences == null)
            {
                MessageBox.Show("No local licence details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetThevalue();

        }
       
    }
}
