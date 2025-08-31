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
    public partial class ctrlShowLocalLicencesDetailsWithFilter : UserControl
    {
        public event Action<int> OnFilterClicked;

        int _LicenceID =-1;
        protected virtual void RaiseOnFilterClicked(int LicenceID)
        {
            Action<int> handler = OnFilterClicked;
            if (handler != null)
            {
                handler(LicenceID);
            }
        }
           
        
        public ctrlShowLocalLicencesDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void Filter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbLicenceID.Text) && int.TryParse(tbLicenceID.Text, out _LicenceID))
            {
                RaiseOnFilterClicked(_LicenceID);
            }
            else
            {
                MessageBox.Show("Please enter a valid Licence ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
        public void LoadData(int LicenceID)
        {
            ctrlGetDetailsOfLocalLicences1.LoadDateByLicencesID(LicenceID);
        }
        public void LoadDataWithoutSearch (int LicenceID)
        {
            tbLicenceID.Enabled = false;
            btnFilter.Enabled = false;

            ctrlGetDetailsOfLocalLicences1.LoadDateByLicencesID(LicenceID);
        }
        private void ctrlShowLocalLicencesDetailsWithFilter_Load(object sender, EventArgs e)
        {
            
        }
    }
}
