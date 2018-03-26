namespace SportsFacilityManagementSystem
{
    partial class frmMemberListingReport
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
            this.crMLReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crMLReport
            // 
            this.crMLReport.ActiveViewIndex = -1;
            this.crMLReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crMLReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crMLReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crMLReport.Location = new System.Drawing.Point(0, 0);
            this.crMLReport.Name = "crMLReport";
            this.crMLReport.Size = new System.Drawing.Size(800, 450);
            this.crMLReport.TabIndex = 0;
            // 
            // frmMemberListingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crMLReport);
            this.Name = "frmMemberListingReport";
            this.Text = "Member Listing Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMemberListingReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crMLReport;
    }
}