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
        #endregion
        
        public ucPastTransactions()
        {
            InitializeComponent();
        }

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
                    if (dtpDateFromML.Value >= dtpDatetoML.Value)
                    {
                        error = true;
                        msgBox();
                        lblWarningMLDateTo.Visible = true;
                    }
                    else
                    {
                        Datefrom = dtpDateFromML.Value;
                        Dateto = dtpDatetoML.Value ;
                        lblWarningMLDateTo.Visible = false;
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
                pt.ShowDialog();
            }
            
            // Reset to false for new search
            error = false;
            msgbox = false;
            #endregion
        }

        private void msgBox()
        {
            if (msgbox == false)
            {
                msgbox = true;
                MessageBox.Show("Selection error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
