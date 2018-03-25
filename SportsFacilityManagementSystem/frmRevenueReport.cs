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
    public partial class frmRevenueReport : Form
    {
        public frmRevenueReport()
        {
            InitializeComponent();
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            DataSet4 ds = new DataSet4();

            DataSet4TableAdapters.revenuereportTableAdapter da = new DataSet4TableAdapters.revenuereportTableAdapter();

            da.Fill(ds.revenuereport);
            MonthlyRevenue cr = new MonthlyRevenue();
            cr.SetDataSource(ds);
            cr.SetParameterValue("Year", ucReports.year);

            crRevenue.ReportSource = cr;
        }
    }
}
