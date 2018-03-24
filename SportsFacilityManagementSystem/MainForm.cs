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
            ucBooking2.Visible = true;
        }

        #region Sidetab Panel (Mouse Enter Events)
        private void pbLogo_MouseEnter(object sender, EventArgs e)
        {
            BookingsMenu(false);
        }
        private void btnBooking_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnBooking.Location;
            this.pnlSidetab.Left = -1;
            MembersMenu(false);
            BookingsMenu(true);
        }

        private void btnMembers_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnMembers.Location;
            this.pnlSidetab.Left = -1;
            MembersMenu(true);
            FacilitiesMenu(false);
            BookingsMenu(false);
        }

        private void btnFacilities_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnFacilities.Location;
            this.pnlSidetab.Left = -1;
            MembersMenu(false);
            FacilitiesMenu(true);
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnReports.Location;
            this.pnlSidetab.Left = -1;
            FacilitiesMenu(false);
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnLogout.Location;
            this.pnlSidetab.Left = -1;
        }

        private void frmMain_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }
        private void ucBooking1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void ucAddFacilities1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void ucAddMember1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void ucBookingDetails1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }
        private void ucBookingEdit1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void ucFacilities1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void ucMembers1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void ucPastTransactions1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }

        private void ucReports1_MouseEnter(object sender, EventArgs e)
        {
            AllMenu(false);
        }
        #endregion

        #region Sidetab Panel (Mouse Click Events)
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logoutMsg =
                MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);

            if (logoutMsg == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HideAllUC();
            ucReports1.Visible = true;
        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {
            HideAllUC();
            ucBooking2.Visible = true;
            BookingsMenu(false);
        }

        private void btnPasttransactions_Click(object sender, EventArgs e)
        {
            HideAllUC();
            ucPastTransactions1.Visible = true;
            BookingsMenu(false);
        }

        private void btnSearchFacilities_Click(object sender, EventArgs e)
        {
            HideAllUC();
            ucFacilities2.Visible = true;
            FacilitiesMenu(false);
        }

        private void btnAddFacilities_Click(object sender, EventArgs e)
        {
            HideAllUC();
            ucAddFacilities1.Visible = true;
            FacilitiesMenu(false);
        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            HideAllUC();
            ucMembers1.Visible = true;
            MembersMenu(false);
        }

        private void btnAddMembers_Click(object sender, EventArgs e)
        {
            HideAllUC();
            ucAddMember1.Visible = true;
            MembersMenu(false);
        }
        #endregion

        #region Visibility Methods
        private void BookingsMenu(bool visibility)
        {
            btnUpcoming.Visible = visibility;
            btnPasttransactions.Visible = visibility;
        }

        private void MembersMenu(bool visibility)
        {
            btnSearchMembers.Visible = visibility;
            btnAddMembers.Visible = visibility;
        }

        private void FacilitiesMenu(bool visibility)
        {
            btnAddFacilities.Visible = visibility;
            btnSearchFacilities.Visible = visibility;
        }

        private void AllMenu(bool visibility)
        {
            BookingsMenu(visibility);
            MembersMenu(visibility);
            FacilitiesMenu(visibility);
        }
        public void HideAllUC()
        {
            ucReports1.Visible = false;
            ucBooking2.Visible = false;
            ucPastTransactions1.Visible = false;
            ucFacilities2.Visible = false;
            ucAddFacilities1.Visible = false;
            ucMembers1.Visible = false;
            ucAddMember1.Visible = false;
        }
        public void ShowMainpage()
        {
            HideAllUC();
            ucBooking2.Visible = true;
        }
        #endregion

    }
}
