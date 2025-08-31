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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ApplicationLayer.Licences
{
    public partial class frmDetainedLicense : Form
    {
        int LicenceID = -1;
        clsLicences licences;
        clsDetainedLicense detainedLicense;
        
        public frmDetainedLicense()
        {
            InitializeComponent();
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
            labLicenseID.Text = licences.LicenceID.ToString();
            labUserName.Text = clsUsers.GetUserNameById(CurrentUserName.CurrentUserID);
            labDetainDate.Text = DateTime.Now.ToString();
            ctrlShowLocalLicencesDetailsWithFilter1.LoadData(LicenceID);

            if (licences.IsActive == (byte)clsLicences.enIsActive.No)
            {
                MessageBox.Show("This licence is inactive and cannot be detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(clsDetainedLicense.IsLicenseDetained(licences.LicenceID))
            {
                MessageBox.Show("This licence is detained and cannot be detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnDetain.Enabled = true;


        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void RestTheData()
        {
            labLicenseID.Text = "0";
            labUserName.Text = "N/A";
            labDetainDate.Text = "N/A";
            likLicenseHistory.Enabled = false;
            btnDetain.Enabled = false;
            likNewLicenseInfo.Enabled = false;
        }
        private void frmDetainedLicense_Load(object sender, EventArgs e)
        {
            RestTheData();
        }

        private void ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked(int obj)
        {
            LicenceID = obj;
            CheckValdaiteLicences();
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
        private bool DisableLicense()
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
        private void btnDetain_Click(object sender, EventArgs e)
        {
            detainedLicense = new clsDetainedLicense();
            detainedLicense.LicenseID = licences.LicenceID;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = Convert.ToDecimal(tbFineFees.Text);
            detainedLicense.CreatedByUserID = CurrentUserName.CurrentUserID;
            detainedLicense.IsReleased = 0;
            if (detainedLicense.Save())
            {
                if (DisableLicense())
                {
                    btnDetain.Enabled = false;
                    likNewLicenseInfo.Enabled = true;
                    labDetainID.Text = detainedLicense.DetainID.ToString();
                }
                MessageBox.Show("Licence detained successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Error occurred while detaining the licence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
