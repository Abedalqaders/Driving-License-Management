using ApplicationLayer.Users;
using DataBuessinesLayer;
using System;
using System.Data;
using System.Windows.Forms;
using static DataBuessinesLayer.clsTestAppointment;

namespace ApplicationLayer.Control
{
    public partial class ctrlAddUpdateTestAppoitment : UserControl
    {
        private int _dlAppId = -1;
        private int TestAppoitmentID = -1;

        private clsTestAppointment.TestType _testType;
        private clsLocalLicence _localLicence;
        private clsTestAppointment _testAppointment;
       
        private clsManagmentTestTypes _testTypes;
        private clsApplications _retakeapplication;

        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;

        public ctrlAddUpdateTestAppoitment()
        {
            InitializeComponent();
        }

        public ctrlAddUpdateTestAppoitment(int dlAppId, clsTestAppointment.TestType testType)
        {
            InitializeComponent();
            _dlAppId = dlAppId;
            _testType = testType;
            _Mode = enMode.Add;
        }

        public ctrlAddUpdateTestAppoitment(int testAppoitmentID)
        {
            InitializeComponent();
            this.TestAppoitmentID = testAppoitmentID;
            _Mode = enMode.Update;
        }

        private void ctrlAddUpdateTestAppoitment_Load(object sender, EventArgs e)
        {
            dtpTestDate.Value = DateTime.Today;
            LoadPictureAndTitle();
            LoadData();
        }

        private void LoadPictureAndTitle()
        {
            switch (_testType)
            {
                case TestType.Vision:
                    labTestType.Text = "Vision Test";
                    pictureBox1.Image = Properties.Resources.Vision_512;
                    break;

                case TestType.Writing:
                    labTestType.Text = "Writing Test";
                    pictureBox1.Image = Properties.Resources.Written_Test_512;
                    break;

                case TestType.Street:
                    labTestType.Text = "Street Test Appointment";
                    pictureBox1.Image = Properties.Resources.driving_test_512;
                    break;
            }
        }

        private void fillData()
        {
            labDLAppID.Text = _localLicence.LocalDrivingApplicationID.ToString();
            labLicencesClass.Text = clsLocalLicence.GetClassName(_localLicence.LocalDrivingApplicationID);
            _testTypes=clsManagmentTestTypes.FindTestType((int)_testType);

           
           labFullName.Text = _localLicence._application.Person.FullName();

            // رسوم التسجيل الأساسي (للعرض فقط)
            labFees.Text = _testTypes.TestFees.ToString("C2");

            dtpTestDate.Value = DateTime.Today;
            labTrail.Text = Trail().ToString();
        }

        private int Trail()
        {
            // عدد المحاولات السابقة لهذا النوع من الاختبار
            return clsTestAppointment.CountOfTrail(_dlAppId, (int)_testType);
        }

        // للمعاينة فقط: يرجع صف نوع الطلب "Retake Test" بدون حفظ أي شيء
        private DataRow GetRetakeApplicationTypeRow()
        {
            DataTable applicationTypes = clsManagmentApplicationTypes.GetApplicationTypes();
            if (applicationTypes == null || applicationTypes.Rows.Count == 0)
                return null;

            foreach (DataRow row in applicationTypes.Rows)
            {
                if (row["ApplicationTypeTitle"] != null &&
                    row["ApplicationTypeTitle"].ToString() == "Retake Test")
                {
                    return row;
                }
            }
            return null;
        }

        // للمعاينة فقط: إظهار الرسوم المتوقعة على الواجهة بدون إنشاء أو حفظ طلب إعادة
        private void ShowFeesPreview()
        {
            int attempts = Trail();

            if (attempts == 0)
            {
                // أول محاولة: رسوم التسجيل فقط
                labAppFees.Text = "N/A";
                labTotalFees.Text = _testTypes.TestFees.ToString("C2");
            }
            else
            {
                // ثاني محاولة فأكثر: رسوم التسجيل + رسوم الإعادة (للعرض فقط)
                DataRow retakeRow = GetRetakeApplicationTypeRow();
                decimal retakeFee = 0m;
                if (retakeRow != null && retakeRow["ApplicationFees"] != DBNull.Value)
                    retakeFee = Convert.ToDecimal(retakeRow["ApplicationFees"]);

                labAppFees.Text = retakeFee.ToString("C2");
                labTotalFees.Text = (Convert.ToDecimal(_testTypes.TestFees) + retakeFee).ToString("C2");
            }
        }

