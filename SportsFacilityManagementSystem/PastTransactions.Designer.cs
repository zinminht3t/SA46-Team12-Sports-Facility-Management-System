namespace SportsFacilityManagementSystem
{
    partial class PastTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastTransactions));
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(89, 28);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(658, 353);
            this.dgvTransactions.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(380, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PastTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 477);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTransactions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PastTransactions";
            this.Text = "PastTransactions";
            this.Load += new System.EventHandler(this.PastTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnClose;
    }
}