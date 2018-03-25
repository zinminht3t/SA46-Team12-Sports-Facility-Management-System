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
            sda.Fill(ds);
            ds.Tables.Add(dt);
            cn.Close();
            dgvTransactions.DataSource = ds.Tables[1];
        }

        private void PastTransactions_Load(object sender, EventArgs e)
        {
            ucPT = new ucPastTransactions();

            #region SQL Commands
            string SQLcolumns = "select memberid, name, transactionid, facilityname, timeslot, total, systemtime, date, status from dbo.bookinginvoicereport ";
            string SQLwhereFacility = "facilityname ='" + ucPT.Fac + "'";
            string SQLwhereDate = "cast (systemtime as date) between '" + ucPT.Datefrom.ToString("yyyy/MM/dd") + "' and '" + ucPT.Dateto.ToString("yyyy/MM/dd") + "'";
            string SQLwhereStatus = "status = '" + ucPT.Status + "'";
            string command;
            #endregion
            #region Display Datagridview
            #region Facility.Checked
            if (getFlagfac == true && getFlagdate == false && getFlagstatus == false)
            {
                if (ucPT.Fac == "All")
                {
                    command = SQLcolumns;
                }
                else
                {
                    command = SQLcolumns + " where " + SQLwhereFacility;
                }
            }
            #endregion
            #region Date.Checked
            else
                if (getFlagfac == false && getFlagdate == true && getFlagstatus == false)
            {
                command = SQLcolumns + " where " + SQLwhereDate;
            }
            #endregion
            #region Status.Checked
            else
                if (getFlagfac == false && getFlagdate == false && getFlagstatus == true)
            {
                if (ucPT.Status == "All")
                {
                    command = SQLcolumns;
                }
                else
                {
                    command = SQLcolumns + " where " + SQLwhereStatus;
                }
            }
            #endregion
            #region All 3 Fields .Checked
            else
                if (getFlagdate == true && getFlagfac == true && getFlagstatus == true)
            {
                if (ucPT.Fac == "All" && ucPT.Status == "All")
                {
                        command = SQLcolumns + " where " + SQLwhereDate;
                }
                else
                if (ucPT.Fac == "All" && ucPT.Status != "All")
                {
                        command = SQLcolumns + " where " + SQLwhereStatus + " and " + SQLwhereDate;
                }
                else
                if (ucPT.Fac != "All" && ucPT.Status == "All")
                {
                        command = SQLcolumns + " where " + SQLwhereFacility + " and " + SQLwhereDate;
                }
                else
                {
                        command = SQLcolumns + " where " + SQLwhereFacility + " and " + SQLwhereStatus + " and " + SQLwhereDate;
                }
            }
            #endregion
            #region Facility.Checked + Date.Checked
            else
                if (getFlagfac == true && getFlagdate == true && getFlagstatus == false)
            {
                if (ucPT.Fac != "All")
                {
                        command = SQLcolumns + " where " + SQLwhereFacility + " and " + SQLwhereDate;
                }
                else
                {
                        command = SQLcolumns + " where " + SQLwhereDate;
                }
            }
            #endregion
            #region Facility.Checked + Status.Checked
            else
                if (getFlagfac == true && getFlagdate == false && getFlagstatus == true)
            {
                if (ucPT.Fac == "All" && ucPT.Status == "All")
                {
                    command = SQLcolumns;
                }
                else 
                    if(ucPT.Fac != "All" && ucPT.Status != "All")
                {
                    command = SQLcolumns + " where " + SQLwhereFacility + " and " + SQLwhereStatus;
                }
                else
                    if(ucPT.Fac != "All" && ucPT.Status == "All")
                {
                    command = SQLcolumns + " where " + SQLwhereStatus;
                }
                else
                {
                    command = SQLcolumns + " where " + SQLwhereFacility;
                }
            }
            #endregion
            #region Date.Checked + Status.Checked
            else
            {
                if (ucPT.Status == "All")
                {
                        command = SQLcolumns + " where " + SQLwhereDate;
                }
                else
                {
                        command = SQLcolumns + " where " + SQLwhereDate + " and " + SQLwhereStatus;
                }
            }
            #endregion

            DisplayTable(command);
            #endregion
            #region Show if no results returned
            if (dgvTransactions.Rows.Count == 1)
            {
                this.Close();
                MessageBox.Show("No results for these criterias!", "No Results");
            }
            #endregion
        }

    }
}
