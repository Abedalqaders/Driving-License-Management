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
    public partial class frmShowInfoOfLocalLicences : Form
    {
        int licencesID = -1;
      
        public frmShowInfoOfLocalLicences(int licenceID)
        {
            InitializeComponent();
            this.licencesID = licenceID;


        }

        private void frmShowInfoOfLocalLicences_Load(object sender, EventArgs e)
        {
            ctrlDetails2.LoadDateByLicencesID(licencesID); 

        }

        private void ctrlGetDetailsOfLocalLicences1_Load(object sender, EventArgs e)
        {

        }
    }
}
