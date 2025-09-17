namespace ApplicationLayer.Licences
{
    partial class frmRenewLocalLicnces
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
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.likNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.likLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ctrlShowLocalLicencesDetailsWithFilter1 = new ApplicationLayer.Control.ctrlShowLocalLicencesDetailsWithFilter();
            this.ctrlApplicationRenewLicences1 = new ApplicationLayer.Control.ctrlApplicationRenewLicences();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.Location = new System.Drawing.Point(718, 873);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(75, 23);
            this.btnRenew.TabIndex = 2;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(637, 873);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // likNewLicenseInfo
            // 
            this.likNewLicenseInfo.AutoSize = true;
            this.likNewLicenseInfo.Enabled = false;
            this.likNewLicenseInfo.Location = new System.Drawing.Point(234, 881);
            this.likNewLicenseInfo.Name = "likNewLicenseInfo";
            this.likNewLicenseInfo.Size = new System.Drawing.Size(126, 13);
            this.likNewLicenseInfo.TabIndex = 4;
            this.likNewLicenseInfo.TabStop = true;
            this.likNewLicenseInfo.Text = "Show New Licences Info";
            this.likNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likNewLicenseInfo_LinkClicked);
            // 
            // likLicenseHistory
            // 
            this.likLicenseHistory.AutoSize = true;
            this.likLicenseHistory.Enabled = false;
            this.likLicenseHistory.Location = new System.Drawing.Point(100, 878);
            this.likLicenseHistory.Name = "likLicenseHistory";
            this.likLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.likLicenseHistory.TabIndex = 5;
            this.likLicenseHistory.TabStop = true;
            this.likLicenseHistory.Text = "Show License History";
            this.likLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likLicenseHistory_LinkClicked);
            // 
            // ctrlShowLocalLicencesDetailsWithFilter1
            // 
            this.ctrlShowLocalLicencesDetailsWithFilter1.Location = new System.Drawing.Point(2, 10);
            this.ctrlShowLocalLicencesDetailsWithFilter1.Name = "ctrlShowLocalLicencesDetailsWithFilter1";
            this.ctrlShowLocalLicencesDetailsWithFilter1.Size = new System.Drawing.Size(836, 493);
            this.ctrlShowLocalLicencesDetailsWithFilter1.TabIndex = 7;
            this.ctrlShowLocalLicencesDetailsWithFilter1.OnFilterClicked += new System.Action<int>(this.ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked);
            // 
            // ctrlApplicationRenewLicences1
            // 
            this.ctrlApplicationRenewLicences1.Location = new System.Drawing.Point(9, 504);
            this.ctrlApplicationRenewLicences1.Name = "ctrlApplicationRenewLicences1";
            this.ctrlApplicationRenewLicences1.Size = new System.Drawing.Size(855, 363);
            this.ctrlApplicationRenewLicences1.TabIndex = 8;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(162, 796);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(581, 58);
            this.tbNotes.TabIndex = 9;
            // 
            // frmRenewLocalLicnces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 908);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.ctrlApplicationRenewLicences1);
            this.Controls.Add(this.ctrlShowLocalLicencesDetailsWithFilter1);
            this.Controls.Add(this.likLicenseHistory);
            this.Controls.Add(this.likNewLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Name = "frmRenewLocalLicnces";
            this.Text = "frmRenewLocalLicnces";
            this.Load += new System.EventHandler(this.frmRenewLocalLicnces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel likNewLicenseInfo;
        private System.Windows.Forms.LinkLabel likLicenseHistory;
        private Control.ctrlShowLocalLicencesDetailsWithFilter ctrlShowLocalLicencesDetailsWithFilter1;
        private Control.ctrlApplicationRenewLicences ctrlApplicationRenewLicences1;
        private System.Windows.Forms.TextBox tbNotes;
    }
}