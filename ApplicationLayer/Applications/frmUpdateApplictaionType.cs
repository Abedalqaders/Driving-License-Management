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
    public partial class frmUpdateApplictaionType : Form
    {
        int _ApplicationTypeID;
        clsManagmentApplicationTypes _App;
        public frmUpdateApplictaionType(int ApplicationTypeID)
        {
            InitializeComponent();
            this._ApplicationTypeID = ApplicationTypeID;
            
        }

        private void frmUpdateApplictaionType_Load(object sender, EventArgs e)
        {
            labID.Text = _ApplicationTypeID.ToString();
            _App= clsManagmentApplicationTypes.FindApplicationType(_ApplicationTypeID);
            if (_App != null)
            {
                tbTitle.Text = _App.ApplicationTypeTitle;
                tbFees.Text = _App.ApplicationFees.ToString();
            }
            else
            {
                MessageBox.Show("Application Type not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string applicationTypeTitle = tbTitle.Text.Trim();
            float applicationFees;
            if (float.TryParse(tbFees.Text, out applicationFees))
            {
                // تم التحويل بنجاح، استخدم applicationFees
            }
            else
            {
                MessageBox.Show("Just Enter float Number");
                return;
            }
            if (clsManagmentApplicationTypes.UpdateApplicationType(_ApplicationTypeID, applicationTypeTitle, applicationFees)){
                MessageBox.Show("Application Type Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Failed to Update Application Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
