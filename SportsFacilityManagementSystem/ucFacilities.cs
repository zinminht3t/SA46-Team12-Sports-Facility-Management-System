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
        string facilitiesnotemp = "";
        public ucFacilities()
        {
            InitializeComponent();
        }
        // Combobox update codes

        private void lblCheckAvailability_Click(object sender, EventArgs e)
        {
            fm = new frmMain();
            fm.ShowMainpage();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cxt = new SportsFacilitiesEntities();
            Facility fac = new Facility();
            Rate rate = new Rate();
            gbSearchResults.Visible = true;
            fac = cxt.Facilities.Where(x => x.facilityname == cmbSearchBy.Text).First();
            
            //Facility Name / ID Display
            txtFacilityID.Text = fac.facilityid.ToString();
            facilityidtemp = txtFacilityID.Text;
            txtName.Text = fac.facilityname.ToString();
            nametemp = txtName.Text;
            // Rates Display
            rate = cxt.Rates.Where(y => y.rateid == fac.rateid).First();
            ratestemp = rate.ratepertimeslot.ToString();
            // Subfacility Display
            //var q = from xsf in cxt.SubFacilities join xf in cxt.Facilities on xsf.facilityid equals xf.facilityid select xsf.facilityid;
            var SubFacilityQ = from xsf in cxt.SubFacilities
                               join xf in cxt.Facilities on xsf.facilityid equals xf.facilityid
                               group xsf by xsf.subfacilityid into results
                               select new { Facility = results.Key, SubFacility = results.Count() };
            txtFacilitiesNo.Text = SubFacilityQ.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ButtonVisibility(true);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFacilityID.Text = facilityidtemp;
            txtName.Text = nametemp;
            txtRates.Text = ratestemp;
            txtFacilitiesNo.Text = facilitiesnotemp;
            ButtonVisibility(false);
        }

        private void ButtonVisibility(bool ClickEditBtn)
        {
            // If edit is clicked, fields can be edited and saved
            if (ClickEditBtn == true)
            {
                txtName.ReadOnly = false;
                txtRates.ReadOnly = false;
                txtFacilitiesNo.ReadOnly = false;
                btnEdit.Visible = false;
                lblCheckAvailability.Visible = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnSearch.Enabled = false;
            }
            else
            {
                txtName.ReadOnly = true;
                txtRates.ReadOnly = true;
                txtFacilitiesNo.ReadOnly = true;
                btnEdit.Visible = true;
                lblCheckAvailability.Visible = true;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                btnSearch.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //update database
            DialogResult savebtn = 
                MessageBox.Show("Are you sure you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo);
            if(savebtn == DialogResult.Yes)
            {
                ButtonVisibility(false);
                cxt = new SportsFacilitiesEntities();
                Facility fac = new Facility();
                fac.facilityname = txtName.Text;
                fac.rateid = int.Parse(txtRates.Text);
            }
        }

        private void PopulateCombobox()
        {

        }
    }
}
