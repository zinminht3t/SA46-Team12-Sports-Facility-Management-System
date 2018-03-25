namespace SportsFacilityManagementSystem
{
    partial class frmMemberInfoReport
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
            this.crMember = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crMember
            // 
            this.crMember.ActiveViewIndex = -1;
            this.crMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crMember.Cursor = System.Windows.Forms.Cursors.Default;
            this.crMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crMember.Location = new System.Drawing.Point(0, 0);
            this.crMember.Name = "crMember";
            this.crMember.Size = new System.Drawing.Size(800, 450);
            this.crMember.TabIndex = 0;
            // 
            // frmMemberInfoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crMember);
            this.Name = "frmMemberInfoReport";
            this.Text = "Member Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMemberInfoReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crMember;
    }
}