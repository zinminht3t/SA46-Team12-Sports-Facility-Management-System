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
    public partial class frmMemberListingReport : Form
    {
        public frmMemberListingReport()
        {
            InitializeComponent();
        }

        private void frmMemberListingReport_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.MembersTableAdapter da = new DataSet1TableAdapters.MembersTableAdapter();
            da.Fill(ds.Members);
            if(ucReports.isDateRange)
            {
                MemberListing cr = new MemberListing();
                cr.SetDataSource(ds);
                cr.SetParameterValue("Param_ExpDateTo", ucReports.daterangeML);
                crMLReport.ReportSource = cr;
            }
            else
            {
                MemberListingbyStatus cr = new MemberListingbyStatus();
                cr.SetDataSource(ds);
                cr.SetParameterValue("Param_Status", ucReports.paramstatus);
                crMLReport.ReportSource = cr;
            }
        }
    }
}
