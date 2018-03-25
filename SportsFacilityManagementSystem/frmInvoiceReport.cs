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
    public partial class frmInvoiceReport : Form
    {
        public frmInvoiceReport()
        {
            InitializeComponent();
        }

        private void frmInvoiceReport_Load(object sender, EventArgs e)
        {
            DataSet2 ds = new DataSet2();

            DataSet2TableAdapters.bookinginvoicereportTableAdapter da = new DataSet2TableAdapters.bookinginvoicereportTableAdapter();

            da.Fill(ds.bookinginvoicereport);
            BookingInvoice cr = new BookingInvoice();
            cr.SetDataSource(ds);
            cr.SetParameterValue("TransactionID", frmBookingDetail.rptTransactionid);

            crInvoice.ReportSource = cr;
        }
    }
}
