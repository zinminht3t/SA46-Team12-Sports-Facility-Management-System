namespace SportsFacilityManagementSystem
{
    partial class frmOccupancyReport
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
            this.crOccupancy = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crOccupancy
            // 
            this.crOccupancy.ActiveViewIndex = -1;
            this.crOccupancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crOccupancy.Cursor = System.Windows.Forms.Cursors.Default;
            this.crOccupancy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crOccupancy.Location = new System.Drawing.Point(0, 0);
            this.crOccupancy.Name = "crOccupancy";
            this.crOccupancy.Size = new System.Drawing.Size(1552, 978);
            this.crOccupancy.TabIndex = 0;
            // 
            // frmOccupancyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 978);
            this.Controls.Add(this.crOccupancy);
            this.Name = "frmOccupancyReport";
            this.Text = "frmOccupancyReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOccupancyReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crOccupancy;
    }
}