using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsFacilityManagementSystem
{
    public partial class ucFacilities : UserControl
    {
        frmMain fm;
        SportsFacilitiesEntities cxt;
        string facilityidtemp = "";
        string nametemp = "";
        string ratestemp = "";
        string ratesWOsymbol = "";
        string facilitiesnotemp = "";
        Facility fac;
        public ucFacilities()
        {
            InitializeComponent();
        }
        private void ucFacilities_Load(object sender, EventArgs e)
        {
            cmbSearchBy.DataSource = frmLogin.facilitylist;
            cmbSearchBy.DisplayMember = "facilityname";
            cmbSearchBy.ValueMember = "facilityname";
            cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void lblCheckAvailability_Click(object sender, EventArgs e)
        {
            fm = new frmMain();
            fm.ShowMainpage();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cxt = new SportsFacilitiesEntities();
            fac = new Facility();
            SubFacility subf = new SubFacility();
            Rate rate = new Rate();
            string r;
            try
            {
                fac = cxt.Facilities.Where(x => x.facilityname == cmbSearchBy.Text).First();
                gbSearchResults.Visible = true;
                //Facility Name / ID Display
                txtFacilityID.Text = fac.facilityid.ToString();
                facilityidtemp = txtFacilityID.Text;
                txtName.Text = fac.facilityname.ToString();
                nametemp = txtName.Text;
                // Rates Display
                r = fac.rateid.ToString();
                rate = cxt.Rates.Where(x => x.rateid.ToString() == r).First();
                ratesWOsymbol = rate.ratepertimeslot.ToString();
                cmbRates.Text = "$ " + ratesWOsymbol + ".00";
                ratestemp = ratesWOsymbol;
                // Subfacility Display
                var q = from x in cxt.SubFacilities where x.facilityid.ToString() == txtFacilityID.Text select x;
                txtFacilitiesNo.Text = q.Count().ToString();
                facilitiesnotemp = txtFacilitiesNo.Text;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Search Results cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ButtonVisibility(true);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFacilityID.Text = facilityidtemp;
            txtName.Text = nametemp;
            cmbRates.Text = "$" + ratestemp + ".00";
            txtFacilitiesNo.Text = facilitiesnotemp;
            ButtonVisibility(false);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult savebtn =
                MessageBox.Show("Are you sure you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo);
            if (savebtn == DialogResult.Yes)
            {
                ButtonVisibility(false);
                string price = "";
                if (cmbRates.Text.Length > 6)
                {
                    price = cmbRates.Text.Substring(2, 2);
                }
                else
                {
                    price = cmbRates.Text.Substring(2, 1);
                }
                int rateid = cxt.Rates.Where(x => x.ratepertimeslot.ToString() == price).Select(y => y.rateid).First(); ;
                fac.rateid = rateid;
                fac.facilityname = txtName.Text;
                cxt.SaveChanges();
                frmLogin.facilitylist = cxt.Facilities.ToList();
                cmbSearchBy.DataSource = frmLogin.facilitylist;
            }
        }
        #region Visibility Events
        private void ButtonVisibility(bool ClickEditBtn)
        {
            // If edit is clicked, fields can be edited and saved
            if (ClickEditBtn == true)
            {
                txtName.ReadOnly = false;
                cmbRates.Enabled = true;
                btnEdit.Visible = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                pbWarningFac.Visible = true;
                pbWarningID.Visible = true;
                pbWarningRate.Visible = true;
                btnSearch.Enabled = false;
            }
            else
            {
                txtName.ReadOnly = true;
                cmbRates.Enabled = false;
                btnEdit.Visible = true;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                pbWarningFac.Visible = false;
                pbWarningID.Visible = false;
                pbWarningRate.Visible = false;
                btnSearch.Enabled = true;
            }
        }
        private void pbWarningID_MouseEnter(object sender, EventArgs e)
        {
            lblWarningID.Visible = true;
        }
        private void pbWarningID_MouseLeave(object sender, EventArgs e)
        {
            lblWarningID.Visible = false;
        }
        private void pbWarningFac_MouseEnter(object sender, EventArgs e)
        {
            lblWarningFac.Visible = true;
        }
        private void pbWarningFac_MouseLeave(object sender, EventArgs e)
        {
            lblWarningFac.Visible = false;
        }
        private void pbWarningRate_MouseEnter(object sender, EventArgs e)
        {
            lblWarningRate.Visible = true;
        }
        private void pbWarningRate_MouseLeave(object sender, EventArgs e)
        {
            lblWarningRate.Visible = false;
        }
        #endregion
    }
}
