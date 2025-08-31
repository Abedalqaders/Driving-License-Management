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
using static DataBuessinesLayer.clsTestAppointment;
using static System.Net.Mime.MediaTypeNames;

namespace ApplicationLayer.Test
{
    public partial class frmTakeTest : Form
    {
        int TestAppointmentID = -1;
        clsTestAppointment _testappoitment;
        clsTest _test;
        clsLocalLicence _localLicence;
        clsApplications _application;
        
        public frmTakeTest(int testAppointmentID)
        {
            InitializeComponent();
            TestAppointmentID = testAppointmentID;
        }

        private void LoadPictureAndTitle()
        {
            if (_testappoitment == null)
                return;

            TestType testType = (TestType)_testappoitment.TestTypeID;

            switch (testType)
            {
                case TestType.Vision:
                    labTestType.Text = "Vision Test";
                    pictureBox1.Image = Properties.Resources.Vision_512;
                    break;

                case TestType.Writing:
                    labTestType.Text = "Writing Test";
                    pictureBox1.Image = Properties.Resources.Written_Test_512;
                    break;

                case TestType.Street:
                    labTestType.Text = "Street Test Appointment";
                    pictureBox1.Image = Properties.Resources.driving_test_512;
                    break;

                default:
                    labTestType.Text = "Unknown Test Type";
                    pictureBox1.Image = null;
                    break;
            }
        }

private void fillData()
{
    labDLAppID.Text = _localLicence.LocalDrivingApplicationID.ToString();
    labLicencesClass.Text = _localLicence._licencesclass.ClassName;
   
    labFullName.Text = _localLicence._application.Person.FullName();
    labFees.Text = _testappoitment.PaidFees.ToString();
    labDate.Text = _testappoitment.AppointmentDate.ToString("dd/MM/yyyy");
    labTrail.Text = Trail().ToString();
}

private int Trail()
{
    return clsTestAppointment.CountOfTrail(_testappoitment.TestAppointmentID, _testappoitment.TestTypeID);

}

private void LoadData()
{
           
            _testappoitment = clsTestAppointment.FindByTestAppoitmentID(TestAppointmentID);
            _localLicence = clsLocalLicence.FindLocalLicencesDetails(_testappoitment.LocalDrivingLicenseApplicationID);
        
        if (_localLicence == null)
        {
            MessageBox.Show("Local licence not found.");
            return;
        }
        else
        { 
            LoadPictureAndTitle();
            fillData();

        }
    }



private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to save the test results?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_testappoitment != null && _localLicence != null)
                {
                    _test = new clsTest();
                   _test.TestAppointmentID =TestAppointmentID;
                    _test.CreatedByUserID=CurrentUserName.CurrentUserID;
                    if(rbFailTest.Checked)
                    {
                        _test.TestResult = 0; // Fail
                    }
                    else if (rbPassTest.Checked)
                    {
                        _test.TestResult = 1; // Pass
                    }
                 _test.Note = txtNote.Text.Trim();
                    _test.TestID=_test.InsertTest();
                    if (_testappoitment!=null)
                    {
                        
                        if (clsTestAppointment.LockTestAppointment(TestAppointmentID)) {  
                            MessageBox.Show("Test results saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to save test results.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Test appointment or local licence not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
