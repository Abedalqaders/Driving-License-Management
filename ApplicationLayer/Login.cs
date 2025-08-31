using DataBuessinesLayer;
using System;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class Login : Form
    {
        public int UserId { get; private set; }

        int FaildLoginCount = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void DisableButtonForMinutes(Button button, int minutes)
        {
            button.Enabled = false;

            Timer timer = new Timer();
            timer.Interval = minutes * 60 * 1000; // Convert minutes to milliseconds

            timer.Tick += (s, e) =>
            {
                button.Enabled = true;
                timer.Stop();
                timer.Dispose();
            };

            timer.Start();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Load saved username and password (if any)
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                txtboxUserName.Text = Properties.Settings.Default.UserName;
                txtboxPassword.Text = Properties.Settings.Default.Password;
                chbRemberMe.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FaildLoginCount > 3)
            {
                MessageBox.Show("Login failed. Try again in 1 minute.");
                DisableButtonForMinutes(button1, 1); // Disable for 1 minute
                return;
            }

            string UserName = txtboxUserName.Text.Trim();
            string Password = txtboxPassword.Text.Trim();

            int UserId = clsUsers.CheckUserNameAndPassword(UserName, Password);

            if (UserId == -1)
            {
                MessageBox.Show("Invalid UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FaildLoginCount++;
            }
            else
            {
                if (clsUsers.IsActive(UserId))
                {
                    this.UserId = UserId;

                    // Save login info if "Remember me" is checked
                    if (chbRemberMe.Checked)
                    {
                        Properties.Settings.Default.UserName = txtboxUserName.Text;
                        Properties.Settings.Default.Password = txtboxPassword.Text;
                    }
                    else
                    {
                        Properties.Settings.Default.UserName = "";
                        Properties.Settings.Default.Password = "";
                    }

                    Properties.Settings.Default.Save();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The account is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();        // Click the login button
                e.SuppressKeyPress = true;     // Prevent the beep sound
            }
        }
    }
}
