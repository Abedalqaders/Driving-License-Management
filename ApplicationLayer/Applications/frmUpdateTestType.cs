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
    public partial class frmUpdateTestType : Form
    {
        int TestTypeID;
        clsManagmentTestTypes _Test;
        public frmUpdateTestType(int TestTypeID)
        {
            this.TestTypeID = TestTypeID;
            InitializeComponent();

        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            labID.Text = TestTypeID.ToString();
            _Test = clsManagmentTestTypes.FindTestType(TestTypeID);
            if (_Test != null)
            {
                tbTitle.Text = _Test.TestTypeTitle;
                tbdescription.Text = _Test.TestTypeDescription;
                tbFees.Text = _Test.TestFees.ToString();
            }
            else
            {
                MessageBox.Show("Application Type not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string TestTypeTitle = tbTitle.Text.Trim();
            string TestTypeDescrption = tbdescription.Text.Trim();
            float TestFees;
            if (float.TryParse(tbFees.Text, out TestFees))
            {
                // تم التحويل بنجاح، استخدم applicationFees
            }
            else
            {
                MessageBox.Show("Just Enter float Number");
                return;
            }
            if (clsManagmentTestTypes.UpdateTestTypes(TestTypeID,TestTypeTitle,TestTypeDescrption,TestFees))
            {
                MessageBox.Show("Test Type Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed to Update Test Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
