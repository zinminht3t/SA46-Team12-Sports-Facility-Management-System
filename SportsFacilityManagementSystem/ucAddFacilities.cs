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
        SubFacility subfacility;
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
            txtRate.Text = "";
            cmbCourtNo.SelectedIndex = 1;
            lblWarningCourt.Visible = false;
            lblWarningName.Visible = false;
            lblWarningRate.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtRate.Text == "" || cmbCourtNo.Text == "")
            {
                if (txtName.Text == "")
                {
                    lblWarningName.Visible = true;
                }
                else
                {
                    lblWarningName.Visible = false;
                }

                if (txtRate.Text == "")
                {
                    lblWarningRate.Visible = true;
                }
                else
                {
                    lblWarningRate.Visible = false;
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
                if (lblWarningRate.Text == "") //if the user only enter the numbers
                {
                    InsertData();
                    MessageBox.Show("Add Facility Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllData();
                }
            }
        }

        private void InsertData()
        {
            SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
            facility = new Facility();
            facility.facilityname = txtName.Text;
            int rate = Convert.ToInt32(txtRate.Text);
            if ((ctx.Rates.Where(x => x.ratepertimeslot == rate).Count()) > 0)
            {
                facility.rateid = ctx.Rates.Where(x => x.ratepertimeslot == rate).First().rateid;
            }
            else
            {
                try
                {
                    Rate newrate = new Rate();
                    newrate.ratepertimeslot = rate;
                    ctx.Rates.Add(newrate);
                    ctx.SaveChanges();
                    facility.rateid = ctx.Rates.Where(x => x.ratepertimeslot == rate).First().rateid;
                }
                catch
                {
                    MessageBox.Show("Error Occurred. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRate.Text, "[^0-9]"))
            {
                lblWarningRate.Text = "Please enter only numbers.";
                lblWarningRate.Visible = true;
            }
            else
            {
                lblWarningRate.Text = "";
            }
        }
    }
}
