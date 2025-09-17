using ApplicationLayer.Licences;
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

namespace ApplicationLayer.Driver
{
    public partial class frmMangmentDrivers : Form
    {
        public frmMangmentDrivers()
        {
            InitializeComponent();
        }

        private void frmMangmentDrivers_Load(object sender, EventArgs e)
        {
            dgvDrivers.DataSource = clsDrivers.GetDrivers();
        }

        private void personLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicencesHistory frm = new frmShowLicencesHistory(Convert.ToInt32(dgvDrivers.CurrentRow.Cells["PersonID"].Value));
            frm.ShowDialog();
        }
    }
}
