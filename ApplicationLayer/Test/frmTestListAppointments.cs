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

namespace ApplicationLayer.Test
{
    public partial class frmTestListAppointments : Form
    {
        int DLappId = -1;
        int ApplicationID = -1;
        private clsTestAppointment.TestType _testtype;

        private void LoadPictureAndTittle()
        {
            switch(_testtype)
            {
                case clsTestAppointment.TestType.Vision:
                    this.Text = "Vision Test Appointment";
                    label1.Text = "Vision Test Appointment";
                    pictureBox1.Image = Properties.Resources.Vision_512;
                    break;
                case clsTestAppointment.TestType.Writing:
                    this.Text = "Writting Test Appointment";
                    label1.Text = "Writting Test Appointment";
                    pictureBox1.Image = Properties.Resources.Written_Test_512;
                    break;
                case clsTestAppointment.TestType.Street:
                    this.Text = "Street Test Appointment";
                    label1.Text = "Street Test Appointment";
                    pictureBox1.Image = Properties.Resources.driving_test_512;
                    break;
            }
        }
        public frmTestListAppointments(int DLappId,clsTestAppointment.TestType TestType)
        {
            InitializeComponent();
            this.DLappId = DLappId;
            ApplicationID = clsLocalLicence.FindLocalLicencesDetails(DLappId).ApplicationID;
            _testtype = TestType;
        }

      private  void RefreshPage()
        {
            LoadPictureAndTittle();
            ctrlLicencesApplication_and_ApplicatonInfo2.LoadData(DLappId, ApplicationID);
            dgvTestAppoitment.DataSource = clsTestAppointment.GetAllTestAppointments(_testtype, DLappId);
        }
        private void frmTestListAppointments_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void btnTestAppoitment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.IsThereActiveAppoitment((int)_testtype, DLappId))
            {
                MessageBox.Show("There is already an active appointment for this test type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            else
            {
                    if (clsTestAppointment.IamPassedTest((int)_testtype, DLappId))
                    {
                        MessageBox.Show("You are already pass the Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    frmAddEditTestAppoitment frm = new frmAddEditTestAppoitment(DLappId, _testtype);
                frm.ShowDialog();
                dgvTestAppoitment.DataSource = clsTestAppointment.GetAllTestAppointments(_testtype, DLappId);
            } }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditTestAppoitment frmAddEdit = new frmAddEditTestAppoitment(Convert.ToInt32(dgvTestAppoitment.CurrentRow.Cells[0].Value));
            frmAddEdit.ShowDialog();
            dgvTestAppoitment.DataSource = clsTestAppointment.GetAllTestAppointments(_testtype, DLappId);
            RefreshPage();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frmTakeTest = new frmTakeTest(Convert.ToInt32(dgvTestAppoitment.CurrentRow.Cells[0].Value));
            frmTakeTest.ShowDialog();
            dgvTestAppoitment.DataSource = clsTestAppointment.GetAllTestAppointments(_testtype, DLappId);
            RefreshPage();
        }
    }
}
