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
    public partial class ctrlDrivingLicensepplicationinfo : UserControl
    {
        int DLappID = -1;
        public ctrlDrivingLicensepplicationinfo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ctrlDrivingLicensepplicationinfo_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(int DLappID)
        {
            this.DLappID = DLappID;
            labClassName.Text = clsLocalLicence.GetClassName(DLappID);
            labDlappID.Text = DLappID.ToString();
            labPassedTest.Text=clsLocalLicence.GetPassedTestCount(DLappID).ToString()+"/3";
        }
    }
}
