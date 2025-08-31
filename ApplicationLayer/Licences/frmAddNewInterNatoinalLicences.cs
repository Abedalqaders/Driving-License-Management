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
using static System.Net.Mime.MediaTypeNames;

namespace ApplicationLayer.Licences
{

    public partial class frmAddNewInterNatoinalLicences : Form
    {
        int LicenceID = -1;
        int InterNationalLicenceID = -1;
        clsLicences licences;
        clsApplications InterNationalApplication;
        clsManagmentApplicationTypes InterNationalApplicationType;
        clsInterNationalLIcences InterNationalLicences;
        public frmAddNewInterNatoinalLicences()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewInterNatoinalLicences_Load(object sender, EventArgs e)
        {

        }
        private bool CheckIfLicenceIsVaildToBeInterNatoinal()
        {
            if (licences != null)
            {
                
                if (licences.LicenseClass == 3)
                {
                    if (clsLicences.enIsActive.Yes == (clsLicences.enIsActive)licences.IsActive)
                    {
                        if (!clsInterNationalLIcences.IsThereActiveInterNationalLicences(licences.LicenceID))
                        {
                            if (clsLicences.IsTheDateIsVaild(licences.LicenceID))
                            {
                                likLicencesHistory.Enabled = true;
                            return true;
                            }
                            else
                            {
                                MessageBox.Show("The Licence Is Expired Please Renew it", "Expired Licence", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                          
                        }
                        else
                        {
                            MessageBox.Show("There is active International Licence for this driver.", "No Active Licence", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected Licence is not Active.", "Invalid Licence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("The selected licence is not an Ordinartiy.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No licence found with the provided ID.", "Licence Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked(int obj)
        {
            int LicenceID = obj;
            licences = clsLicences.GetLicencesByID(LicenceID);
            if (CheckIfLicenceIsVaildToBeInterNatoinal())
            {
                ctrlShowLocalLicencesDetailsWithFilter1.LoadData(LicenceID);
                btnIssue.Enabled = true;

            }


        }

        private void ctrlShowLocalLicencesDetailsWithFilter1_Load(object sender, EventArgs e)
        {

        }
        private void GetTypeOfInterNatoinal()
        {
            var types = clsManagmentApplicationTypes.GetApplicationTypesWithList();
            var international = types.FirstOrDefault(t => t.ApplicationTypeTitle == "New International License");
            if (international != null)
            {

                InterNationalApplicationType = clsManagmentApplicationTypes.FindApplicationType(international.ApplicationTypeID);
            }
        }

        private bool AddApplication()
        {
            GetTypeOfInterNatoinal();
            InterNationalApplication = new clsApplications();
            InterNationalApplication.ApplicantPersonID = licences.Drivers.PersonID;
            InterNationalApplication.ApplicationDate = DateTime.Now;
            InterNationalApplication.LastStatusDate = DateTime.Now;
            InterNationalApplication.PaidFees = InterNationalApplicationType.ApplicationFees;
            InterNationalApplication.ApplicationTypeID = InterNationalApplicationType.ApplicationTypeID;
            InterNationalApplication.CreatedByUserID = CurrentUserName.CurrentUserID;
            InterNationalApplication.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
            if (InterNationalApplication.Save())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Failed to save the International Licence application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private DateTime ExpairedDate()
        {
            return DateTime.Now.AddYears(1);
        }
        private bool AddInternatoinalLicences()
        {
            InterNationalLicences = new clsInterNationalLIcences();
            InterNationalLicences.ApplicationID = InterNationalApplication.ApplicationID;
            InterNationalLicences.DriverID = licences.DriverID;
            InterNationalLicences.IssuedUsingLocalLicenseID = licences.LicenceID;
            InterNationalLicences.IssueDate = DateTime.Now;
            InterNationalLicences.ExpirationDate = ExpairedDate();
            InterNationalLicences.IsActive = true;
            InterNationalLicences.CreatedByUserID = CurrentUserName.CurrentUserID;
            if (InterNationalLicences.Save())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void btnIssue_Click(object sender, EventArgs e)
        {

            if (AddApplication())
            {
                if (AddInternatoinalLicences())
                {
                    MessageBox.Show("International Licence issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlApplicationOfInterNationalLicences1.LoadData(InterNationalLicences.InternationalLicenseID);
                  btnIssue.Enabled = false;
                    likLicencesInfo.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Failed to issue the International Licence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to create the International Licence application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void likLicencesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicencesHistory frm = new frmShowLicencesHistory(licences.Drivers.PersonID);
            frm.ShowDialog();
        }

        private void likLicencesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(InterNationalLicences.InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
