using ApplicationLayer.People;
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
    public partial class frmMangmentDetainedLicense : Form
    {
        public frmMangmentDetainedLicense()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
           
            dgvDetained.DataSource = DataBuessinesLayer.clsDetainedLicense.GetDataOfDetainedClass();
        }
        private void frmMangmentDetainedLicense_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRelesed_Click(object sender, EventArgs e)
        {
            frmRelaseDetainLicense frm = new frmRelaseDetainLicense();
            frm.ShowDialog();
            RefreshData();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainedLicense frm = new frmDetainedLicense();
            frm.ShowDialog();
            RefreshData();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvDetained.CurrentRow.Cells[1].Value);
            clsLicences license =clsLicences.GetLicencesByID(LicenseID);
            int personID = license._Applications.ApplicantPersonID;
            ShowDetailsPerson frm = new ShowDetailsPerson(personID);
            frm.ShowDialog();
            RefreshData();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvDetained.CurrentRow.Cells[1].Value);
            frmShowInfoOfLocalLicences frm = new frmShowInfoOfLocalLicences(LicenseID);
            frm.ShowDialog();
            RefreshData();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvDetained.CurrentRow.Cells[1].Value);
            clsLicences license = clsLicences.GetLicencesByID(LicenseID);
            int personID = license._Applications.ApplicantPersonID;
            frmShowLicencesHistory frm = new frmShowLicencesHistory(personID);
            frm.ShowDialog();
            RefreshData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt16(dgvDetained.CurrentRow.Cells[3].Value) == 0)
            {
                relasedDetainedLicenesToolStripMenuItem.Enabled = true;
            }
            else
            {
                relasedDetainedLicenesToolStripMenuItem.Enabled = false;
            }
        }

        private void relasedDetainedLicenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvDetained.CurrentRow.Cells[1].Value);
            frmRelaseDetainLicense frm = new frmRelaseDetainLicense(LicenseID);
            frm.ShowDialog();
            RefreshData();
        }
    }
}
