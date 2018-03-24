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
        public ucPastTransactions()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

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
                lblWarningMLDateTo.Visible = true;
        }
        #endregion
    }
}
