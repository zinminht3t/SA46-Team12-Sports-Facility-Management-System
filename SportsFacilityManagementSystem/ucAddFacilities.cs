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
    public partial class ucAddFacilities : UserControl
    {
        public ucAddFacilities()
        {
            InitializeComponent();
        }

        private void pbRatesinfo_MouseEnter(object sender, EventArgs e)
        {
            lblRatesInfo.Visible = true;
        }
    }
}
