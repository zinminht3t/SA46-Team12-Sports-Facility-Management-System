﻿namespace SportsFacilityManagementSystem
{
    partial class ucPastTransactions
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.chkbStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWarningMLDateTo = new System.Windows.Forms.Label();
            this.dtpDatetoML = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFromML = new System.Windows.Forms.DateTimePicker();
            this.chkbDateFrom = new System.Windows.Forms.CheckBox();
            this.chkbFacilities = new System.Windows.Forms.CheckBox();
            this.btnView = new System.Windows.Forms.Button();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(40, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(678, 40);
            this.lblTitle.TabIndex = 67;
            this.lblTitle.Text = "View Past Transactions";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cmbStatus);
            this.gbSearch.Controls.Add(this.cmbFac);
            this.gbSearch.Controls.Add(this.chkbStatus);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.lblWarningMLDateTo);
            this.gbSearch.Controls.Add(this.dtpDatetoML);
            this.gbSearch.Controls.Add(this.dtpDateFromML);
            this.gbSearch.Controls.Add(this.chkbDateFrom);
            this.gbSearch.Controls.Add(this.chkbFacilities);
            this.gbSearch.Location = new System.Drawing.Point(126, 93);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(522, 272);
            this.gbSearch.TabIndex = 68;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Confirmed",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(183, 202);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(222, 24);
            this.cmbStatus.TabIndex = 41;
            // 
            // cmbFac
            // 
            this.cmbFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.Items.AddRange(new object[] {
            "All",
            "Badminton",
            "Basketball",
            "Futsal",
            "Squash",
            "Table Tennis"});
            this.cmbFac.Location = new System.Drawing.Point(183, 44);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(222, 24);
            this.cmbFac.TabIndex = 40;
            // 
            // chkbStatus
            // 
            this.chkbStatus.AutoSize = true;
            this.chkbStatus.Location = new System.Drawing.Point(44, 202);
            this.chkbStatus.Name = "chkbStatus";
            this.chkbStatus.Size = new System.Drawing.Size(133, 21);
            this.chkbStatus.TabIndex = 39;
            this.chkbStatus.Text = "Booking Status :";
            this.chkbStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Date To :";
            // 
            // lblWarningMLDateTo
            // 
            this.lblWarningMLDateTo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningMLDateTo.Location = new System.Drawing.Point(415, 149);
            this.lblWarningMLDateTo.Name = "lblWarningMLDateTo";
            this.lblWarningMLDateTo.Size = new System.Drawing.Size(88, 77);
            this.lblWarningMLDateTo.TabIndex = 37;
            this.lblWarningMLDateTo.Text = "* Date cannot be less than Date from";
            this.lblWarningMLDateTo.Visible = false;
            // 
            // dtpDatetoML
            // 
            this.dtpDatetoML.Location = new System.Drawing.Point(183, 150);
            this.dtpDatetoML.Name = "dtpDatetoML";
            this.dtpDatetoML.Size = new System.Drawing.Size(226, 22);
            this.dtpDatetoML.TabIndex = 36;
            // 
            // dtpDateFromML
            // 
            this.dtpDateFromML.Location = new System.Drawing.Point(183, 97);
            this.dtpDateFromML.Name = "dtpDateFromML";
            this.dtpDateFromML.Size = new System.Drawing.Size(222, 22);
            this.dtpDateFromML.TabIndex = 35;
            // 
            // chkbDateFrom
            // 
            this.chkbDateFrom.AutoSize = true;
            this.chkbDateFrom.Location = new System.Drawing.Point(44, 96);
            this.chkbDateFrom.Name = "chkbDateFrom";
            this.chkbDateFrom.Size = new System.Drawing.Size(104, 21);
            this.chkbDateFrom.TabIndex = 34;
            this.chkbDateFrom.Text = "Date From :";
            this.chkbDateFrom.UseVisualStyleBackColor = true;
            // 
            // chkbFacilities
            // 
            this.chkbFacilities.AutoSize = true;
            this.chkbFacilities.Location = new System.Drawing.Point(44, 47);
            this.chkbFacilities.Name = "chkbFacilities";
            this.chkbFacilities.Size = new System.Drawing.Size(92, 21);
            this.chkbFacilities.TabIndex = 33;
            this.chkbFacilities.Text = "Facilities :";
            this.chkbFacilities.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(337, 395);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(114, 40);
            this.btnView.TabIndex = 69;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ucPastTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ucPastTransactions";
            this.Size = new System.Drawing.Size(752, 508);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbFac;
        private System.Windows.Forms.CheckBox chkbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWarningMLDateTo;
        private System.Windows.Forms.DateTimePicker dtpDatetoML;
        private System.Windows.Forms.DateTimePicker dtpDateFromML;
        private System.Windows.Forms.CheckBox chkbDateFrom;
        private System.Windows.Forms.CheckBox chkbFacilities;
    }
}
