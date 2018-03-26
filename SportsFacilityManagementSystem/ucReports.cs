using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SportsFacilityManagementSystem
{
    public partial class ucReports : UserControl
    {
        public static ParameterRangeValue daterangeML;
        public static string paramstatus;
        public static bool isDateRange;
        public static DateTime datefrom;
        public static DateTime dateto;
        public static string year;
        public static string mrmonth;
        public static string mryear;
        public static int facilityid;
        public static int subfacilityid;
        SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
        public ucReports()
        {
            InitializeComponent();
        }
        private void cmbTypeofReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeofReport.SelectedIndex == 0)
            {
                gbReport.Visible = false;
                gbMemberList.Visible = true;
                gbRevenue.Visible = false;
                gbMMR.Visible = false;
            }
            else if (cmbTypeofReport.SelectedIndex == 1)
            {
                gbMemberList.Visible = false;
                gbRevenue.Visible = false;
                gbReport.Visible = true;
                gbMMR.Visible = false;
            }
            else if (cmbTypeofReport.SelectedIndex == 2)
            {
                gbMemberList.Visible = false;
                gbRevenue.Visible = true;
                gbReport.Visible = false;
                gbMMR.Visible = false;
            }
            else
            {
                gbMemberList.Visible = false;
                gbRevenue.Visible = false;
                gbReport.Visible = false;
                gbMMR.Visible = true;
            }
        }
        private void ucReports_Load(object sender, EventArgs e)
        {
            rdnDateRange.Checked = true;
            gbMemberList.Visible = false;
            gbReport.Visible = false;
            cmbStatus.SelectedIndex = 0;
            cmbTypeofReport.Text = "Select Report";
            List<int> years = new List<int>();
            int thisyear = DateTime.Today.Year;
            for (int i = 0; i < 3; i++)
            {
                years.Add(thisyear - i);
            }
            cmbMRYear.DataSource = years;
            cmbYear.DataSource = years;
            dtpToDateReport.Value = DateTime.Today.AddDays(7);
        }
        private void gbMemberList_Enter(object sender, EventArgs e)
        {
        }
        private void btnPrintML_Click(object sender, EventArgs e)
        {
            daterangeML = new ParameterRangeValue();
            daterangeML.StartValue = dtpDateFromML.Value;
            daterangeML.EndValue = dtpDatetoML.Value;
            paramstatus = cmbStatus.SelectedItem.ToString();
            if (rdnDateRange.Checked)
            {
                isDateRange = true;
            }
            else
            {
                isDateRange = false;
            }
            frmMemberListingReport frm = new frmMemberListingReport();
            frm.ShowDialog();
        }
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            datefrom = dtpDateFromReport.Value;
            dateto = dtpToDateReport.Value;
            if (cmbTypeofReport.SelectedIndex == 1) //facility occupancy report
            {
                frmOccupancyReport frmOR = new frmOccupancyReport();
                frmOR.ShowDialog();
            }
        }
        private void btnRPrint_Click(object sender, EventArgs e)
        {
            year = cmbYear.SelectedItem.ToString();
            frmRevenueReport frmRR = new frmRevenueReport();
            frmRR.ShowDialog();
        }
        private void dtpToDateReport_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFromReport.Value = dtpToDateReport.Value.AddDays(-6);
        }
        private void dtpDatetoML_ValueChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mrmonth = (cmbMRMonth.SelectedIndex + 1).ToString();
            mryear = cmbMRYear.SelectedItem.ToString();
            frmMonthlyRevenueReport frmMRR = new frmMonthlyRevenueReport();
            frmMRR.ShowDialog();
        }
        private void cmbMRYear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dtpDateFromReport_ValueChanged(object sender, EventArgs e)
        {
            dtpToDateReport.Value = dtpDateFromReport.Value.AddDays(6);
        }

        private void ucReports_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                cmbTypeofReport.SelectedIndex=0;
            }
        }

        private void AddVisibleChangedEventHandler()
        {
            this.VisibleChanged += new EventHandler(this.ucReports_VisibleChanged);
        }
    }
}
