namespace ApplicationLayer.Licences
{
    partial class frmDetainedLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labTittle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labLicenseID = new System.Windows.Forms.Label();
            this.labDetainDate = new System.Windows.Forms.Label();
            this.labDetainID = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.likLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.likNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlShowLocalLicencesDetailsWithFilter1
            // 
            this.ctrlShowLocalLicencesDetailsWithFilter1.Location = new System.Drawing.Point(3, 72);
            this.ctrlShowLocalLicencesDetailsWithFilter1.Name = "ctrlShowLocalLicencesDetailsWithFilter1";
            this.ctrlShowLocalLicencesDetailsWithFilter1.Size = new System.Drawing.Size(804, 520);
            this.ctrlShowLocalLicencesDetailsWithFilter1.TabIndex = 0;
            this.ctrlShowLocalLicencesDetailsWithFilter1.OnFilterClicked += new System.Action<int>(this.ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detain ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detain Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "License ID:";
            // 
            // labTittle
            // 
            this.labTittle.AutoSize = true;
            this.labTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTittle.ForeColor = System.Drawing.Color.Red;
            this.labTittle.Location = new System.Drawing.Point(312, 40);
            this.labTittle.Name = "labTittle";
            this.labTittle.Size = new System.Drawing.Size(199, 29);
            this.labTittle.TabIndex = 4;
            this.labTittle.Text = "Detain Licences";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fine Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Created By:";
            // 
            // labLicenseID
            // 
            this.labLicenseID.AutoSize = true;
            this.labLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLicenseID.Location = new System.Drawing.Point(533, 607);
            this.labLicenseID.Name = "labLicenseID";
            this.labLicenseID.Size = new System.Drawing.Size(45, 18);
            this.labLicenseID.TabIndex = 9;
            this.labLicenseID.Text = "[???]";
            // 
            // labDetainDate
            // 
            this.labDetainDate.AutoSize = true;
            this.labDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetainDate.Location = new System.Drawing.Point(176, 639);
            this.labDetainDate.Name = "labDetainDate";
            this.labDetainDate.Size = new System.Drawing.Size(35, 18);
            this.labDetainDate.TabIndex = 8;
            this.labDetainDate.Text = "???";
            // 
            // labDetainID
            // 
            this.labDetainID.AutoSize = true;
            this.labDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetainID.Location = new System.Drawing.Point(166, 595);
            this.labDetainID.Name = "labDetainID";
            this.labDetainID.Size = new System.Drawing.Size(45, 18);
            this.labDetainID.TabIndex = 7;
            this.labDetainID.Text = "[???]";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(543, 652);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(35, 18);
            this.labUserName.TabIndex = 10;
            this.labUserName.Text = "???";
            // 
            // tbFineFees
            // 
            this.tbFineFees.Location = new System.Drawing.Point(158, 673);
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(53, 20);
            this.tbFineFees.TabIndex = 11;
            this.tbFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // likLicenseHistory
            // 
            this.likLicenseHistory.AutoSize = true;
            this.likLicenseHistory.Enabled = false;
            this.likLicenseHistory.Location = new System.Drawing.Point(107, 759);
            this.likLicenseHistory.Name = "likLicenseHistory";
            this.likLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.likLicenseHistory.TabIndex = 13;
            this.likLicenseHistory.TabStop = true;
            this.likLicenseHistory.Text = "Show License History";
            this.likLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likLicenseHistory_LinkClicked);
            // 
            // likNewLicenseInfo
            // 
            this.likNewLicenseInfo.AutoSize = true;
            this.likNewLicenseInfo.Enabled = false;
            this.likNewLicenseInfo.Location = new System.Drawing.Point(241, 762);
            this.likNewLicenseInfo.Name = "likNewLicenseInfo";
            this.likNewLicenseInfo.Size = new System.Drawing.Size(126, 13);
            this.likNewLicenseInfo.TabIndex = 12;
            this.likNewLicenseInfo.TabStop = true;
            this.likNewLicenseInfo.Text = "Show New Licences Info";
            this.likNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likNewLicenseInfo_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.Location = new System.Drawing.Point(646, 749);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(75, 23);
            this.btnDetain.TabIndex = 14;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(546, 749);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 803);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.likLicenseHistory);
            this.Controls.Add(this.likNewLicenseInfo);
            this.Controls.Add(this.tbFineFees);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labLicenseID);
            this.Controls.Add(this.labDetainDate);
            this.Controls.Add(this.labDetainID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labTittle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlShowLocalLicencesDetailsWithFilter1);
            this.Name = "frmDetainedLicense";
            this.Text = "frmDetainedLicense";
            this.Load += new System.EventHandler(this.frmDetainedLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ctrlShowLocalLicencesDetailsWithFilter ctrlShowLocalLicencesDetailsWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labTittle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labLicenseID;
        private System.Windows.Forms.Label labDetainDate;
        private System.Windows.Forms.Label labDetainID;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.TextBox tbFineFees;
        private System.Windows.Forms.LinkLabel likLicenseHistory;
        private System.Windows.Forms.LinkLabel likNewLicenseInfo;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnClose;
    }
}