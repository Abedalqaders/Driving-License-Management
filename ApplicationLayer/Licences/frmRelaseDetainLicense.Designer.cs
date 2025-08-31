namespace ApplicationLayer.Licences
{
    partial class frmRelaseDetainLicense
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRelase = new System.Windows.Forms.Button();
            this.likLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.likNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.labUserName = new System.Windows.Forms.Label();
            this.labLicenseID = new System.Windows.Forms.Label();
            this.labDetainDate = new System.Windows.Forms.Label();
            this.labDetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labTittle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlShowLocalLicencesDetailsWithFilter1 = new ApplicationLayer.Control.ctrlShowLocalLicencesDetailsWithFilter();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labApplicationFees = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.labFineFees = new System.Windows.Forms.Label();
            this.labApplicationID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(540, 815);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRelase
            // 
            this.btnRelase.Location = new System.Drawing.Point(621, 815);
            this.btnRelase.Name = "btnRelase";
            this.btnRelase.Size = new System.Drawing.Size(75, 23);
            this.btnRelase.TabIndex = 27;
            this.btnRelase.Text = "Relase";
            this.btnRelase.UseVisualStyleBackColor = true;
            this.btnRelase.Click += new System.EventHandler(this.btnRelase_Click);
            // 
            // likLicenseHistory
            // 
            this.likLicenseHistory.AutoSize = true;
            this.likLicenseHistory.Enabled = false;
            this.likLicenseHistory.Location = new System.Drawing.Point(97, 825);
            this.likLicenseHistory.Name = "likLicenseHistory";
            this.likLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.likLicenseHistory.TabIndex = 26;
            this.likLicenseHistory.TabStop = true;
            this.likLicenseHistory.Text = "Show License History";
            this.likLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likLicenseHistory_LinkClicked);
            // 
            // likNewLicenseInfo
            // 
            this.likNewLicenseInfo.AutoSize = true;
            this.likNewLicenseInfo.Enabled = false;
            this.likNewLicenseInfo.Location = new System.Drawing.Point(230, 825);
            this.likNewLicenseInfo.Name = "likNewLicenseInfo";
            this.likNewLicenseInfo.Size = new System.Drawing.Size(126, 13);
            this.likNewLicenseInfo.TabIndex = 25;
            this.likNewLicenseInfo.TabStop = true;
            this.likNewLicenseInfo.Text = "Show New Licences Info";
            this.likNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likNewLicenseInfo_LinkClicked);
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(543, 670);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(35, 18);
            this.labUserName.TabIndex = 23;
            this.labUserName.Text = "???";
            // 
            // labLicenseID
            // 
            this.labLicenseID.AutoSize = true;
            this.labLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLicenseID.Location = new System.Drawing.Point(538, 625);
            this.labLicenseID.Name = "labLicenseID";
            this.labLicenseID.Size = new System.Drawing.Size(45, 18);
            this.labLicenseID.TabIndex = 22;
            this.labLicenseID.Text = "[???]";
            // 
            // labDetainDate
            // 
            this.labDetainDate.AutoSize = true;
            this.labDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetainDate.Location = new System.Drawing.Point(194, 657);
            this.labDetainDate.Name = "labDetainDate";
            this.labDetainDate.Size = new System.Drawing.Size(35, 18);
            this.labDetainDate.TabIndex = 21;
            this.labDetainDate.Text = "???";
            // 
            // labDetainID
            // 
            this.labDetainID.AutoSize = true;
            this.labDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetainID.Location = new System.Drawing.Point(189, 613);
            this.labDetainID.Name = "labDetainID";
            this.labDetainID.Size = new System.Drawing.Size(45, 18);
            this.labDetainID.TabIndex = 20;
            this.labDetainID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Created By:";
            // 
            // labTittle
            // 
            this.labTittle.AutoSize = true;
            this.labTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTittle.ForeColor = System.Drawing.Color.Red;
            this.labTittle.Location = new System.Drawing.Point(300, 37);
            this.labTittle.Name = "labTittle";
            this.labTittle.Size = new System.Drawing.Size(206, 29);
            this.labTittle.TabIndex = 18;
            this.labTittle.Text = "Relase Licences";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "License ID:";
            // 
            // ctrlShowLocalLicencesDetailsWithFilter1
            // 
            this.ctrlShowLocalLicencesDetailsWithFilter1.Location = new System.Drawing.Point(-6, 78);
            this.ctrlShowLocalLicencesDetailsWithFilter1.Name = "ctrlShowLocalLicencesDetailsWithFilter1";
            this.ctrlShowLocalLicencesDetailsWithFilter1.Size = new System.Drawing.Size(804, 520);
            this.ctrlShowLocalLicencesDetailsWithFilter1.TabIndex = 16;
            this.ctrlShowLocalLicencesDetailsWithFilter1.OnFilterClicked += new System.Action<int>(this.ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 713);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fine Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Detain Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Detain ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 704);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Application Fees:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 747);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total Fees:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(365, 746);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Application ID:";
            // 
            // labApplicationFees
            // 
            this.labApplicationFees.AutoSize = true;
            this.labApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApplicationFees.Location = new System.Drawing.Point(194, 704);
            this.labApplicationFees.Name = "labApplicationFees";
            this.labApplicationFees.Size = new System.Drawing.Size(35, 18);
            this.labApplicationFees.TabIndex = 35;
            this.labApplicationFees.Text = "???";
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFees.Location = new System.Drawing.Point(194, 746);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(35, 18);
            this.labFees.TabIndex = 36;
            this.labFees.Text = "???";
            // 
            // labFineFees
            // 
            this.labFineFees.AutoSize = true;
            this.labFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFineFees.Location = new System.Drawing.Point(543, 713);
            this.labFineFees.Name = "labFineFees";
            this.labFineFees.Size = new System.Drawing.Size(35, 18);
            this.labFineFees.TabIndex = 37;
            this.labFineFees.Text = "???";
            // 
            // labApplicationID
            // 
            this.labApplicationID.AutoSize = true;
            this.labApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApplicationID.Location = new System.Drawing.Point(543, 747);
            this.labApplicationID.Name = "labApplicationID";
            this.labApplicationID.Size = new System.Drawing.Size(35, 18);
            this.labApplicationID.TabIndex = 38;
            this.labApplicationID.Text = "???";
            // 
            // frmRelaseDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 850);
            this.Controls.Add(this.labApplicationID);
            this.Controls.Add(this.labFineFees);
            this.Controls.Add(this.labFees);
            this.Controls.Add(this.labApplicationFees);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelase);
            this.Controls.Add(this.likLicenseHistory);
            this.Controls.Add(this.likNewLicenseInfo);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labLicenseID);
            this.Controls.Add(this.labDetainDate);
            this.Controls.Add(this.labDetainID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labTittle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlShowLocalLicencesDetailsWithFilter1);
            this.Name = "frmRelaseDetainLicense";
            this.Text = "frmRelaseDetainLicense";
            this.Load += new System.EventHandler(this.frmRelaseDetainLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRelase;
        private System.Windows.Forms.LinkLabel likLicenseHistory;
        private System.Windows.Forms.LinkLabel likNewLicenseInfo;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labLicenseID;
        private System.Windows.Forms.Label labDetainDate;
        private System.Windows.Forms.Label labDetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labTittle;
        private System.Windows.Forms.Label label3;
        private Control.ctrlShowLocalLicencesDetailsWithFilter ctrlShowLocalLicencesDetailsWithFilter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labApplicationFees;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Label labFineFees;
        private System.Windows.Forms.Label labApplicationID;
    }
}