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
    public partial class frmManageTestType : Form
    {
        public frmManageTestType()
        {
            InitializeComponent();
        }

        private void frmManageTestType_Load(object sender, EventArgs e)
        {
            dgvTestTypes.DataSource = DataBuessinesLayer.clsManagmentTestTypes.GetTestTypes();
            labRecords.Text=dgvTestTypes.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType(Convert.ToInt32(dgvTestTypes.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            dgvTestTypes.DataSource = DataBuessinesLayer.clsManagmentTestTypes.GetTestTypes();

        }
    }
}
