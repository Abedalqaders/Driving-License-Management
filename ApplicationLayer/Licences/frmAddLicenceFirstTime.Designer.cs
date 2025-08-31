namespace ApplicationLayer.Licences
{
    partial class frmAddLicenceFirstTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlLicencesApplication_and_ApplicatonInfo1 = new ApplicationLayer.Control.ctrlLicencesApplication_and_ApplicatonInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes:";
            // 
            // txtbNotes
            // 
            this.txtbNotes.Location = new System.Drawing.Point(114, 521);
            this.txtbNotes.Multiline = true;
            this.txtbNotes.Name = "txtbNotes";
            this.txtbNotes.Size = new System.Drawing.Size(648, 98);
            this.txtbNotes.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(572, 647);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(667, 647);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlLicencesApplication_and_ApplicatonInfo1
            // 
            this.ctrlLicencesApplication_and_ApplicatonInfo1.Location = new System.Drawing.Point(1, -32);
            this.ctrlLicencesApplication_and_ApplicatonInfo1.Name = "ctrlLicencesApplication_and_ApplicatonInfo1";
            this.ctrlLicencesApplication_and_ApplicatonInfo1.Size = new System.Drawing.Size(772, 536);
            this.ctrlLicencesApplication_and_ApplicatonInfo1.TabIndex = 0;
            // 
            // frmAddLicenceFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 682);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtbNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLicencesApplication_and_ApplicatonInfo1);
            this.Name = "frmAddLicenceFirstTime";
            this.Text = "Issue Driving Licences For First Time";
            this.Load += new System.EventHandler(this.frmAddLicenceFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ctrlLicencesApplication_and_ApplicatonInfo ctrlLicencesApplication_and_ApplicatonInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}