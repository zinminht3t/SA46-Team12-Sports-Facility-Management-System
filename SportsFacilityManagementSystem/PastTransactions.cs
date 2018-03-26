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
        #region Properties
        ucPastTransactions ucPT;
        public bool getFlagfac;
        public bool getFlagdate;
        public bool getFlagstatus;
        public bool viewbtnTrans;
        public bool viewAllTrans;
        public bool norecords;
        string command;
        #endregion
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
            DataSet2 ds = new DataSet2();
            cn.Open();
            #region Catch invalid variable
            try
            {
                sda.Fill(ds);
                ds.Tables.Add();
                cn.Close();
                dgvTransactions.DataSource = ds.Tables[1];
            }
            catch
            {
                this.Close();
                MessageBox.Show("Incorrect value! Please try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            #region Show if no results returned
            if (dgvTransactions.Rows.Count == 0)
            {
                this.Close();
                MessageBox.Show("No results found!", "No results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion
        }

        private void PastTransactions_Load(object sender, EventArgs e)
        {
            ucPT = new ucPastTransactions();
            SQL();

            DisplayTable(command);

            int count = dgvTransactions.Rows.Count;
            if(count > 0)
            {
                toolStripStatusLabel1.Text = count.ToString() + " Records Found!";
            }
            else
            {
                toolStripStatusLabel1.Text = "No result";
            }
        }

        private void SQL()
        {
            #region SQL Command
            ucPT = new ucPastTransactions();
            string SQLcolumns = "select memberid, name, transactionid, facilityname, timeslot, total, systemtime, date, status from dbo.bookinginvoicereport ";
            string SQLwhereFacility = "facilityname ='" + ucPT.Fac + "'";
            string SQLwhereDate = "date between '" + ucPT.Datefrom.ToString("yyyy/MM/dd") + "' and '" + ucPT.Dateto.ToString("yyyy/MM/dd") + "'";
            string SQLwhereStatus = "status = '" + ucPT.Status + "'";
            #endregion
            #region Display Datagridview Table
            if (viewbtnTrans == false)
            {
                #region Display Search by Type
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
                        if (ucPT.Fac != "All" && ucPT.Status != "All")
                    {
                        command = SQLcolumns + " where " + SQLwhereFacility + " and " + SQLwhereStatus;
                    }
                    else
                        if (ucPT.Fac != "All" && ucPT.Status == "All")
                    {
                        command = SQLcolumns + " where " + SQLwhereFacility;
                    }
                    else
                    {
                        command = SQLcolumns + " where " + SQLwhereStatus;
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
                #endregion
            }
            else
            {
                #region Display Transaction Search
                if (viewAllTrans == true)
                {
                    command = SQLcolumns;
                }
                else
                {
                    command = SQLcolumns + " where transactionid ='" + ucPT.TransID + "'";
                }
                #endregion
            }
            #endregion


        }

    }
}
