using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsFacilityManagementSystem
{
    public partial class frmBookingDetail : Form
    {

        int i;
        private SportsFacilitiesEntities cxt = new SportsFacilitiesEntities();
        private int noOfSlotsSelected = 1;
        double price;
        int facilityID;
        public frmBookingDetail()
        {
            InitializeComponent();
        }

        
        private void frmBookingDetail_Load(object sender, EventArgs e)
        {
            facilityID = cxt.Facilities.First(x=>x.facilityname==txtFacilityID.Text).facilityid;
            double rate = cxt.Facilities.First(x => x.facilityid == facilityID).Rate.ratepertimeslot;
            //txtRates.Text = rate.ToString("{0:C}");
            txtRates.Text = "$" + String.Format("{0:#.00}", rate);
            noOfSlotsSelected = lbSelSlotsSF.Items.Count;
            price = rate * noOfSlotsSelected;
            string totalprice = price.ToString();
            txtTotalPrice.Text = "$" + String.Format("{0:#.00}", totalprice);

        }

        public void setLbSelFacility(String s)
        {
            this.lbSelSlotsFacility.Items.Add(s);
        }
            
        public void setTxtFacilityID(string s)
        {
            this.txtFacilityID.Text = s;
        }

        public void SetLbSelectedSlotSF(List<BookingDetails> l)
        {
            string a;
            int timeslot;
            foreach (BookingDetails bd in l)
            {
                i = l.IndexOf(bd) + 0;
                this.lbSelSlotsSF.Items.Add(l[i].subFacilityBooked);
                timeslot = l[i].slotBooked;
                a = cxt.Timeslots.First(x => x.timeslotid == timeslot).timeslot.ToString();
                this.lbSelSlotsTiming.Items.Add(a);
            }

        }

        private void lbSelSlotsSF_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMemID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtMemID.Text);
                txtMemIDdisplay.Text = cxt.Members.First(x => x.memberid == ID).name;
            }
            catch
            {
                txtMemIDdisplay.Text = "";
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSubMembers fsm = new FrmSubMembers();
            fsm.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {

                Transaction t = new Transaction();
                t.memberid = Convert.ToInt32(txtMemID.Text);
                t.remark = txtRemarks.Text;
                t.systemtime = DateTime.Now;
                t.total = price;
                t.status = "Confirmed";
                SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
                ctx.Transactions.Add(t);
                ctx.SaveChanges();

                int id = t.transactionid;
                TransactionDetail td;
                int subfacilityid;
                int timeslotid;
                foreach (BookingDetails bd in ucBooking.getSelectedSlots())
                {
                    subfacilityid = ctx.SubFacilities.First(x => x.facilityid == facilityID && x.subfacilityname == bd.subFacilityBooked).subfacilityid;
                    timeslotid = bd.slotBooked;
                    td = new TransactionDetail();
                    td.transactionid = id;
                    td.facilityid = facilityID;
                    td.timeslotid = timeslotid;
                    td.date = dtpDate.Value;
                    td.subfacilityid = subfacilityid;
                    ctx.TransactionDetails.Add(td);
                }
                ctx.SaveChanges();
                MessageBox.Show("Booking Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("You have encountered an error. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //for(lb)
            //for(int i = 0; i < noOfSlotsSelected; i++)
            //{
            //    td = new TransactionDetail();
            //}
        }
    }
}
