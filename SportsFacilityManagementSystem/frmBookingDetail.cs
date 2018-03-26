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
        #region Properties
        int i;
        SportsFacilitiesEntities cxt = new SportsFacilitiesEntities();
        int noOfSlotsSelected = 1;
        double price;
        int facilityID;
        int transid;
        int trandetailid;
        public static int rptTransactionid;
        TransactionDetail removetd;
        Transaction rt;
        #endregion
        public frmBookingDetail()
        {
            InitializeComponent();
        }
        #region Accessor / Mutator
        public void setLbSelFacility(String s)
        {
            lbSelSlotsFacility.Items.Clear();
            this.lbSelSlotsFacility.Items.Add(s);
        }
        public void setTxtFacilityID(string s)
        {
            this.txtFacilityID.Text = s;
        }
        public void SetLbSelectedSlotSF(List<BookingDetails> l)
        {
            lbSelSlotsSF.Items.Clear();
            lbSelSlotsTiming.Items.Clear();
            string a;
            int timeslot;
            foreach (BookingDetails bd in l.OrderBy(x => x.subFacilityBooked).ThenBy(x => x.slotBooked))
            {
                i = l.IndexOf(bd) + 0;
                this.lbSelSlotsSF.Items.Add(l[i].subFacilityBooked);
                timeslot = l[i].slotBooked;
                a = cxt.Timeslots.First(x => x.timeslotid == timeslot).timeslot.ToString();
                this.lbSelSlotsTiming.Items.Add(a);
            }

        }
        #endregion
        #region Event Handler
        private void frmBookingDetail_Load(object sender, EventArgs e)
        {
            if (txtFacilityID.Text == "" || txtFacilityID.Text is null)
            {
                ShowExistingBookingDetail();
            }
            else
            {
                btnBook.Enabled = false;
                txtMemID.ReadOnly = false;
                btnCancel.Visible = false;
                btnBook.Visible = true;
                facilityID = cxt.Facilities.First(x => x.facilityname == txtFacilityID.Text).facilityid;
                double rate = cxt.Facilities.First(x => x.facilityid == facilityID).Rate.ratepertimeslot;
                txtRates.Text = "$" + String.Format("{0:#.00}", rate);
                noOfSlotsSelected = lbSelSlotsSF.Items.Count;
                price = rate * noOfSlotsSelected;
                string totalprice = price.ToString();
                txtTotalPrice.Text = "$" + String.Format("{0:#.00}", totalprice);
                dtpDate.Value = ucBooking.getForDate();
            }

        }
        private void txtMemID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtMemID.Text);
                txtMemIDdisplay.Text = cxt.Members.First(x => x.memberid == ID && x.status == "Active").name;
                btnBook.Enabled = true;
            }
            catch
            {
                txtMemIDdisplay.Text = "";
                btnBook.Enabled = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmSubMembers fsm = new FrmSubMembers();
            fsm.ShowDialog();
            txtMemID.Text = FrmSubMembers.memberid.ToString();
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
                DialogResult result = MessageBox.Show("Do you want to print the booking invoice?", "Print", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    rptTransactionid = id;
                    frmInvoiceReport frmIR = new frmInvoiceReport();
                    frmIR.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("You have encountered an error. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed with the cancellation?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    cxt.TransactionDetails.Remove(removetd);
                    cxt.SaveChanges();
                    if (cxt.TransactionDetails.Where(x => x.transactionid == transid).Count() == 0)
                    {
                        rt.status = "Cancelled";
                        cxt.SaveChanges();
                    }
                    MessageBox.Show("Booking has been successfully cancelled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("You have encountered an error. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        private void ShowExistingBookingDetail()
        {
            btnCancel.Visible = true;
            btnBook.Visible = false;
            txtMemID.ReadOnly = true;
            lbSelSlotsFacility.Items.Clear();
            lbSelSlotsSF.Items.Clear();
            lbSelSlotsTiming.Items.Clear();
            trandetailid = ucBooking.redButtonTransID;
            transid = cxt.TransactionDetails.First(x => x.transactiondetailid == trandetailid).transactionid;
            removetd = new TransactionDetail();
            removetd = cxt.TransactionDetails.First(x => x.transactiondetailid == trandetailid);
            dtpDate.Value = ucBooking.getForDate();
            rt = new Transaction();
            rt = cxt.Transactions.First(x => x.transactionid == transid);
            txtMemID.Text = rt.memberid.ToString();
            txtMemIDdisplay.Text = rt.Member.name.ToString();
            dtpBookingDate.Value = rt.systemtime;
            txtRemarks.Text = rt.remark;
            txtTotalPrice.Text = rt.total.ToString();
            txtFacilityID.Text = removetd.facilityid.ToString();
            txtFacilityIDdisplay.Text = removetd.Facility.facilityname.ToString();
            txtRates.Text = removetd.Facility.Rate.ratepertimeslot.ToString();
            lbSelSlotsFacility.Items.Add(removetd.Facility.facilityname);
            lbSelSlotsSF.Items.Add(removetd.SubFacility.subfacilityname);
            lbSelSlotsTiming.Items.Add(removetd.Timeslot.timeslot);
        }
    }
}
