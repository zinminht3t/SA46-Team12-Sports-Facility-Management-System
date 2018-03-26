namespace SportsFacilityManagementSystem
{
    partial class ucFacilities
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchby = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearchResults = new System.Windows.Forms.GroupBox();
            this.cmbRates = new System.Windows.Forms.ComboBox();
            this.lblWarningRate = new System.Windows.Forms.Label();
            this.pbWarningRate = new System.Windows.Forms.PictureBox();
            this.lblWarningFac = new System.Windows.Forms.Label();
            this.lblWarningID = new System.Windows.Forms.Label();
            this.pbWarningFac = new System.Windows.Forms.PictureBox();
            this.pbWarningID = new System.Windows.Forms.PictureBox();
            this.txtFacilityID = new System.Windows.Forms.TextBox();
            this.lblFacilityID = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFacilitiesNo = new System.Windows.Forms.TextBox();
            this.lblFacilitiesno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRates = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.gbSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(400, 118);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 30);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchby
            // 
            this.lblSearchby.AutoSize = true;
            this.lblSearchby.Location = new System.Drawing.Point(229, 74);
            this.lblSearchby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchby.Name = "lblSearchby";
            this.lblSearchby.Size = new System.Drawing.Size(84, 17);
            this.lblSearchby.TabIndex = 26;
            this.lblSearchby.Text = "Search by : ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(123, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(541, 40);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Search Facilities";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSearchResults
            // 
            this.gbSearchResults.BackColor = System.Drawing.Color.Transparent;
            this.gbSearchResults.Controls.Add(this.cmbRates);
            this.gbSearchResults.Controls.Add(this.lblWarningRate);
            this.gbSearchResults.Controls.Add(this.pbWarningRate);
            this.gbSearchResults.Controls.Add(this.lblWarningFac);
            this.gbSearchResults.Controls.Add(this.lblWarningID);
            this.gbSearchResults.Controls.Add(this.pbWarningFac);
            this.gbSearchResults.Controls.Add(this.pbWarningID);
            this.gbSearchResults.Controls.Add(this.txtFacilityID);
            this.gbSearchResults.Controls.Add(this.lblFacilityID);
            this.gbSearchResults.Controls.Add(this.btnEdit);
            this.gbSearchResults.Controls.Add(this.btnSave);
            this.gbSearchResults.Controls.Add(this.btnCancel);
            this.gbSearchResults.Controls.Add(this.txtFacilitiesNo);
            this.gbSearchResults.Controls.Add(this.lblFacilitiesno);
            this.gbSearchResults.Controls.Add(this.txtName);
            this.gbSearchResults.Controls.Add(this.lblRates);
            this.gbSearchResults.Controls.Add(this.lblName);
            this.gbSearchResults.Location = new System.Drawing.Point(178, 167);
            this.gbSearchResults.Name = "gbSearchResults";
            this.gbSearchResults.Size = new System.Drawing.Size(419, 328);
            this.gbSearchResults.TabIndex = 63;
            this.gbSearchResults.TabStop = false;
            this.gbSearchResults.Text = "Search Results";
            this.gbSearchResults.Visible = false;
            // 
            // cmbRates
            // 
            this.cmbRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRates.Enabled = false;
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
            this.cmbRates.Location = new System.Drawing.Point(174, 131);
            this.cmbRates.Name = "cmbRates";
            this.cmbRates.Size = new System.Drawing.Size(119, 24);
            this.cmbRates.TabIndex = 72;
            // 
            // lblWarningRate
            // 
            this.lblWarningRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarningRate.Location = new System.Drawing.Point(324, 126);
            this.lblWarningRate.Name = "lblWarningRate";
            this.lblWarningRate.Size = new System.Drawing.Size(83, 36);
            this.lblWarningRate.TabIndex = 71;
            this.lblWarningRate.Text = "Rates / 2 hours";
            this.lblWarningRate.Visible = false;
            // 
            // pbWarningRate
            // 
            this.pbWarningRate.Image = global::SportsFacilityManagementSystem.Properties.Resources.Info;
            this.pbWarningRate.Location = new System.Drawing.Point(294, 131);
            this.pbWarningRate.Name = "pbWarningRate";
            this.pbWarningRate.Size = new System.Drawing.Size(24, 22);
            this.pbWarningRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningRate.TabIndex = 70;
            this.pbWarningRate.TabStop = false;
            this.pbWarningRate.Visible = false;
            this.pbWarningRate.MouseEnter += new System.EventHandler(this.pbWarningRate_MouseEnter);
            this.pbWarningRate.MouseLeave += new System.EventHandler(this.pbWarningRate_MouseLeave);
            // 
            // lblWarningFac
            // 
            this.lblWarningFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarningFac.Location = new System.Drawing.Point(323, 167);
            this.lblWarningFac.Name = "lblWarningFac";
            this.lblWarningFac.Size = new System.Drawing.Size(89, 56);
            this.lblWarningFac.TabIndex = 69;
            this.lblWarningFac.Text = "This field cannot be edited";
            this.lblWarningFac.Visible = false;
            // 
            // lblWarningID
            // 
            this.lblWarningID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarningID.Location = new System.Drawing.Point(324, 53);
            this.lblWarningID.Name = "lblWarningID";
            this.lblWarningID.Size = new System.Drawing.Size(83, 60);
            this.lblWarningID.TabIndex = 68;
            this.lblWarningID.Text = "This field cannot be edited";
            this.lblWarningID.Visible = false;
            // 
            // pbWarningFac
            // 
            this.pbWarningFac.Image = global::SportsFacilityManagementSystem.Properties.Resources.Info;
            this.pbWarningFac.Location = new System.Drawing.Point(294, 168);
            this.pbWarningFac.Name = "pbWarningFac";
            this.pbWarningFac.Size = new System.Drawing.Size(24, 22);
            this.pbWarningFac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningFac.TabIndex = 67;
            this.pbWarningFac.TabStop = false;
            this.pbWarningFac.Visible = false;
            this.pbWarningFac.MouseEnter += new System.EventHandler(this.pbWarningFac_MouseEnter);
            this.pbWarningFac.MouseLeave += new System.EventHandler(this.pbWarningFac_MouseLeave);
            // 
            // pbWarningID
            // 
            this.pbWarningID.Image = global::SportsFacilityManagementSystem.Properties.Resources.Info;
            this.pbWarningID.Location = new System.Drawing.Point(294, 53);
            this.pbWarningID.Name = "pbWarningID";
            this.pbWarningID.Size = new System.Drawing.Size(24, 22);
            this.pbWarningID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningID.TabIndex = 66;
            this.pbWarningID.TabStop = false;
            this.pbWarningID.Visible = false;
            this.pbWarningID.MouseEnter += new System.EventHandler(this.pbWarningID_MouseEnter);
            this.pbWarningID.MouseLeave += new System.EventHandler(this.pbWarningID_MouseLeave);
            // 
            // txtFacilityID
            // 
            this.txtFacilityID.Location = new System.Drawing.Point(174, 53);
            this.txtFacilityID.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacilityID.Name = "txtFacilityID";
            this.txtFacilityID.ReadOnly = true;
            this.txtFacilityID.Size = new System.Drawing.Size(119, 22);
            this.txtFacilityID.TabIndex = 58;
            // 
            // lblFacilityID
            // 
            this.lblFacilityID.AutoSize = true;
            this.lblFacilityID.Location = new System.Drawing.Point(51, 56);
            this.lblFacilityID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacilityID.Name = "lblFacilityID";
            this.lblFacilityID.Size = new System.Drawing.Size(76, 17);
            this.lblFacilityID.TabIndex = 64;
            this.lblFacilityID.Text = "Facility ID :";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(257, 262);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 37);
            this.btnEdit.TabIndex = 62;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 262);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(80, 262);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFacilitiesNo
            // 
            this.txtFacilitiesNo.Location = new System.Drawing.Point(174, 168);
            this.txtFacilitiesNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacilitiesNo.Name = "txtFacilitiesNo";
            this.txtFacilitiesNo.ReadOnly = true;
            this.txtFacilitiesNo.Size = new System.Drawing.Size(119, 22);
            this.txtFacilitiesNo.TabIndex = 61;
            // 
            // lblFacilitiesno
            // 
            this.lblFacilitiesno.AutoSize = true;
            this.lblFacilitiesno.Location = new System.Drawing.Point(51, 171);
            this.lblFacilitiesno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacilitiesno.Name = "lblFacilitiesno";
            this.lblFacilitiesno.Size = new System.Drawing.Size(112, 17);
            this.lblFacilitiesno.TabIndex = 41;
            this.lblFacilitiesno.Text = "No of Facilities : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(119, 22);
            this.txtName.TabIndex = 59;
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Location = new System.Drawing.Point(51, 134);
            this.lblRates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(57, 17);
            this.lblRates.TabIndex = 38;
            this.lblRates.Text = "Rates : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 94);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 17);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Facility Name : ";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "- default -"});
            this.cmbSearchBy.Location = new System.Drawing.Point(335, 71);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(190, 24);
            this.cmbSearchBy.TabIndex = 56;
            // 
            // ucFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.gbSearchResults);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.lblSearchby);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucFacilities";
            this.Size = new System.Drawing.Size(752, 508);
            this.Load += new System.EventHandler(this.ucFacilities_Load);
            this.gbSearchResults.ResumeLayout(false);
            this.gbSearchResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchby;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSearchResults;
        private System.Windows.Forms.TextBox txtFacilitiesNo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblFacilitiesno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFacilityID;
        private System.Windows.Forms.Label lblFacilityID;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblWarningFac;
        private System.Windows.Forms.Label lblWarningID;
        private System.Windows.Forms.PictureBox pbWarningFac;
        private System.Windows.Forms.PictureBox pbWarningID;
        private System.Windows.Forms.Label lblWarningRate;
        private System.Windows.Forms.PictureBox pbWarningRate;
        private System.Windows.Forms.ComboBox cmbRates;
    }
}
