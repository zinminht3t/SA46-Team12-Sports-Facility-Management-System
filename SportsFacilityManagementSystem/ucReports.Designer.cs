﻿namespace SportsFacilityManagementSystem
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
            this.lblDateRange = new System.Windows.Forms.Label();
            this.btnPrintML = new System.Windows.Forms.Button();
            this.dtpDatetoML = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFromML = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdnDateRange = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cmbTypeofReport.Location = new System.Drawing.Point(360, 88);
            this.cmbTypeofReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTypeofReport.Name = "cmbTypeofReport";
            this.cmbTypeofReport.Size = new System.Drawing.Size(331, 33);
            this.cmbTypeofReport.TabIndex = 0;
            this.cmbTypeofReport.Text = "Select Report";
            this.cmbTypeofReport.SelectedIndexChanged += new System.EventHandler(this.cmbTypeofReport_SelectedIndexChanged);
            // 
            // lblTypeofReport
            // 
            this.lblTypeofReport.AutoSize = true;
            this.lblTypeofReport.Location = new System.Drawing.Point(184, 92);
            this.lblTypeofReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeofReport.Name = "lblTypeofReport";
            this.lblTypeofReport.Size = new System.Drawing.Size(166, 25);
            this.lblTypeofReport.TabIndex = 1;
            this.lblTypeofReport.Text = "Type of Report :";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(52, 108);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(124, 25);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "Date From :";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(52, 191);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(100, 25);
            this.lblToDate.TabIndex = 3;
            this.lblToDate.Text = "To Date :";
            // 
            // dtpDateFromReport
            // 
            this.dtpDateFromReport.Location = new System.Drawing.Point(228, 108);
            this.dtpDateFromReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateFromReport.Name = "dtpDateFromReport";
            this.dtpDateFromReport.Size = new System.Drawing.Size(331, 31);
            this.dtpDateFromReport.TabIndex = 4;
            // 
            // dtpToDateReport
            // 
            this.dtpToDateReport.Location = new System.Drawing.Point(228, 191);
            this.dtpToDateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpToDateReport.Name = "dtpToDateReport";
            this.dtpToDateReport.Size = new System.Drawing.Size(331, 31);
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
            this.gbReport.Location = new System.Drawing.Point(134, 147);
            this.gbReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbReport.Name = "gbReport";
            this.gbReport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbReport.Size = new System.Drawing.Size(806, 528);
            this.gbReport.TabIndex = 13;
            this.gbReport.TabStop = false;
            // 
            // labelWarningReportTodate
            // 
            this.labelWarningReportTodate.ForeColor = System.Drawing.Color.Red;
            this.labelWarningReportTodate.Location = new System.Drawing.Point(591, 188);
            this.labelWarningReportTodate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarningReportTodate.Name = "labelWarningReportTodate";
            this.labelWarningReportTodate.Size = new System.Drawing.Size(196, 70);
            this.labelWarningReportTodate.TabIndex = 24;
            this.labelWarningReportTodate.Text = "* To Date cannot be less than Date From";
            this.labelWarningReportTodate.Visible = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(290, 398);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(168, 91);
            this.btnPrintReport.TabIndex = 13;
            this.btnPrintReport.Text = "Print";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            // 
            // gbMemberList
            // 
            this.gbMemberList.Controls.Add(this.label1);
            this.gbMemberList.Controls.Add(this.radioButton1);
            this.gbMemberList.Controls.Add(this.rdnDateRange);
            this.gbMemberList.Controls.Add(this.lblDateRange);
            this.gbMemberList.Controls.Add(this.btnPrintML);
            this.gbMemberList.Controls.Add(this.dtpDatetoML);
            this.gbMemberList.Controls.Add(this.dtpDateFromML);
            this.gbMemberList.Controls.Add(this.cmbStatus);
            this.gbMemberList.Location = new System.Drawing.Point(134, 147);
            this.gbMemberList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMemberList.Name = "gbMemberList";
            this.gbMemberList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMemberList.Size = new System.Drawing.Size(806, 528);
            this.gbMemberList.TabIndex = 14;
            this.gbMemberList.TabStop = false;
            this.gbMemberList.Enter += new System.EventHandler(this.gbMemberList_Enter);
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Location = new System.Drawing.Point(44, 161);
            this.lblDateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(210, 25);
            this.lblDateRange.TabIndex = 24;
            this.lblDateRange.Text = "Expiry Date Range : ";
            // 
            // btnPrintML
            // 
            this.btnPrintML.Location = new System.Drawing.Point(316, 402);
            this.btnPrintML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintML.Name = "btnPrintML";
            this.btnPrintML.Size = new System.Drawing.Size(168, 91);
            this.btnPrintML.TabIndex = 22;
            this.btnPrintML.Text = "Print";
            this.btnPrintML.UseVisualStyleBackColor = true;
            this.btnPrintML.Click += new System.EventHandler(this.btnPrintML_Click);
            // 
            // dtpDatetoML
            // 
            this.dtpDatetoML.Location = new System.Drawing.Point(255, 194);
            this.dtpDatetoML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDatetoML.Name = "dtpDatetoML";
            this.dtpDatetoML.Size = new System.Drawing.Size(393, 31);
            this.dtpDatetoML.TabIndex = 21;
            // 
            // dtpDateFromML
            // 
            this.dtpDateFromML.Location = new System.Drawing.Point(255, 111);
            this.dtpDateFromML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateFromML.Name = "dtpDateFromML";
            this.dtpDateFromML.Size = new System.Drawing.Size(393, 31);
            this.dtpDateFromML.TabIndex = 20;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(255, 277);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(184, 33);
            this.cmbStatus.TabIndex = 17;
            this.cmbStatus.Text = "All";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(134, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(806, 62);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Print Report";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdnDateRange
            // 
            this.rdnDateRange.AutoSize = true;
            this.rdnDateRange.Location = new System.Drawing.Point(10, 161);
            this.rdnDateRange.Name = "rdnDateRange";
            this.rdnDateRange.Size = new System.Drawing.Size(27, 26);
            this.rdnDateRange.TabIndex = 25;
            this.rdnDateRange.TabStop = true;
            this.rdnDateRange.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 284);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(27, 26);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Status : ";
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTypeofReport);
            this.Controls.Add(this.cmbTypeofReport);
            this.Controls.Add(this.gbMemberList);
            this.Controls.Add(this.gbReport);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1128, 794);
            this.Load += new System.EventHandler(this.ucReports_Load);
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
        private System.Windows.Forms.Button btnPrintML;
        private System.Windows.Forms.DateTimePicker dtpDatetoML;
        private System.Windows.Forms.DateTimePicker dtpDateFromML;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdnDateRange;
        private System.Windows.Forms.Label label1;
    }
}
