using ApplicationLayer.Users;
using DataBuessinesLayer;
using System;
using System.Data;
using System.Windows.Forms;
using static DataBuessinesLayer.clsLocalLicence;

namespace ApplicationLayer.Applications
{
    public partial class frmAddNewLocalDrivingApplication : Form
    {
        int PersonID = -1;
        int DLappID = -1;

        enum enMode { Add = 1, Update = 2 }
        enMode _Mode = enMode.Add;

        clsLocalLicence _locallicence;
      

        public frmAddNewLocalDrivingApplication()
        {
            InitializeComponent();
            ctrlSearchPerson1.OnPersonSelected += CtrlSearchPerson1_OnPersonSelected;
        }

        public frmAddNewLocalDrivingApplication(int DLappID)
        {
            InitializeComponent();
            this.DLappID = DLappID;
            _Mode = enMode.Update;
            ctrlSearchPerson1.OnPersonSelected += CtrlSearchPerson1_OnPersonSelected;
        }

        private void frmAddNewLocalDrivingApplication_Load(object sender, EventArgs e)
        {
            // Load license classes
            DataTable dt = clsLiceenseClass.GetLiceenseClass();
            cbLiceenseClass.DataSource = dt;
            cbLiceenseClass.DisplayMember = "ClassName";
            cbLiceenseClass.ValueMember = "LicenseClassID";
            cbLiceenseClass.SelectedIndex = -1;

            labDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            labDLappFees.Text = clsLocalLicence.FeesOfLocalLicence().ToString("0.00");
            labCreatedBy.Text = clsUsers.GetUserNameById(CurrentUserName.CurrentUserID);
            btnSave.Enabled = false;

            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            _locallicence = clsLocalLicence.FindLocalLicencesDetails(DLappID);
            if (_locallicence == null) return;

            if (_locallicence.LocalDrivingApplicationID != -1)
            {
                cbLiceenseClass.SelectedValue = _locallicence.LocalClassID;
                labDLappID.Text = _locallicence.LocalDrivingApplicationID.ToString();
            }

            

            if (_locallicence._application.ApplicantPersonID > 0)
            {
                PersonID = _locallicence._application.ApplicantPersonID;
                ctrlShowPersonDetails1.LoadData(PersonID);
                ctrlSearchPerson1.Enabled = false;
                labDate.Text = _locallicence._application.ApplicationDate.ToString("yyyy-MM-dd");
                labDLappFees.Text = _locallicence._application.PaidFees.ToString("0.00");
                labCreatedBy.Text = clsUsers.GetUserNameById(_locallicence._application.CreatedByUserID);
            }
        }

        private void CtrlSearchPerson1_OnPersonSelected(object sender, int personID)
        {
            PersonID = personID;
            ctrlShowPersonDetails1.LoadData(personID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.SelectedTab = tabPage2;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = tabControl1.SelectedTab == tabPage2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbLiceenseClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a license class.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedClassID = Convert.ToInt32(cbLiceenseClass.SelectedValue);

            // Prevent duplicate active license in same class
            if (clsLocalLicence.CheckIfPersonHasActiveLocalLicenceInSameClass(PersonID, selectedClassID)
                && _Mode == enMode.Add) // Only check for new apps
            {
                MessageBox.Show("This person already has an active license in the same class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(clsLicences.CheckIfPersonHasActiveLocalLicenceInSameClass(PersonID, selectedClassID))
            {
                MessageBox.Show("This person already has an active licence in the same class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.Add)
            {
                
                _locallicence = new clsLocalLicence();
                _locallicence._application = new clsApplications();

                _locallicence._application.ApplicantPersonID = PersonID;
                _locallicence._application.ApplicationDate = DateTime.Now;
                _locallicence._application.ApplicationTypeID = 1; // Local Application
                _locallicence._application.ApplicationStatus = (byte)enApplicationStatus.New;
                _locallicence._application.LastStatusDate = DateTime.Now;
                _locallicence._application.PaidFees = clsLocalLicence.FeesOfLocalLicence();
                _locallicence._application.CreatedByUserID = CurrentUserName.CurrentUserID;
            }
            else // Update
            {
                // Keep existing application object
                var oldStatus = _locallicence._application.ApplicationStatus;

                _locallicence._application.ApplicantPersonID = PersonID; // in case it was editable
                _locallicence._application.PaidFees = clsLocalLicence.FeesOfLocalLicence();

                // Update LastStatusDate only if status changes
                if (_locallicence._application.ApplicationStatus != oldStatus)
                {
                    _locallicence._application.LastStatusDate = DateTime.Now;
                }
            }

            // Save Application
            if (_locallicence._application.Save())
            {
                _locallicence.ApplicationID = _locallicence._application.ApplicationID;
                _locallicence.LocalClassID = selectedClassID;

                if (_locallicence.Save())
                {
                    MessageBox.Show("Local Driving Application saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.Update;
                    labDLappID.Text = _locallicence.LocalDrivingApplicationID.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to save the local licence record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to save the application record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
