namespace SportsFacilityManagementSystem
{
    partial class ucAddFacilities
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
            this.gbSearchEdit = new System.Windows.Forms.GroupBox();
            this.lblRatesInfo = new System.Windows.Forms.Label();
            this.pbRatesinfo = new System.Windows.Forms.PictureBox();
            this.cmbCourtNo = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFacilitiesNoEdit = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRatesEdit = new System.Windows.Forms.Label();
            this.lblNameEdit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWarningName = new System.Windows.Forms.Label();
            this.lblWarningRate = new System.Windows.Forms.Label();
            this.lblWarningCourt = new System.Windows.Forms.Label();
            this.gbSearchEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRatesinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchEdit
            // 
            this.gbSearchEdit.Controls.Add(this.lblWarningCourt);
            this.gbSearchEdit.Controls.Add(this.lblWarningRate);
            this.gbSearchEdit.Controls.Add(this.lblWarningName);
            this.gbSearchEdit.Controls.Add(this.lblRatesInfo);
            this.gbSearchEdit.Controls.Add(this.pbRatesinfo);
            this.gbSearchEdit.Controls.Add(this.cmbCourtNo);
            this.gbSearchEdit.Controls.Add(this.txtRate);
            this.gbSearchEdit.Controls.Add(this.btnSubmit);
            this.gbSearchEdit.Controls.Add(this.btnReset);
            this.gbSearchEdit.Controls.Add(this.lblFacilitiesNoEdit);
            this.gbSearchEdit.Controls.Add(this.txtName);
            this.gbSearchEdit.Controls.Add(this.lblRatesEdit);
            this.gbSearchEdit.Controls.Add(this.lblNameEdit);
            this.gbSearchEdit.Location = new System.Drawing.Point(190, 125);
            this.gbSearchEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearchEdit.Name = "gbSearchEdit";
            this.gbSearchEdit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearchEdit.Size = new System.Drawing.Size(724, 512);
            this.gbSearchEdit.TabIndex = 65;
            this.gbSearchEdit.TabStop = false;
            // 
            // lblRatesInfo
            // 
            this.lblRatesInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRatesInfo.Location = new System.Drawing.Point(498, 164);
            this.lblRatesInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRatesInfo.Name = "lblRatesInfo";
            this.lblRatesInfo.Size = new System.Drawing.Size(192, 66);
            this.lblRatesInfo.TabIndex = 67;
            this.lblRatesInfo.Text = "Rates / 2 hours";
            this.lblRatesInfo.Visible = false;
            // 
            // pbRatesinfo
            // 
            this.pbRatesinfo.Image = global::SportsFacilityManagementSystem.Properties.Resources.Info;
            this.pbRatesinfo.Location = new System.Drawing.Point(448, 162);
            this.pbRatesinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbRatesinfo.Name = "pbRatesinfo";
            this.pbRatesinfo.Size = new System.Drawing.Size(36, 34);
            this.pbRatesinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRatesinfo.TabIndex = 66;
            this.pbRatesinfo.TabStop = false;
            this.pbRatesinfo.MouseEnter += new System.EventHandler(this.pbRatesinfo_MouseEnter);
            this.pbRatesinfo.MouseLeave += new System.EventHandler(this.pbRatesinfo_MouseLeave);
            // 
            // cmbCourtNo
            // 
            this.cmbCourtNo.FormattingEnabled = true;
            this.cmbCourtNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCourtNo.Location = new System.Drawing.Point(262, 251);
            this.cmbCourtNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCourtNo.Name = "cmbCourtNo";
            this.cmbCourtNo.Size = new System.Drawing.Size(104, 33);
            this.cmbCourtNo.TabIndex = 65;
            this.cmbCourtNo.Text = "Select";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(262, 162);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(176, 31);
            this.txtRate.TabIndex = 61;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(498, 430);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 58);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(69, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 58);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFacilitiesNoEdit
            // 
            this.lblFacilitiesNoEdit.Location = new System.Drawing.Point(45, 251);
            this.lblFacilitiesNoEdit.Name = "lblFacilitiesNoEdit";
            this.lblFacilitiesNoEdit.Size = new System.Drawing.Size(150, 66);
            this.lblFacilitiesNoEdit.TabIndex = 41;
            this.lblFacilitiesNoEdit.Text = "No of Courts / Fields : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(262, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 31);
            this.txtName.TabIndex = 39;
            // 
            // lblRatesEdit
            // 
            this.lblRatesEdit.AutoSize = true;
            this.lblRatesEdit.Location = new System.Drawing.Point(45, 162);
            this.lblRatesEdit.Name = "lblRatesEdit";
            this.lblRatesEdit.Size = new System.Drawing.Size(86, 25);
            this.lblRatesEdit.TabIndex = 38;
            this.lblRatesEdit.Text = "Rates : ";
            // 
            // lblNameEdit
            // 
            this.lblNameEdit.AutoSize = true;
            this.lblNameEdit.Location = new System.Drawing.Point(45, 67);
            this.lblNameEdit.Name = "lblNameEdit";
            this.lblNameEdit.Size = new System.Drawing.Size(184, 25);
            this.lblNameEdit.TabIndex = 37;
            this.lblNameEdit.Text = "Name of Facility : ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(174, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(764, 62);
            this.lblTitle.TabIndex = 66;
            this.lblTitle.Text = "Add New Facilities";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarningName
            // 
            this.lblWarningName.AutoSize = true;
            this.lblWarningName.ForeColor = System.Drawing.Color.Red;
            this.lblWarningName.Location = new System.Drawing.Point(266, 29);
            this.lblWarningName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningName.Name = "lblWarningName";
            this.lblWarningName.Size = new System.Drawing.Size(232, 25);
            this.lblWarningName.TabIndex = 68;
            this.lblWarningName.Text = "* Field cannot be blank";
            this.lblWarningName.Visible = false;
            // 
            // lblWarningRate
            // 
            this.lblWarningRate.AutoSize = true;
            this.lblWarningRate.ForeColor = System.Drawing.Color.Red;
            this.lblWarningRate.Location = new System.Drawing.Point(266, 132);
            this.lblWarningRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningRate.Name = "lblWarningRate";
            this.lblWarningRate.Size = new System.Drawing.Size(232, 25);
            this.lblWarningRate.TabIndex = 69;
            this.lblWarningRate.Text = "* Field cannot be blank";
            this.lblWarningRate.Visible = false;
            // 
            // lblWarningCourt
            // 
            this.lblWarningCourt.AutoSize = true;
            this.lblWarningCourt.ForeColor = System.Drawing.Color.Red;
            this.lblWarningCourt.Location = new System.Drawing.Point(266, 221);
            this.lblWarningCourt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningCourt.Name = "lblWarningCourt";
            this.lblWarningCourt.Size = new System.Drawing.Size(232, 25);
            this.lblWarningCourt.TabIndex = 70;
            this.lblWarningCourt.Text = "* Field cannot be blank";
            this.lblWarningCourt.Visible = false;
            // 
            // ucAddFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbSearchEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucAddFacilities";
            this.Size = new System.Drawing.Size(1128, 794);
            this.gbSearchEdit.ResumeLayout(false);
            this.gbSearchEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRatesinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchEdit;
        private System.Windows.Forms.ComboBox cmbCourtNo;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFacilitiesNoEdit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRatesEdit;
        private System.Windows.Forms.Label lblNameEdit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRatesInfo;
        private System.Windows.Forms.PictureBox pbRatesinfo;
        private System.Windows.Forms.Label lblWarningCourt;
        private System.Windows.Forms.Label lblWarningRate;
        private System.Windows.Forms.Label lblWarningName;
    }
}
