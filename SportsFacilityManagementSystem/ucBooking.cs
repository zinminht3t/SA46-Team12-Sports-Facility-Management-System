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
        private SportsFacilitiesEntities ctx;
        private List<String> subfacilitiesListNames = new List<String>();
        private List<int> subfacilitiesListIds = new List<int>();
        private List<int> ifBookedSubfacility = new List<int>();
        private int[,] arrayDaySlots = new int[3, 5];
        private string[,] arrayDaySlotsName = new string[3, 5];
        private string defaultCmbSports;
        private int noSubFacilities;
        private List<Control> collectionVisibleButtons = new List<Control>();
        private int noSelected;
        private List<Control> collectionClickedButtons = new List<Control>();
        private static List<BookingDetails> bkgDetailsList = new List<BookingDetails>();
        private int facId;
        private int? facilityTransID;
        private int? facilityMemID;
        private string facilityMemName;
        private static DateTime dtpBookingDatevalue;
        public static int redButtonTransID;
        public ucBooking()
        {
            InitializeComponent();

        }
        //This event is triggered when a visible Button is clicked.
        protected void con_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);

            if (dynamicButton.BackColor == Color.Green) //already clicked before
            {
                dynamicButton.BackColor = Color.LightGreen;
                collectionClickedButtons.Remove(dynamicButton);
                noSelected--; //unselected
            }
            else if (dynamicButton.BackColor == Color.Red)
            {
                this.getFacilityID(); //facility id
                char redButtonSubfacility = char.Parse(dynamicButton.Name.Substring(3, 1));
                //int redButtonSubfacility_ = 0; //subfacility id
                string subfname = redButtonSubfacility.ToString();
                int fid = this.getFacilityID();

                int redButtonSubfacility_ = ctx.SubFacilities.First(x => x.subfacilityname == subfname && x.facilityid == fid).subfacilityid;
                //switch (redButtonSubfacility)
                //{
                //    case 'A':
                //        redButtonSubfacility_ = 1
                //        break;

                //    case 'B':
                //        redButtonSubfacility_ = 2;
                //        break;

                //    case 'C':
                //        redButtonSubfacility_ = 3;
                //        break;

                //}

                int redButtonTimeslotID = Int32.Parse(dynamicButton.Name.Substring(4, 1)); //slot id
                redButtonTransID = ctx.TransactionDetails.First(x => x.facilityid == fid && x.subfacilityid == redButtonSubfacility_ && x.date == dtpBookingDate.Value && x.timeslotid == redButtonTimeslotID).transactiondetailid; // this is the transaction detail id

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

            if (noSelected > 0)
            {
                btnBook.Enabled = true;
            }
            else
            {
                btnBook.Enabled = false;
            }

        }
        public static List<BookingDetails> getSelectedSlots()
        {
            return bkgDetailsList;
        }
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
                // ucBookingDetails ucbd = new ucBookingDetails();
                //ucbd.Show();
                //ucbd.setTxtFacilityID(cmbSports.Text);
                //ucbd.SetLbSelectedSlotSF(bkgDetailsList);
            }

        }

        private void ucBooking_Load(object sender, EventArgs e)
        {

        }

        private void cmbSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            collectionClickedButtons.Clear();
            LoadBookingSlots();
        }

        private void LoadBookingSlots()
        {
            //bkgDetailsList.Clear();
            noSelected = 0;
            //need to clear button collections                     con.Click += new System.EventHandler(this.con_Click);
            foreach (Control c in collectionVisibleButtons)
            {
                c.Click -= new System.EventHandler(this.con_Click);
            }

            collectionVisibleButtons.Clear(); //pls check collection of items stored per click change
            subfacilitiesListNames.Clear();
            ifBookedSubfacility.Clear();

            //get facility id of chosen facility in combobox
            if (cmbSports.Text != "Select Sports")
            {
                this.getFacilityID();
                noSubFacilities = ctx.SubFacilities.Count(x => x.facilityid == facId); //to replace output with no of subfac belonging to selected facility

                //create array of subfacilities name belonging to selceted facility
                var qrySubFacilitiesName = from x in ctx.SubFacilities where x.facilityid == facId orderby x.subfacilityname select x.subfacilityname;
                subfacilitiesListNames = qrySubFacilitiesName.ToList<String>();

                string sfname;
                int sfid;
                //populate arrays for UI booking slots of selected date
                for (int slotRow = 1; slotRow <= 3; slotRow++)
                {
                    for (int slotCol = 1; slotCol <= 5; slotCol++)
                    {
                        try
                        {
                            //foreach(char name in subfacilitiesListNames[slotRow])
                            //{
                            //    MessageBox.Show(name.ToString());
                            //}
                            sfname = subfacilitiesListNames[slotRow - 1].ToString();
                            sfid = ctx.SubFacilities.First(x => x.subfacilityname == sfname && x.facilityid == facId).subfacilityid;
                            facilityTransID = ctx.TransactionDetails.First(x => x.facilityid == facId && x.subfacilityid == sfid && x.timeslotid == slotCol && x.date == dtpBookingDate.Value).transactionid;
                            facilityMemID = ctx.Transactions.Where(x => x.transactionid == facilityTransID && x.status == "Confirmed").FirstOrDefault().memberid;
                            facilityMemName = ctx.Members.Where(x => x.memberid == facilityMemID).FirstOrDefault().name;
                        }
                        catch (Exception)
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

                //for each relevant buttons, make buttons visisble + create collections of button click events + populate text with data
                for (int noRows = 1; noRows <= 3; noRows++)
                {
                    if (noRows <= noSubFacilities) //subfacility labels visibility
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
                                    //A.Enabled = false;
                                }
                                else
                                {
                                    A.BackColor = Color.LightGreen;
                                    A.Text = "";
                                }


                                break;
                            case 2: //might need to hide if selected facility only has 1 subfacility

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
                            case 3: //might need to hide if selected facility only has 1 subfacility

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
                //if default option, show 0 row of subfacility slots
                //for each relevant buttons, make buttons visisble + create collections of button click events + populate text with data

                for (int slotsLabels = 1; slotsLabels <= 5; slotsLabels++)
                {
                    Controls["lblTime" + slotsLabels].Visible = false;
                }

                //Q: do i need to reset the collection of vis buttons?
                for (int noRows = 1; noRows <= 3; noRows++)
                {
                    Controls["lblRow" + noRows].Visible = false; //subtntity labels

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

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            dtpBookingDatevalue = dtpBookingDate.Value;
            LoadBookingSlots();
        }

        private void ucBooking_Load_1(object sender, EventArgs e)
        {
            ctx = new SportsFacilitiesEntities();

 

            cmbSports.DataSource = frmLogin.bookingSportsList;
            //cmbSports.DisplayMember = "facilityname";
            //cmbSports.ValueMember = "facilityname";
            dtpBookingDate.Value = DateTime.Today;
            dtpBookingDatevalue = dtpBookingDate.Value;

            cmbSports.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
