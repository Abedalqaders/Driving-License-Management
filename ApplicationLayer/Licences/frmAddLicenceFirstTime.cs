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
    public partial class frmAddLicenceFirstTime : Form
    {
        int DLappId = -1;
        int DriverID = -1;
        clsApplications _application;
        clsLicences _licence;
        clsLocalLicence _localLicence;
        public frmAddLicenceFirstTime(int dLappId)
        {
            InitializeComponent();
            DLappId = dLappId;
        }

        private void frmAddLicenceFirstTime_Load(object sender, EventArgs e)
        {
            ctrlLicencesApplication_and_ApplicatonInfo1.LoadData(DLappId, DataBuessinesLayer.clsLocalLicence.FindLocalLicencesDetails(DLappId).ApplicationID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool GetDataOfLocalLicenceDetails(int DLappId)
        {
            _localLicence = clsLocalLicence.FindLocalLicencesDetails(DLappId);
            if (_localLicence != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No local licence details found for the given application ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool GetDataOfApplication()
        {
            _application = clsApplications.GetApplicationByID(
                DataBuessinesLayer.clsLocalLicence.FindLocalLicencesDetails(DLappId).ApplicationID
            );
            if (_application != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No application details found for the given application ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool AddNewDriver()
        {
            if (GetDataOfLocalLicenceDetails(DLappId) && GetDataOfApplication())
            {
                if (clsDrivers.GetDriverIDByPersonID(_application.ApplicantPersonID) > 0)
                {
                    DriverID = clsDrivers.GetDriverIDByPersonID(_application.ApplicantPersonID);

                }

                else
                {
                    DriverID = clsDrivers.AddNewDriver(_application.ApplicantPersonID, CurrentUserName.CurrentUserID, DateTime.Now);
                }

                if (DriverID > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to add new driver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void AddNewLicence()
        {
            _localLicence = clsLocalLicence.FindLocalLicencesDetails(DLappId);
            _licence = new clsLicences();
            _licence.ApplicationID = _localLicence.ApplicationID;
            _licence.DriverID = DriverID;
            _licence.LicenseClass = _localLicence._licencesclass.LiceenseClassID;
            _licence.IssueDate = DateTime.Now;
            _licence.ExpirationDate = DateTime.Now.AddYears(_localLicence._licencesclass.DefaultValidityLength);// Assuming a 5-year licence validity
            _licence.Notes = txtbNotes.Text;
            _licence.PaidFees = _localLicence._licencesclass.ClassFees;
            _licence.IsActive = (byte)clsLicences.enIsActive.Yes; // Assuming the licence is active upon creation
            _licence.IssueReason = (byte)clsLicences.enIssueReason.FirstTime; // Assuming this is a first-time licence issuance
            _licence.CreatedByUserID = CurrentUserName.CurrentUserID;
        }
        private bool UpdateApplicationStatusToApproved()
        {
           _application.ApplicationStatus = (byte)clsApplications.enApplicationStatus.Completed;
            _application.LastStatusDate = DateTime.Now;
            return _application.Save();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AddNewDriver()) {
                    AddNewLicence();
                    if (_licence.AddNewLocalLicences())
                    {
                        MessageBox.Show("New driver and licence added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Update the application status to 'Approved'
                        if (UpdateApplicationStatusToApproved())
                        {
                        this.Close();
                        return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new licence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            else
            {
                return;
            }


        } 
    }
}
