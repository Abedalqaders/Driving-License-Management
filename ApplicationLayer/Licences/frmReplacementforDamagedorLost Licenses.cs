using ApplicationLayer.Control;
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
    public partial class frmReplacementforDamagedorLost_Licenses : Form
    {
        int OldLicenceID = -1;
        clsLicences licences;
        clsManagmentApplicationTypes applicationTypes;
        clsApplications application;
        clsLicences newLicence;
        public frmReplacementforDamagedorLost_Licenses()
        {
            InitializeComponent();
        }

        private void rbLostLicences_CheckedChanged(object sender, EventArgs e)
        {
            labTittle.Text = "Replacement for Lost Licences";
            applicationTypes = clsManagmentApplicationTypes.FindApplicationType(3);
            labApplicationFees.Text = applicationTypes.ApplicationFees.ToString();
            if(licences != null)
            {
                labTotalFees.Text = (Convert.ToDecimal(applicationTypes.ApplicationFees) + licences.PaidFees).ToString();
            }

        }

        private void rbDamagedLicences_CheckedChanged(object sender, EventArgs e)
        {
            labTittle.Text = "Replacement for Damaged Licences";
            applicationTypes = clsManagmentApplicationTypes.FindApplicationType(4);
            labApplicationFees.Text = applicationTypes.ApplicationFees.ToString();
            if (licences != null)
            {
                labTotalFees.Text = (Convert.ToDecimal(applicationTypes.ApplicationFees) + licences.PaidFees).ToString();
            }
        }
        private void CheckValdaiteLicences()
        {
            licences = clsLicences.GetLicencesByID(OldLicenceID);
            if (licences == null)
            {
                MessageBox.Show("Please select a valid licence from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            labOldLicenseID.Text = licences.LicenceID.ToString();
            likLicenseHistory.Enabled = true;
            ctrlShowLocalLicencesDetailsWithFilter1.LoadData(OldLicenceID);

            if (licences.IsActive == (byte)clsLicences.enIsActive.No)
            {
                MessageBox.Show("This licence is inactive and cannot be Replacment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            labTotalFees.Text = (Convert.ToDecimal (applicationTypes.ApplicationFees) + licences.PaidFees).ToString();
            btnIssue.Enabled = true;
            groupBox1.Enabled = true;
        }
        private void ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked(int obj)
        {
            RestData();
            OldLicenceID = obj;
            CheckValdaiteLicences();
        }

        private void likLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicencesHistory frm = new frmShowLicencesHistory(licences.Drivers.PersonID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestData()
        {
            labUserName.Text = clsUsers.GetUserNameById(CurrentUserName.CurrentUserID);
            labApplicationDate.Text = DateTime.Now.ToShortDateString();
            btnIssue.Enabled = false;
            likLicenseHistory.Enabled = false;
            rbLostLicences.Checked = true;
            applicationTypes = clsManagmentApplicationTypes.FindApplicationType(3);
            labApplicationFees.Text = applicationTypes.ApplicationFees.ToString();
            groupBox1.Enabled = false;
        }
        private void frmReplacementforDamagedorLost_Licenses_Load(object sender, EventArgs e)
        {
            RestData();

        }
        private bool AddNewApplication()
        {
            application = new clsApplications();
            application.ApplicationTypeID = applicationTypes.ApplicationTypeID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicantPersonID = licences.Drivers.PersonID;
            application.PaidFees = applicationTypes.ApplicationFees;

            application.CreatedByUserID = CurrentUserName.CurrentUserID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
            application.Mode = clsApplications.enMode.AddNew;
            if (application.Save())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error occurred while creating the new application.");
                return false;
            }

        }

        private bool AddNewLicense()
        {
            newLicence = new clsLicences();
            newLicence.ApplicationID = application.ApplicationID;
            newLicence.DriverID = licences.DriverID;
            newLicence.LicenseClass = licences.LicenseClass;
            newLicence.IssueDate = DateTime.Now;
            newLicence.ExpirationDate = licences.LiceenseClass.DefaultValidityLength > 0 ? DateTime.Now.AddYears(licences.LiceenseClass.DefaultValidityLength) : DateTime.MaxValue;
            newLicence.PaidFees = Convert.ToDecimal(licences.LiceenseClass.ClassFees);
            newLicence.IsActive = (byte)clsLicences.enIsActive.Yes;
            if(rbLostLicences.Checked)
            {
               
                newLicence.IssueReason = (byte)clsLicences.enIssueReason.ReplacementforLost;
            }
            else if (rbDamagedLicences.Checked)
            {
              
                newLicence.IssueReason = (byte)clsLicences.enIssueReason.ReplacementforDamaged;
            }
            else
            {
                MessageBox.Show("Please select a reason for replacement.");
                return false;
            }
           
            newLicence.CreatedByUserID = CurrentUserName.CurrentUserID;

            if (newLicence.AddNewLocalLicences())
            {
                MessageBox.Show("Licence Replaced successfully.");
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
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (licences != null)
            {
                if (AddNewApplication())
                {
                    if (AddNewLicense())
                    {
                        if (DisableOldLicense())
                        {
                            btnIssue.Enabled = false;
                            groupBox1.Enabled = false;
                            likNewLicenseInfo.Enabled = true;
                            labNewLicenseID.Text = newLicence.LicenceID.ToString();
                            labApplicationID.Text = application.ApplicationID.ToString();
                        }

                    }


                }
            }
        }

        private void likNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInfoOfLocalLicences frm = new frmShowInfoOfLocalLicences(newLicence.LicenceID);
            frm.ShowDialog();
        }
    }
}