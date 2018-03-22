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
        public frmMain()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            lblWelcome.Text = lblWelcome.Text + frmLogin.user.name;
        }

        #region Sidetab Panel
        private void btnBooking_MouseEnter(object sender, EventArgs e)
        {
            //this.pnlSidetab.Location = new System.Drawing.Point(-1, 160);
            this.pnlSidetab.Location = this.btnBooking.Location;
            this.pnlSidetab.Left = -1;
            btnSearchMembers.Visible = false;
            btnAddMembers.Visible = false;
        }

        private void btnMembers_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnMembers.Location;
            this.pnlSidetab.Left = -1;
            btnAddMembers.Visible = true;
            btnSearchMembers.Visible = true;
            btnAddFacilities.Visible = false;
            btnSearchFacilities.Visible = false;
        }

        private void btnFacilities_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnFacilities.Location;
            this.pnlSidetab.Left = -1;
            btnSearchMembers.Visible = false;
            btnAddMembers.Visible = false;
            btnAddFacilities.Visible = true;
            btnSearchFacilities.Visible = true;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnReports.Location;
            this.pnlSidetab.Left = -1;
            btnAddFacilities.Visible = false;
            btnSearchFacilities.Visible = false;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnLogout.Location;
            this.pnlSidetab.Left = -1;
        }
        #endregion

        private void frmMain_MouseEnter(object sender, EventArgs e)
        {
            btnAddFacilities.Visible = false;
            btnSearchFacilities.Visible = false;
            btnSearchMembers.Visible = false;
            btnAddMembers.Visible = false;
        }
    }
}
