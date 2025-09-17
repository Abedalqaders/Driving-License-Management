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
    public partial class frmRenewLocalLicnces : Form
    {
        clsApplications RenewApplication;
        clsManagmentApplicationTypes RenewType;
        clsLicences licences;
        clsLicences newLicence;
        clsLocalLicence localLicenceApplication;
        int licenceId = 0;
        public frmRenewLocalLicnces()
        {
            InitializeComponent();
        }
        private void CheckValdaiteLicences()
        {
            licences = clsLicences.GetLicencesByID(licenceId);
            if (licences == null)
            {
                MessageBox.Show("Please select a valid licence from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlShowLocalLicencesDetailsWithFilter1.LoadData(licenceId);
            likLicenseHistory.Enabled = true;
            ctrlApplicationRenewLicences1.LoadBasicData(licenceId);
            if (licences.IsActive == (byte)clsLicences.enIsActive.No)
            {
                MessageBox.Show("This licence is inactive and cannot be renewed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (licences.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("This licence is not Expired, It Will Expire in " + licences.ExpirationDate + " .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnRenew.Enabled = true;
        }
        private void ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked(int obj)
        {
            licenceId = obj;
            CheckValdaiteLicences();
        }

        private void frmRenewLocalLicnces_Load(object sender, EventArgs e)
        {

        }
        private bool AddRenewApplication()
        {
            RenewApplication = new clsApplications();
            RenewType = clsManagmentApplicationTypes.FindApplicationType(2);
            RenewApplication.ApplicationDate = DateTime.Now;
            RenewApplication.ApplicationTypeID = RenewType.ApplicationTypeID;
            RenewApplication.ApplicantPersonID = licences.Drivers.PersonID;
            RenewApplication.PaidFees = Convert.ToSingle(RenewType.ApplicationFees);
            RenewApplication.CreatedByUserID = CurrentUserName.CurrentUserID;
            RenewApplication.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
            RenewApplication.LastStatusDate = DateTime.Now;
            RenewApplication.Mode = clsApplications.enMode.AddNew;
            if (RenewApplication.Save())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error occurred while creating the renewal application.");
                return false;
            }
        }
        private bool AddNewLicense()
        {
            newLicence = new clsLicences();
            newLicence.ApplicationID = RenewApplication.ApplicationID;
            newLicence.DriverID = licences.DriverID;
            newLicence.LicenseClass = licences.LicenseClass;
            newLicence.IssueDate = DateTime.Now;
            newLicence.ExpirationDate = licences.LiceenseClass.DefaultValidityLength > 0 ? DateTime.Now.AddYears(licences.LiceenseClass.DefaultValidityLength) : DateTime.MaxValue;
            newLicence.Notes =  tbNotes.Text;
            newLicence.PaidFees = Convert.ToDecimal(licences.LiceenseClass.ClassFees);
            newLicence.IsActive = (byte)clsLicences.enIsActive.Yes;
            newLicence.IssueReason = (byte)clsLicences.enIssueReason.Renew;
            newLicence.CreatedByUserID = CurrentUserName.CurrentUserID;

            if (newLicence.AddNewLocalLicences())
            {
                MessageBox.Show("Licence renewed successfully.");
                return true;
            }
            else
            {
                MessageBox.Show("Error occurred while renewing the licence.");
                return false;
            }
        }
        private bool DisableOldLicense()
        {
            
           
            if (clsLicences.DisActiveLocalLicences(licences.LicenceID))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error occurred while disabling the old licence.");
                return false;
            }
        }
   
        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (licences != null)
            {
                if (AddRenewApplication())
                {
                        if (AddNewLicense())
                        {
                            if (DisableOldLicense())
                            {
                                btnRenew.Enabled = false;
                                likNewLicenseInfo.Enabled = true;
                                ctrlApplicationRenewLicences1.LoadNewLicences(newLicence.LicenceID);
                            }

                        }
                   
                  
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void likLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicencesHistory frm = new frmShowLicencesHistory(licences.Drivers.PersonID);
            frm.ShowDialog();
        }

        private void likNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInfoOfLocalLicences frm = new frmShowInfoOfLocalLicences(newLicence.LicenceID);
            frm.ShowDialog();

        }
    }
}
