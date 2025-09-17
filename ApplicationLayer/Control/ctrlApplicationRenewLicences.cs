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

namespace ApplicationLayer.Control
{
    public partial class ctrlApplicationRenewLicences : UserControl
    {
        clsManagmentApplicationTypes ManagmentApplicationTypes;
        clsLiceenseClass LiceenseClass;
        clsLicences Licences;
        clsLicences NewLicences;
        
        public ctrlApplicationRenewLicences()
        {
            InitializeComponent();
        }

        private void ctrlApplicationRenewLicences_Load(object sender, EventArgs e)
        {
          ManagmentApplicationTypes=clsManagmentApplicationTypes.FindApplicationType(2);
            labApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labIssueDateLicences.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labCreatedByUser.Text = clsUsers.GetUserNameById(CurrentUserName.CurrentUserID).ToString();
            labAppFees.Text = ManagmentApplicationTypes.ApplicationFees.ToString("0.00");
        }
        public void LoadBasicData(int LicenseID)
        {
            Licences = clsLicences.GetLicencesByID(LicenseID);
            if (Licences != null)
            {
               LiceenseClass=clsLiceenseClass.GetLiceenseClassByID(Licences.LicenseClass);
                labTotalFees.Text = (Convert.ToDecimal(ManagmentApplicationTypes.ApplicationFees)+Licences.LiceenseClass.ClassFees).ToString();
                labOldLicenseID.Text = Licences.LicenceID.ToString();
                labExprationDate.Text = Licences.ExpirationDate.ToString("dd/MM/yyyy");
                labLicencesFees.Text = Licences.LiceenseClass.ClassFees.ToString("0.00");
            }
        }
        public void LoadNewLicences(int Newlicense)
        {
            if (Newlicense > 0)
            {
                NewLicences = clsLicences.GetLicencesByID(Newlicense);
                if (NewLicences != null)
                {
                    labRenewdLicencsID.Text = NewLicences.LicenceID.ToString();
                    labRLApplicationID.Text = NewLicences.ApplicationID.ToString();
              }
            }
        }
    }
}
