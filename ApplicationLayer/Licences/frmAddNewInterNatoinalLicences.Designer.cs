namespace ApplicationLayer.Licences
{
    partial class frmAddNewInterNatoinalLicences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewInterNatoinalLicences));
            this.button2 = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.ctrlApplicationOfInterNationalLicences1 = new ApplicationLayer.Control.ctrlApplicationOfInterNationalLicences();
            this.ctrlShowLocalLicencesDetailsWithFilter1 = new ApplicationLayer.Control.ctrlShowLocalLicencesDetailsWithFilter();
            this.likLicencesHistory = new System.Windows.Forms.LinkLabel();
            this.likLicencesInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(534, 770);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnIssue.Image")));
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(628, 770);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(79, 42);
            this.btnIssue.TabIndex = 2;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ctrlApplicationOfInterNationalLicences1
            // 
            this.ctrlApplicationOfInterNationalLicences1.Location = new System.Drawing.Point(4, 503);
            this.ctrlApplicationOfInterNationalLicences1.Name = "ctrlApplicationOfInterNationalLicences1";
            this.ctrlApplicationOfInterNationalLicences1.Size = new System.Drawing.Size(693, 250);
            this.ctrlApplicationOfInterNationalLicences1.TabIndex = 5;
            // 
            // ctrlShowLocalLicencesDetailsWithFilter1
            // 
            this.ctrlShowLocalLicencesDetailsWithFilter1.Location = new System.Drawing.Point(4, 11);
            this.ctrlShowLocalLicencesDetailsWithFilter1.Name = "ctrlShowLocalLicencesDetailsWithFilter1";
            this.ctrlShowLocalLicencesDetailsWithFilter1.Size = new System.Drawing.Size(805, 479);
            this.ctrlShowLocalLicencesDetailsWithFilter1.TabIndex = 4;
            this.ctrlShowLocalLicencesDetailsWithFilter1.OnFilterClicked += new System.Action<int>(this.ctrlShowLocalLicencesDetailsWithFilter1_OnFilterClicked);
            this.ctrlShowLocalLicencesDetailsWithFilter1.Load += new System.EventHandler(this.ctrlShowLocalLicencesDetailsWithFilter1_Load);
            // 
            // likLicencesHistory
            // 
            this.likLicencesHistory.AutoSize = true;
            this.likLicencesHistory.Enabled = false;
            this.likLicencesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likLicencesHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.likLicencesHistory.Location = new System.Drawing.Point(27, 770);
            this.likLicencesHistory.Name = "likLicencesHistory";
            this.likLicencesHistory.Size = new System.Drawing.Size(160, 18);
            this.likLicencesHistory.TabIndex = 6;
            this.likLicencesHistory.TabStop = true;
            this.likLicencesHistory.Text = "Show Licences History";
            this.likLicencesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likLicencesHistory_LinkClicked);
            // 
            // likLicencesInfo
            // 
            this.likLicencesInfo.AutoSize = true;
            this.likLicencesInfo.Enabled = false;
            this.likLicencesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likLicencesInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.likLicencesInfo.Location = new System.Drawing.Point(216, 770);
            this.likLicencesInfo.Name = "likLicencesInfo";
            this.likLicencesInfo.Size = new System.Drawing.Size(129, 18);
            this.likLicencesInfo.TabIndex = 7;
            this.likLicencesInfo.TabStop = true;
            this.likLicencesInfo.Text = "Show Licencs Info";
            this.likLicencesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likLicencesInfo_LinkClicked);
            // 
            // frmAddNewInterNatoinalLicences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 818);
            this.Controls.Add(this.likLicencesInfo);
            this.Controls.Add(this.likLicencesHistory);
            this.Controls.Add(this.ctrlApplicationOfInterNationalLicences1);
            this.Controls.Add(this.ctrlShowLocalLicencesDetailsWithFilter1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIssue);
            this.Name = "frmAddNewInterNatoinalLicences";
            this.Text = "frmAddNewInterNatoinalLicences";
            this.Load += new System.EventHandler(this.frmAddNewInterNatoinalLicences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button button2;
        private Control.ctrlShowLocalLicencesDetailsWithFilter ctrlShowLocalLicencesDetailsWithFilter1;
        private Control.ctrlApplicationOfInterNationalLicences ctrlApplicationOfInterNationalLicences1;
        private System.Windows.Forms.LinkLabel likLicencesHistory;
        private System.Windows.Forms.LinkLabel likLicencesInfo;
    }
}