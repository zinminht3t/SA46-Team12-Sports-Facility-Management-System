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
        public ucReports()
        {
            InitializeComponent();
        }

        private void cmbTypeofReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTypeofReport.SelectedIndex == 0)
            {
                gbReport.Visible = false;
                gbMemberList.Visible = true;
            }
            else
            {
                gbMemberList.Visible = false;
                gbReport.Visible = true;
            }
        }

        private void ucReports_Load(object sender, EventArgs e)
        {
            rdnDateRange.Checked = true;
            gbMemberList.Visible = false;
            gbReport.Visible = false;
            cmbStatus.SelectedIndex = 0;
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
            if(rdnDateRange.Checked)
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
    }
}
