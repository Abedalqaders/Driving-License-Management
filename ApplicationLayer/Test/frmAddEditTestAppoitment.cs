using ApplicationLayer.Control;
using DataBuessinesLayer;
using System;
using System.Windows.Forms;
using static DataBuessinesLayer.clsTestAppointment;

namespace ApplicationLayer.Test
{
    public partial class frmAddEditTestAppoitment : Form
    {
        private int _dlAppId = -1;
        private clsTestAppointment.TestType _testType;
        private clsLocalLicence _localLicence;
        private int TestAppoitmentID = -1;
        private enum enMode { Add, Update }
        private enMode _mode = enMode.Add;
        public frmAddEditTestAppoitment(int dlAppId, clsTestAppointment.TestType testType)
        {
            InitializeComponent();
            _dlAppId = dlAppId;
            _testType = testType;
            _mode = enMode.Add;
        }

        // Update mode
        public frmAddEditTestAppoitment(int testAppoitmentID)
        {
            InitializeComponent();
            TestAppoitmentID = testAppoitmentID;
            _mode = enMode.Update;
        }

        private void frmAddEditTestAppoitment_Load(object sender, EventArgs e)
        {
            UserControl ctrlTestAppointment;

            if (_mode == enMode.Add)
            {
                ctrlTestAppointment = new ctrlAddUpdateTestAppoitment(_dlAppId, _testType);
            }
            else // Update mode
            {
                ctrlTestAppointment = new ctrlAddUpdateTestAppoitment(TestAppoitmentID);
            }

            ctrlTestAppointment.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(ctrlTestAppointment);

        }

       
    }
}
