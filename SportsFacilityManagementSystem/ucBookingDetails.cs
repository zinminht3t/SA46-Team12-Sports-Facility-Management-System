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
        private int i;


        public ucBookingDetails()
        {
            InitializeComponent();
            dtpBookingDate.CustomFormat = "dd-MMM-yyyy hh:mm tt";
        }

        public void setTxtFacilityID(string s)
        {
            this.txtFacilityID.Text = s;
        }

        public void SetLbSelectedSlotSF(List<BookingDetails> l)
        {
            foreach(BookingDetails bd in l)
            {
                i= l.IndexOf(bd);
                this.lbSelSlotsSF.Items[i] = l[i].subFacilityBooked;
                this.lbSelSlotsTiming.Items[i] = l[i].slotBooked;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtMemID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
