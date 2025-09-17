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

namespace ApplicationLayer.Users
{
    public partial class frmUserMangment : Form
    {
        public frmUserMangment()
        {
            InitializeComponent();
        }
        public void Refersh()
        {
            dgvUsers.DataSource = DataBuessinesLayer.clsUsers.GetAllUsers();
        }
        private void frmUserMangment_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = DataBuessinesLayer.clsUsers.GetAllUsers();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.Show();
            Refersh();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.Show();
            Refersh();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CurrentUserName.CurrentUserID == Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("You cannot delete your own account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsUsers.DeleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            Refersh();
        }

        private void showDetiulsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.Show(); 

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.Show();
            Refersh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmChangePasswordUser frm = new frmChangePasswordUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.Show();
        }
    }
}
