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
    public partial class ucAddFacilities : UserControl
    {
        Facility facility;
        public ucAddFacilities()
        {
            InitializeComponent();
        }
        private void pbRatesinfo_MouseEnter(object sender, EventArgs e)
        {
            lblRatesInfo.Visible = true;
        }
        private void pbRatesinfo_MouseLeave(object sender, EventArgs e)
        {
            lblRatesInfo.Visible = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllData();
        }
        private void ResetAllData()
        {
            txtName.Text = "";
            cmbRates.Text = "";
            cmbCourtNo.SelectedIndex = 1;
            lblWarningRate.Visible = false;
            lblWarningCourt.Visible = false;
            lblWarningName.Visible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbRates.Text == "")
            {
                lblWarningRate.Visible = true;
            }
            else
            if (txtName.Text == "" || cmbCourtNo.Text == "")
            {
                if (txtName.Text == "")
                {
                    lblWarningName.Visible = true;
                }
                else
                {
                    lblWarningName.Visible = false;
                }


                if (cmbCourtNo.Text == "")
                {
                    lblWarningCourt.Visible = true;
                }
                else
                {
                    lblWarningCourt.Visible = false;
                }
            }
            else
            {
                InsertData();
                MessageBox.Show("Add Facility Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetAllData();
            }
        }
        private void InsertData()
        {
            SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
            facility = new Facility();
            facility.facilityname = txtName.Text;
            string price = "";
            if (cmbRates.Text.Length > 6)
            {
                price = cmbRates.Text.Substring(2, 2);
            }
            else
            {
                price = cmbRates.Text.Substring(2, 1);
            }
            int rate = Convert.ToInt32(price);

            if ((ctx.Rates.Where(x => x.ratepertimeslot == rate).Count()) > 0)
            {
                facility.rateid = ctx.Rates.Where(x => x.ratepertimeslot == rate).First().rateid;
            }
            else
            {
                Rate newrate = new Rate();
                newrate.ratepertimeslot = rate;
                ctx.Rates.Add(newrate);
                ctx.SaveChanges();
                facility.rateid = ctx.Rates.Where(x => x.ratepertimeslot == rate).First().rateid;
            }
            try
            {
                ctx.Facilities.Add(facility);
                int noOfCourt = Convert.ToInt32(cmbCourtNo.SelectedItem.ToString());
                for (int i = 0; i < noOfCourt; i++)
                {
                    SubFacility sf = new SubFacility();
                    sf.facilityid = facility.facilityid;
                    if (i == 0)
                    {
                        sf.subfacilityname = "A";
                    }
                    else if (i == 1)
                    {
                        sf.subfacilityname = "B";
                    }
                    else
                    {
                        sf.subfacilityname = "C";
                    }
                    ctx.SubFacilities.Add(sf);
                }
                ctx.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error Occurred. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucAddFacilities_Load(object sender, EventArgs e)
        {
            cmbCourtNo.SelectedIndex = 0;
        }
    }
}
