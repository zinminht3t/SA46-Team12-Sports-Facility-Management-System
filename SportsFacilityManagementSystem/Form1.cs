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


            DataSet1 ds = new DataSet1();

            DataSet1TableAdapters.MembersTableAdapter da = new DataSet1TableAdapters.MembersTableAdapter();

            da.Fill(ds.Members);
            MemberListing cr = new MemberListing();
            cr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = cr;
            

        }
    }
}
