namespace SportsFacilityManagementSystem
{
    partial class ucAddMember
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtICNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelJoindate = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.lblIC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpJoindate = new System.Windows.Forms.DateTimePicker();
            this.lblWarningName = new System.Windows.Forms.Label();
            this.lblWarningIC = new System.Windows.Forms.Label();
            this.lblWarningGender = new System.Windows.Forms.Label();
            this.lblWarningMobile = new System.Windows.Forms.Label();
            this.lblWarningAddress = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblWarningEmail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(297, 253);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 22);
            this.txtEmail.TabIndex = 39;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(297, 217);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(117, 22);
            this.txtMobile.TabIndex = 37;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(297, 292);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(219, 46);
            this.txtAddress.TabIndex = 36;
            // 
            // txtICNo
            // 
            this.txtICNo.Location = new System.Drawing.Point(297, 94);
            this.txtICNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtICNo.Name = "txtICNo";
            this.txtICNo.Size = new System.Drawing.Size(219, 22);
            this.txtICNo.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(297, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 22);
            this.txtName.TabIndex = 34;
            // 
            // labelJoindate
            // 
            this.labelJoindate.AutoSize = true;
            this.labelJoindate.Location = new System.Drawing.Point(177, 362);
            this.labelJoindate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJoindate.Name = "labelJoindate";
            this.labelJoindate.Size = new System.Drawing.Size(80, 17);
            this.labelJoindate.TabIndex = 31;
            this.labelJoindate.Text = "Join Date : ";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(177, 185);
            this.labelDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(99, 17);
            this.labelDob.TabIndex = 30;
            this.labelDob.Text = "Date of Birth : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Email : ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(177, 134);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(68, 17);
            this.labelGender.TabIndex = 28;
            this.labelGender.Text = "Gender : ";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Location = new System.Drawing.Point(177, 220);
            this.labelMobile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(115, 17);
            this.labelMobile.TabIndex = 27;
            this.labelMobile.Text = "Mobile Number : ";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(177, 291);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(72, 17);
            this.labelAddress.TabIndex = 26;
            this.labelAddress.Text = "Address : ";
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Location = new System.Drawing.Point(177, 97);
            this.lblIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(91, 17);
            this.lblIC.TabIndex = 25;
            this.lblIC.Text = "Identity No. : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(177, 61);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 17);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name : ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(386, 447);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 32);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(232, 447);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 32);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpJoindate
            // 
            this.dtpJoindate.Location = new System.Drawing.Point(297, 362);
            this.dtpJoindate.MinDate = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            this.dtpJoindate.Name = "dtpJoindate";
            this.dtpJoindate.Size = new System.Drawing.Size(272, 22);
            this.dtpJoindate.TabIndex = 48;
            // 
            // lblWarningName
            // 
            this.lblWarningName.AutoSize = true;
            this.lblWarningName.ForeColor = System.Drawing.Color.Red;
            this.lblWarningName.Location = new System.Drawing.Point(521, 60);
            this.lblWarningName.Name = "lblWarningName";
            this.lblWarningName.Size = new System.Drawing.Size(152, 17);
            this.lblWarningName.TabIndex = 49;
            this.lblWarningName.Text = "* Field cannot be blank";
            this.lblWarningName.Visible = false;
            // 
            // lblWarningIC
            // 
            this.lblWarningIC.AutoSize = true;
            this.lblWarningIC.ForeColor = System.Drawing.Color.Red;
            this.lblWarningIC.Location = new System.Drawing.Point(522, 94);
            this.lblWarningIC.Name = "lblWarningIC";
            this.lblWarningIC.Size = new System.Drawing.Size(152, 17);
            this.lblWarningIC.TabIndex = 50;
            this.lblWarningIC.Text = "* Field cannot be blank";
            this.lblWarningIC.Visible = false;
            // 
            // lblWarningGender
            // 
            this.lblWarningGender.AutoSize = true;
            this.lblWarningGender.ForeColor = System.Drawing.Color.Red;
            this.lblWarningGender.Location = new System.Drawing.Point(522, 131);
            this.lblWarningGender.Name = "lblWarningGender";
            this.lblWarningGender.Size = new System.Drawing.Size(152, 17);
            this.lblWarningGender.TabIndex = 51;
            this.lblWarningGender.Text = "* Field cannot be blank";
            this.lblWarningGender.Visible = false;
            // 
            // lblWarningMobile
            // 
            this.lblWarningMobile.AutoSize = true;
            this.lblWarningMobile.ForeColor = System.Drawing.Color.Red;
            this.lblWarningMobile.Location = new System.Drawing.Point(523, 217);
            this.lblWarningMobile.Name = "lblWarningMobile";
            this.lblWarningMobile.Size = new System.Drawing.Size(152, 17);
            this.lblWarningMobile.TabIndex = 53;
            this.lblWarningMobile.Text = "* Field cannot be blank";
            this.lblWarningMobile.Visible = false;
            // 
            // lblWarningAddress
            // 
            this.lblWarningAddress.AutoSize = true;
            this.lblWarningAddress.ForeColor = System.Drawing.Color.Red;
            this.lblWarningAddress.Location = new System.Drawing.Point(523, 295);
            this.lblWarningAddress.Name = "lblWarningAddress";
            this.lblWarningAddress.Size = new System.Drawing.Size(152, 17);
            this.lblWarningAddress.TabIndex = 54;
            this.lblWarningAddress.Text = "* Field cannot be blank";
            this.lblWarningAddress.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(156, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 40);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Add New Members";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(297, 182);
            this.dtpDOB.MaxDate = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 30, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(272, 22);
            this.dtpDOB.TabIndex = 57;
            this.dtpDOB.Value = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            // 
            // lblWarningEmail
            // 
            this.lblWarningEmail.AutoSize = true;
            this.lblWarningEmail.ForeColor = System.Drawing.Color.Red;
            this.lblWarningEmail.Location = new System.Drawing.Point(523, 253);
            this.lblWarningEmail.Name = "lblWarningEmail";
            this.lblWarningEmail.Size = new System.Drawing.Size(152, 17);
            this.lblWarningEmail.TabIndex = 58;
            this.lblWarningEmail.Text = "* Field cannot be blank";
            this.lblWarningEmail.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Location = new System.Drawing.Point(297, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(217, 43);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(125, 19);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(75, 21);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(14, 19);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(59, 21);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // ucAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWarningEmail);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWarningAddress);
            this.Controls.Add(this.lblWarningMobile);
            this.Controls.Add(this.lblWarningGender);
            this.Controls.Add(this.lblWarningIC);
            this.Controls.Add(this.lblWarningName);
            this.Controls.Add(this.dtpJoindate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtICNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelJoindate);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.lblIC);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucAddMember";
            this.Size = new System.Drawing.Size(752, 508);
            this.Load += new System.EventHandler(this.ucAddMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtICNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelJoindate;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label lblIC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpJoindate;
        private System.Windows.Forms.Label lblWarningName;
        private System.Windows.Forms.Label lblWarningIC;
        private System.Windows.Forms.Label lblWarningGender;
        private System.Windows.Forms.Label lblWarningMobile;
        private System.Windows.Forms.Label lblWarningAddress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblWarningEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
    }
}
