using ApplicationLayer.People;
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

namespace ApplicationLayer.Control
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        int _applicationID = -1;
        int PersonID = -1;
        clsApplications _application;
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private void ctrlApplicationBasicInfo_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(int applicationID)
        {
            _application = clsApplications.GetApplicationByID(applicationID);
            if (applicationID != -1)
            {
                PersonID = _application.ApplicantPersonID;
                _applicationID = applicationID;
                labAppID.Text = _application.ApplicationID.ToString();

                labDate.Text = _application.ApplicationDate.ToShortDateString();
                labType.Text = clsManagmentApplicationTypes.FindApplicationType(_application.ApplicationTypeID).ApplicationTypeTitle;
                DataTable dt = clsPeopel.GetPeoplebyPersonID(_application.ApplicantPersonID);
                labName.Text = dt.Rows.Count > 0 ? $"{dt.Rows[0]["FirstName"]} {dt.Rows[0]["SecondName"]} {dt.Rows[0]["ThirdName"]} {dt.Rows[0]["LastName"]}" : "Unknown Person";
                labStauts.Text = clsApplications.GetApplicationStatusName(_application.ApplicationStatus);
                labStatusDate.Text = _application.LastStatusDate.ToShortDateString();
                labFees.Text = _application.PaidFees.ToString("F2");
                labUser.Text = clsUsers.GetUserNameById(_application.CreatedByUserID);

            }
            else
            {
                MessageBox.Show("Invalid Application ID");

            }
        }

        private void likPersonDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowDetailsPerson frmShowPersonDetails = new ShowDetailsPerson(PersonID);
            frmShowPersonDetails.ShowDialog();

            LoadData(_applicationID);
        }
    }
}