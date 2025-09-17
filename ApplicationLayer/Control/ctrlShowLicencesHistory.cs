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

namespace ApplicationLayer.Control
{
    public partial class ctrlShowLicencesHistory : UserControl
    {
        int PersonID = -1;
        public ctrlShowLicencesHistory()
        {
            InitializeComponent();
           
        }

        public void LoadData(int PersonID)
        {
           this.PersonID = PersonID;
          
            dgvLocal.DataSource = clsLocalLicence.GetLocalLicencesByID(PersonID);
        }
        private void tpInterNational_Click(object sender, EventArgs e)
        {
            dgvInterNational.DataSource = clsInterNationalLIcences.GetInterNationalLicecesForPerson(PersonID);
        }

        private void tpLocal_Click(object sender, EventArgs e)
        {
            dgvLocal.DataSource= clsLocalLicence.GetLocalLicencesByID(PersonID);
        }

        private void ctrlShowLicencesHistory_Load(object sender, EventArgs e)
        {
            
        }

        private void showLicencesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInfoOfLocalLicences frm = new frmShowInfoOfLocalLicences((int)dgvLocal.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
