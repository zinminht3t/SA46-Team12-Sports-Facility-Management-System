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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchby = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearchResults = new System.Windows.Forms.GroupBox();
            this.lblCheckAvailability = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblFacilitiesno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRates = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(466, 124);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 30);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(314, 81);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(277, 22);
            this.txtKeyword.TabIndex = 28;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Customer ID",
            "Customer Name",
            "IC Number"});
            this.cmbSearchBy.Location = new System.Drawing.Point(145, 81);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(144, 24);
            this.cmbSearchBy.TabIndex = 27;
            // 
            // lblSearchby
            // 
            this.lblSearchby.AutoSize = true;
            this.lblSearchby.Location = new System.Drawing.Point(141, 57);
            this.lblSearchby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchby.Name = "lblSearchby";
            this.lblSearchby.Size = new System.Drawing.Size(84, 17);
            this.lblSearchby.TabIndex = 26;
            this.lblSearchby.Text = "Search by : ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(122, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(509, 40);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Search Facilities";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSearchResults
            // 
            this.gbSearchResults.BackColor = System.Drawing.Color.Transparent;
            this.gbSearchResults.Controls.Add(this.lblCheckAvailability);
            this.gbSearchResults.Controls.Add(this.textBox2);
            this.gbSearchResults.Controls.Add(this.textBox1);
            this.gbSearchResults.Controls.Add(this.btnEdit);
            this.gbSearchResults.Controls.Add(this.lblFacilitiesno);
            this.gbSearchResults.Controls.Add(this.txtName);
            this.gbSearchResults.Controls.Add(this.lblRates);
            this.gbSearchResults.Controls.Add(this.lblName);
            this.gbSearchResults.Location = new System.Drawing.Point(139, 159);
            this.gbSearchResults.Name = "gbSearchResults";
            this.gbSearchResults.Size = new System.Drawing.Size(455, 328);
            this.gbSearchResults.TabIndex = 63;
            this.gbSearchResults.TabStop = false;
            this.gbSearchResults.Text = "Search Results";
            this.gbSearchResults.Visible = false;
            // 
            // lblCheckAvailability
            // 
            this.lblCheckAvailability.AutoSize = true;
            this.lblCheckAvailability.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCheckAvailability.Location = new System.Drawing.Point(25, 272);
            this.lblCheckAvailability.Name = "lblCheckAvailability";
            this.lblCheckAvailability.Size = new System.Drawing.Size(117, 17);
            this.lblCheckAvailability.TabIndex = 61;
            this.lblCheckAvailability.Text = "Check Availability";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 155);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(71, 22);
            this.textBox2.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 99);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 22);
            this.textBox1.TabIndex = 59;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(327, 272);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 37);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblFacilitiesno
            // 
            this.lblFacilitiesno.AutoSize = true;
            this.lblFacilitiesno.Location = new System.Drawing.Point(30, 160);
            this.lblFacilitiesno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacilitiesno.Name = "lblFacilitiesno";
            this.lblFacilitiesno.Size = new System.Drawing.Size(112, 17);
            this.lblFacilitiesno.TabIndex = 41;
            this.lblFacilitiesno.Text = "No of Facilities : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(197, 22);
            this.txtName.TabIndex = 39;
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Location = new System.Drawing.Point(30, 104);
            this.lblRates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(57, 17);
            this.lblRates.TabIndex = 38;
            this.lblRates.Text = "Rates : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 43);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 17);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Facility : ";
            // 
            // ucFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gbSearchResults);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.lblSearchby);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucFacilities";
            this.Size = new System.Drawing.Size(752, 508);
            this.gbSearchResults.ResumeLayout(false);
            this.gbSearchResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblSearchby;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSearchResults;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblFacilitiesno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCheckAvailability;
    }
}
