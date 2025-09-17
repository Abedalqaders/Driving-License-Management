namespace ApplicationLayer.Control
{
    partial class ctrlSearchPerson
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
            this.pSearch = new System.Windows.Forms.Panel();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearchperson = new System.Windows.Forms.Button();
            this.txtboxFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.btnAddPerson);
            this.pSearch.Controls.Add(this.btnSearchperson);
            this.pSearch.Controls.Add(this.txtboxFilter);
            this.pSearch.Controls.Add(this.label2);
            this.pSearch.Controls.Add(this.comboBox1);
            this.pSearch.Location = new System.Drawing.Point(57, 20);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(754, 64);
            this.pSearch.TabIndex = 14;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(578, 20);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(128, 23);
            this.btnAddPerson.TabIndex = 11;
            this.btnAddPerson.Text = "Add New Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchperson
            // 
            this.btnSearchperson.Location = new System.Drawing.Point(455, 19);
            this.btnSearchperson.Name = "btnSearchperson";
            this.btnSearchperson.Size = new System.Drawing.Size(117, 23);
            this.btnSearchperson.TabIndex = 10;
            this.btnSearchperson.Text = "SearchPerson";
            this.btnSearchperson.UseVisualStyleBackColor = true;
            this.btnSearchperson.Click += new System.EventHandler(this.btnSearchperson_Click);
            // 
            // txtboxFilter
            // 
            this.txtboxFilter.Location = new System.Drawing.Point(243, 20);
            this.txtboxFilter.Name = "txtboxFilter";
            this.txtboxFilter.Size = new System.Drawing.Size(194, 20);
            this.txtboxFilter.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "FilterBy:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PersonID",
            "NationalID",
            "FullName"});
            this.comboBox1.Location = new System.Drawing.Point(116, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // ctrlSearchPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pSearch);
            this.Name = "ctrlSearchPerson";
            this.Size = new System.Drawing.Size(818, 93);
            this.Load += new System.EventHandler(this.ctrlSearchPerson_Load);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearchperson;
        private System.Windows.Forms.TextBox txtboxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
