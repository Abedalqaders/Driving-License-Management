namespace ApplicationLayer.Control
{
    partial class ctrlDrivingLicensepplicationinfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDlappID = new System.Windows.Forms.Label();
            this.labClassName = new System.Windows.Forms.Label();
            this.labPassedTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L App ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applied For Licences:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "PassedTest:";
            // 
            // labDlappID
            // 
            this.labDlappID.AutoSize = true;
            this.labDlappID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDlappID.Location = new System.Drawing.Point(194, 42);
            this.labDlappID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDlappID.Name = "labDlappID";
            this.labDlappID.Size = new System.Drawing.Size(31, 16);
            this.labDlappID.TabIndex = 3;
            this.labDlappID.Text = "???";
            this.labDlappID.Click += new System.EventHandler(this.label4_Click);
            // 
            // labClassName
            // 
            this.labClassName.AutoSize = true;
            this.labClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClassName.Location = new System.Drawing.Point(648, 44);
            this.labClassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labClassName.Name = "labClassName";
            this.labClassName.Size = new System.Drawing.Size(31, 16);
            this.labClassName.TabIndex = 4;
            this.labClassName.Text = "???";
            // 
            // labPassedTest
            // 
            this.labPassedTest.AutoSize = true;
            this.labPassedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassedTest.Location = new System.Drawing.Point(648, 103);
            this.labPassedTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPassedTest.Name = "labPassedTest";
            this.labPassedTest.Size = new System.Drawing.Size(31, 16);
            this.labPassedTest.TabIndex = 5;
            this.labPassedTest.Text = "???";
            // 
            // ctrlDrivingLicensepplicationinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labPassedTest);
            this.Controls.Add(this.labClassName);
            this.Controls.Add(this.labDlappID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctrlDrivingLicensepplicationinfo";
            this.Size = new System.Drawing.Size(852, 185);
            this.Load += new System.EventHandler(this.ctrlDrivingLicensepplicationinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDlappID;
        private System.Windows.Forms.Label labClassName;
        private System.Windows.Forms.Label labPassedTest;
    }
}
