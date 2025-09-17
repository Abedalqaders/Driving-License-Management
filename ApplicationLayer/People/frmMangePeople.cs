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

namespace ApplicationLayer.People
{
    public partial class frmMangePeople : Form
    {
        public frmMangePeople()
        {
            InitializeComponent();
        }

        private void frmMangePeople_Load(object sender, EventArgs e)
        {
            dgvMangePeople.DataSource = clsPeopel.GetAllPeople();
            labNumberofPeople.Text=clsPeopel.GetNumberOfPeople().ToString();

        }
        void FilterBy(string text)
        {
            if (comboBox1.SelectedItem == null )
            {
                dgvMangePeople.DataSource = clsPeopel.GetAllPeople();
                txtboxFilter.Visible = false;
                return;
            }    
            string filter = comboBox1.SelectedItem.ToString();
            txtboxFilter.Visible = true;
            if (filter == "PersonID")
            {
                dgvMangePeople.DataSource = clsPeopel.GetPeoplebyPersonID(Convert.ToInt32(text));
            }
            else if (filter == "NationalID")
            {
                dgvMangePeople.DataSource = clsPeopel.GetPeoplebyNationalNo(text);
            }
            else if(filter == "Gendor")
            {
                dgvMangePeople.DataSource = clsPeopel.GetPeoplebyGendor(text);
            }
            else if (filter == "FullName")
            {
                dgvMangePeople.DataSource = clsPeopel.GetPeoplebyName(text);
            }
            if (string.IsNullOrWhiteSpace(text))
            {
                dgvMangePeople.DataSource = clsPeopel.GetAllPeople();
            }
          

         
        }
        private void RefreshDataGridView()
        {
            dgvMangePeople.DataSource = clsPeopel.GetAllPeople();
            labNumberofPeople.Text = clsPeopel.GetNumberOfPeople().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxFilter.Clear();
            txtboxFilter.Visible = true;
        }

        private void txtboxFilter_TextChanged(object sender, EventArgs e)
        {
            FilterBy(txtboxFilter.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDetailsPerson_Click(object sender, EventArgs e)
        {
            ShowDetailsPerson frm = new ShowDetailsPerson(Convert.ToInt32(dgvMangePeople.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            RefreshDataGridView();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPeopel.DeletePerson(Convert.ToInt32(dgvMangePeople.CurrentRow.Cells[0].Value));
            RefreshDataGridView();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            RefreshDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(Convert.ToInt32(dgvMangePeople.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
