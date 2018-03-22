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

        #region Sidetab Panel (Mouse Enter Events)
        private void btnBooking_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnBooking.Location;
            this.pnlSidetab.Left = -1;
            MembersMenu(false);
        }

        private void btnMembers_MouseEnter(object sender, EventArgs e)
        {
            this.pnlSidetab.Location = this.btnMembers.Location;
            this.pnlSidetab.Left = -1;
            MembersMenu(true);
            FacilitiesMenu(false);
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
            FacilitiesMenu(false);
            MembersMenu(false);
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
        #endregion

        #region Visibility Methods
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
        #endregion

        private void ShowUserControl(string ucName)
        {
            // Visibility methods using ucName to call which to hide using if method
        }

    }
}
