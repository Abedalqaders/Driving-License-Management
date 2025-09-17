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
    public partial class ctrlApplicationOfInterNationalLicences : UserControl
    {
        int InterNationalLicenceID = -1;
        clsInterNationalLIcences InterNationalLicences;
        public ctrlApplicationOfInterNationalLicences()
        {
            InitializeComponent();
        }

       

        private void ctrlApplicationOfInterNationalLicences_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(int InterNationalLicenceID)
        {
            this.InterNationalLicenceID = InterNationalLicenceID;
            InterNationalLicences = clsInterNationalLIcences.GetInternationalLicenseByID(InterNationalLicenceID);
            if (InterNationalLicences != null)
            {
                labAppID.Text = InterNationalLicences.ApplicationID.ToString();
                labLocalLicenseID.Text = InterNationalLicences.IssuedUsingLocalLicenseID.ToString();
                labIssueDate.Text = InterNationalLicences.IssueDate.ToShortDateString();
                labExprationDate.Text = InterNationalLicences.ExpirationDate.ToShortDateString();
                labappDate.Text = InterNationalLicences.Applications.ApplicationDate.ToShortDateString();
                labUserName.Text = InterNationalLicences.Users._UserName;
                labFees.Text = InterNationalLicences.Applications.PaidFees.ToString("C2");
                labILLicenseID.Text = InterNationalLicences.InternationalLicenseID.ToString();
            }
            else
            {
                MessageBox.Show("International Licence not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
