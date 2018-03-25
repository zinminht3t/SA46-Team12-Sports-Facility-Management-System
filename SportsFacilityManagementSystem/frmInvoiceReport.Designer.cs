namespace SportsFacilityManagementSystem
{
    partial class frmInvoiceReport
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
            this.crInvoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crInvoice
            // 
            this.crInvoice.ActiveViewIndex = -1;
            this.crInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crInvoice.Location = new System.Drawing.Point(0, 0);
            this.crInvoice.Name = "crInvoice";
            this.crInvoice.Size = new System.Drawing.Size(800, 450);
            this.crInvoice.TabIndex = 0;
            // 
            // frmInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crInvoice);
            this.Name = "frmInvoiceReport";
            this.Text = "Booking Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoiceReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crInvoice;
    }
}