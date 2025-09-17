namespace ApplicationLayer.Control
{
    partial class ctrlShowLicencesHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlShowLicencesHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.tpInterNational = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInterNational = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicencesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.tpInterNational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterNational)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 255);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLocal);
            this.tabControl1.Controls.Add(this.tpInterNational);
            this.tabControl1.Location = new System.Drawing.Point(11, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 236);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tpInterNational_Click);
            // 
            // tpLocal
            // 
            this.tpLocal.Controls.Add(this.label2);
            this.tpLocal.Controls.Add(this.dgvLocal);
            this.tpLocal.Location = new System.Drawing.Point(4, 22);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(937, 210);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "LocalLicences";
            this.tpLocal.UseVisualStyleBackColor = true;
            this.tpLocal.Click += new System.EventHandler(this.tpLocal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Licences History";
            // 
            // dgvLocal
            // 
            this.dgvLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocal.Location = new System.Drawing.Point(2, 35);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.Size = new System.Drawing.Size(932, 169);
            this.dgvLocal.TabIndex = 0;
            // 
            // tpInterNational
            // 
            this.tpInterNational.Controls.Add(this.label3);
            this.tpInterNational.Controls.Add(this.dgvInterNational);
            this.tpInterNational.Location = new System.Drawing.Point(4, 22);
            this.tpInterNational.Name = "tpInterNational";
            this.tpInterNational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInterNational.Size = new System.Drawing.Size(937, 210);
            this.tpInterNational.TabIndex = 1;
            this.tpInterNational.Text = "InterNational";
            this.tpInterNational.UseVisualStyleBackColor = true;
            this.tpInterNational.Click += new System.EventHandler(this.tpInterNational_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "InterNational Licences History";
            // 
            // dgvInterNational
            // 
            this.dgvInterNational.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInterNational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterNational.Location = new System.Drawing.Point(0, 35);
            this.dgvInterNational.Name = "dgvInterNational";
            this.dgvInterNational.Size = new System.Drawing.Size(934, 169);
            this.dgvInterNational.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DriverLicences";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicencesDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 48);
            // 
            // showLicencesDetailsToolStripMenuItem
            // 
            this.showLicencesDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicencesDetailsToolStripMenuItem.Image")));
            this.showLicencesDetailsToolStripMenuItem.Name = "showLicencesDetailsToolStripMenuItem";
            this.showLicencesDetailsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.showLicencesDetailsToolStripMenuItem.Text = "Show Licences Details";
            this.showLicencesDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicencesDetailsToolStripMenuItem_Click);
            // 
            // ctrlShowLicencesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlShowLicencesHistory";
            this.Size = new System.Drawing.Size(991, 280);
            this.Load += new System.EventHandler(this.ctrlShowLicencesHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.tpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.tpInterNational.ResumeLayout(false);
            this.tpInterNational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterNational)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.TabPage tpInterNational;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInterNational;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicencesDetailsToolStripMenuItem;
    }
}
