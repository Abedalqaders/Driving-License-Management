namespace ApplicationLayer.Users
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctrlSearchPerson1 = new ApplicationLayer.Control.ctrlSearchPerson();
            this.ctrlShowPerson = new ApplicationLayer.People.ctrlShowPersonDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sav = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkbActive = new System.Windows.Forms.CheckBox();
            this.txtbConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUserName = new System.Windows.Forms.TextBox();
            this.labUserID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labTittle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 570);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrlSearchPerson1);
            this.tabPage1.Controls.Add(this.ctrlShowPerson);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ctrlSearchPerson1
            // 
            this.ctrlSearchPerson1.Location = new System.Drawing.Point(52, 20);
            this.ctrlSearchPerson1.Name = "ctrlSearchPerson1";
            this.ctrlSearchPerson1.Size = new System.Drawing.Size(818, 93);
            this.ctrlSearchPerson1.TabIndex = 15;
            // 
            // ctrlShowPerson
            // 
            this.ctrlShowPerson.Location = new System.Drawing.Point(62, 104);
            this.ctrlShowPerson.Name = "ctrlShowPerson";
            this.ctrlShowPerson.Size = new System.Drawing.Size(823, 405);
            this.ctrlShowPerson.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(906, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 76);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(977, 462);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 76);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sav);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.checkbActive);
            this.tabPage2.Controls.Add(this.txtbConfirmPassword);
            this.tabPage2.Controls.Add(this.txtbPassword);
            this.tabPage2.Controls.Add(this.txtbUserName);
            this.tabPage2.Controls.Add(this.labUserID);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sav
            // 
            this.sav.Image = ((System.Drawing.Image)(resources.GetObject("sav.Image")));
            this.sav.Location = new System.Drawing.Point(989, 453);
            this.sav.Name = "sav";
            this.sav.Size = new System.Drawing.Size(75, 85);
            this.sav.TabIndex = 11;
            this.sav.UseVisualStyleBackColor = true;
            this.sav.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(913, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 85);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbActive
            // 
            this.checkbActive.AutoSize = true;
            this.checkbActive.Location = new System.Drawing.Point(170, 313);
            this.checkbActive.Name = "checkbActive";
            this.checkbActive.Size = new System.Drawing.Size(67, 17);
            this.checkbActive.TabIndex = 9;
            this.checkbActive.Text = "Is Active";
            this.checkbActive.UseVisualStyleBackColor = true;
            // 
            // txtbConfirmPassword
            // 
            this.txtbConfirmPassword.Location = new System.Drawing.Point(170, 262);
            this.txtbConfirmPassword.Name = "txtbConfirmPassword";
            this.txtbConfirmPassword.PasswordChar = '*';
            this.txtbConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.txtbConfirmPassword.TabIndex = 8;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(170, 213);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(137, 20);
            this.txtbPassword.TabIndex = 7;
            // 
            // txtbUserName
            // 
            this.txtbUserName.Location = new System.Drawing.Point(170, 168);
            this.txtbUserName.Name = "txtbUserName";
            this.txtbUserName.Size = new System.Drawing.Size(137, 20);
            this.txtbUserName.TabIndex = 6;
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.Location = new System.Drawing.Point(167, 124);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(25, 13);
            this.labUserID.TabIndex = 5;
            this.labUserID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "UserName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "ConfirmPassword:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID:";
            // 
            // labTittle
            // 
            this.labTittle.AutoSize = true;
            this.labTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTittle.Location = new System.Drawing.Point(444, 43);
            this.labTittle.Name = "labTittle";
            this.labTittle.Size = new System.Drawing.Size(202, 33);
            this.labTittle.TabIndex = 12;
            this.labTittle.Text = "Add New User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 642);
            this.Controls.Add(this.labTittle);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddUpdateUser";
            this.Text = "frmAddUpdateUser";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbActive;
        private System.Windows.Forms.TextBox txtbConfirmPassword;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbUserName;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labTittle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button sav;
        private System.Windows.Forms.Button button1;
        private People.ctrlShowPersonDetails ctrlShowPerson;
        private Control.ctrlSearchPerson ctrlSearchPerson1;
    }
}