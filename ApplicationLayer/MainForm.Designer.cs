namespace ApplicationLayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labUserName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interNatonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaiendLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relasedDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.Color.Black;
            this.labUserName.Location = new System.Drawing.Point(1006, 577);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(128, 25);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "CurrentUser";
            this.labUserName.Click += new System.EventHandler(this.labUserName_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1833, 72);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenessToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.mangToolStripMenuItem});
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 68);
            this.toolStripMenuItem2.Text = "Applications";
            // 
            // drivingLicenessToolStripMenuItem
            // 
            this.drivingLicenessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem,
            this.relaseDetainedDrivingLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLicenessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drivingLicenessToolStripMenuItem.Image")));
            this.drivingLicenessToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLicenessToolStripMenuItem.Name = "drivingLicenessToolStripMenuItem";
            this.drivingLicenessToolStripMenuItem.Size = new System.Drawing.Size(263, 70);
            this.drivingLicenessToolStripMenuItem.Text = "Driving Licenses Services";
            this.drivingLicenessToolStripMenuItem.Click += new System.EventHandler(this.drivingLicenessToolStripMenuItem_Click);
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenceToolStripMenuItem,
            this.interNatonalToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newDrivingLicenseToolStripMenuItem.Image")));
            this.newDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            this.newDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenseToolStripMenuItem_Click);
            // 
            // licenceToolStripMenuItem
            // 
            this.licenceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licenceToolStripMenuItem.Image")));
            this.licenceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            this.licenceToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.licenceToolStripMenuItem.Text = "Local Licences";
            this.licenceToolStripMenuItem.Click += new System.EventHandler(this.licenceToolStripMenuItem_Click);
            // 
            // interNatonalToolStripMenuItem
            // 
            this.interNatonalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("interNatonalToolStripMenuItem.Image")));
            this.interNatonalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.interNatonalToolStripMenuItem.Name = "interNatonalToolStripMenuItem";
            this.interNatonalToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.interNatonalToolStripMenuItem.Text = "International license";
            this.interNatonalToolStripMenuItem.Click += new System.EventHandler(this.interNatonalToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renewDrivingLicenseToolStripMenuItem.Image")));
            this.renewDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replacmentForLostOrDamagedLicenseToolStripMenuItem
            // 
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("replacmentForLostOrDamagedLicenseToolStripMenuItem.Image")));
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Name = "replacmentForLostOrDamagedLicenseToolStripMenuItem";
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacment for Lost or Damaged License";
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacmentForLostOrDamagedLicenseToolStripMenuItem_Click);
            // 
            // relaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.relaseDetainedDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relaseDetainedDrivingLicenseToolStripMenuItem.Image")));
            this.relaseDetainedDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relaseDetainedDrivingLicenseToolStripMenuItem.Name = "relaseDetainedDrivingLicenseToolStripMenuItem";
            this.relaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.relaseDetainedDrivingLicenseToolStripMenuItem.Text = "Relase Detained Driving License ";
            this.relaseDetainedDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.relaseDetainedDrivingLicenseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retakeTestToolStripMenuItem.Image")));
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsToolStripMenuItem.Image")));
            this.manageApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(263, 70);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localToolStripMenuItem.Image")));
            this.localToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.localToolStripMenuItem.Text = "Local Driver Licenes Applications";
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseToolStripMenuItem.Image")));
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.internationalLicenseToolStripMenuItem.Text = "International license";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicenseToolStripMenuItem,
            this.detaiendLicenseToolStripMenuItem,
            this.relasedDetainedLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicensesToolStripMenuItem.Image")));
            this.detainLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(263, 70);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicenseToolStripMenuItem
            // 
            this.manageDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDetainedLicenseToolStripMenuItem.Image")));
            this.manageDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainedLicenseToolStripMenuItem.Name = "manageDetainedLicenseToolStripMenuItem";
            this.manageDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.manageDetainedLicenseToolStripMenuItem.Text = "Manage Detained License";
            this.manageDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicenseToolStripMenuItem_Click);
            // 
            // detaiendLicenseToolStripMenuItem
            // 
            this.detaiendLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detaiendLicenseToolStripMenuItem.Image")));
            this.detaiendLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detaiendLicenseToolStripMenuItem.Name = "detaiendLicenseToolStripMenuItem";
            this.detaiendLicenseToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.detaiendLicenseToolStripMenuItem.Text = "Detaiend License";
            this.detaiendLicenseToolStripMenuItem.Click += new System.EventHandler(this.detaiendLicenseToolStripMenuItem_Click);
            // 
            // relasedDetainedLicenseToolStripMenuItem
            // 
            this.relasedDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relasedDetainedLicenseToolStripMenuItem.Image")));
            this.relasedDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relasedDetainedLicenseToolStripMenuItem.Name = "relasedDetainedLicenseToolStripMenuItem";
            this.relasedDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.relasedDetainedLicenseToolStripMenuItem.Text = "Relased Detained License";
            this.relasedDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.relasedDetainedLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationTypesToolStripMenuItem.Image")));
            this.manageApplicationTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationTypesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(263, 70);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // mangToolStripMenuItem
            // 
            this.mangToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mangToolStripMenuItem.Image")));
            this.mangToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mangToolStripMenuItem.Name = "mangToolStripMenuItem";
            this.mangToolStripMenuItem.Size = new System.Drawing.Size(263, 70);
            this.mangToolStripMenuItem.Text = "Manage Test Types";
            this.mangToolStripMenuItem.Click += new System.EventHandler(this.mangToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(103, 68);
            this.toolStripMenuItem3.Text = "People";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(119, 68);
            this.toolStripMenuItem4.Text = "Drivers";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(97, 68);
            this.toolStripMenuItem5.Text = "Users";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserDetailsToolStripMenuItem,
            this.changePasswToolStripMenuItem,
            this.toolStripMenuItem7});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 68);
            this.toolStripMenuItem1.Text = "Account Mangment";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // showUserDetailsToolStripMenuItem
            // 
            this.showUserDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showUserDetailsToolStripMenuItem.Image")));
            this.showUserDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showUserDetailsToolStripMenuItem.Name = "showUserDetailsToolStripMenuItem";
            this.showUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 36);
            this.showUserDetailsToolStripMenuItem.Text = "Show User Details";
            this.showUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.showUserDetailsToolStripMenuItem_Click);
            // 
            // changePasswToolStripMenuItem
            // 
            this.changePasswToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswToolStripMenuItem.Image")));
            this.changePasswToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswToolStripMenuItem.Name = "changePasswToolStripMenuItem";
            this.changePasswToolStripMenuItem.Size = new System.Drawing.Size(182, 36);
            this.changePasswToolStripMenuItem.Text = "Change Password";
            this.changePasswToolStripMenuItem.Click += new System.EventHandler(this.changePasswToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(182, 36);
            this.toolStripMenuItem7.Text = "Log out";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1833, 770);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem showUserDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacmentForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interNatonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaiendLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relasedDetainedLicenseToolStripMenuItem;
    }
}