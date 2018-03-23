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
    public partial class ucBookingDetails : UserControl
    {
        public ucBookingDetails()
        {
            InitializeComponent();
            dtpBookingDate.CustomFormat = "dd-MMM-yyyy hh:mm tt";
        }

        public void setTxtFacilityID(string s)
        {
            this.txtFacilityID.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
