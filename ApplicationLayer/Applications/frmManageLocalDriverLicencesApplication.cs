using ApplicationLayer.Licences;
using ApplicationLayer.Test;
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

namespace ApplicationLayer.Applications
{
    public partial class frmManageLocalDriverLicencesApplication : Form
    {

        public frmManageLocalDriverLicencesApplication()
        {
            InitializeComponent();
        }
        private void RefrshDataGridView()
        {
            dgvManagmentLocalLicences.DataSource = DataBuessinesLayer.clsLocalLicence.GetDataOfLocalDriverLicencesApplications();
        }
        private void frmManageLocalDriverLicencesApplication_Load(object sender, EventArgs e)
        {
            RefrshDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingApplication frmAddNewLocalDrivingApplication = new frmAddNewLocalDrivingApplication(Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value));
            frmAddNewLocalDrivingApplication.StartPosition = FormStartPosition.Manual;
            frmAddNewLocalDrivingApplication.Location = new Point(
                this.Location.X + (this.Width - frmAddNewLocalDrivingApplication.Width) / 2,
                this.Location.Y + (this.Height - frmAddNewLocalDrivingApplication.Height) / 2 + 50
            );
            frmAddNewLocalDrivingApplication.ShowDialog();
            RefrshDataGridView();
        }

