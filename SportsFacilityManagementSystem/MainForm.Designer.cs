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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidetab = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnFacilities = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.btnAddMembers = new System.Windows.Forms.Button();
            this.btnAddFacilities = new System.Windows.Forms.Button();
            this.btnSearchFacilities = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUpcoming = new System.Windows.Forms.Button();
            this.btnPasttransactions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucAddFacilities1 = new SportsFacilityManagementSystem.ucAddFacilities();
            this.ucAddMember1 = new SportsFacilityManagementSystem.ucAddMember();
            this.ucFacilities2 = new SportsFacilityManagementSystem.ucFacilities();
            this.ucMembers1 = new SportsFacilityManagementSystem.ucMembers();
            this.ucPastTransactions1 = new SportsFacilityManagementSystem.ucPastTransactions();
            this.ucReports1 = new SportsFacilityManagementSystem.ucReports();
            this.ucBooking2 = new SportsFacilityManagementSystem.ucBooking();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Ivory;
            this.pnlSidebar.Controls.Add(this.pbLogo);
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
            // pbLogo
            // 
            this.pbLogo.Image = global::SportsFacilityManagementSystem.Properties.Resources.GetActiveLogo;
            this.pbLogo.Location = new System.Drawing.Point(-11, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(229, 160);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            this.pbLogo.MouseEnter += new System.EventHandler(this.pbLogo_MouseEnter);
            // 
            // pnlSidetab
            // 
            this.pnlSidetab.BackColor = System.Drawing.Color.Crimson;
            this.pnlSidetab.Location = new System.Drawing.Point(-1, 160);
            this.pnlSidetab.Name = "pnlSidetab";
            this.pnlSidetab.Size = new System.Drawing.Size(17, 76);
            this.pnlSidetab.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Ivory;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Image = global::SportsFacilityManagementSystem.Properties.Resources.Logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(13, 464);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(215, 76);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Ivory;
            this.btnBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBooking.Image = global::SportsFacilityManagementSystem.Properties.Resources.Booking;
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
            this.btnMembers.BackColor = System.Drawing.Color.Ivory;
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMembers.Image = global::SportsFacilityManagementSystem.Properties.Resources.Members;
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
            this.btnFacilities.BackColor = System.Drawing.Color.Ivory;
            this.btnFacilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFacilities.FlatAppearance.BorderSize = 0;
            this.btnFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacilities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFacilities.Image = global::SportsFacilityManagementSystem.Properties.Resources.Stadium;
            this.btnFacilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacilities.Location = new System.Drawing.Point(13, 312);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Size = new System.Drawing.Size(215, 76);
            this.btnFacilities.TabIndex = 9;
            this.btnFacilities.Text = "Facilities";
            this.btnFacilities.UseVisualStyleBackColor = false;
            this.btnFacilities.MouseEnter += new System.EventHandler(this.btnFacilities_MouseEnter);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Ivory;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReports.Image = global::SportsFacilityManagementSystem.Properties.Resources.Report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(13, 388);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(215, 76);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.MouseEnter += new System.EventHandler(this.btnReports_MouseEnter);
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.BackColor = System.Drawing.Color.Crimson;
            this.btnSearchMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchMembers.FlatAppearance.BorderSize = 0;
            this.btnSearchMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMembers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMembers.Location = new System.Drawing.Point(228, 232);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(154, 76);
            this.btnSearchMembers.TabIndex = 11;
            this.btnSearchMembers.Text = "Search / Modify Members List";
            this.btnSearchMembers.UseVisualStyleBackColor = false;
            this.btnSearchMembers.Visible = false;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            // 
            // btnAddMembers
            // 
            this.btnAddMembers.BackColor = System.Drawing.Color.Crimson;
            this.btnAddMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMembers.FlatAppearance.BorderSize = 0;
            this.btnAddMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMembers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMembers.Location = new System.Drawing.Point(228, 308);
            this.btnAddMembers.Name = "btnAddMembers";
            this.btnAddMembers.Size = new System.Drawing.Size(154, 76);
            this.btnAddMembers.TabIndex = 12;
            this.btnAddMembers.Text = "Add New Members";
            this.btnAddMembers.UseVisualStyleBackColor = false;
            this.btnAddMembers.Visible = false;
            this.btnAddMembers.Click += new System.EventHandler(this.btnAddMembers_Click);
            // 
            // btnAddFacilities
            // 
            this.btnAddFacilities.BackColor = System.Drawing.Color.Crimson;
            this.btnAddFacilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddFacilities.FlatAppearance.BorderSize = 0;
            this.btnAddFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFacilities.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFacilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFacilities.Location = new System.Drawing.Point(228, 383);
            this.btnAddFacilities.Name = "btnAddFacilities";
            this.btnAddFacilities.Size = new System.Drawing.Size(154, 76);
            this.btnAddFacilities.TabIndex = 14;
            this.btnAddFacilities.Text = "Add New Facilities";
            this.btnAddFacilities.UseVisualStyleBackColor = false;
            this.btnAddFacilities.Visible = false;
            this.btnAddFacilities.Click += new System.EventHandler(this.btnAddFacilities_Click);
            // 
            // btnSearchFacilities
            // 
            this.btnSearchFacilities.BackColor = System.Drawing.Color.Crimson;
            this.btnSearchFacilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchFacilities.FlatAppearance.BorderSize = 0;
            this.btnSearchFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFacilities.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchFacilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFacilities.Location = new System.Drawing.Point(228, 307);
            this.btnSearchFacilities.Name = "btnSearchFacilities";
            this.btnSearchFacilities.Size = new System.Drawing.Size(154, 76);
            this.btnSearchFacilities.TabIndex = 13;
            this.btnSearchFacilities.Text = "Search / Modify Facilities";
            this.btnSearchFacilities.UseVisualStyleBackColor = false;
            this.btnSearchFacilities.Visible = false;
            this.btnSearchFacilities.Click += new System.EventHandler(this.btnSearchFacilities_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Location = new System.Drawing.Point(698, 4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(154, 20);
            this.lblWelcome.TabIndex = 16;
            this.lblWelcome.Text = "User logged on : ";
            // 
            // btnUpcoming
            // 
            this.btnUpcoming.BackColor = System.Drawing.Color.Crimson;
            this.btnUpcoming.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpcoming.FlatAppearance.BorderSize = 0;
            this.btnUpcoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpcoming.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpcoming.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpcoming.Location = new System.Drawing.Point(228, 156);
            this.btnUpcoming.Name = "btnUpcoming";
            this.btnUpcoming.Size = new System.Drawing.Size(154, 76);
            this.btnUpcoming.TabIndex = 21;
            this.btnUpcoming.Text = "Upcoming Bookings";
            this.btnUpcoming.UseVisualStyleBackColor = false;
            this.btnUpcoming.Visible = false;
            this.btnUpcoming.Click += new System.EventHandler(this.btnUpcoming_Click);
            // 
            // btnPasttransactions
            // 
            this.btnPasttransactions.BackColor = System.Drawing.Color.Crimson;
            this.btnPasttransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPasttransactions.FlatAppearance.BorderSize = 0;
            this.btnPasttransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasttransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasttransactions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPasttransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasttransactions.Location = new System.Drawing.Point(228, 231);
            this.btnPasttransactions.Name = "btnPasttransactions";
            this.btnPasttransactions.Size = new System.Drawing.Size(154, 76);
            this.btnPasttransactions.TabIndex = 20;
            this.btnPasttransactions.Text = "View Past Transactions";
            this.btnPasttransactions.UseVisualStyleBackColor = false;
            this.btnPasttransactions.Visible = false;
            this.btnPasttransactions.Click += new System.EventHandler(this.btnPasttransactions_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SportsFacilityManagementSystem.Properties.Resources.Account;
            this.pictureBox1.Location = new System.Drawing.Point(680, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 548);
            this.panel1.TabIndex = 34;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // ucAddFacilities1
            // 
            this.ucAddFacilities1.BackColor = System.Drawing.Color.Ivory;
            this.ucAddFacilities1.Location = new System.Drawing.Point(235, 27);
            this.ucAddFacilities1.Name = "ucAddFacilities1";
            this.ucAddFacilities1.Size = new System.Drawing.Size(752, 508);
            this.ucAddFacilities1.TabIndex = 35;
            this.ucAddFacilities1.Visible = false;
            this.ucAddFacilities1.MouseEnter += new System.EventHandler(this.ucAddFacilities1_MouseEnter);
            // 
            // ucAddMember1
            // 
            this.ucAddMember1.BackColor = System.Drawing.Color.Ivory;
            this.ucAddMember1.Location = new System.Drawing.Point(235, 26);
            this.ucAddMember1.Margin = new System.Windows.Forms.Padding(2);
            this.ucAddMember1.Name = "ucAddMember1";
            this.ucAddMember1.Size = new System.Drawing.Size(752, 508);
            this.ucAddMember1.TabIndex = 36;
            this.ucAddMember1.Visible = false;
            this.ucAddMember1.MouseEnter += new System.EventHandler(this.ucAddMember1_MouseEnter);
            // 
            // ucFacilities2
            // 
            this.ucFacilities2.BackColor = System.Drawing.Color.Ivory;
            this.ucFacilities2.Location = new System.Drawing.Point(235, 26);
            this.ucFacilities2.Margin = new System.Windows.Forms.Padding(2);
            this.ucFacilities2.Name = "ucFacilities2";
            this.ucFacilities2.Size = new System.Drawing.Size(752, 508);
            this.ucFacilities2.TabIndex = 37;
            this.ucFacilities2.Visible = false;
            this.ucFacilities2.MouseEnter += new System.EventHandler(this.ucFacilities2_MouseEnter);
            // 
            // ucMembers1
            // 
            this.ucMembers1.BackColor = System.Drawing.Color.Ivory;
            this.ucMembers1.Location = new System.Drawing.Point(235, 26);
            this.ucMembers1.Margin = new System.Windows.Forms.Padding(2);
            this.ucMembers1.Name = "ucMembers1";
            this.ucMembers1.Size = new System.Drawing.Size(752, 508);
            this.ucMembers1.TabIndex = 38;
            this.ucMembers1.Visible = false;
            this.ucMembers1.MouseEnter += new System.EventHandler(this.ucMembers1_MouseEnter);
            // 
            // ucPastTransactions1
            // 
            this.ucPastTransactions1.BackColor = System.Drawing.Color.Ivory;
            this.ucPastTransactions1.Datefrom = new System.DateTime(((long)(0)));
            this.ucPastTransactions1.Dateto = new System.DateTime(((long)(0)));
            this.ucPastTransactions1.Fac = null;
            this.ucPastTransactions1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucPastTransactions1.Location = new System.Drawing.Point(235, 27);
            this.ucPastTransactions1.Name = "ucPastTransactions1";
            this.ucPastTransactions1.Size = new System.Drawing.Size(752, 508);
            this.ucPastTransactions1.Status = null;
            this.ucPastTransactions1.TabIndex = 39;
            this.ucPastTransactions1.TransID = null;
            this.ucPastTransactions1.Visible = false;
            this.ucPastTransactions1.MouseEnter += new System.EventHandler(this.ucPastTransactions1_MouseEnter);
            // 
            // ucReports1
            // 
            this.ucReports1.BackColor = System.Drawing.Color.Ivory;
            this.ucReports1.Location = new System.Drawing.Point(235, 27);
            this.ucReports1.Name = "ucReports1";
            this.ucReports1.Size = new System.Drawing.Size(752, 508);
            this.ucReports1.TabIndex = 40;
            this.ucReports1.Visible = false;
            this.ucReports1.MouseEnter += new System.EventHandler(this.ucReports1_MouseEnter);
            // 
            // ucBooking2
            // 
            this.ucBooking2.BackColor = System.Drawing.Color.Ivory;
            this.ucBooking2.Location = new System.Drawing.Point(235, 27);
            this.ucBooking2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucBooking2.Name = "ucBooking2";
            this.ucBooking2.Size = new System.Drawing.Size(752, 508);
            this.ucBooking2.TabIndex = 41;
            this.ucBooking2.Visible = false;
            this.ucBooking2.MouseEnter += new System.EventHandler(this.ucBooking2_MouseEnter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(979, 524);
            this.Controls.Add(this.btnUpcoming);
            this.Controls.Add(this.btnPasttransactions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAddFacilities);
            this.Controls.Add(this.btnSearchFacilities);
            this.Controls.Add(this.btnAddMembers);
            this.Controls.Add(this.btnSearchMembers);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucFacilities2);
            this.Controls.Add(this.ucAddMember1);
            this.Controls.Add(this.ucAddFacilities1);
            this.Controls.Add(this.ucBooking2);
            this.Controls.Add(this.ucReports1);
            this.Controls.Add(this.ucPastTransactions1);
            this.Controls.Add(this.ucMembers1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(997, 571);
            this.MinimumSize = new System.Drawing.Size(997, 571);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Facility Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidetab;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnFacilities;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSearchMembers;
        private System.Windows.Forms.Button btnAddMembers;
        private System.Windows.Forms.Button btnAddFacilities;
        private System.Windows.Forms.Button btnSearchFacilities;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpcoming;
        private System.Windows.Forms.Button btnPasttransactions;
        private ucBooking ucBooking1;
        private ucFacilities ucFacilities1;
        private System.Windows.Forms.Panel panel1;
        private ucAddFacilities ucAddFacilities1;
        private ucAddMember ucAddMember1;
        private ucFacilities ucFacilities2;
        private ucMembers ucMembers1;
        private ucPastTransactions ucPastTransactions1;
        private ucReports ucReports1;
        private ucBooking ucBooking2;
    }
}

