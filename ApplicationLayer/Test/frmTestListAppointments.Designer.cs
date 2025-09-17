namespace ApplicationLayer.Test
{
    partial class frmTestListAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestListAppointments));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTestAppoitment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestAppoitment = new System.Windows.Forms.Button();
            this.ctrlLicencesApplication_and_ApplicatonInfo2 = new ApplicationLayer.Control.ctrlLicencesApplication_and_ApplicatonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppoitment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vison Test Appointment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTestAppoitment
            // 
            this.dgvTestAppoitment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppoitment.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppoitment.Location = new System.Drawing.Point(-3, 656);
            this.dgvTestAppoitment.Name = "dgvTestAppoitment";
            this.dgvTestAppoitment.Size = new System.Drawing.Size(785, 168);
            this.dgvTestAppoitment.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Appointment";
            // 
            // btnTestAppoitment
            // 
            this.btnTestAppoitment.Image = ((System.Drawing.Image)(resources.GetObject("btnTestAppoitment.Image")));
            this.btnTestAppoitment.Location = new System.Drawing.Point(707, 608);
            this.btnTestAppoitment.Name = "btnTestAppoitment";
            this.btnTestAppoitment.Size = new System.Drawing.Size(75, 42);
            this.btnTestAppoitment.TabIndex = 6;
            this.btnTestAppoitment.UseVisualStyleBackColor = true;
            this.btnTestAppoitment.Click += new System.EventHandler(this.btnTestAppoitment_Click);
            // 
            // ctrlLicencesApplication_and_ApplicatonInfo2
            // 
            this.ctrlLicencesApplication_and_ApplicatonInfo2.Location = new System.Drawing.Point(-18, 123);
            this.ctrlLicencesApplication_and_ApplicatonInfo2.Name = "ctrlLicencesApplication_and_ApplicatonInfo2";
            this.ctrlLicencesApplication_and_ApplicatonInfo2.Size = new System.Drawing.Size(800, 527);
            this.ctrlLicencesApplication_and_ApplicatonInfo2.TabIndex = 7;
            // 
            // frmTestListAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 852);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTestAppoitment);
            this.Controls.Add(this.ctrlLicencesApplication_and_ApplicatonInfo2);
            this.Controls.Add(this.dgvTestAppoitment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmTestListAppointments";
            this.Text = "frmVisonTest";
            this.Load += new System.EventHandler(this.frmTestListAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppoitment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTestAppoitment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestAppoitment;
        private Control.ctrlLicencesApplication_and_ApplicatonInfo ctrlLicencesApplication_and_ApplicatonInfo2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}