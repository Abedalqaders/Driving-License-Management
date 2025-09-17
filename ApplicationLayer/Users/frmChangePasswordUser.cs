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
    public partial class frmChangePasswordUser : Form
    {
        int UserID;
        public frmChangePasswordUser(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtbCurrentPassword.Text.Trim() ==clsUsers.GetPasswordOfUser(UserID))
            {
               if(txtbNewPassword.Text.Trim() == txtbConfirmPassword.Text.Trim())
                {
                    if (clsUsers.ChangePasswordforUser(UserID, txtbNewPassword.Text.Trim()))
                    {
                        MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to change password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("New password and confirmation do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void 
            _Load(object sender, EventArgs e)
        {

        }

        private void frmChangePasswordUser_Load(object sender, EventArgs e)
        {
         
            ctrlShowPersonpassword.LoadData(clsUsers.GetPersonIDfromUser(UserID));
            ctrlShowUserInfoPassword.LoadUserDetails(UserID);

        }
    }
}
