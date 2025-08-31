using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataBuessinesLayer;
using System.IO;

namespace ApplicationLayer.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        private string SelectedFilePath = "";
        private string _oldImagePath = "";
        clsPeopel _Person;
        string folderPath = "C:\\Images";

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _ResetDefualtValues()
        {
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPeopel();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            rbMale.Checked = true;
            pbPersonImage.Image = Properties.Resources.man_4086624;
            pbPersonImage.ImageLocation = null;
            llRemoveImage.Visible = false;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            lblPersonID.Text = "";
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void _FillCountriesInComoboBox()
        {
            cbCountry.Items.Clear();
            DataTable dtCountries = clsCountries.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"].ToString());
            }
        }

        private void _LoadData()
        {
            _Person = clsPeopel.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            _oldImagePath = _Person.ImagePath;

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;

            if (_Person.DateOfBirth >= dtpDateOfBirth.MinDate && _Person.DateOfBirth <= dtpDateOfBirth.MaxDate)
            {
                dtpDateOfBirth.Value = _Person.DateOfBirth;
            }
            else
            {
                dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            }

            rbMale.Checked = !_Person.Gendor;
            rbFemale.Checked = _Person.Gendor;

            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;

            DataTable dtCountries = clsCountries.GetAllCountries();
            string countryName = "";
            foreach (DataRow row in dtCountries.Rows)
            {
                if (Convert.ToInt32(row["CountryID"]) == _Person.NationalityCountryID)
                {
                    countryName = row["CountryName"].ToString();
                    break;
                }
            }
            cbCountry.SelectedIndex = cbCountry.FindString(countryName);

            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                llRemoveImage.Visible = true;
            }
            else
            {
                pbPersonImage.ImageLocation = null;
                pbPersonImage.Image = rbMale.Checked ? Properties.Resources.man_4086624 : Properties.Resources.woman_4086693;
                llRemoveImage.Visible = false;
            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        public bool CheckNatonalID(string NatonalNo)
        {
            if (_Mode == enMode.Update && _Person.NationalNo == NatonalNo)
                return true;

            return !clsPeopel.NatonalNoIsExist(NatonalNo);
        }

        private bool CheckEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool CheckPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return true;

            foreach (char c in phone)
            {
                if (!char.IsDigit(c) && c != '+' && c != '-' && c != ' ')
                    return false;
            }
            return true;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Properties.Resources.woman_4086693;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Properties.Resources.man_4086624;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "اختر صورة";
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                llRemoveImage.Visible = true;
                SelectedFilePath = ofd.FileName;

                // Load image without locking the file
                using (var img = Image.FromFile(SelectedFilePath))
                {
                    pbPersonImage.Image = new Bitmap(img);
                }
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.Image?.Dispose();
            pbPersonImage.Image = null;
            llRemoveImage.Visible = false;

            SelectedFilePath = ""; // إلغاء اختيار الصورة الجديدة
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _PersonID);
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // تحقق من صحة البيانات
            if (!CheckNatonalID(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "This National ID already exists.");
                return;
            }

            if (!CheckEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Invalid email format.");
                return;
            }

            if (!CheckPhone(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Invalid phone number format.");
                return;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtSecondName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First Name and Last Name are required.");
                return;
            }

            if (cbCountry.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbCountry, "Please select a country.");
                return;
            }

            // تعيين قيم الكائن _Person
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gendor = rbFemale.Checked;
            _Person.Address = txtAddress.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.NationalityCountryID = clsCountries.GetAllCountries().Rows[cbCountry.SelectedIndex].Field<int>("CountryID");

            // فك القفل عن صورة PictureBox لو موجودة
            if (pbPersonImage.Image != null)
            {
                pbPersonImage.Image.Dispose();
                pbPersonImage.Image = null;
            }

            if (!string.IsNullOrEmpty(SelectedFilePath))
            {
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string newFileName = Path.Combine(folderPath, Guid.NewGuid().ToString() + Path.GetExtension(SelectedFilePath));

                // نسخ الصورة الجديدة
                File.Copy(SelectedFilePath, newFileName, true);

                // تحميل نسخة من الصورة لتجنب القفل
                using (var img = Image.FromFile(newFileName))
                {
                    pbPersonImage.Image = new Bitmap(img);
                }

                // حفظ مسار الصورة الجديدة
                _Person.ImagePath = newFileName;

                // حذف الصورة القديمة بأمان لو كانت موجودة ومسارها مختلف
                if (!string.IsNullOrEmpty(_oldImagePath) && _oldImagePath != newFileName && File.Exists(_oldImagePath))
                {
                    try
                    {
                        File.Delete(_oldImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting old image: " + ex.Message);
                    }
                }

                _oldImagePath = newFileName; // تحديث مسار الصورة القديمة
            }
            else
            {
                // إذا ما في صورة جديدة، لا تغير الصورة القديمة ولا تحذفها
                // فقط خليك محافظ على الصورة أو إفرغ الـ PictureBox إذا بدك
                pbPersonImage.Image = null; // أو اترك الصورة كما هي حسب حاجتك
            }

            // حفظ الكائن
            if (_Person.Save())
            {
                _PersonID = _Person.PersonID;
                _Mode = enMode.Update;
                lblPersonID.Text = _PersonID.ToString();
                lblTitle.Text = "Update Person";

                MessageBox.Show("Person saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
