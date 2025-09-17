namespace ApplicationLayer.Control
{
    partial class ctrlShowLocalLicencesDetailsWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlShowLocalLicencesDetailsWithFilter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Label();
            this.tbLicenceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlGetDetailsOfLocalLicences1 = new ApplicationLayer.Control.ctrlGetDetailsOfLocalLicences();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.Filter);
            this.panel1.Controls.Add(this.tbLicenceID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 113);
            this.panel1.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(355, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 42);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.Location = new System.Drawing.Point(20, 0);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(44, 20);
            this.Filter.TabIndex = 0;
            this.Filter.Text = "Filter";
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // tbLicenceID
            // 
            this.tbLicenceID.Location = new System.Drawing.Point(154, 52);
            this.tbLicenceID.Name = "tbLicenceID";
            this.tbLicenceID.Size = new System.Drawing.Size(170, 20);
            this.tbLicenceID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "LicencesID:";
            // 
            // ctrlGetDetailsOfLocalLicences1
            // 
            this.ctrlGetDetailsOfLocalLicences1.Location = new System.Drawing.Point(3, 135);
            this.ctrlGetDetailsOfLocalLicences1.Name = "ctrlGetDetailsOfLocalLicences1";
            this.ctrlGetDetailsOfLocalLicences1.Size = new System.Drawing.Size(870, 373);
            this.ctrlGetDetailsOfLocalLicences1.TabIndex = 2;
            // 
            // ctrlShowLocalLicencesDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlGetDetailsOfLocalLicences1);
            this.Controls.Add(this.panel1);
            this.Name = "ctrlShowLocalLicencesDetailsWithFilter";
            this.Size = new System.Drawing.Size(904, 522);
            this.Load += new System.EventHandler(this.ctrlShowLocalLicencesDetailsWithFilter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Filter;
        private System.Windows.Forms.TextBox tbLicenceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private ctrlGetDetailsOfLocalLicences ctrlGetDetailsOfLocalLicences1;
    }
}
