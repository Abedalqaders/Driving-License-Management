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
    public partial class frmShowApplicatonsLicencesDetails : Form
    {
        int ApplicationID = -1;
        int DLAppID = -1;
        public frmShowApplicatonsLicencesDetails(int dLAppID, int applicationID)
        {
            InitializeComponent();
            ApplicationID = applicationID;
            DLAppID = dLAppID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowApplicatonsLicencesDetails_Load(object sender, EventArgs e)
        {
            ctrlLicencesApplication_and_ApplicatonInfo1.LoadData(DLAppID, ApplicationID);
        }
    }
}
