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
            this.lblWarningRate = new System.Windows.Forms.Label();
            this.cmbRates = new System.Windows.Forms.ComboBox();
            this.lblWarningCourt = new System.Windows.Forms.Label();
            this.lblWarningName = new System.Windows.Forms.Label();
            this.lblRatesInfo = new System.Windows.Forms.Label();
            this.pbRatesinfo = new System.Windows.Forms.PictureBox();
            this.cmbCourtNo = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFacilitiesNoEdit = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRatesEdit = new System.Windows.Forms.Label();
            this.lblNameEdit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearchEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRatesinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchEdit
            // 
            this.gbSearchEdit.Controls.Add(this.lblWarningRate);
            this.gbSearchEdit.Controls.Add(this.cmbRates);
            this.gbSearchEdit.Controls.Add(this.lblWarningCourt);
            this.gbSearchEdit.Controls.Add(this.lblWarningName);
            this.gbSearchEdit.Controls.Add(this.lblRatesInfo);
            this.gbSearchEdit.Controls.Add(this.pbRatesinfo);
            this.gbSearchEdit.Controls.Add(this.cmbCourtNo);
            this.gbSearchEdit.Controls.Add(this.btnSubmit);
            this.gbSearchEdit.Controls.Add(this.btnReset);
            this.gbSearchEdit.Controls.Add(this.lblFacilitiesNoEdit);
            this.gbSearchEdit.Controls.Add(this.txtName);
            this.gbSearchEdit.Controls.Add(this.lblRatesEdit);
            this.gbSearchEdit.Controls.Add(this.lblNameEdit);
            this.gbSearchEdit.Location = new System.Drawing.Point(95, 65);
            this.gbSearchEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearchEdit.Name = "gbSearchEdit";
            this.gbSearchEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearchEdit.Size = new System.Drawing.Size(362, 266);
            this.gbSearchEdit.TabIndex = 65;
            this.gbSearchEdit.TabStop = false;
            // 
            // lblWarningRate
            // 
            this.lblWarningRate.AutoSize = true;
            this.lblWarningRate.ForeColor = System.Drawing.Color.Red;
            this.lblWarningRate.Location = new System.Drawing.Point(133, 62);
            this.lblWarningRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningRate.Name = "lblWarningRate";
            this.lblWarningRate.Size = new System.Drawing.Size(116, 13);
            this.lblWarningRate.TabIndex = 72;
            this.lblWarningRate.Text = "* Field cannot be blank";
            this.lblWarningRate.Visible = false;
            // 
            // cmbRates
            // 
            this.cmbRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRates.FormattingEnabled = true;
            this.cmbRates.Items.AddRange(new object[] {
            "$ 3.00",
            "$ 4.00",
            "$ 5.00",
            "$ 6.00",
            "$ 7.00",
            "$ 8.00",
            "$ 9.00",
            "$ 10.00"});
            this.cmbRates.Location = new System.Drawing.Point(131, 79);
            this.cmbRates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRates.Name = "cmbRates";
            this.cmbRates.Size = new System.Drawing.Size(92, 21);
            this.cmbRates.TabIndex = 71;
            // 
            // lblWarningCourt
            // 
            this.lblWarningCourt.AutoSize = true;
            this.lblWarningCourt.ForeColor = System.Drawing.Color.Red;
            this.lblWarningCourt.Location = new System.Drawing.Point(133, 115);
            this.lblWarningCourt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningCourt.Name = "lblWarningCourt";
            this.lblWarningCourt.Size = new System.Drawing.Size(116, 13);
            this.lblWarningCourt.TabIndex = 70;
            this.lblWarningCourt.Text = "* Field cannot be blank";
            this.lblWarningCourt.Visible = false;
            // 
            // lblWarningName
            // 
            this.lblWarningName.AutoSize = true;
            this.lblWarningName.ForeColor = System.Drawing.Color.Red;
            this.lblWarningName.Location = new System.Drawing.Point(133, 15);
            this.lblWarningName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningName.Name = "lblWarningName";
            this.lblWarningName.Size = new System.Drawing.Size(116, 13);
            this.lblWarningName.TabIndex = 68;
            this.lblWarningName.Text = "* Field cannot be blank";
            this.lblWarningName.Visible = false;
            // 
            // lblRatesInfo
            // 
            this.lblRatesInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRatesInfo.Location = new System.Drawing.Point(251, 71);
            this.lblRatesInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRatesInfo.Name = "lblRatesInfo";
            this.lblRatesInfo.Size = new System.Drawing.Size(97, 35);
            this.lblRatesInfo.TabIndex = 67;
            this.lblRatesInfo.Text = "Rates / 2 hours";
            this.lblRatesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRatesInfo.Visible = false;
            // 
            // pbRatesinfo
            // 
            this.pbRatesinfo.Image = global::SportsFacilityManagementSystem.Properties.Resources.Info;
            this.pbRatesinfo.Location = new System.Drawing.Point(226, 78);
            this.pbRatesinfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRatesinfo.Name = "pbRatesinfo";
            this.pbRatesinfo.Size = new System.Drawing.Size(18, 18);
            this.pbRatesinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRatesinfo.TabIndex = 66;
            this.pbRatesinfo.TabStop = false;
            this.pbRatesinfo.MouseEnter += new System.EventHandler(this.pbRatesinfo_MouseEnter);
            this.pbRatesinfo.MouseLeave += new System.EventHandler(this.pbRatesinfo_MouseLeave);
            // 
            // cmbCourtNo
            // 
            this.cmbCourtNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourtNo.FormattingEnabled = true;
            this.cmbCourtNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCourtNo.Location = new System.Drawing.Point(131, 131);
            this.cmbCourtNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCourtNo.Name = "cmbCourtNo";
            this.cmbCourtNo.Size = new System.Drawing.Size(54, 21);
            this.cmbCourtNo.TabIndex = 67;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(249, 223);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 30);
            this.btnSubmit.TabIndex = 69;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(34, 223);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 30);
            this.btnReset.TabIndex = 68;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFacilitiesNoEdit
            // 
            this.lblFacilitiesNoEdit.Location = new System.Drawing.Point(22, 131);
            this.lblFacilitiesNoEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacilitiesNoEdit.Name = "lblFacilitiesNoEdit";
            this.lblFacilitiesNoEdit.Size = new System.Drawing.Size(75, 34);
            this.lblFacilitiesNoEdit.TabIndex = 41;
            this.lblFacilitiesNoEdit.Text = "No of Courts / Fields : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 65;
            // 
            // lblRatesEdit
            // 
            this.lblRatesEdit.AutoSize = true;
            this.lblRatesEdit.Location = new System.Drawing.Point(22, 84);
            this.lblRatesEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRatesEdit.Name = "lblRatesEdit";
            this.lblRatesEdit.Size = new System.Drawing.Size(44, 13);
            this.lblRatesEdit.TabIndex = 38;
            this.lblRatesEdit.Text = "Rates : ";
            // 
            // lblNameEdit
            // 
            this.lblNameEdit.AutoSize = true;
            this.lblNameEdit.Location = new System.Drawing.Point(22, 35);
            this.lblNameEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameEdit.Name = "lblNameEdit";
            this.lblNameEdit.Size = new System.Drawing.Size(91, 13);
            this.lblNameEdit.TabIndex = 37;
            this.lblNameEdit.Text = "Name of Facility : ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(87, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(382, 32);
            this.lblTitle.TabIndex = 66;
            this.lblTitle.Text = "Add New Facilities";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucAddFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbSearchEdit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucAddFacilities";
            this.Size = new System.Drawing.Size(564, 413);
            this.Load += new System.EventHandler(this.ucAddFacilities_Load);
            this.VisibleChanged += new System.EventHandler(this.ucAddFacilities_VisibleChanged);
            this.gbSearchEdit.ResumeLayout(false);
            this.gbSearchEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRatesinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchEdit;
        private System.Windows.Forms.ComboBox cmbCourtNo;
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
        private System.Windows.Forms.Label lblWarningName;
        private System.Windows.Forms.ComboBox cmbRates;
        private System.Windows.Forms.Label lblWarningRate;
    }
}
