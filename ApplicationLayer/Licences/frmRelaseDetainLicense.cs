using ApplicationLayer.Users;
using DataBuessinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer.Licences
{
    public partial class frmRelaseDetainLicense : Form
    {
        int LicenceID = -1;
        clsLicences licences;
        clsApplications applications;
        clsDetainedLicense detainedLicense;
        clsManagmentApplicationTypes applicationType;
        public frmRelaseDetainLicense()
        {
            InitializeComponent();
        }
        public frmRelaseDetainLicense(int LicenseID)
        {
            InitializeComponent();
            this.LicenceID = LicenseID;
            applicationType = clsManagmentApplicationTypes.FindApplicationType(5);  
            licences = clsLicences.GetLicencesByID(LicenceID);
            ctrlShowLocalLicencesDetailsWithFilter1.LoadDataWithoutSearch(LicenceID);
         
            labLicenseID.Text = LicenseID.ToString();
            likLicenseHistory.Enabled = true;
            labUserName.Text = clsUsers.GetUserNameById(CurrentUserName.CurrentUserID);
            detainedLicense = clsDetainedLicense.GetDetainedLicenseByLicenseID(LicenseID);
            labDetainDate.Text = detainedLicense.DetainDate.ToString("yyyy-MM-dd");
            labFineFees.Text = detainedLicense.FineFees.ToString("F2");
            labApplicationFees.Text = applicationType.ApplicationFees.ToString("F2");
            labFees.Text = (detainedLicense.FineFees + Convert.ToDecimal(applicationType.ApplicationFees)).ToString("F2");
            labDetainID.Text = detainedLicense.DetainID.ToString();
            btnRelase.Enabled = true;
        }
        private void CheckValdaiteLicences()
        {
            licences = clsLicences.GetLicencesByID(LicenceID);
            if (licences == null)
            {
                MessageBox.Show("Please select a valid licence from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            labLicenseID.Text = licences.LicenceID.ToString();
            likLicenseHistory.Enabled = true;
            labUserName.Text = clsUsers.GetUserNameById(CurrentUserName.CurrentUserID);
            ctrlShowLocalLicencesDetailsWithFilter1.LoadData(LicenceID);

            if (!clsDetainedLicense.IsLicenseDetained(licences.LicenceID))
            {
                MessageBox.Show("This licence is Not detained Choise Another one .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            applicationType = clsManagmentApplicationTypes.FindApplicationType(5);
            if (applicationType == null)
            {
                MessageBox.Show("Error finding application type for releasing detained licence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            detainedLicense = clsDetainedLicense.GetDetainedLicenseByLicenseID(licences.LicenceID);
            labDetainDate.Text = detainedLicense.DetainDate.ToString("yyyy-MM-dd");
            labFineFees.Text = detainedLicense.FineFees.ToString("F2");
            labApplicationFees.Text = applicationType.ApplicationFees.ToString("F2");
            labFees.Text = (detainedLicense.FineFees + Convert.ToDecimal(applicationType.ApplicationFees)).ToString("F2");
            labDetainID.Text = detainedLicense.DetainID.ToString();
            labApplicationFees.Text = applicationType.ApplicationFees.ToString("F2");
            btnRelase.Enabled = true;
        }
        private void frmRelaseDetainLicense_Load(object sender, EventArgs e)
        {
          
        }

        private void ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked(int obj)
        {
            ClearData();
            LicenceID = obj;
            CheckValdaiteLicences();
        }
        private bool AddNewApplication()
        {
          
           
            applications = new clsApplications();
            applications.ApplicantPersonID = licences.Drivers.PersonID;
            applications.ApplicationDate = DateTime.Now;
            applications.ApplicationTypeID = applicationType.ApplicationTypeID;
            applications.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
            applications.LastStatusDate = DateTime.Now;
            applications.PaidFees = applicationType.ApplicationFees;
            applications.CreatedByUserID = CurrentUserName.CurrentUserID;
            if (applications.Save())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error adding new application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void ClearData()
        {
            licences = null;
            applications = null;
            detainedLicense = null;
            applicationType = null;
            LicenceID = -1;
            labLicenseID.Text = string.Empty;
            labDetainDate.Text = string.Empty;
            labFineFees.Text = string.Empty;
            labDetainID.Text = string.Empty;
            labApplicationFees.Text = string.Empty;
            labApplicationID.Text = string.Empty;
            labFees.Text = string.Empty;
            labUserName.Text = string.Empty;
            likLicenseHistory.Enabled = false;
            btnRelase.Enabled = false;
          
        }
        private bool ActiveLicense()
        {
            return clsLicences.ActiveLocalLicences(LicenceID);
        }
        private void btnRelase_Click(object sender, EventArgs e)
        {
            if (AddNewApplication())
            {
                detainedLicense.IsReleased = 1;
                detainedLicense.ReleaseDate = DateTime.Now;
                detainedLicense.ReleasedByUserID = CurrentUserName.CurrentUserID;
                detainedLicense.ReleaseApplicationID = applications.ApplicationID;
                if (detainedLicense.Save())
                {
                    if (!ActiveLicense())
                    {
                        MessageBox.Show("Error activating the licence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Licence released successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRelase.Enabled = false;
                   likNewLicenseInfo.Enabled = true;
                    labApplicationID.Text = applications.ApplicationID.ToString();
                  
                 
                }
                else
                {
                    MessageBox.Show("Error releasing licence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
        }

        private void likLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicencesHistory frm = new frmShowLicencesHistory(licences.Drivers.PersonID);
            frm.ShowDialog();
        }

        private void likNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInfoOfLocalLicences frm = new frmShowInfoOfLocalLicences(licences.LicenceID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
