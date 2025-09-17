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

namespace ApplicationLayer.Licences
{
    public partial class frmShowLicencesHistory : Form
    {
        int LDLAppID = -1;
        clsLocalLicence _localLicence;
        int PersonID = -1;
        public frmShowLicencesHistory(int personID)
        {   InitializeComponent();
           this.PersonID = personID;

        }

        private void ctrlShowPersonDetails1_Load(object sender, EventArgs e)
        {

        }

        private void frmShowLicencesHistory_Load(object sender, EventArgs e)
        {   
            ctrlShowPersonDetails1.LoadData(PersonID);
            ctrlShowLicencesHistory1.LoadData(PersonID);
        }
    }
}
