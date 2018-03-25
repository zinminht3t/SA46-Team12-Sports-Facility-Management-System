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
    public partial class frmMemberInfoReport : Form
    {
        public frmMemberInfoReport()
        {
            InitializeComponent();
        }

        private void frmMemberInfoReport_Load(object sender, EventArgs e)
        {
            DataSet3 ds = new DataSet3();

            DataSet3TableAdapters.MembersTableAdapter da = new DataSet3TableAdapters.MembersTableAdapter();

            da.Fill(ds.Members);
            MemberForm cr = new MemberForm();
            cr.SetDataSource(ds);
            cr.SetParameterValue("MemberID", ucMembers.memberid);
            crMember.ReportSource = cr;
        }
    }
}
