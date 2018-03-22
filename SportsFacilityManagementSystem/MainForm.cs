using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsFacilityManagementSystem
{
    public partial class frmMain : Form
    {
        SportsFacilitiesEntities ctx;
        public frmMain()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctx = new SportsFacilitiesEntities();
            
        }

        #region Sidetab Panel
        private void btnBooking_MouseEnter(object sender, EventArgs e)
        {
            //this.pnlSidetab.Location = new System.Drawing.Point(-1, 160);
            this.pnlSidetab.Location = this.btnBooking.Location;
            this.pnlSidetab.Left = -1;
        }

        private void btnMembers_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnMembers.Location;
            this.pnlSidetab.Left = -1;
        }

        private void btnFacilities_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnFacilities.Location;
            this.pnlSidetab.Left = -1;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnReports.Location;
            this.pnlSidetab.Left = -1;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnLogout.Location;
            this.pnlSidetab.Left = -1;
        }
        #endregion
    }
}
