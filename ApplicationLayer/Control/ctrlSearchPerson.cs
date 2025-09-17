using ApplicationLayer.People;
using DataBuessinesLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace ApplicationLayer.Control
{
    public partial class ctrlSearchPerson : UserControl
    {
        private int _personID = -1;

        // ✅ Public property to expose PersonID
        public int SelectedPersonID => _personID;

        // ✅ Event to notify when a person is selected
        public event EventHandler<int> OnPersonSelected;

        public ctrlSearchPerson()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
        }

        private void Frm_DataBack(object sender, int personID)
        {
            _personID = personID;

            // ✅ Notify that a person was selected
            OnPersonSelected?.Invoke(this, _personID);
        }

        private void btnSearchperson_Click(object sender, EventArgs e)
        {
            FilterBy(txtboxFilter.Text.Trim());

            if (_personID != -1 && _personID != 0)
            {
                OnPersonSelected?.Invoke(this, _personID);
            }
            else
            {
                MessageBox.Show("No person found with the given criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FilterBy(string text)
        {
            // If no filter type is selected, hide the filter box and exit
            if (comboBox1.SelectedItem == null)
            {
                txtboxFilter.Visible = false;
                return;
            }

            // If the input text is empty, reset person ID and exit
            if (string.IsNullOrWhiteSpace(text))
            {
                _personID = -1;
                return;
            }

            string filter = comboBox1.SelectedItem.ToString();
            txtboxFilter.Visible = true;

            DataTable m = null;

            try
            {
                switch (filter)
                {
                    case "PersonID":
                        if (!int.TryParse(text, out int personId))
                        {
                            MessageBox.Show("Please enter a valid numeric Person ID.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            _personID = -1;
                            return;
                        }
                        m = clsPeopel.GetPeoplebyPersonID(personId);
                        break;

                    case "NationalID":
                        m = clsPeopel.GetPeoplebyNationalNo(text);
                        break;

                    case "FullName":
                        m = clsPeopel.GetPeoplebyName(text);
                        break;
                }

                if (m != null && m.Rows.Count > 0)
                {
                    _personID = Convert.ToInt32(m.Rows[0]["PersonID"]);
                }
                else
                {
                    MessageBox.Show($"No person found for the given {filter}.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _personID = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _personID = -1;
            }
        }
        private void ctrlSearchPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
