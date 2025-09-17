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
    public partial class ShowUserDetails : UserControl
    { clsUsers _User;
        public ShowUserDetails()
        {
            InitializeComponent();
        }
        public void LoadUserDetails(int UserID)
        {
           
            _User = DataBuessinesLayer.clsUsers.Find(UserID);
            if (_User != null)
            {
                labUserID.Text=_User._UserID.ToString();
                labUserName.Text = _User._UserName;
                labIsActive.Text = _User._IsActive ? "Active" : "Inactive";
            }
            else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
