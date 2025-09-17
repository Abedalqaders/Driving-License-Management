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

namespace ApplicationLayer.Applications
{
    public partial class frmManageApplicationType : Form
    {
        public frmManageApplicationType()
        {
            InitializeComponent();
        }

        private void frmManageApplicationType_Load(object sender, EventArgs e)
        {
            dgvApplicationTypes.DataSource = clsManagmentApplicationTypes.GetApplicationTypes();
            labRecords.Text =  dgvApplicationTypes.Rows.Count.ToString();

        }

        private void updateApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplictaionType frm = new frmUpdateApplictaionType(Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            dgvApplicationTypes.DataSource = clsManagmentApplicationTypes.GetApplicationTypes();
        }
    }
}
