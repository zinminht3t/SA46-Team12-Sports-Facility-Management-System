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
        string fac;
        string status;
        string datefrom;
        string dateto;

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
        public string Datefrom
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
        public string Dateto
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
        int error = 0;
        public ucPastTransactions()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (chkbDateFrom.Checked == false && chkbFacilities.Checked == false && chkbStatus.Checked == false)
            {
                    error = 1;
                    MessageBox.Show("Please tick at least one box", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
            }
            else
            {
                if (chkbFacilities.Checked)
                {
                    if (cmbFac.Text == "")
                    {
                        error = 1;
                        MessageBox.Show("Please choose an option!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Fac = cmbFac.Text;
                    }
                }
                else
                if (chkbStatus.Checked)
                {
                    if (cmbStatus.Text != "")
                    {
                        Status = cmbStatus.Text;
                    }
                    else
                    {
                        error = 1;
                        MessageBox.Show("Please choose an option!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (chkbDateFrom.Checked)
                {
                    if (dtpDateFromML.Value >= dtpDatetoML.Value)
                    {
                        Datefrom = dtpDateFromML.Text;
                        Dateto = dtpDatetoML.Text;
                    }
                    else
                    {
                        error = 1;
                    }
                }
            }

            if(error == 0)
            {
                PastTransactions pt = new PastTransactions();
                pt.ShowDialog();
            }
            else
            {
                error = 0;
            }
        }

        #region Date changes
        private void dtpDateFromML_ValueChanged(object sender, EventArgs e)
        {
            Datelabelwarning();            
        }

        private void dtpDatetoML_ValueChanged(object sender, EventArgs e)
        {
            Datelabelwarning();
        }

        private void Datelabelwarning()
        {
            if (dtpDateFromML.Value < dtpDatetoML.Value)
            {
                lblWarningMLDateTo.Visible = true;
            }
        }
        #endregion
    }
}
