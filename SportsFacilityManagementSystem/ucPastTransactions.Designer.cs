namespace SportsFacilityManagementSystem
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
            this.btnView = new System.Windows.Forms.Button();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblWarningMLDateTo = new System.Windows.Forms.Label();
            this.dtpDatetoML = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFromML = new System.Windows.Forms.DateTimePicker();
            this.chkbDateFrom = new System.Windows.Forms.CheckBox();
            this.chkbFacilities = new System.Windows.Forms.CheckBox();
            this.btnTid = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.gbTrans = new System.Windows.Forms.GroupBox();
            this.rbtnTid = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.btnViewTrans = new System.Windows.Forms.Button();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.gbType.SuspendLayout();
            this.gbTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(30, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(508, 32);
            this.lblTitle.TabIndex = 67;
            this.lblTitle.Text = "View Transactions";
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
            this.gbType.Location = new System.Drawing.Point(85, 123);
            this.gbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbType.Name = "gbType";
            this.gbType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbType.Size = new System.Drawing.Size(392, 254);
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
            this.cmbStatus.Location = new System.Drawing.Point(137, 164);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(168, 21);
            this.cmbStatus.TabIndex = 27;
            // 
            // cmbFac
            // 
            this.cmbFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.Items.AddRange(new object[] {
            "All"});
            this.cmbFac.Location = new System.Drawing.Point(137, 36);
            this.cmbFac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(168, 21);
            this.cmbFac.TabIndex = 22;
            // 
            // chkbStatus
            // 
            this.chkbStatus.AutoSize = true;
            this.chkbStatus.Location = new System.Drawing.Point(33, 164);
            this.chkbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkbStatus.Name = "chkbStatus";
            this.chkbStatus.Size = new System.Drawing.Size(104, 17);
            this.chkbStatus.TabIndex = 26;
            this.chkbStatus.Text = "Booking Status :";
            this.chkbStatus.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(154, 205);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 32);
            this.btnView.TabIndex = 28;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(48, 124);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(26, 13);
            this.lblDateTo.TabIndex = 38;
            this.lblDateTo.Text = "To :";
            // 
            // lblWarningMLDateTo
            // 
            this.lblWarningMLDateTo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningMLDateTo.Location = new System.Drawing.Point(311, 121);
            this.lblWarningMLDateTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningMLDateTo.Name = "lblWarningMLDateTo";
            this.lblWarningMLDateTo.Size = new System.Drawing.Size(66, 63);
            this.lblWarningMLDateTo.TabIndex = 37;
            this.lblWarningMLDateTo.Text = "* Date cannot be earlier than Date from";
            this.lblWarningMLDateTo.Visible = false;
            // 
            // dtpDatetoML
            // 
            this.dtpDatetoML.Location = new System.Drawing.Point(137, 122);
            this.dtpDatetoML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatetoML.Name = "dtpDatetoML";
            this.dtpDatetoML.Size = new System.Drawing.Size(170, 20);
            this.dtpDatetoML.TabIndex = 25;
            // 
            // dtpDateFromML
            // 
            this.dtpDateFromML.Location = new System.Drawing.Point(137, 79);
            this.dtpDateFromML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateFromML.Name = "dtpDateFromML";
            this.dtpDateFromML.Size = new System.Drawing.Size(170, 20);
            this.dtpDateFromML.TabIndex = 24;
            // 
            // chkbDateFrom
            // 
            this.chkbDateFrom.Location = new System.Drawing.Point(33, 71);
            this.chkbDateFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkbDateFrom.Name = "chkbDateFrom";
            this.chkbDateFrom.Size = new System.Drawing.Size(100, 33);
            this.chkbDateFrom.TabIndex = 23;
            this.chkbDateFrom.Text = "Booking Date From :";
            this.chkbDateFrom.UseVisualStyleBackColor = true;
            // 
            // chkbFacilities
            // 
            this.chkbFacilities.AutoSize = true;
            this.chkbFacilities.Location = new System.Drawing.Point(33, 38);
            this.chkbFacilities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkbFacilities.Name = "chkbFacilities";
            this.chkbFacilities.Size = new System.Drawing.Size(72, 17);
            this.chkbFacilities.TabIndex = 21;
            this.chkbFacilities.Text = "Facilities :";
            this.chkbFacilities.UseVisualStyleBackColor = true;
            // 
            // btnTid
            // 
            this.btnTid.BackColor = System.Drawing.Color.Maroon;
            this.btnTid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTid.Location = new System.Drawing.Point(182, 46);
            this.btnTid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTid.Name = "btnTid";
            this.btnTid.Size = new System.Drawing.Size(88, 55);
            this.btnTid.TabIndex = 15;
            this.btnTid.Text = "Search by Transaction";
            this.btnTid.UseVisualStyleBackColor = false;
            this.btnTid.Click += new System.EventHandler(this.btnTid_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.Maroon;
            this.btnType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnType.Location = new System.Drawing.Point(284, 46);
            this.btnType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(86, 55);
            this.btnType.TabIndex = 16;
            this.btnType.Text = "Search by Type";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // gbTrans
            // 
            this.gbTrans.Controls.Add(this.rbtnTid);
            this.gbTrans.Controls.Add(this.rbtnAll);
            this.gbTrans.Controls.Add(this.btnViewTrans);
            this.gbTrans.Controls.Add(this.txtTid);
            this.gbTrans.Location = new System.Drawing.Point(118, 115);
            this.gbTrans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTrans.Name = "gbTrans";
            this.gbTrans.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTrans.Size = new System.Drawing.Size(324, 188);
            this.gbTrans.TabIndex = 69;
            this.gbTrans.TabStop = false;
            this.gbTrans.Text = "Search by Transaction";
            this.gbTrans.Visible = false;
            // 
            // rbtnTid
            // 
            this.rbtnTid.AutoSize = true;
            this.rbtnTid.Location = new System.Drawing.Point(56, 82);
            this.rbtnTid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTid.Name = "rbtnTid";
            this.rbtnTid.Size = new System.Drawing.Size(116, 17);
            this.rbtnTid.TabIndex = 18;
            this.rbtnTid.TabStop = true;
            this.rbtnTid.Text = "By Transaction ID :";
            this.rbtnTid.UseVisualStyleBackColor = true;
            this.rbtnTid.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(56, 44);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(100, 17);
            this.rbtnAll.TabIndex = 17;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All Transactions";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // btnViewTrans
            // 
            this.btnViewTrans.Location = new System.Drawing.Point(121, 137);
            this.btnViewTrans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewTrans.Name = "btnViewTrans";
            this.btnViewTrans.Size = new System.Drawing.Size(86, 32);
            this.btnViewTrans.TabIndex = 20;
            this.btnViewTrans.Text = "View";
            this.btnViewTrans.UseVisualStyleBackColor = true;
            this.btnViewTrans.Click += new System.EventHandler(this.btnViewTrans_Click);
            // 
            // txtTid
            // 
            this.txtTid.Location = new System.Drawing.Point(172, 82);
            this.txtTid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTid.Name = "txtTid";
            this.txtTid.ReadOnly = true;
            this.txtTid.Size = new System.Drawing.Size(76, 20);
            this.txtTid.TabIndex = 19;
            // 
            // ucPastTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnTid);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbTrans);
            this.Controls.Add(this.gbType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucPastTransactions";
            this.Size = new System.Drawing.Size(564, 413);
            this.Load += new System.EventHandler(this.ucPastTransactions_Load);
            this.VisibleChanged += new System.EventHandler(this.ucPastTransactions_VisibleChanged);
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
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnTid;
        private System.Windows.Forms.Label lblDateTo;
    }
}
