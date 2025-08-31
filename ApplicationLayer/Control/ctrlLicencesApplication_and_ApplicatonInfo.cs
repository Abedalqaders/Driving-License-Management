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
    public partial class ctrlLicencesApplication_and_ApplicatonInfo : UserControl
    {
    
        public ctrlLicencesApplication_and_ApplicatonInfo()
        {
            InitializeComponent();
        }

        private void ctrlLicencesApplication_and_ApplicatonInfo_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(int DLAppID,int ApplicationID)
        {
            ctrlDrivingLicensepplicationinfo1.LoadData(DLAppID);
            ctrlApplicationBasicInfo1.LoadData(ApplicationID);
        }

        private void ctrlLicencesApplication_and_ApplicatonInfo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
