using ApplicationLayer.People;
using DataBuessinesLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace ApplicationLayer.Users
{
    public partial class frmAddUpdateUser : Form
    {
        int PersonID = -1;
        int UserID;
        clsUsers _User;
        enAddUpdate _Mode = enAddUpdate.Add;

        enum enAddUpdate
        {
            Add = 1,
            Update = 2
        }

        public frmAddUpdateUser()
        {
            InitializeComponent();
            InitializeForm();
        }

        public frmAddUpdateUser(int userID)
        {
            this.UserID = userID;
            _Mode = enAddUpdate.Update;
            InitializeComponent();
            InitializeForm(); // ✅ Ensure event gets wired up even in Update mode
        }

        private void InitializeForm()
        {
            ctrlSearchPerson1.OnPersonSelected += CtrlSearchPerson1_OnPersonSelected;
        }

        private void CtrlSearchPerson1_OnPersonSelected(object sender, int personID)
        {
            PersonID = personID; // ✅ Important: store the ID
            ctrlShowPerson.LoadData(personID);
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (_Mode == enAddUpdate.Add)
            {
                _User = new clsUsers();
                this.Text = "Add User";
                labTittle.Text = "Add New User";
                return;
            }

            // Load existing user data
            _User = clsUsers.Find(UserID);

            if (_User == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            PersonID = _User._PersonId;
            ctrlShowPerson.LoadData(PersonID);
            labUserID.Text = _User._UserID.ToString();
            txtbUserName.Text = _User._UserName;
            txtbPassword.Text = _User._Password;
            txtbConfirmPassword.Text = _User._Password;
            checkbActive.Checked = _User._IsActive;

            this.Text = "Update User";
            labTittle.Text = "Update User";
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
        }

        private void Frm_DataBack(object sender, int personID)
        {
            PersonID = personID;
            ctrlShowPerson.LoadData(PersonID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsUsers.IsUserExistsForPerson(PersonID) && _Mode == enAddUpdate.Add)
            {
                MessageBox.Show("This person already has a user account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.SelectedTab = tabPage2;
            tabControl1.Refresh();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage2 &&
                (PersonID <= 0 || (clsUsers.IsUserExistsForPerson(PersonID) && _Mode == enAddUpdate.Add)))
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateUserForm()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtbUserName.Text))
            {
                errorProvider1.SetError(txtbUserName, "User name is required.");
                isValid = false;
            }
            else if (txtbUserName.Text.Length < 4)
            {
                errorProvider1.SetError(txtbUserName, "User name must be at least 4 characters.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtbPassword.Text))
            {
                errorProvider1.SetError(txtbPassword, "Password is required.");
                isValid = false;
            }
            else if (txtbPassword.Text.Length < 6)
            {
                errorProvider1.SetError(txtbPassword, "Password must be at least 6 characters.");
                isValid = false;
            }

            if (txtbConfirmPassword.Text != txtbPassword.Text)
            {
                errorProvider1.SetError(txtbConfirmPassword, "Passwords do not match.");
                isValid = false;
            }

            if (PersonID <= 0)
            {
                errorProvider1.SetError(ctrlShowPerson, "Please select a person.");
                isValid = false;
            }

            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_User == null)
            {
                MessageBox.Show("User data is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateUserForm())
                return;

            _User._UserName = txtbUserName.Text.Trim();
            _User._Password = txtbPassword.Text.Trim();
            _User._PersonId = PersonID;
            _User._IsActive = checkbActive.Checked;

            if (_User.Save())
            {
                MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

                _Mode = enAddUpdate.Update;
                this.Text = "Update User";
                labTittle.Text = "Update User";
                labUserID.Text = _User._UserID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to save user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
