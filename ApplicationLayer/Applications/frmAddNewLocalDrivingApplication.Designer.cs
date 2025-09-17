namespace ApplicationLayer.Applications
{
    partial class frmAddNewLocalDrivingApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewLocalDrivingApplication));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlShowPersonDetails1 = new ApplicationLayer.People.ctrlShowPersonDetails();
            this.ctrlSearchPerson1 = new ApplicationLayer.Control.ctrlSearchPerson();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbLiceenseClass = new System.Windows.Forms.ComboBox();
            this.labCreatedBy = new System.Windows.Forms.Label();
            this.labDLappFees = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labDLappID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 547);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlShowPersonDetails1);
            this.tabPage1.Controls.Add(this.ctrlSearchPerson1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(784, 439);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 76);
            this.btnNext.TabIndex = 13;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(30, 119);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(773, 354);
            this.ctrlShowPersonDetails1.TabIndex = 1;
            // 
            // ctrlSearchPerson1
            // 
            this.ctrlSearchPerson1.Location = new System.Drawing.Point(-44, 3);
            this.ctrlSearchPerson1.Name = "ctrlSearchPerson1";
            this.ctrlSearchPerson1.Size = new System.Drawing.Size(797, 82);
            this.ctrlSearchPerson1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbLiceenseClass);
            this.tabPage2.Controls.Add(this.labCreatedBy);
            this.tabPage2.Controls.Add(this.labDLappFees);
            this.tabPage2.Controls.Add(this.labDate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.labDLappID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbLiceenseClass
            // 
            this.cbLiceenseClass.FormattingEnabled = true;
            this.cbLiceenseClass.Location = new System.Drawing.Point(237, 157);
            this.cbLiceenseClass.Name = "cbLiceenseClass";
            this.cbLiceenseClass.Size = new System.Drawing.Size(212, 21);
            this.cbLiceenseClass.TabIndex = 10;
            // 
            // labCreatedBy
            // 
            this.labCreatedBy.AutoSize = true;
            this.labCreatedBy.Location = new System.Drawing.Point(234, 244);
            this.labCreatedBy.Name = "labCreatedBy";
            this.labCreatedBy.Size = new System.Drawing.Size(25, 13);
            this.labCreatedBy.TabIndex = 9;
            this.labCreatedBy.Text = "???";
            // 
            // labDLappFees
            // 
            this.labDLappFees.AutoSize = true;
            this.labDLappFees.Location = new System.Drawing.Point(234, 201);
            this.labDLappFees.Name = "labDLappFees";
            this.labDLappFees.Size = new System.Drawing.Size(13, 13);
            this.labDLappFees.TabIndex = 8;
            this.labDLappFees.Text = "0";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(234, 121);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(30, 13);
            this.labDate.TabIndex = 7;
            this.labDate.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Created By:";
            // 
            // labDLappID
            // 
            this.labDLappID.AutoSize = true;
            this.labDLappID.Location = new System.Drawing.Point(234, 69);
            this.labDLappID.Name = "labDLappID";
            this.labDLappID.Size = new System.Drawing.Size(25, 13);
            this.labDLappID.TabIndex = 5;
            this.labDLappID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Application Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Liceense Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "D.L.Application ID:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(759, 703);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(840, 703);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(232, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(471, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "New Local Driving Application";
            // 
            // frmAddNewLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 752);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddNewLocalDrivingApplication";
            this.Text = "frmAddNewLocalDrivingApplication";
            this.Load += new System.EventHandler(this.frmAddNewLocalDrivingApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private People.ctrlShowPersonDetails ctrlShowPersonDetails1;
        private Control.ctrlSearchPerson ctrlSearchPerson1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labCreatedBy;
        private System.Windows.Forms.Label labDLappFees;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labDLappID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLiceenseClass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
    }
}