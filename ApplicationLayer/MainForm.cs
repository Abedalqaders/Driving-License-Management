using ApplicationLayer.Applications;
using ApplicationLayer.Driver;
using ApplicationLayer.Licences;
using ApplicationLayer.People;
using ApplicationLayer.Users;
using DVLD.Applications.International_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApplicationLayer
{
    public partial class MainForm : Form
    {
        int _UserID;
        public MainForm(int UserID)
        {        
            InitializeComponent();
            _UserID = UserID;
            CurrentUserName.CurrentUserID = _UserID;
        }

        void ShowCurrentUserName()
        {
            string UserName = DataBuessinesLayer.clsUsers.GetUserNameById(_UserID);
            
            labUserName.Text = $"Current User: {UserName}";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCurrentUserName();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //frmMangePeople frm = new People.frmMangePeople();
            //frm.ShowDialog();
            frmMangePeople peopleForm = new frmMangePeople();
            peopleForm.StartPosition = FormStartPosition.Manual;
            peopleForm.Location = new Point(
                this.Location.X + (this.Width - peopleForm.Width) / 2,
                this.Location.Y + (this.Height - peopleForm.Height) / 2+50
            );
            peopleForm.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmUserMangment userform = new frmUserMangment();
            userform.StartPosition = FormStartPosition.Manual;
            userform.Location = new Point(
                this.Location.X + (this.Width - userform.Width) / 2,
                this.Location.Y + (this.Height - userform.Height) / 2 + 50
            );
            userform.ShowDialog();
        }

        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails userDetailsForm = new frmShowUserDetails(_UserID);
            userDetailsForm.StartPosition = FormStartPosition.Manual;
            userDetailsForm.Location = new Point(
                this.Location.X + (this.Width - userDetailsForm.Width) / 2,
                this.Location.Y + (this.Height - userDetailsForm.Height) / 2 + 50
            );
            userDetailsForm.ShowDialog();
        }

        private void changePasswToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePasswordUser frmChangePasswordUser = new frmChangePasswordUser(_UserID);
            frmChangePasswordUser.StartPosition = FormStartPosition.Manual;
            frmChangePasswordUser.Location = new Point(
                this.Location.X + (this.Width - frmChangePasswordUser.Width) / 2,
                this.Location.Y + (this.Height - frmChangePasswordUser.Height) / 2 + 50
            );
            frmChangePasswordUser.ShowDialog();

        }

        private void labUserName_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationType frmManageApplicationType = new frmManageApplicationType();
            frmManageApplicationType.StartPosition = FormStartPosition.Manual;
            frmManageApplicationType.Location = new Point(
                this.Location.X + (this.Width - frmManageApplicationType.Width) / 2,
                this.Location.Y + (this.Height - frmManageApplicationType.Height) / 2 + 50
            );
            frmManageApplicationType.ShowDialog();

        }

        private void mangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestType frmManageTestType = new frmManageTestType();
            frmManageTestType.StartPosition = FormStartPosition.Manual;
            frmManageTestType.Location = new Point(
                this.Location.X + (this.Width - frmManageTestType.Width) / 2,
                this.Location.Y + (this.Height - frmManageTestType.Height) / 2 + 50
            );
            frmManageTestType.ShowDialog();
        }

        private void drivingLicenessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
        

        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDriverLicencesApplication frmManageLocalDriverLicencesApplication = new frmManageLocalDriverLicencesApplication();
            frmManageLocalDriverLicencesApplication.StartPosition = FormStartPosition.Manual;
            frmManageLocalDriverLicencesApplication.Location = new Point(
                this.Location.X + (this.Width - frmManageLocalDriverLicencesApplication.Width) / 2,
                this.Location.Y + (this.Height - frmManageLocalDriverLicencesApplication.Height) / 2 + 50
            );
            frmManageLocalDriverLicencesApplication.ShowDialog();

        }

        private void licenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingApplication frmAddNewLocalDrivingApplication = new frmAddNewLocalDrivingApplication();
            frmAddNewLocalDrivingApplication.StartPosition = FormStartPosition.Manual;
            frmAddNewLocalDrivingApplication.Location = new Point(
                this.Location.X + (this.Width - frmAddNewLocalDrivingApplication.Width) / 2,
                this.Location.Y + (this.Height - frmAddNewLocalDrivingApplication.Height) / 2 + 50
            );
            frmAddNewLocalDrivingApplication.ShowDialog();
        }

        private void interNatonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewInterNatoinalLicences frmAddNewInterNatoinalLicences = new frmAddNewInterNatoinalLicences();
            frmAddNewInterNatoinalLicences.StartPosition = FormStartPosition.Manual;
            frmAddNewInterNatoinalLicences.Location = new Point(
                this.Location.X + (this.Width - frmAddNewInterNatoinalLicences.Width) / 2,
                this.Location.Y + (this.Height - frmAddNewInterNatoinalLicences.Height) / 2 + 50
            );
            frmAddNewInterNatoinalLicences.ShowDialog();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmMangmentDrivers frmMangmentDrivers = new frmMangmentDrivers();
            frmMangmentDrivers.StartPosition = FormStartPosition.Manual;
            frmMangmentDrivers.Location = new Point(
                this.Location.X + (this.Width - frmMangmentDrivers.Width) / 2,
                this.Location.Y + (this.Height - frmMangmentDrivers.Height) / 2 + 50
            );
            frmMangmentDrivers.ShowDialog();

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicesnseApplications frmListInternationalLicesnseApplications = new frmListInternationalLicesnseApplications();
            frmListInternationalLicesnseApplications.StartPosition = FormStartPosition.Manual;
            frmListInternationalLicesnseApplications.Location = new Point(
                this.Location.X + (this.Width - frmListInternationalLicesnseApplications.Width) / 2,
                this.Location.Y + (this.Height - frmListInternationalLicesnseApplications.Height) / 2 + 50
            );
            frmListInternationalLicesnseApplications.ShowDialog();

        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalLicnces frmRenewLocalLicnces = new frmRenewLocalLicnces();
            frmRenewLocalLicnces.StartPosition = FormStartPosition.Manual;
            frmRenewLocalLicnces.Location = new Point(
                this.Location.X + (this.Width - frmRenewLocalLicnces.Width) / 2,
                this.Location.Y + (this.Height - frmRenewLocalLicnces.Height) / 2 + 50
            );
            frmRenewLocalLicnces.ShowDialog();
        }

        private void replacmentForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementforDamagedorLost_Licenses frm = new frmReplacementforDamagedorLost_Licenses();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(
                this.Location.X + (this.Width - frm.Width) / 2,
                this.Location.Y + (this.Height - frm.Height) / 2 + 50
            );
            frm.ShowDialog();

        }

        private void detaiendLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainedLicense frm= new frmDetainedLicense();
             frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(
                this.Location.X + (this.Width - frm.Width) / 2,
                this.Location.Y + (this.Height - frm.Height) / 2 + 50
                );
            frm.ShowDialog();
        }

        private void relasedDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelaseDetainLicense frm = new frmRelaseDetainLicense();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(
                this.Location.X + (this.Width - frm.Width) / 2,
                this.Location.Y + (this.Height - frm.Height) / 2 + 50
                );
            frm.ShowDialog();
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMangmentDetainedLicense frm = new frmMangmentDetainedLicense();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(
                this.Location.X + (this.Width - frm.Width) / 2,
                this.Location.Y + (this.Height - frm.Height) / 2 + 50
                );
            frm.ShowDialog();

        }

        private void relaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainedLicense frm = new frmDetainedLicense();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(
                this.Location.X + (this.Width - frm.Width) / 2,
                this.Location.Y + (this.Height - frm.Height) / 2 + 50
                );
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDriverLicencesApplication frmManageLocalDriverLicencesApplication = new frmManageLocalDriverLicencesApplication();
            frmManageLocalDriverLicencesApplication.StartPosition = FormStartPosition.Manual;
            frmManageLocalDriverLicencesApplication.Location = new Point(
                this.Location.X + (this.Width - frmManageLocalDriverLicencesApplication.Width) / 2,
                this.Location.Y + (this.Height - frmManageLocalDriverLicencesApplication.Height) / 2 + 50
            );
            frmManageLocalDriverLicencesApplication.ShowDialog();
        }
    }
}