        // إنشاء وحفظ طلب الإعادة فعليًا عند الحاجة
        private bool RetakeApplication()
        {
            DataRow retakeRow = GetRetakeApplicationTypeRow();
            if (retakeRow == null)
            {
                MessageBox.Show("Retake application type not found.");
                return false;
            }

            _retakeapplication = new clsApplications
            {
                ApplicantPersonID = _localLicence._application.ApplicantPersonID,
                ApplicationDate = DateTime.Now,
                ApplicationTypeID = Convert.ToInt32(retakeRow["ApplicationTypeID"]),
                ApplicationStatus = (byte)clsApplications.enApplicationStatus.New,
                LastStatusDate = DateTime.Now,
                PaidFees = retakeRow["ApplicationFees"] != DBNull.Value ? Convert.ToSingle(retakeRow["ApplicationFees"]) : 0.0f,
                CreatedByUserID = CurrentUserName.CurrentUserID,
                Mode = clsApplications.enMode.AddNew
            }; 

            if (_retakeapplication.Save())
                return true;

            MessageBox.Show("Failed to save retake application.");
            return false;
        }

        private void LoadData()
        {
            if (_Mode == enMode.Add)
            {
                _localLicence = clsLocalLicence.FindLocalLicencesDetails(_dlAppId);
                if (_localLicence == null)
                {
                    MessageBox.Show("Local licence not found.");
                    return;
                }
                fillData();
                // عرض الرسوم المتوقعة حسب القاعدة المطلوبة (بدون حفظ)
                ShowFeesPreview();
            }
            else if (_Mode == enMode.Update)
            {
                _testAppointment = clsTestAppointment.FindByTestAppoitmentID(TestAppoitmentID);
                if (_testAppointment == null)
                {
                    MessageBox.Show("Test appointment not found.");
                    return;
                }

                if (_testAppointment.IsLocked)
                {
                    btnSave.Enabled = false;
                    dtpTestDate.Enabled = false;
                    labNotes.Text = "this appointment is locked, you can't change it.";
                }

                _localLicence = clsLocalLicence.FindLocalLicencesDetails(_testAppointment.LocalDrivingLicenseApplicationID);
                

                // ضبط نوع الاختبار حسب الموعد الحالي
                _testType = (clsTestAppointment.TestType)_testAppointment.TestTypeID;
                
                // تعبئة بيانات العرض
                if (_localLicence != null )
                {
                    labDLAppID.Text = _localLicence.LocalDrivingApplicationID.ToString();
                    labLicencesClass.Text = clsLocalLicence.GetClassName(_localLicence.LocalDrivingApplicationID);

                    labFullName.Text = _localLicence._application.Person.FullName();


                    labFees.Text = _testAppointment.PaidFees.ToString();
                    labTrail.Text = Trail().ToString();
                }

                dtpTestDate.Value = _testAppointment.AppointmentDate;

                // في وضع التعديل: إظهار الرسوم الفعلية حسب ما تم حفظه سابقًا
                if (_testAppointment.RetakeTestApplicationID != null)
                {
                    _retakeapplication = clsApplications.GetApplicationByID(_testAppointment.RetakeTestApplicationID.Value);
                    if (_retakeapplication != null)
                    {
                        labAppFees.Text = _retakeapplication.PaidFees.ToString("C2");
                        labTotalFees.Text = (_testTypes.TestFees + _retakeapplication.PaidFees).ToString("C2");
                    }
                    else
                    {
                        labAppFees.Text = "N/A";
                        labTotalFees.Text = _testTypes.TestFees.ToString("C2");
                    }
                }
                else
                {
                    // يعني كانت أول محاولة: رسوم التسجيل فقط
                    labAppFees.Text = "N/A";
                    labTotalFees.Text = _testAppointment.PaidFees.ToString();
                }

                labApplicationID.Text = _testAppointment.RetakeTestApplicationID != null
                    ? _testAppointment.RetakeTestApplicationID.ToString()
                    : "N/A";

                LoadPictureAndTitle();
            }
        }

