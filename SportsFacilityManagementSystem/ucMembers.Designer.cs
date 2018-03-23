namespace SportsFacilityManagementSystem
{
    partial class ucMembers
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
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearchResults = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtICNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWarningKeyword = new System.Windows.Forms.Label();
            this.lblWarningSearchBy = new System.Windows.Forms.Label();
            this.lblWarningSearchResult = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpJoin = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.gbSearchResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by : ";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Name",
            "IC Number",
            "Mobile Number",
            "Email"});
            this.cmbSearchBy.Location = new System.Drawing.Point(162, 119);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(342, 33);
            this.cmbSearchBy.TabIndex = 1;
            this.cmbSearchBy.Text = "Select";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(566, 119);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(326, 31);
            this.txtKeyword.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(706, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 47);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(160, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(734, 62);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Search Members";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSearchResults
            // 
            this.gbSearchResults.Controls.Add(this.groupBox1);
            this.gbSearchResults.Controls.Add(this.cmbStatus);
            this.gbSearchResults.Controls.Add(this.dtpExpiry);
            this.gbSearchResults.Controls.Add(this.dtpJoin);
            this.gbSearchResults.Controls.Add(this.dtpDOB);
            this.gbSearchResults.Controls.Add(this.btnReset);
            this.gbSearchResults.Controls.Add(this.btnUpdate);
            this.gbSearchResults.Controls.Add(this.txtEmail);
            this.gbSearchResults.Controls.Add(this.txtMobile);
            this.gbSearchResults.Controls.Add(this.txtAddress);
            this.gbSearchResults.Controls.Add(this.txtICNo);
            this.gbSearchResults.Controls.Add(this.txtName);
            this.gbSearchResults.Controls.Add(this.label11);
            this.gbSearchResults.Controls.Add(this.label10);
            this.gbSearchResults.Controls.Add(this.label9);
            this.gbSearchResults.Controls.Add(this.label8);
            this.gbSearchResults.Controls.Add(this.label7);
            this.gbSearchResults.Controls.Add(this.label6);
            this.gbSearchResults.Controls.Add(this.label5);
            this.gbSearchResults.Controls.Add(this.label4);
            this.gbSearchResults.Controls.Add(this.lbl);
            this.gbSearchResults.Controls.Add(this.lblName);
            this.gbSearchResults.Location = new System.Drawing.Point(122, 219);
            this.gbSearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearchResults.Name = "gbSearchResults";
            this.gbSearchResults.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearchResults.Size = new System.Drawing.Size(834, 569);
            this.gbSearchResults.TabIndex = 58;
            this.gbSearchResults.TabStop = false;
            this.gbSearchResults.Text = "Search Results";
            this.gbSearchResults.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(174, 513);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(188, 47);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(592, 513);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 47);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(378, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(402, 31);
            this.txtEmail.TabIndex = 41;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(378, 186);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(402, 31);
            this.txtMobile.TabIndex = 39;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(378, 109);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(402, 70);
            this.txtAddress.TabIndex = 38;
            // 
            // txtICNo
            // 
            this.txtICNo.Location = new System.Drawing.Point(378, 69);
            this.txtICNo.Name = "txtICNo";
            this.txtICNo.Size = new System.Drawing.Size(402, 31);
            this.txtICNo.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(378, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 31);
            this.txtName.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Expiry Date : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Join Date : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Date of Birth : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Email : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gender : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mobile Number : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Address : ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(51, 75);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(131, 25);
            this.lbl.TabIndex = 27;
            this.lbl.Text = "IC Number : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 25);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name : ";
            // 
            // lblWarningKeyword
            // 
            this.lblWarningKeyword.AutoSize = true;
            this.lblWarningKeyword.ForeColor = System.Drawing.Color.Red;
            this.lblWarningKeyword.Location = new System.Drawing.Point(561, 79);
            this.lblWarningKeyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningKeyword.Name = "lblWarningKeyword";
            this.lblWarningKeyword.Size = new System.Drawing.Size(232, 25);
            this.lblWarningKeyword.TabIndex = 59;
            this.lblWarningKeyword.Text = "* Field cannot be blank";
            this.lblWarningKeyword.Visible = false;
            // 
            // lblWarningSearchBy
            // 
            this.lblWarningSearchBy.AutoSize = true;
            this.lblWarningSearchBy.ForeColor = System.Drawing.Color.Red;
            this.lblWarningSearchBy.Location = new System.Drawing.Point(163, 155);
            this.lblWarningSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningSearchBy.Name = "lblWarningSearchBy";
            this.lblWarningSearchBy.Size = new System.Drawing.Size(341, 25);
            this.lblWarningSearchBy.TabIndex = 60;
            this.lblWarningSearchBy.Text = "* Select one of the search criterias";
            this.lblWarningSearchBy.Visible = false;
            // 
            // lblWarningSearchResult
            // 
            this.lblWarningSearchResult.AutoSize = true;
            this.lblWarningSearchResult.ForeColor = System.Drawing.Color.Red;
            this.lblWarningSearchResult.Location = new System.Drawing.Point(288, 193);
            this.lblWarningSearchResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningSearchResult.Name = "lblWarningSearchResult";
            this.lblWarningSearchResult.Size = new System.Drawing.Size(397, 25);
            this.lblWarningSearchResult.TabIndex = 61;
            this.lblWarningSearchResult.Text = "There is no result related to the keyword";
            this.lblWarningSearchResult.Visible = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(378, 337);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(402, 31);
            this.dtpDOB.TabIndex = 48;
            // 
            // dtpJoin
            // 
            this.dtpJoin.Location = new System.Drawing.Point(378, 380);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(402, 31);
            this.dtpJoin.TabIndex = 49;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(378, 420);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(402, 31);
            this.dtpExpiry.TabIndex = 50;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(378, 467);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(402, 33);
            this.cmbStatus.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Location = new System.Drawing.Point(378, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 57);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(56, 18);
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
            this.rdbFemale.Location = new System.Drawing.Point(248, 18);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(114, 29);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // ucMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWarningSearchResult);
            this.Controls.Add(this.lblWarningSearchBy);
            this.Controls.Add(this.lblWarningKeyword);
            this.Controls.Add(this.gbSearchResults);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.label1);
            this.Name = "ucMembers";
            this.Size = new System.Drawing.Size(1128, 794);
            this.Load += new System.EventHandler(this.ucMembers_Load);
            this.gbSearchResults.ResumeLayout(false);
            this.gbSearchResults.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSearchResults;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtICNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWarningKeyword;
        private System.Windows.Forms.Label lblWarningSearchBy;
        private System.Windows.Forms.Label lblWarningSearchResult;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.DateTimePicker dtpJoin;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
    }
}
