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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            //DataSet4 ds = new DataSet4();

            //DataSet4TableAdapters.revenuereportTableAdapter da = new DataSet4TableAdapters.revenuereportTableAdapter();

            //da.Fill(ds.revenuereport);
            //Revenue cr = new Revenue();
            //cr.SetDataSource(ds);
            //cr.SetParameterValue("Param_datefrom", 1);
            //cr.SetParameterValue("Param_dateto", 2);

            //crystalReportViewer1.ReportSource = cr;




            // Monthly Revenue Report
           // DataSet4 ds = new DataSet4();

           // DataSet4TableAdapters.revenuereportTableAdapter da = new DataSet4TableAdapters.revenuereportTableAdapter();

//            da.Fill(ds.revenuereport);
            //MonthlyRevenue cr = new MonthlyRevenue();
            //cr.SetDataSource(ds);            

//            crystalReportViewer1.ReportSource = cr;





            //Booking Occupancy Report
            //DataSet5 ds = new DataSet5();

            //DataSet5TableAdapters.revenuereportTableAdapter da = new DataSet5TableAdapters.revenuereportTableAdapter();

            //da.Fill(ds.revenuereport);
            //BookingOccupancy cr = new BookingOccupancy();
            //cr.SetDataSource(ds);


            //crystalReportViewer1.ReportSource = cr;






        }
    }
}
