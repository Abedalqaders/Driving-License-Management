namespace ApplicationLayer.Licences
{
    partial class frmReplacementforDamagedorLost_Licenses
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
            this.ctrlShowLocalLicencesDetailsWithFilter1 = new ApplicationLayer.Control.ctrlShowLocalLicencesDetailsWithFilter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLostLicences = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicences = new System.Windows.Forms.RadioButton();
            this.labTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labTotalFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labOldLicenseID = new System.Windows.Forms.Label();
            this.labNewLicenseID = new System.Windows.Forms.Label();
            this.labApplicationFees = new System.Windows.Forms.Label();
            this.labApplicationID = new System.Windows.Forms.Label();
            this.labApplicationDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.likLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.likNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlShowLocalLicencesDetailsWithFilter1
            // 
            this.ctrlShowLocalLicencesDetailsWithFilter1.Location = new System.Drawing.Point(-3, 104);
            this.ctrlShowLocalLicencesDetailsWithFilter1.Name = "ctrlShowLocalLicencesDetailsWithFilter1";
            this.ctrlShowLocalLicencesDetailsWithFilter1.Size = new System.Drawing.Size(839, 507);
            this.ctrlShowLocalLicencesDetailsWithFilter1.TabIndex = 0;
            this.ctrlShowLocalLicencesDetailsWithFilter1.OnFilterClicked += new System.Action<int>(this.ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLostLicences);
            this.groupBox1.Controls.Add(this.rbDamagedLicences);
            this.groupBox1.Location = new System.Drawing.Point(495, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacment For";
            // 
            // rbLostLicences
            // 
            this.rbLostLicences.AutoSize = true;
            this.rbLostLicences.Checked = true;
            this.rbLostLicences.Location = new System.Drawing.Point(10, 30);
            this.rbLostLicences.Name = "rbLostLicences";
            this.rbLostLicences.Size = new System.Drawing.Size(91, 17);
            this.rbLostLicences.TabIndex = 2;
            this.rbLostLicences.TabStop = true;
            this.rbLostLicences.Text = "Lost Licences";
            this.rbLostLicences.UseVisualStyleBackColor = true;
            this.rbLostLicences.CheckedChanged += new System.EventHandler(this.rbLostLicences_CheckedChanged);
            // 
            // rbDamagedLicences
            // 
            this.rbDamagedLicences.AutoSize = true;
            this.rbDamagedLicences.Location = new System.Drawing.Point(10, 53);
            this.rbDamagedLicences.Name = "rbDamagedLicences";
            this.rbDamagedLicences.Size = new System.Drawing.Size(117, 17);
            this.rbDamagedLicences.TabIndex = 1;
            this.rbDamagedLicences.Text = "Damaged Licences";
            this.rbDamagedLicences.UseVisualStyleBackColor = true;
            this.rbDamagedLicences.CheckedChanged += new System.EventHandler(this.rbDamagedLicences_CheckedChanged);
            // 
            // labTittle
            // 
            this.labTittle.AutoSize = true;
            this.labTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTittle.ForeColor = System.Drawing.Color.Red;
            this.labTittle.Location = new System.Drawing.Point(220, 41);
            this.labTittle.Name = "labTittle";
            this.labTittle.Size = new System.Drawing.Size(366, 29);
            this.labTittle.TabIndex = 4;
            this.labTittle.Text = "Replacment For Lost Licenses";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labTotalFees);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labUserName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labOldLicenseID);
            this.panel1.Controls.Add(this.labNewLicenseID);
            this.panel1.Controls.Add(this.labApplicationFees);
            this.panel1.Controls.Add(this.labApplicationID);
            this.panel1.Controls.Add(this.labApplicationDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 190);
            this.panel1.TabIndex = 5;
            // 
            // labTotalFees
            // 
            this.labTotalFees.AutoSize = true;
            this.labTotalFees.Location = new System.Drawing.Point(356, 171);
            this.labTotalFees.Name = "labTotalFees";
            this.labTotalFees.Size = new System.Drawing.Size(31, 13);
            this.labTotalFees.TabIndex = 14;
            this.labTotalFees.Text = "[$$$]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "TotalFees:";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(559, 134);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(28, 16);
            this.labUserName.TabIndex = 12;
            this.labUserName.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Application Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(399, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Old License ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Application Fees:";
            // 
            // labOldLicenseID
            // 
            this.labOldLicenseID.AutoSize = true;
            this.labOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOldLicenseID.Location = new System.Drawing.Point(553, 93);
            this.labOldLicenseID.Name = "labOldLicenseID";
            this.labOldLicenseID.Size = new System.Drawing.Size(36, 16);
            this.labOldLicenseID.TabIndex = 8;
            this.labOldLicenseID.Text = "[???]";
            // 
            // labNewLicenseID
            // 
            this.labNewLicenseID.AutoSize = true;
            this.labNewLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNewLicenseID.Location = new System.Drawing.Point(553, 53);
            this.labNewLicenseID.Name = "labNewLicenseID";
            this.labNewLicenseID.Size = new System.Drawing.Size(36, 16);
            this.labNewLicenseID.TabIndex = 7;
            this.labNewLicenseID.Text = "[???]";
            // 
            // labApplicationFees
            // 
            this.labApplicationFees.AutoSize = true;
            this.labApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApplicationFees.Location = new System.Drawing.Point(205, 127);
            this.labApplicationFees.Name = "labApplicationFees";
            this.labApplicationFees.Size = new System.Drawing.Size(28, 16);
            this.labApplicationFees.TabIndex = 6;
            this.labApplicationFees.Text = "???";
            // 
            // labApplicationID
            // 
            this.labApplicationID.AutoSize = true;
            this.labApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApplicationID.Location = new System.Drawing.Point(205, 43);
            this.labApplicationID.Name = "labApplicationID";
            this.labApplicationID.Size = new System.Drawing.Size(36, 16);
            this.labApplicationID.TabIndex = 5;
            this.labApplicationID.Text = "[???]";
            // 
            // labApplicationDate
            // 
            this.labApplicationDate.AutoSize = true;
            this.labApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApplicationDate.Location = new System.Drawing.Point(205, 82);
            this.labApplicationDate.Name = "labApplicationDate";
            this.labApplicationDate.Size = new System.Drawing.Size(28, 16);
            this.labApplicationDate.TabIndex = 4;
            this.labApplicationDate.Tag = "";
            this.labApplicationDate.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Replaced License ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "L.R.Application ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Info for License Replacement";
            // 
            // likLicenseHistory
            // 
            this.likLicenseHistory.AutoSize = true;
            this.likLicenseHistory.Enabled = false;
            this.likLicenseHistory.Location = new System.Drawing.Point(75, 828);
            this.likLicenseHistory.Name = "likLicenseHistory";
            this.likLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.likLicenseHistory.TabIndex = 7;
            this.likLicenseHistory.TabStop = true;
            this.likLicenseHistory.Text = "Show License History";
            this.likLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likLicenseHistory_LinkClicked);
            // 
            // likNewLicenseInfo
            // 
            this.likNewLicenseInfo.AutoSize = true;
            this.likNewLicenseInfo.Enabled = false;
            this.likNewLicenseInfo.Location = new System.Drawing.Point(209, 831);
            this.likNewLicenseInfo.Name = "likNewLicenseInfo";
            this.likNewLicenseInfo.Size = new System.Drawing.Size(126, 13);
            this.likNewLicenseInfo.TabIndex = 6;
            this.likNewLicenseInfo.TabStop = true;
            this.likNewLicenseInfo.Text = "Show New Licences Info";
            this.likNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likNewLicenseInfo_LinkClicked);
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Location = new System.Drawing.Point(618, 818);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(75, 23);
            this.btnIssue.TabIndex = 8;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(537, 818);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReplacementforDamagedorLost_Licenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 869);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.likLicenseHistory);
            this.Controls.Add(this.likNewLicenseInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labTittle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlShowLocalLicencesDetailsWithFilter1);
            this.Name = "frmReplacementforDamagedorLost_Licenses";
            this.Text = "frmReplacementforDamagedorLost_Licenses";
            this.Load += new System.EventHandler(this.frmReplacementforDamagedorLost_Licenses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ctrlShowLocalLicencesDetailsWithFilter ctrlShowLocalLicencesDetailsWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLostLicences;
        private System.Windows.Forms.RadioButton rbDamagedLicences;
        private System.Windows.Forms.Label labTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labOldLicenseID;
        private System.Windows.Forms.Label labNewLicenseID;
        private System.Windows.Forms.Label labApplicationFees;
        private System.Windows.Forms.Label labApplicationID;
        private System.Windows.Forms.Label labApplicationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel likLicenseHistory;
        private System.Windows.Forms.LinkLabel likNewLicenseInfo;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labTotalFees;
        private System.Windows.Forms.Label label5;
    }
}