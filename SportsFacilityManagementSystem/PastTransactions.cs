using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsFacilityManagementSystem
{
    public partial class PastTransactions : Form
    {
        ucPastTransactions ucPT;
        public bool getFlagfac;
        public bool getFlagdate;
        public bool getFlagstatus;
        public PastTransactions()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayTable(string sqlcommand)
        {
            string con = "data source = (local);" + "integrated security = SSPI;Initial catalog = Team12BSFMS";
            SqlConnection cn = new SqlConnection(con);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand, cn);
            DataTable dt = new DataTable();
            DataSet2 ds = new DataSet2();
            cn.Open();
            sda.Fill(dt);
            ds.Tables.Add(dt);
            cn.Close();
            dgvTransactions.DataSource = ds.Tables[1];
        }

        private void PastTransactions_Load(object sender, EventArgs e)
        {
            ucPT = new ucPastTransactions();
            if (getFlagfac == true && getFlagdate == false && getFlagstatus == false)
            {
                string facsql = "select memberid, name, transactionid, facilityname, " +
                    "timeslot, total, systemtime, date from dbo.bookinginvoicereport" +
                    "where facilityname = '" + ucPT.Fac + "'";
                DisplayTable(facsql);
            }
            else
                if(getFlagfac == false && getFlagdate == true && getFlagstatus == false)
            {
                // Change date format!!
                string datesql = "select transactionid, facilityname, total, systemtime, date " +
                                "from dbo.bookinginvoicereport where facilityname = '" + ucPT.Fac + "'";
            }
            else
                if(getFlagfac == false && getFlagdate == false && getFlagstatus == true)
            {
                string status;
            }
            else 
                if(getFlagdate == true && getFlagfac ==true && getFlagstatus == true)
            {
                string all = "select memberid, name, transactionid, facilityname, " +
                    "timeslot, total, systemtime, date from dbo.bookinginvoicereport";
                DisplayTable(all);
            }
            else 
                if(getFlagfac == true && getFlagdate == true && getFlagstatus == false)
            {
                // Change date format !!
                string facdatesql;
            }
            else
                if(getFlagfac == true && getFlagdate == false && getFlagstatus == true)
            {
                string facstatussql;
            }
            else
            {
                // Change Date format !!
                string datestatussql;
            }

        }
    }
}
