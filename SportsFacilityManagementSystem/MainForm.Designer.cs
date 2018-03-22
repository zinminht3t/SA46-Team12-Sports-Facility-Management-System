namespace SportsFacilityManagementSystem
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSidetab = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnFacilities = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlSidebar.Controls.Add(this.pnlSidetab);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnBooking);
            this.pnlSidebar.Controls.Add(this.btnMembers);
            this.pnlSidebar.Controls.Add(this.btnFacilities);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSidebar.Location = new System.Drawing.Point(-1, -4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(229, 553);
            this.pnlSidebar.TabIndex = 6;
            // 
            // pnlSidetab
            // 
            this.pnlSidetab.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlSidetab.Location = new System.Drawing.Point(-1, 160);
            this.pnlSidetab.Name = "pnlSidetab";
            this.pnlSidetab.Size = new System.Drawing.Size(17, 76);
            this.pnlSidetab.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        //    this.btnLogout.Image = global::SportsFacilityManagementSystem.Properties.Resources.Logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(13, 467);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(215, 76);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
          //  this.btnReports.Image = global::SportsFacilityManagementSystem.Properties.Resources.Report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(13, 388);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(215, 76);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.MouseEnter += new System.EventHandler(this.btnReports_MouseEnter);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         //   this.btnBooking.Image = global::SportsFacilityManagementSystem.Properties.Resources.Booking;
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(13, 160);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(215, 76);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Bookings";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.MouseEnter += new System.EventHandler(this.btnBooking_MouseEnter);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
          //  this.btnMembers.Image = global::SportsFacilityManagementSystem.Properties.Resources.Members;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(13, 236);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(215, 76);
            this.btnMembers.TabIndex = 7;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.MouseEnter += new System.EventHandler(this.btnMembers_MouseEnter);
            // 
            // btnFacilities
            // 
            this.btnFacilities.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFacilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFacilities.FlatAppearance.BorderSize = 0;
            this.btnFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacilities.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
          //  this.btnFacilities.Image = global::SportsFacilityManagementSystem.Properties.Resources.Stadium;
            this.btnFacilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacilities.Location = new System.Drawing.Point(13, 312);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Size = new System.Drawing.Size(215, 76);
            this.btnFacilities.TabIndex = 9;
            this.btnFacilities.Text = "Facilities";
            this.btnFacilities.UseVisualStyleBackColor = false;
            this.btnFacilities.MouseEnter += new System.EventHandler(this.btnFacilities_MouseEnter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 533);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1000, 580);
            this.MinimumSize = new System.Drawing.Size(1000, 580);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Facility Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidetab;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnFacilities;
        private System.Windows.Forms.Button btnReports;
    }
}

