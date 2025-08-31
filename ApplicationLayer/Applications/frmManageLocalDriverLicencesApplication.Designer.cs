namespace ApplicationLayer.Applications
{
    partial class frmManageLocalDriverLicencesApplication
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDriverLicencesApplication));
            this.dgvManagmentLocalLicences = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicatoinsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleVisonTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicencesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labTittle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagmentLocalLicences)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManagmentLocalLicences
            // 
            this.dgvManagmentLocalLicences.AllowUserToAddRows = false;
            this.dgvManagmentLocalLicences.AllowUserToDeleteRows = false;
            this.dgvManagmentLocalLicences.AllowUserToOrderColumns = true;
            this.dgvManagmentLocalLicences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagmentLocalLicences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagmentLocalLicences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagmentLocalLicences.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManagmentLocalLicences.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManagmentLocalLicences.Location = new System.Drawing.Point(12, 254);
            this.dgvManagmentLocalLicences.Name = "dgvManagmentLocalLicences";
            this.dgvManagmentLocalLicences.ReadOnly = true;
            this.dgvManagmentLocalLicences.Size = new System.Drawing.Size(1163, 312);
            this.dgvManagmentLocalLicences.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicatoinsDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.canelApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.schduleTestToolStripMenuItem,
            this.issueToolStripMenuItem,
            this.showLicencesToolStripMenuItem,
            this.showPersonLicencesHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 220);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicatoinsDetailsToolStripMenuItem
            // 
            this.showApplicatoinsDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showApplicatoinsDetailsToolStripMenuItem.Image")));
            this.showApplicatoinsDetailsToolStripMenuItem.Name = "showApplicatoinsDetailsToolStripMenuItem";
            this.showApplicatoinsDetailsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.showApplicatoinsDetailsToolStripMenuItem.Text = "Show Applicatoins Details";
            this.showApplicatoinsDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicatoinsDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AccessibleName = "EditMenu";
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteApplicationToolStripMenuItem.Image")));
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.deleteApplicationToolStripMenuItem.Text = "delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // canelApplicationToolStripMenuItem
            // 
            this.canelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("canelApplicationToolStripMenuItem.Image")));
            this.canelApplicationToolStripMenuItem.Name = "canelApplicationToolStripMenuItem";
            this.canelApplicationToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.canelApplicationToolStripMenuItem.Text = "cancel Application";
            this.canelApplicationToolStripMenuItem.Click += new System.EventHandler(this.canelApplicationToolStripMenuItem_Click);
            // 
            // schduleTestToolStripMenuItem
            // 
            this.schduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schduleVisonTestToolStripMenuItem,
            this.schduleWrittenTestToolStripMenuItem,
            this.schduleStreetTestToolStripMenuItem});
            this.schduleTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schduleTestToolStripMenuItem.Image")));
            this.schduleTestToolStripMenuItem.Name = "schduleTestToolStripMenuItem";
            this.schduleTestToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.schduleTestToolStripMenuItem.Text = "Schdule Test";
            this.schduleTestToolStripMenuItem.Click += new System.EventHandler(this.schduleTestToolStripMenuItem_Click);
            // 
            // schduleVisonTestToolStripMenuItem
            // 
            this.schduleVisonTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schduleVisonTestToolStripMenuItem.Image")));
            this.schduleVisonTestToolStripMenuItem.Name = "schduleVisonTestToolStripMenuItem";
            this.schduleVisonTestToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.schduleVisonTestToolStripMenuItem.Text = "Schdule Vison Test";
            this.schduleVisonTestToolStripMenuItem.Click += new System.EventHandler(this.schduleVisonTestToolStripMenuItem_Click);
            // 
            // schduleWrittenTestToolStripMenuItem
            // 
            this.schduleWrittenTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schduleWrittenTestToolStripMenuItem.Image")));
            this.schduleWrittenTestToolStripMenuItem.Name = "schduleWrittenTestToolStripMenuItem";
            this.schduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.schduleWrittenTestToolStripMenuItem.Text = "Schdule Written Test";
            this.schduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.schduleWrittenTestToolStripMenuItem_Click);
            // 
            // schduleStreetTestToolStripMenuItem
            // 
            this.schduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schduleStreetTestToolStripMenuItem.Image")));
            this.schduleStreetTestToolStripMenuItem.Name = "schduleStreetTestToolStripMenuItem";
            this.schduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.schduleStreetTestToolStripMenuItem.Text = "Schdule Street Test";
            this.schduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.schduleStreetTestToolStripMenuItem_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueToolStripMenuItem.Image")));
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.issueToolStripMenuItem.Text = "Issue Driving Licences (first time)";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.issueToolStripMenuItem_Click);
            // 
            // showLicencesToolStripMenuItem
            // 
            this.showLicencesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicencesToolStripMenuItem.Image")));
            this.showLicencesToolStripMenuItem.Name = "showLicencesToolStripMenuItem";
            this.showLicencesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.showLicencesToolStripMenuItem.Text = "Show Licences";
            this.showLicencesToolStripMenuItem.Click += new System.EventHandler(this.showLicencesToolStripMenuItem_Click);
            // 
            // showPersonLicencesHistoryToolStripMenuItem
            // 
            this.showPersonLicencesHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicencesHistoryToolStripMenuItem.Image")));
            this.showPersonLicencesHistoryToolStripMenuItem.Name = "showPersonLicencesHistoryToolStripMenuItem";
            this.showPersonLicencesHistoryToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.showPersonLicencesHistoryToolStripMenuItem.Text = "Show Person Licences History";
            this.showPersonLicencesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicencesHistoryToolStripMenuItem_Click);
            // 
            // labTittle
            // 
            this.labTittle.AutoSize = true;
            this.labTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTittle.ForeColor = System.Drawing.Color.Red;
            this.labTittle.Location = new System.Drawing.Point(357, 186);
            this.labTittle.Name = "labTittle";
            this.labTittle.Size = new System.Drawing.Size(422, 39);
            this.labTittle.TabIndex = 1;
            this.labTittle.Text = "Local Driving Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1082, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(244, 6);
            // 
            // frmManageLocalDriverLicencesApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 597);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTittle);
            this.Controls.Add(this.dgvManagmentLocalLicences);
            this.Name = "frmManageLocalDriverLicencesApplication";
            this.Text = "frmManageLocalDriverLicencesApplication";
            this.Load += new System.EventHandler(this.frmManageLocalDriverLicencesApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagmentLocalLicences)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManagmentLocalLicences;
        private System.Windows.Forms.Label labTittle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem showApplicatoinsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleVisonTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicencesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}