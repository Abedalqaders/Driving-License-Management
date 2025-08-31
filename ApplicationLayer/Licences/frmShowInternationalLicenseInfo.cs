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
    public partial class frmShowInternationalLicenseInfo : Form
    {
        int InternationalLicenceID = -1;
        public frmShowInternationalLicenseInfo(int InternationalLicenceID)
        {
            InitializeComponent();
            this.InternationalLicenceID = InternationalLicenceID;
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverInternationalLicenseInfo1.LoadInfo(InternationalLicenceID);
        }
    }
}