        public DateTime GetTestDate()
        {
            if (dtpTestDate.Value < DateTime.Today)
                throw new InvalidOperationException("Test date must be today or later.");

            return dtpTestDate.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // تاريخ الاختبار
            if (dtpTestDate.Value < DateTime.Today)
            {
                MessageBox.Show("تاريخ الاختبار يجب أن يكون اليوم أو بعده.");
                return;
            }

            // تحميل الرخصة والطلب الأساسي
            if (_localLicence == null)
                _localLicence = clsLocalLicence.FindLocalLicencesDetails(_dlAppId);

            if (_localLicence == null)
            {
                MessageBox.Show("الرخصة المحلية غير موجودة.");
                return;
            }

         

            

            if (_Mode == enMode.Add)
            {
                int attempts = Trail();
                int? retakeAppID = null;

                // القاعدة:
                // أول محاولة => رسوم التسجيل فقط
                // ثاني محاولة فأكثر => رسوم التسجيل + رسوم الإعادة
                decimal totalFees = 0m;

                if (attempts == 0)
                {
                    totalFees = Convert.ToDecimal(_testTypes.TestFees);
                }
                else
                {
                    // إنشاء وحفظ طلب إعادة
                    if (!RetakeApplication())
                        return;

                    retakeAppID = _retakeapplication.ApplicationID;

                    // جمع رسوم التسجيل + رسوم الإعادة
                    totalFees = Convert.ToDecimal(_testTypes.TestFees) +
                                Convert.ToDecimal(_retakeapplication.PaidFees);

                    MessageBox.Show("تم إنشاء طلب إعادة الاختبار بنجاح.");
                    
                }

                // إنشاء موعد الاختبار برسوم حسب القاعدة
                _testAppointment = new clsTestAppointment
                {
                    TestTypeID = (int)_testType,
                    LocalDrivingLicenseApplicationID = _localLicence.LocalDrivingApplicationID,
                    AppointmentDate = dtpTestDate.Value,
                    PaidFees = totalFees, // بدون أي رسوم اختبار إضافية حالياً
                    CreatedByUserID = CurrentUserName.CurrentUserID,
                    IsLocked = false,
                    RetakeTestApplicationID = retakeAppID
                };

                if (_testAppointment.Save())
                {
                    MessageBox.Show("تم إضافة موعد الاختبار بنجاح.");
                    labApplicationID.Text = retakeAppID?.ToString() ?? "N/A";

                    // تحديث العرض بعد الحفظ
                    labAppFees.Text = (retakeAppID != null && _retakeapplication != null)
                        ? _retakeapplication.PaidFees.ToString("C2")
                        : "N/A";
                    labTotalFees.Text = totalFees.ToString("C2");
                    this.ParentForm?.Close(); 
                }
                else
                {
                    MessageBox.Show("فشل في حفظ موعد الاختبار.");
                }
            }
            else if (_Mode == enMode.Update)
            {
                _testAppointment = clsTestAppointment.FindByTestAppoitmentID(TestAppoitmentID);
                if (_testAppointment == null)
                {
                    MessageBox.Show("موعد الاختبار غير موجود.");
                    return;
                }

                if (_testAppointment.IsLocked)
                {
                    MessageBox.Show("لا يمكن تعديل موعد مقفل.");
                    return;
                }

                _testAppointment.AppointmentDate = dtpTestDate.Value;

                if (_testAppointment.Update())
                {
                    MessageBox.Show("تم تحديث موعد الاختبار بنجاح.");
                    this.ParentForm?.Close();
                }
                else
                {
                    MessageBox.Show("فشل في تحديث موعد الاختبار.");
                }
            }
        }
    }
}
