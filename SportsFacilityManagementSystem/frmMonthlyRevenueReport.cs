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
    public partial class frmMonthlyRevenueReport : Form
    {
        public frmMonthlyRevenueReport()
        {
            InitializeComponent();
        }

        private void frmMonthlyRevenueReport_Load(object sender, EventArgs e)
        {
            DataSet5 ds = new DataSet5();
            DataSet5TableAdapters.revenuereportTableAdapter da = new DataSet5TableAdapters.revenuereportTableAdapter();
            da.Fill(ds.revenuereport);


            MarchRevenue cr = new MarchRevenue();
            cr.SetDataSource(ds);
            cr.SetParameterValue("Month", ucReports.month);
            crMRReport.ReportSource = cr;
        }
    }
}
