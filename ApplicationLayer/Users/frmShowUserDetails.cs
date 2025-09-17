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
    public partial class frmShowUserDetails : Form
    {
        int _UserID;
        public frmShowUserDetails(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            showUserDetails1.LoadUserDetails(_UserID);
            ctrlShowPersonDetails1.LoadData(clsUsers.GetPersonIDfromUser(_UserID));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
