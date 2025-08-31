namespace ApplicationLayer.Users
{
    partial class frmChangePasswordUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtbNewPassword = new System.Windows.Forms.TextBox();
            this.txtbConfirmPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ctrlShowPersonDetails1 = new ApplicationLayer.People.ctrlShowPersonDetails();
            this.showUserDetails1 = new ApplicationLayer.Control.ShowUserDetails();
            this.ctrlShowPersonpassword = new ApplicationLayer.People.ctrlShowPersonDetails();
            this.ctrlShowUserInfoPassword = new ApplicationLayer.Control.ShowUserDetails();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbCurrentPassword
            // 
            this.txtbCurrentPassword.Location = new System.Drawing.Point(214, 489);
            this.txtbCurrentPassword.Name = "txtbCurrentPassword";
            this.txtbCurrentPassword.PasswordChar = '*';
            this.txtbCurrentPassword.Size = new System.Drawing.Size(183, 20);
            this.txtbCurrentPassword.TabIndex = 5;
            // 
            // txtbNewPassword
            // 
            this.txtbNewPassword.Location = new System.Drawing.Point(217, 521);
            this.txtbNewPassword.Name = "txtbNewPassword";
            this.txtbNewPassword.PasswordChar = '*';
            this.txtbNewPassword.Size = new System.Drawing.Size(183, 20);
            this.txtbNewPassword.TabIndex = 6;
            // 
            // txtbConfirmPassword
            // 
            this.txtbConfirmPassword.Location = new System.Drawing.Point(217, 560);
            this.txtbConfirmPassword.Name = "txtbConfirmPassword";
            this.txtbConfirmPassword.PasswordChar = '*';
            this.txtbConfirmPassword.Size = new System.Drawing.Size(183, 20);
            this.txtbConfirmPassword.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(725, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(12, 28);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(791, 327);
            this.ctrlShowPersonDetails1.TabIndex = 0;
            // 
            // showUserDetails1
            // 
            this.showUserDetails1.Location = new System.Drawing.Point(1, 361);
            this.showUserDetails1.Name = "showUserDetails1";
            this.showUserDetails1.Size = new System.Drawing.Size(867, 141);
            this.showUserDetails1.TabIndex = 1;
            // 
            // ctrlShowPersonpassword
            // 
            this.ctrlShowPersonpassword.Location = new System.Drawing.Point(15, 14);
            this.ctrlShowPersonpassword.Name = "ctrlShowPersonpassword";
            this.ctrlShowPersonpassword.Size = new System.Drawing.Size(846, 316);
            this.ctrlShowPersonpassword.TabIndex = 10;
            // 
            // ctrlShowUserInfoPassword
            // 
            this.ctrlShowUserInfoPassword.Location = new System.Drawing.Point(-9, 336);
            this.ctrlShowUserInfoPassword.Name = "ctrlShowUserInfoPassword";
            this.ctrlShowUserInfoPassword.Size = new System.Drawing.Size(809, 122);
            this.ctrlShowUserInfoPassword.TabIndex = 11;
            // 
            // frmChangePasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 635);
            this.Controls.Add(this.ctrlShowUserInfoPassword);
            this.Controls.Add(this.ctrlShowPersonpassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbConfirmPassword);
            this.Controls.Add(this.txtbNewPassword);
            this.Controls.Add(this.txtbCurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChangePasswordUser";
            this.Text = "frmChangePasswordUser";
            this.Load += new System.EventHandler(this.frmChangePasswordUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.ctrlShowPersonDetails ctrlShowPersonDetails1;
        private Control.ShowUserDetails showUserDetails1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbCurrentPassword;
        private System.Windows.Forms.TextBox txtbNewPassword;
        private System.Windows.Forms.TextBox txtbConfirmPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private People.ctrlShowPersonDetails ctrlShowPersonpassword;
        private Control.ShowUserDetails ctrlShowUserInfoPassword;
    }
}