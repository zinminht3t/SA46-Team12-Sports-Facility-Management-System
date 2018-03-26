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
    public partial class frmOccupancyReport : Form
    {
        public frmOccupancyReport()
        {
            InitializeComponent();
        }

        private void frmOccupancyReport_Load(object sender, EventArgs e)
        {
            DataSet6 ds = new DataSet6();

            DataSet6TableAdapters.bookinginvoicereportTableAdapter da = new DataSet6TableAdapters.bookinginvoicereportTableAdapter();

            da.Fill(ds.bookinginvoicereport);
            Occupancy cr = new Occupancy();
            cr.SetDataSource(ds);
            cr.SetParameterValue("dateFrom", ucReports.datefrom);
            cr.SetParameterValue("dateTo", ucReports.dateto);
            //cr.SetParameterValue("FacilityID", ucReports.facilityid);
            //cr.SetParameterValue("SubFacilityID", ucReports.subfacilityid);
            crOccupancy.ReportSource = cr;
        }
    }
}
