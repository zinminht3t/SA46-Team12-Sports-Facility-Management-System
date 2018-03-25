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
            this.gbType = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.chkbStatus = new System.Windows.Forms.CheckBox();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblWarningMLDateTo = new System.Windows.Forms.Label();
            this.dtpDatetoML = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFromML = new System.Windows.Forms.DateTimePicker();
            this.chkbDateFrom = new System.Windows.Forms.CheckBox();
            this.chkbFacilities = new System.Windows.Forms.CheckBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnTid = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.gbTrans = new System.Windows.Forms.GroupBox();
            this.lblTid = new System.Windows.Forms.Label();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.btnViewTrans = new System.Windows.Forms.Button();
            this.gbType.SuspendLayout();
            this.gbTrans.SuspendLayout();
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
            // gbType
            // 
            this.gbType.Controls.Add(this.cmbStatus);
            this.gbType.Controls.Add(this.cmbFac);
            this.gbType.Controls.Add(this.chkbStatus);
            this.gbType.Controls.Add(this.btnView);
            this.gbType.Controls.Add(this.lblDateTo);
            this.gbType.Controls.Add(this.lblWarningMLDateTo);
            this.gbType.Controls.Add(this.dtpDatetoML);
            this.gbType.Controls.Add(this.dtpDateFromML);
            this.gbType.Controls.Add(this.chkbDateFrom);
            this.gbType.Controls.Add(this.chkbFacilities);
            this.gbType.Location = new System.Drawing.Point(113, 151);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(522, 313);
            this.gbType.TabIndex = 68;
            this.gbType.TabStop = false;
            this.gbType.Text = "Search by Type";
            this.gbType.Visible = false;
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
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(64, 153);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(67, 17);
            this.lblDateTo.TabIndex = 38;
            this.lblDateTo.Text = "Date To :";
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
            this.btnView.Location = new System.Drawing.Point(205, 252);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(114, 40);
            this.btnView.TabIndex = 69;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnTid
            // 
            this.btnTid.BackColor = System.Drawing.Color.Maroon;
            this.btnTid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTid.Location = new System.Drawing.Point(243, 56);
            this.btnTid.Name = "btnTid";
            this.btnTid.Size = new System.Drawing.Size(118, 68);
            this.btnTid.TabIndex = 70;
            this.btnTid.Text = "Search by Transaction ID";
            this.btnTid.UseVisualStyleBackColor = false;
            this.btnTid.Click += new System.EventHandler(this.btnTid_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.Maroon;
            this.btnType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnType.Location = new System.Drawing.Point(379, 56);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(115, 68);
            this.btnType.TabIndex = 71;
            this.btnType.Text = "Search by Type";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // gbTrans
            // 
            this.gbTrans.Controls.Add(this.btnViewTrans);
            this.gbTrans.Controls.Add(this.txtTid);
            this.gbTrans.Controls.Add(this.lblTid);
            this.gbTrans.Location = new System.Drawing.Point(157, 142);
            this.gbTrans.Name = "gbTrans";
            this.gbTrans.Size = new System.Drawing.Size(432, 232);
            this.gbTrans.TabIndex = 69;
            this.gbTrans.TabStop = false;
            this.gbTrans.Text = "Search by Transaction ID";
            this.gbTrans.Visible = false;
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Location = new System.Drawing.Point(92, 72);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(108, 17);
            this.lblTid.TabIndex = 0;
            this.lblTid.Text = "Transaction ID :";
            // 
            // txtTid
            // 
            this.txtTid.Location = new System.Drawing.Point(216, 69);
            this.txtTid.Name = "txtTid";
            this.txtTid.Size = new System.Drawing.Size(100, 22);
            this.txtTid.TabIndex = 1;
            // 
            // btnViewTrans
            // 
            this.btnViewTrans.Location = new System.Drawing.Point(161, 169);
            this.btnViewTrans.Name = "btnViewTrans";
            this.btnViewTrans.Size = new System.Drawing.Size(114, 40);
            this.btnViewTrans.TabIndex = 70;
            this.btnViewTrans.Text = "View";
            this.btnViewTrans.UseVisualStyleBackColor = true;
            this.btnViewTrans.Click += new System.EventHandler(this.btnViewTrans_Click);
            // 
            // ucPastTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gbTrans);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnTid);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ucPastTransactions";
            this.Size = new System.Drawing.Size(752, 508);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbTrans.ResumeLayout(false);
            this.gbTrans.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbFac;
        private System.Windows.Forms.CheckBox chkbStatus;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblWarningMLDateTo;
        private System.Windows.Forms.DateTimePicker dtpDatetoML;
        private System.Windows.Forms.DateTimePicker dtpDateFromML;
        private System.Windows.Forms.CheckBox chkbDateFrom;
        private System.Windows.Forms.CheckBox chkbFacilities;
        private System.Windows.Forms.Button btnTid;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.GroupBox gbTrans;
        private System.Windows.Forms.Button btnViewTrans;
        private System.Windows.Forms.TextBox txtTid;
        private System.Windows.Forms.Label lblTid;
    }
}
