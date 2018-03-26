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
    public partial class ucBooking : UserControl
    {
        #region Properties
        SportsFacilitiesEntities ctx;
        List<String> subfacilitiesListNames = new List<String>();
        List<int> subfacilitiesListIds = new List<int>();
        List<int> ifBookedSubfacility = new List<int>();
        List<Control> collectionVisibleButtons = new List<Control>();
        List<Control> collectionClickedButtons = new List<Control>();
        static List<BookingDetails> bkgDetailsList = new List<BookingDetails>();
        string[,] arrayDaySlotsName = new string[3, 5];
        string defaultCmbSports;
        string facilityMemName;
        string sfname;
        int sfid;
        int noSubFacilities;
        int noSelected;
        int facId;
        int[,] arrayDaySlots = new int[3, 5];
        int? facilityTransID;
        int? facilityMemID;
        public static int redButtonTransID;
        static DateTime dtpBookingDatevalue;
        #endregion

        public ucBooking()
        {
            InitializeComponent();

        }
        
        #region Accessor / Mutator
        public static List<BookingDetails> getSelectedSlots()
        {
            return bkgDetailsList;
        }

        private int getFacilityID()
        {
            try
            {
                facId = ctx.Facilities.First(x => x.facilityname == cmbSports.Text).facilityid;
            }
            catch
            {
                //invalid facilityID
            }
            return facId;
        }

        public static DateTime getForDate()
        {
            return dtpBookingDatevalue;
        }
        #endregion

        #region Event Handler
        private void btnBook_Click(object sender, EventArgs e)
        {
            bkgDetailsList.Clear();
            if (noSelected == 0)
            {
                MessageBox.Show("You have not selected any booking slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bkgDetailsList.Clear();
                int controlIndex = 0;
                foreach (Control c in collectionClickedButtons)
                {
                    char cRow = char.Parse(c.Name.Substring(3, 1));
                    int cRow_ = 0;
                    switch (cRow)
                    {
                        case 'A':
                            cRow_ = 1;
                            break;

                        case 'B':
                            cRow_ = 2;
                            break;

                        case 'C':
                            cRow_ = 3;
                            break;
                    }

                    BookingDetails bd = new BookingDetails() { subFacilityBooked = subfacilitiesListNames[cRow_ - 1], slotBooked = Int32.Parse(c.Name.Substring(4, 1)) };
                    bkgDetailsList.Add(bd);
                    controlIndex++;
                }

                frmBookingDetail frmBD = new frmBookingDetail();
                frmBD.setTxtFacilityID(cmbSports.Text);
                frmBD.SetLbSelectedSlotSF(bkgDetailsList);
                for (int i = 0; i < noSelected; i++)
                {
                    frmBD.setLbSelFacility(cmbSports.Text);

                }
                frmBD.ShowDialog();
                LoadBookingSlots();
                collectionClickedButtons.Clear();
            }
        }
        private void cmbSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            collectionClickedButtons.Clear();
            LoadBookingSlots();
        }
        protected void con_Click(object sender, EventArgs e)
        {
            //This event is triggered when a visible Button is clicked.
            #region Button Clicks for displayed booking slots
            Button dynamicButton = (sender as Button);
            if (dynamicButton.BackColor == Color.Green) //already clicked before
            {
                dynamicButton.BackColor = Color.LightGreen;
                collectionClickedButtons.Remove(dynamicButton);
                noSelected--; //unselected
            }
            else
            if (dynamicButton.BackColor == Color.Red)
            {
                this.getFacilityID();
                char redButtonSubfacility = char.Parse(dynamicButton.Name.Substring(3, 1));
                string subfname = redButtonSubfacility.ToString();
                int fid = this.getFacilityID();
                int redButtonSubfacility_ = ctx.SubFacilities.First(x => x.subfacilityname == subfname && x.facilityid == fid).subfacilityid;
                int redButtonTimeslotID = Int32.Parse(dynamicButton.Name.Substring(4, 1));
                redButtonTransID = ctx.TransactionDetails.First
                    (x => x.facilityid == fid && x.subfacilityid == redButtonSubfacility_ && x.date == dtpBookingDate.Value
                    && x.timeslotid == redButtonTimeslotID).transactiondetailid;
                frmBookingDetail frmBD = new frmBookingDetail();
                frmBD.ShowDialog();
                LoadBookingSlots();
            }
            else
            {
                dynamicButton.BackColor = Color.Green;
                collectionClickedButtons.Add(dynamicButton);
                noSelected++;
            }
            #endregion

            if (noSelected > 0)
            {
                btnBook.Enabled = true;
            }
            else
            {
                btnBook.Enabled = false;
            }
        }
        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            dtpBookingDatevalue = dtpBookingDate.Value;
            LoadBookingSlots();
        }
        private void ucBooking_Load_1(object sender, EventArgs e)
        {
            ctx = new SportsFacilitiesEntities();
            defaultCmbSports = "- Select sport -";
            cmbSports.Text = defaultCmbSports;
            dtpBookingDate.Value = DateTime.Today;
            dtpBookingDatevalue = dtpBookingDate.Value;
        }
        private void cmbSports_Click(object sender, EventArgs e)
        {
            cmbSports.DataSource = frmLogin.facilitylist;
            cmbSports.DisplayMember = "facilityname";
            cmbSports.ValueMember = "facilityname";
            if (cmbSports.SelectedIndex >= 0)
            {
                cmbSports.DropDownStyle = ComboBoxStyle.DropDownList;
                LoadBookingSlots();
            }

        }
        #endregion

        #region Reload buttons displayed
        private void LoadBookingSlots()
        {
            noSelected = 0;

            foreach (Control c in collectionVisibleButtons)
            {
                c.Click -= new System.EventHandler(this.con_Click);
            }
            collectionVisibleButtons.Clear();
            subfacilitiesListNames.Clear();
            ifBookedSubfacility.Clear();

            if (cmbSports.Text != defaultCmbSports)
            {
                this.getFacilityID();
                noSubFacilities = ctx.SubFacilities.Count(x => x.facilityid == facId); //to replace output with no of subfac belonging to selected facility
                //create array of subfacilities name belonging to selected facility
                var qrySubFacilitiesName = from x in ctx.SubFacilities where x.facilityid == facId orderby x.subfacilityname select x.subfacilityname;
                subfacilitiesListNames = qrySubFacilitiesName.ToList<String>();
                //populate arrays for UI booking slots of selected date
                for (int slotRow = 1; slotRow <= 3; slotRow++)
                {
                    for (int slotCol = 1; slotCol <= 5; slotCol++)
                    {
                        try
                        {
                            sfname = subfacilitiesListNames[slotRow - 1].ToString();
                            sfid = ctx.SubFacilities.First(x => x.subfacilityname == sfname && x.facilityid == facId).subfacilityid;
                            facilityTransID = ctx.TransactionDetails.First(x => x.facilityid == facId && x.subfacilityid == sfid && x.timeslotid == slotCol && x.date == dtpBookingDate.Value).transactionid;
                            facilityMemID = ctx.Transactions.Where(x => x.transactionid == facilityTransID && x.status == "Confirmed").FirstOrDefault().memberid;
                            facilityMemName = ctx.Members.Where(x => x.memberid == facilityMemID).FirstOrDefault().name;
                        }
                        catch
                        {
                        }
                        if (facilityMemName != null)
                        {
                            arrayDaySlots[slotRow - 1, slotCol - 1] = 1;
                            arrayDaySlotsName[slotRow - 1, slotCol - 1] = facilityMemName; //get member details via Transaction table
                            facilityMemName = null;
                        }
                        else
                        {
                            arrayDaySlots[slotRow - 1, slotCol - 1] = 0;
                            arrayDaySlotsName[slotRow - 1, slotCol - 1] = facilityMemName;
                        }
                    }
                }
                //popoulate visible buttons + handle the click events
                for (int slotsLabels = 1; slotsLabels <= 5; slotsLabels++)
                {
                    Controls["lblTime" + slotsLabels].Visible = true;
                }
                //loop to populate buttons for display
                for (int noRows = 1; noRows <= 3; noRows++)
                {
                    if (noRows <= noSubFacilities) 
                    {
                        Controls["lblRow" + noRows].Text = subfacilitiesListNames[noRows - 1];
                        Controls["lblRow" + noRows].Visible = true;
                    }
                    else
                    {
                        Controls["lblRow" + noRows].Visible = false;
                    }
                    for (int noCols = 1; noCols <= 5; noCols++)
                    {
                        switch (noRows)
                        {
                            case 1:
                                Control A = this.Controls["btnA" + noCols];
                                A.Enabled = true;
                                A.Visible = true;
                                collectionVisibleButtons.Add(A);

                                if (arrayDaySlots[noRows - 1, noCols - 1] == 1)
                                {
                                    //this slot is already booked
                                    A.Text = arrayDaySlotsName[noRows - 1, noCols - 1];
                                    A.BackColor = Color.Red;
                                }
                                else
                                {
                                    A.BackColor = Color.LightGreen;
                                    A.Text = "";
                                }
                                break;
                            case 2: 
                                Control B = this.Controls["btnB" + noCols];
                                if (noSubFacilities > 1)
                                {
                                    B.Enabled = true;
                                    B.Visible = true;
                                    if (arrayDaySlots[noRows - 1, noCols - 1] == 1)
                                    {
                                        //this slot is already booked
                                        B.Text = arrayDaySlotsName[noRows - 1, noCols - 1];
                                        B.BackColor = Color.Red;
                                        collectionVisibleButtons.Add(B);
                                    }
                                    else
                                    {
                                        B.BackColor = Color.LightGreen;
                                        B.Text = "";
                                        collectionVisibleButtons.Add(B);
                                    }
                                }
                                else
                                {
                                    B.Enabled = false;
                                    B.Visible = false;
                                    B.BackColor = Color.LightGreen;
                                }
                                break;
                            case 3: 
                                Control C = this.Controls["btnC" + noCols];
                                if (noSubFacilities > 2)
                                {
                                    C.Enabled = true;
                                    C.Visible = true;
                                    if (arrayDaySlots[noRows - 1, noCols - 1] == 1)
                                    {
                                        //this slot is already booked
                                        C.Text = arrayDaySlotsName[noRows - 1, noCols - 1];
                                        C.BackColor = Color.Red;
                                        collectionVisibleButtons.Add(C);
                                    }
                                    else
                                    {
                                        C.BackColor = Color.LightGreen;
                                        C.Text = "";
                                        collectionVisibleButtons.Add(C);
                                    }
                                }
                                else
                                {
                                    C.Enabled = false;
                                    C.Visible = false;
                                    C.BackColor = Color.LightGreen;
                                }
                                break;
                        }
                    }

                }
                //for each button in visible buttons, add click event handler
                foreach (Control con in collectionVisibleButtons)
                {
                    con.Click += new System.EventHandler(this.con_Click);
                }
            }
            else
            {
                //when default option in cmbSports, hide all buttons and slot/SF labels
                for (int slotsLabels = 1; slotsLabels <= 5; slotsLabels++)
                {
                    Controls["lblTime" + slotsLabels].Visible = false;
                }
                for (int noRows = 1; noRows <= 3; noRows++)
                {
                    Controls["lblRow" + noRows].Visible = false; 

                    for (int noCols = 1; noCols <= 5; noCols++)
                    {
                        switch (noRows)
                        {
                            case 1:
                                Control A = this.Controls["btnA" + noCols];
                                A.Enabled = false;
                                A.Visible = false;
                                break;
                            case 2:
                                Control B = this.Controls["btnB" + noCols];
                                B.Enabled = false;
                                B.Visible = false;
                                break;
                            case 3:
                                Control C = this.Controls["btnC" + noCols];
                                C.Enabled = false;
                                C.Visible = false;
                                break;
                        }
                    }
                }

            }
        }
        #endregion

    }
}
