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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();

            // Members Listing 
            //DataSet1 ds = new DataSet1();

            //DataSet1TableAdapters.MembersTableAdapter da = new DataSet1TableAdapters.MembersTableAdapter();

            //da.Fill(ds.Members);
            //MemberListing cr = new MemberListing();
            //cr.SetDataSource(ds);

            //crystalReportViewer1.ReportSource = cr;


            // Booking Invoice
            //DataSet2 ds = new DataSet2();

            //DataSet2TableAdapters.bookinginvoicereportTableAdapter da = new DataSet2TableAdapters.bookinginvoicereportTableAdapter();

            //da.Fill(ds.bookinginvoicereport);
            //BookingInvoice cr = new BookingInvoice();
            //cr.SetDataSource(ds);

            //crystalReportViewer1.ReportSource = cr;


            // Membership Form
            //DataSet3 ds = new DataSet3();

            //DataSet3TableAdapters.MembersTableAdapter da = new DataSet3TableAdapters.MembersTableAdapter();       

            //da.Fill(ds.Members);           
            //MemberForm cr = new MemberForm();
            //cr.SetDataSource(ds);

            //crystalReportViewer1.ReportSource = cr;



            //Revenue Report
            DataSet4 ds = new DataSet4();

            DataSet4TableAdapters.revenuereportTableAdapter da = new DataSet4TableAdapters.revenuereportTableAdapter();

            da.Fill(ds.revenuereport);
            Revenue cr = new Revenue();
            cr.SetDataSource(ds);
            //cr.SetParameterValue("Param_datefrom", "2018-01-01");
            //cr.SetParameterValue("Param_dateto", "2018-02-01");

            crystalReportViewer1.ReportSource = cr;






        }
    }
}
