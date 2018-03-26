using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsFacilityManagementSystem
{
    public partial class ucPastTransactions : UserControl
    {
        #region Properties
        static string fac;
        static string status;
        static string transID;
        static DateTime datefrom;
        static DateTime dateto;
        bool error = false;
        bool msgbox = false;
        #endregion
        #region Assessor / Mutators (For passing values to New Form)
        public string Fac
        {
            get
            {
                return fac;
            }
            set
            {
                fac = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public DateTime Datefrom
        {
            get
            {
                return datefrom;
            }
            set
            {
                datefrom = value;
            }
        }
        public DateTime Dateto
        {
            get
            {
                return dateto;
            }
            set
            {
                dateto = value;
            }
        }
        public string TransID
        {
            get
            {
                return transID;
            }
            set
            {
                transID = value;
            }
        }
        #endregion
        public ucPastTransactions()
        {
            InitializeComponent();
        }

        #region Event Handler
        private void btnView_Click(object sender, EventArgs e)
        {
            #region Checking error of selection
            if (chkbDateFrom.Checked == false && chkbFacilities.Checked == false && chkbStatus.Checked == false)
            {
                error = true;
                msgBox();
            }
            else
            {
                if (chkbFacilities.Checked)
                {
                    if (cmbFac.Text == "")
                    {
                        error = true;
                        msgBox();
                    }
                    else
                    {
                        Fac = cmbFac.Text;
                    }
                }

                if (chkbStatus.Checked)
                {
                    if (cmbStatus.Text == "")
                    {
                        error = true;
                        msgBox();
                    }
                    else
                    {
                        Status = cmbStatus.Text;
                    }
                }

                if (chkbDateFrom.Checked)
                {
                    // Cannot work if you put same date... WHY !!?!?
                    if (dtpDateFromML.Value < dtpDatetoML.Value || dtpDateFromML.Value.ToString("yyyy/MM/dd") == dtpDatetoML.Value.ToString("yyyy/MM/dd"))
                    {
                        Datefrom = dtpDateFromML.Value;
                        Dateto = dtpDatetoML.Value;
                        lblWarningMLDateTo.Visible = false;

                    }
                    else
                    {
                        error = true;
                        msgBox();
                        lblWarningMLDateTo.Visible = true;
                    }
                }
            }
            #endregion

            #region Passing values to new form / reset boolean
            if (error == false)
            {
                PastTransactions pt = new PastTransactions();
                pt.getFlagfac = chkbFacilities.Checked;
                pt.getFlagdate = chkbDateFrom.Checked;
                pt.getFlagstatus = chkbStatus.Checked;
                pt.viewbtnTrans = false;
                pt.ShowDialog();
            }

            // Reset to false for new search
            error = false;
            msgbox = false;
            #endregion
        }
        private void btnTid_Click(object sender, EventArgs e)
        {
            gbTrans.Visible = true;
            gbType.Visible = false;
        }
        private void btnType_Click(object sender, EventArgs e)
        {
            gbType.Visible = true;
            gbTrans.Visible = false;
        }
        private void btnViewTrans_Click(object sender, EventArgs e)
        {
            PastTransactions pt = new PastTransactions();
            if (rbtnAll.Checked == true)
            {
                pt.viewAllTrans = true;
                pt.viewbtnTrans = true;
            }
            else
            {
                transID = txtTid.Text;
                pt.viewbtnTrans = true;
                pt.viewAllTrans = false;
            }
            pt.ShowDialog();

        }
        private void ucPastTransactions_Load(object sender, EventArgs e)
        {
            cmbFac.DataSource = frmLogin.facilitylist;
            cmbFac.ValueMember = "facilityname";
            this.Refresh();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtTid.ReadOnly = false;
        }
        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            txtTid.ReadOnly = true;
        }
        private void ucPastTransactions_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                resetPastTransControls();
            }

            btnView.Enabled = true;
            btnViewTrans.Enabled = true;

        }
        private void AddVisibleChangedEventHandler()
        {
            this.VisibleChanged += new EventHandler(this.ucPastTransactions_VisibleChanged);
        }
        #endregion

        private void msgBox()
        {
            if (msgbox == false)
            {
                msgbox = true;
                MessageBox.Show("Selection error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void resetPastTransControls()
        {
            //search by type
            cmbFac.Text = "";
            cmbStatus.Text = "All";
            dtpDateFromML.Value = DateTime.Now;
            dtpDatetoML.Value = DateTime.Now;
            chkbFacilities.Checked = false;
            chkbDateFrom.Checked = false;
            chkbStatus.Checked = false;
            btnView.Enabled = false;


            //search by transaction
            rbtnAll.Checked = false;
            rbtnTid.Checked = false;
            txtTid.Text = "";
            btnViewTrans.Enabled = false;
        }
    }
}
