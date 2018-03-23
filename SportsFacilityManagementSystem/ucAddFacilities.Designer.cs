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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFacilitiesNoEdit = new System.Windows.Forms.Label();
            this.txtNameEdit = new System.Windows.Forms.TextBox();
            this.lblRatesEdit = new System.Windows.Forms.Label();
            this.lblNameEdit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearchEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRatesinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchEdit
            // 
            this.gbSearchEdit.Controls.Add(this.lblRatesInfo);
            this.gbSearchEdit.Controls.Add(this.pbRatesinfo);
            this.gbSearchEdit.Controls.Add(this.comboBox2);
            this.gbSearchEdit.Controls.Add(this.textBox4);
            this.gbSearchEdit.Controls.Add(this.btnSave);
            this.gbSearchEdit.Controls.Add(this.btnReset);
            this.gbSearchEdit.Controls.Add(this.lblFacilitiesNoEdit);
            this.gbSearchEdit.Controls.Add(this.txtNameEdit);
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
            this.lblRatesInfo.Location = new System.Drawing.Point(484, 162);
            this.lblRatesInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRatesInfo.Name = "lblRatesInfo";
            this.lblRatesInfo.Size = new System.Drawing.Size(89, 66);
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox2.Location = new System.Drawing.Point(262, 239);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 33);
            this.comboBox2.TabIndex = 65;
            this.comboBox2.Text = "Select";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(262, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 31);
            this.textBox4.TabIndex = 61;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(498, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 58);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.lblFacilitiesNoEdit.Location = new System.Drawing.Point(45, 228);
            this.lblFacilitiesNoEdit.Name = "lblFacilitiesNoEdit";
            this.lblFacilitiesNoEdit.Size = new System.Drawing.Size(150, 66);
            this.lblFacilitiesNoEdit.TabIndex = 41;
            this.lblFacilitiesNoEdit.Text = "No of Courts / Fields : ";
            // 
            // txtNameEdit
            // 
            this.txtNameEdit.Location = new System.Drawing.Point(262, 61);
            this.txtNameEdit.Name = "txtNameEdit";
            this.txtNameEdit.Size = new System.Drawing.Size(310, 31);
            this.txtNameEdit.TabIndex = 39;
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFacilitiesNoEdit;
        private System.Windows.Forms.TextBox txtNameEdit;
        private System.Windows.Forms.Label lblRatesEdit;
        private System.Windows.Forms.Label lblNameEdit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRatesInfo;
        private System.Windows.Forms.PictureBox pbRatesinfo;
    }
}
