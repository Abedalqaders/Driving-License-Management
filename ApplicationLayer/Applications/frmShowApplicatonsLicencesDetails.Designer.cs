namespace ApplicationLayer.Applications
{
    partial class frmShowApplicatonsLicencesDetails
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
            this.ctrlLicencesApplication_and_ApplicatonInfo1 = new ApplicationLayer.Control.ctrlLicencesApplication_and_ApplicatonInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(566, 564);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLicencesApplication_and_ApplicatonInfo1
            // 
            this.ctrlLicencesApplication_and_ApplicatonInfo1.Location = new System.Drawing.Point(30, 12);
            this.ctrlLicencesApplication_and_ApplicatonInfo1.Name = "ctrlLicencesApplication_and_ApplicatonInfo1";
            this.ctrlLicencesApplication_and_ApplicatonInfo1.Size = new System.Drawing.Size(792, 528);
            this.ctrlLicencesApplication_and_ApplicatonInfo1.TabIndex = 0;
            // 
            // frmShowApplicatonsLicencesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 599);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlLicencesApplication_and_ApplicatonInfo1);
            this.Name = "frmShowApplicatonsLicencesDetails";
            this.Text = "frmShowApplicatonsLicencesDetails";
            this.Load += new System.EventHandler(this.frmShowApplicatonsLicencesDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ctrlLicencesApplication_and_ApplicatonInfo ctrlLicencesApplication_and_ApplicatonInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}