        private void canelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalLicence.CancelApplicationStatusByLocalappID(Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value));
            MessageBox.Show("Application cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvManagmentLocalLicences.DataSource = DataBuessinesLayer.clsLocalLicence.GetDataOfLocalDriverLicencesApplications();

        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalLicence.DeleteApplicationStatusByLocalappID(Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value));
            MessageBox.Show("Application cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingApplication frmAddNewLocalDrivingApplication = new frmAddNewLocalDrivingApplication();
            frmAddNewLocalDrivingApplication.StartPosition = FormStartPosition.Manual;
            frmAddNewLocalDrivingApplication.Location = new Point(
                this.Location.X + (this.Width - frmAddNewLocalDrivingApplication.Width) / 2,
                this.Location.Y + (this.Height - frmAddNewLocalDrivingApplication.Height) / 2 + 50
            );
            frmAddNewLocalDrivingApplication.ShowDialog();
            RefrshDataGridView();

        }

        private void showApplicatoinsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DlAppID = Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value);
            frmShowApplicatonsLicencesDetails frmShowApplicatonsLicencesDetails = new frmShowApplicatonsLicencesDetails(DlAppID, clsLocalLicence.FindLocalLicencesDetails(DlAppID).ApplicationID);
            frmShowApplicatonsLicencesDetails.StartPosition = FormStartPosition.Manual;
            frmShowApplicatonsLicencesDetails.Location = new Point(
                this.Location.X + (this.Width - frmShowApplicatonsLicencesDetails.Width) / 2,
                this.Location.Y + (this.Height - frmShowApplicatonsLicencesDetails.Height) / 2 + 50
            );
            frmShowApplicatonsLicencesDetails.ShowDialog();
            RefrshDataGridView();
        }

        private void schduleTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void EnableLicencesFunctions(string status)
        {
            if (status == "Completed")
            {
                schduleTestToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                canelApplicationToolStripMenuItem.Enabled = false;
                showApplicatoinsDetailsToolStripMenuItem.Enabled = true;
                showPersonLicencesHistoryToolStripMenuItem.Enabled = true;
                showLicencesToolStripMenuItem.Enabled = true;
                schduleTestToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;

            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var drv = dgvManagmentLocalLicences.CurrentRow?.DataBoundItem as DataRowView;
            if (drv == null)
            {
                e.Cancel = true;
                return;
            }

            string status = Convert.ToString(drv["Status"]);
            int passedTests = drv["PassedTests"] == DBNull.Value ? 0 : Convert.ToInt32(drv["PassedTests"]);
            bool isLocked = status == "Canceled" || status == "Completed";

            EnableGeneralMenuItems(!isLocked);
            EnableTestSchedulingItems(!isLocked, passedTests);
            EnableLicencesFunctions(status);
        }

        private void EnableGeneralMenuItems(bool isEditable)
        {
            schduleTestToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = isEditable;
            canelApplicationToolStripMenuItem.Enabled = isEditable;
            showApplicatoinsDetailsToolStripMenuItem.Enabled = true;
            showPersonLicencesHistoryToolStripMenuItem.Enabled = true;
            showLicencesToolStripMenuItem.Enabled = false;
            issueToolStripMenuItem.Enabled = false;

        }

        private void EnableTestSchedulingItems(bool isEditable, int passedTests)
        {
            schduleVisonTestToolStripMenuItem.Enabled = false;
            schduleWrittenTestToolStripMenuItem.Enabled = false;
            schduleStreetTestToolStripMenuItem.Enabled = false;

            if (!isEditable) return;

            switch (passedTests)
            {
                case 0:
                    schduleVisonTestToolStripMenuItem.Enabled = true;
                    break;
                case 1:
                    schduleWrittenTestToolStripMenuItem.Enabled = true;
                    break;
                case 2:
                    schduleStreetTestToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    issueToolStripMenuItem.Enabled = true;
                    break;
            }
        }

        private void schduleVisonTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestListAppointments frmVisonTest = new frmTestListAppointments(
                  Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value),
                  clsTestAppointment.TestType.Vision
              );
            frmVisonTest.StartPosition = FormStartPosition.Manual;
            frmVisonTest.Location = new Point(
                this.Location.X + (this.Width - frmVisonTest.Width) / 2,
                this.Location.Y + (this.Height - frmVisonTest.Height) / 2 + 50
            );
            frmVisonTest.ShowDialog();
            RefrshDataGridView();

        }

        private void schduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestListAppointments frmVisonTest = new frmTestListAppointments(
                Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value),
                clsTestAppointment.TestType.Writing
            );
            frmVisonTest.StartPosition = FormStartPosition.Manual;
            frmVisonTest.Location = new Point(
                this.Location.X + (this.Width - frmVisonTest.Width) / 2,
                this.Location.Y + (this.Height - frmVisonTest.Height) / 2 + 50
            );
            frmVisonTest.ShowDialog();
            RefrshDataGridView();
        }

        private void schduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestListAppointments frmVisonTest = new frmTestListAppointments(
                Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value),
                clsTestAppointment.TestType.Street
            );
            frmVisonTest.StartPosition = FormStartPosition.Manual;
            frmVisonTest.Location = new Point(
                this.Location.X + (this.Width - frmVisonTest.Width) / 2,
                this.Location.Y + (this.Height - frmVisonTest.Height) / 2 + 50
            );
            frmVisonTest.ShowDialog();
            RefrshDataGridView();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLicenceFirstTime frmAddLicenceFirstTime = new frmAddLicenceFirstTime(Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value));
            frmAddLicenceFirstTime.StartPosition = FormStartPosition.Manual;
            frmAddLicenceFirstTime.Location = new Point(
                this.Location.X + (this.Width - frmAddLicenceFirstTime.Width) / 2,
                this.Location.Y + (this.Height - frmAddLicenceFirstTime.Height) / 2 + 50
            );
            frmAddLicenceFirstTime.ShowDialog();
            RefrshDataGridView();

        }

        private void showLicencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
         int AppID=clsLocalLicence.FindLocalLicencesDetails(Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value)).ApplicationID;
          clsLicences licence = clsLicences.GetLicencesByApplicationID(AppID);
            frmShowInfoOfLocalLicences frmShowInfoOfLocalLicences = new frmShowInfoOfLocalLicences(licence.LicenceID);
            frmShowInfoOfLocalLicences.StartPosition = FormStartPosition.Manual;
            frmShowInfoOfLocalLicences.Location = new Point(
                this.Location.X + (this.Width - frmShowInfoOfLocalLicences.Width) / 2,
                this.Location.Y + (this.Height - frmShowInfoOfLocalLicences.Height) / 2 + 50
            );
            frmShowInfoOfLocalLicences.ShowDialog();
            RefrshDataGridView();
        }

        private void showPersonLicencesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalLicence localLicence=clsLocalLicence.FindLocalLicencesDetails(Convert.ToInt32(dgvManagmentLocalLicences.CurrentRow.Cells[0].Value));
            int PersonID = localLicence._application.ApplicantPersonID;
            frmShowLicencesHistory frmShowLicencesHistory = new frmShowLicencesHistory(PersonID);
            frmShowLicencesHistory.StartPosition = FormStartPosition.Manual;
            frmShowLicencesHistory.Location = new Point(
                this.Location.X + (this.Width - frmShowLicencesHistory.Width) / 2,
                this.Location.Y + (this.Height - frmShowLicencesHistory.Height) / 2 + 50
            );
            frmShowLicencesHistory.ShowDialog();
            RefrshDataGridView();
        }
    }
        }
