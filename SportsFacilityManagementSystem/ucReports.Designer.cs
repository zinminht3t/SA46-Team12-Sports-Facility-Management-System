namespace SportsFacilityManagementSystem
{
    partial class ucReports
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
            this.cmbTypeofReport = new System.Windows.Forms.ComboBox();
            this.lblTypeofReport = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpDateFromReport = new System.Windows.Forms.DateTimePicker();
            this.dtpToDateReport = new System.Windows.Forms.DateTimePicker();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.labelWarningReportTodate = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.gbMemberList = new System.Windows.Forms.GroupBox();
            this.lblWarningMLDateTo = new System.Windows.Forms.Label();
            this.btnPrintML = new System.Windows.Forms.Button();
            this.dtpDatetoML = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFromML = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.chkbStatus = new System.Windows.Forms.CheckBox();
            this.chkbDateTo = new System.Windows.Forms.CheckBox();
            this.chkbDateFrom = new System.Windows.Forms.CheckBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbReport.SuspendLayout();
            this.gbMemberList.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTypeofReport
            // 
            this.cmbTypeofReport.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbTypeofReport.FormattingEnabled = true;
            this.cmbTypeofReport.Items.AddRange(new object[] {
            "Member List",
            "Facility Occupany Report",
            "Revenue Report"});
            this.cmbTypeofReport.Location = new System.Drawing.Point(240, 76);
            this.cmbTypeofReport.Name = "cmbTypeofReport";
            this.cmbTypeofReport.Size = new System.Drawing.Size(222, 24);
            this.cmbTypeofReport.TabIndex = 0;
            this.cmbTypeofReport.Text = "Select Report";
            // 
            // lblTypeofReport
            // 
            this.lblTypeofReport.AutoSize = true;
            this.lblTypeofReport.Location = new System.Drawing.Point(123, 79);
            this.lblTypeofReport.Name = "lblTypeofReport";
            this.lblTypeofReport.Size = new System.Drawing.Size(111, 17);
            this.lblTypeofReport.TabIndex = 1;
            this.lblTypeofReport.Text = "Type of Report :";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(35, 69);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(82, 17);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "Date From :";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(35, 122);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(67, 17);
            this.lblToDate.TabIndex = 3;
            this.lblToDate.Text = "To Date :";
            // 
            // dtpDateFromReport
            // 
            this.dtpDateFromReport.Location = new System.Drawing.Point(152, 69);
            this.dtpDateFromReport.Name = "dtpDateFromReport";
            this.dtpDateFromReport.Size = new System.Drawing.Size(222, 22);
            this.dtpDateFromReport.TabIndex = 4;
            // 
            // dtpToDateReport
            // 
            this.dtpToDateReport.Location = new System.Drawing.Point(152, 122);
            this.dtpToDateReport.Name = "dtpToDateReport";
            this.dtpToDateReport.Size = new System.Drawing.Size(222, 22);
            this.dtpToDateReport.TabIndex = 5;
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.labelWarningReportTodate);
            this.gbReport.Controls.Add(this.btnPrintReport);
            this.gbReport.Controls.Add(this.dtpToDateReport);
            this.gbReport.Controls.Add(this.dtpDateFromReport);
            this.gbReport.Controls.Add(this.lblToDate);
            this.gbReport.Controls.Add(this.lblDateFrom);
            this.gbReport.Location = new System.Drawing.Point(89, 114);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(537, 338);
            this.gbReport.TabIndex = 13;
            this.gbReport.TabStop = false;
            // 
            // labelWarningReportTodate
            // 
            this.labelWarningReportTodate.ForeColor = System.Drawing.Color.Red;
            this.labelWarningReportTodate.Location = new System.Drawing.Point(394, 120);
            this.labelWarningReportTodate.Name = "labelWarningReportTodate";
            this.labelWarningReportTodate.Size = new System.Drawing.Size(131, 45);
            this.labelWarningReportTodate.TabIndex = 24;
            this.labelWarningReportTodate.Text = "* To Date cannot be less than Date From";
            this.labelWarningReportTodate.Visible = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(193, 255);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(112, 58);
            this.btnPrintReport.TabIndex = 13;
            this.btnPrintReport.Text = "Print";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            // 
            // gbMemberList
            // 
            this.gbMemberList.Controls.Add(this.lblWarningMLDateTo);
            this.gbMemberList.Controls.Add(this.btnPrintML);
            this.gbMemberList.Controls.Add(this.dtpDatetoML);
            this.gbMemberList.Controls.Add(this.dtpDateFromML);
            this.gbMemberList.Controls.Add(this.cmbStatus);
            this.gbMemberList.Controls.Add(this.chkbStatus);
            this.gbMemberList.Controls.Add(this.chkbDateTo);
            this.gbMemberList.Controls.Add(this.chkbDateFrom);
            this.gbMemberList.Controls.Add(this.rbtnAll);
            this.gbMemberList.Location = new System.Drawing.Point(89, 114);
            this.gbMemberList.Name = "gbMemberList";
            this.gbMemberList.Size = new System.Drawing.Size(537, 338);
            this.gbMemberList.TabIndex = 14;
            this.gbMemberList.TabStop = false;
            // 
            // lblWarningMLDateTo
            // 
            this.lblWarningMLDateTo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningMLDateTo.Location = new System.Drawing.Point(404, 121);
            this.lblWarningMLDateTo.Name = "lblWarningMLDateTo";
            this.lblWarningMLDateTo.Size = new System.Drawing.Size(121, 45);
            this.lblWarningMLDateTo.TabIndex = 23;
            this.lblWarningMLDateTo.Text = "* To Date cannot be less than Date From";
            this.lblWarningMLDateTo.Visible = false;
            // 
            // btnPrintML
            // 
            this.btnPrintML.Location = new System.Drawing.Point(211, 257);
            this.btnPrintML.Name = "btnPrintML";
            this.btnPrintML.Size = new System.Drawing.Size(112, 58);
            this.btnPrintML.TabIndex = 22;
            this.btnPrintML.Text = "Print";
            this.btnPrintML.UseVisualStyleBackColor = true;
            // 
            // dtpDatetoML
            // 
            this.dtpDatetoML.Location = new System.Drawing.Point(170, 124);
            this.dtpDatetoML.Name = "dtpDatetoML";
            this.dtpDatetoML.Size = new System.Drawing.Size(222, 22);
            this.dtpDatetoML.TabIndex = 21;
            // 
            // dtpDateFromML
            // 
            this.dtpDateFromML.Location = new System.Drawing.Point(170, 71);
            this.dtpDateFromML.Name = "dtpDateFromML";
            this.dtpDateFromML.Size = new System.Drawing.Size(222, 22);
            this.dtpDateFromML.TabIndex = 20;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(170, 177);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(124, 24);
            this.cmbStatus.TabIndex = 17;
            this.cmbStatus.Text = "All";
            // 
            // chkbStatus
            // 
            this.chkbStatus.Location = new System.Drawing.Point(33, 167);
            this.chkbStatus.Name = "chkbStatus";
            this.chkbStatus.Size = new System.Drawing.Size(121, 44);
            this.chkbStatus.TabIndex = 16;
            this.chkbStatus.Text = "Membership Status :";
            this.chkbStatus.UseVisualStyleBackColor = true;
            // 
            // chkbDateTo
            // 
            this.chkbDateTo.AutoSize = true;
            this.chkbDateTo.Location = new System.Drawing.Point(33, 123);
            this.chkbDateTo.Name = "chkbDateTo";
            this.chkbDateTo.Size = new System.Drawing.Size(89, 21);
            this.chkbDateTo.TabIndex = 15;
            this.chkbDateTo.Text = "Date To :";
            this.chkbDateTo.UseVisualStyleBackColor = true;
            // 
            // chkbDateFrom
            // 
            this.chkbDateFrom.AutoSize = true;
            this.chkbDateFrom.Location = new System.Drawing.Point(33, 70);
            this.chkbDateFrom.Name = "chkbDateFrom";
            this.chkbDateFrom.Size = new System.Drawing.Size(104, 21);
            this.chkbDateFrom.TabIndex = 14;
            this.chkbDateFrom.Text = "Date From :";
            this.chkbDateFrom.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(33, 25);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(87, 21);
            this.rbtnAll.TabIndex = 13;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Select All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "There\'s a stack of groupbox. Use sendtoback Please delete this text after reading" +
    "";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(89, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(537, 40);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Print Report";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTypeofReport);
            this.Controls.Add(this.cmbTypeofReport);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.gbMemberList);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(752, 508);
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.gbMemberList.ResumeLayout(false);
            this.gbMemberList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTypeofReport;
        private System.Windows.Forms.Label lblTypeofReport;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpDateFromReport;
        private System.Windows.Forms.DateTimePicker dtpToDateReport;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Label labelWarningReportTodate;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.GroupBox gbMemberList;
        private System.Windows.Forms.Label lblWarningMLDateTo;
        private System.Windows.Forms.Button btnPrintML;
        private System.Windows.Forms.DateTimePicker dtpDatetoML;
        private System.Windows.Forms.DateTimePicker dtpDateFromML;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.CheckBox chkbStatus;
        private System.Windows.Forms.CheckBox chkbDateTo;
        private System.Windows.Forms.CheckBox chkbDateFrom;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
    }
}
