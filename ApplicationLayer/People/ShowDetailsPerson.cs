using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer.People
{
    public partial class ShowDetailsPerson : Form
    {
        int _PersonID;
        public ShowDetailsPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void ShowDetailsPerson_Load(object sender, EventArgs e)
        {
            ctrlShowPersonDetails2.LoadData(_PersonID);
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
