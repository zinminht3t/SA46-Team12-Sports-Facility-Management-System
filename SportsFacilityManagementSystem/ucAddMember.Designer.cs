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
            this.label13 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblWarningEmail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(446, 395);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 31);
            this.txtEmail.TabIndex = 39;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(446, 339);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(174, 31);
            this.txtMobile.TabIndex = 37;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(446, 456);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(326, 70);
            this.txtAddress.TabIndex = 36;
            // 
            // txtICNo
            // 
            this.txtICNo.Location = new System.Drawing.Point(446, 147);
            this.txtICNo.Name = "txtICNo";
            this.txtICNo.Size = new System.Drawing.Size(326, 31);
            this.txtICNo.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(446, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 31);
            this.txtName.TabIndex = 34;
            // 
            // labelJoindate
            // 
            this.labelJoindate.AutoSize = true;
            this.labelJoindate.Location = new System.Drawing.Point(266, 566);
            this.labelJoindate.Name = "labelJoindate";
            this.labelJoindate.Size = new System.Drawing.Size(135, 25);
            this.labelJoindate.TabIndex = 31;
            this.labelJoindate.Text = "* Join Date : ";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(266, 289);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(163, 25);
            this.labelDob.TabIndex = 30;
            this.labelDob.Text = "* Date of Birth : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Email : ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(266, 209);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(115, 25);
            this.labelGender.TabIndex = 28;
            this.labelGender.Text = "* Gender : ";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Location = new System.Drawing.Point(266, 344);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(189, 25);
            this.labelMobile.TabIndex = 27;
            this.labelMobile.Text = "* Mobile Number : ";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(266, 455);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(123, 25);
            this.labelAddress.TabIndex = 26;
            this.labelAddress.Text = "* Address : ";
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Location = new System.Drawing.Point(266, 152);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(152, 25);
            this.lblIC.TabIndex = 25;
            this.lblIC.Text = "* Identity No. : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(266, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 25);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "* Name : ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(579, 698);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 50);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(348, 698);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 50);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpJoindate
            // 
            this.dtpJoindate.Location = new System.Drawing.Point(446, 566);
            this.dtpJoindate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpJoindate.MinDate = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            this.dtpJoindate.Name = "dtpJoindate";
            this.dtpJoindate.Size = new System.Drawing.Size(326, 31);
            this.dtpJoindate.TabIndex = 48;
            // 
            // lblWarningName
            // 
            this.lblWarningName.AutoSize = true;
            this.lblWarningName.ForeColor = System.Drawing.Color.Red;
            this.lblWarningName.Location = new System.Drawing.Point(782, 94);
            this.lblWarningName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningName.Name = "lblWarningName";
            this.lblWarningName.Size = new System.Drawing.Size(232, 25);
            this.lblWarningName.TabIndex = 49;
            this.lblWarningName.Text = "* Field cannot be blank";
            this.lblWarningName.Visible = false;
            // 
            // lblWarningIC
            // 
            this.lblWarningIC.AutoSize = true;
            this.lblWarningIC.ForeColor = System.Drawing.Color.Red;
            this.lblWarningIC.Location = new System.Drawing.Point(783, 147);
            this.lblWarningIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningIC.Name = "lblWarningIC";
            this.lblWarningIC.Size = new System.Drawing.Size(232, 25);
            this.lblWarningIC.TabIndex = 50;
            this.lblWarningIC.Text = "* Field cannot be blank";
            this.lblWarningIC.Visible = false;
            // 
            // lblWarningGender
            // 
            this.lblWarningGender.AutoSize = true;
            this.lblWarningGender.ForeColor = System.Drawing.Color.Red;
            this.lblWarningGender.Location = new System.Drawing.Point(783, 205);
            this.lblWarningGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningGender.Name = "lblWarningGender";
            this.lblWarningGender.Size = new System.Drawing.Size(232, 25);
            this.lblWarningGender.TabIndex = 51;
            this.lblWarningGender.Text = "* Field cannot be blank";
            this.lblWarningGender.Visible = false;
            // 
            // lblWarningMobile
            // 
            this.lblWarningMobile.AutoSize = true;
            this.lblWarningMobile.ForeColor = System.Drawing.Color.Red;
            this.lblWarningMobile.Location = new System.Drawing.Point(784, 339);
            this.lblWarningMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningMobile.Name = "lblWarningMobile";
            this.lblWarningMobile.Size = new System.Drawing.Size(232, 25);
            this.lblWarningMobile.TabIndex = 53;
            this.lblWarningMobile.Text = "* Field cannot be blank";
            this.lblWarningMobile.Visible = false;
            // 
            // lblWarningAddress
            // 
            this.lblWarningAddress.AutoSize = true;
            this.lblWarningAddress.ForeColor = System.Drawing.Color.Red;
            this.lblWarningAddress.Location = new System.Drawing.Point(784, 461);
            this.lblWarningAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningAddress.Name = "lblWarningAddress";
            this.lblWarningAddress.Size = new System.Drawing.Size(232, 25);
            this.lblWarningAddress.TabIndex = 54;
            this.lblWarningAddress.Text = "* Field cannot be blank";
            this.lblWarningAddress.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 636);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 25);
            this.label13.TabIndex = 55;
            this.label13.Text = "*Compulsory field";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(234, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(588, 62);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Add New Members";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(446, 284);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDOB.MaxDate = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 30, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(326, 31);
            this.dtpDOB.TabIndex = 57;
            this.dtpDOB.Value = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            // 
            // lblWarningEmail
            // 
            this.lblWarningEmail.AutoSize = true;
            this.lblWarningEmail.ForeColor = System.Drawing.Color.Red;
            this.lblWarningEmail.Location = new System.Drawing.Point(784, 395);
            this.lblWarningEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningEmail.Name = "lblWarningEmail";
            this.lblWarningEmail.Size = new System.Drawing.Size(232, 25);
            this.lblWarningEmail.TabIndex = 58;
            this.lblWarningEmail.Text = "* Field cannot be blank";
            this.lblWarningEmail.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Location = new System.Drawing.Point(446, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 67);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(21, 30);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(90, 29);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(187, 29);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(114, 29);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // ucAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWarningEmail);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label13);
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
            this.Name = "ucAddMember";
            this.Size = new System.Drawing.Size(1128, 794);
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblWarningEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
    }
}
