namespace SportsFacilityManagementSystem
{
    partial class frmRevenueReport
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
            this.crRevenue = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crRevenue
            // 
            this.crRevenue.ActiveViewIndex = -1;
            this.crRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crRevenue.Cursor = System.Windows.Forms.Cursors.Default;
            this.crRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crRevenue.Location = new System.Drawing.Point(0, 0);
            this.crRevenue.Name = "crRevenue";
            this.crRevenue.Size = new System.Drawing.Size(800, 450);
            this.crRevenue.TabIndex = 0;
            // 
            // frmRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crRevenue);
            this.Name = "frmRevenueReport";
            this.Text = "frmRevenueReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRevenueReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crRevenue;
    }
}