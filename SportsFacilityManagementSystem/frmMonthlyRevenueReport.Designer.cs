namespace SportsFacilityManagementSystem
{
    partial class frmMonthlyRevenueReport
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
            this.crMRReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crMRReport
            // 
            this.crMRReport.ActiveViewIndex = -1;
            this.crMRReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crMRReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crMRReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crMRReport.Location = new System.Drawing.Point(0, 0);
            this.crMRReport.Name = "crMRReport";
            this.crMRReport.Size = new System.Drawing.Size(800, 450);
            this.crMRReport.TabIndex = 0;
            // 
            // frmMonthlyRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crMRReport);
            this.Name = "frmMonthlyRevenueReport";
            this.Text = "Monthly Revenue Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonthlyRevenueReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crMRReport;
    }
}