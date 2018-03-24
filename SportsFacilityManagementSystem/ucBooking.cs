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
        private int[,] arrayDaySlots = new int[3,5];
        private string[,] arrayDaySlotsName = new string[3, 5];
        private string defaultCmbSports;
        private int noSubFacilities;
        private List<Control> collectionVisibleButtons = new List<Control>();
        private int noSelected;
        private List<Control> collectionClickedButtons = new List<Control>();
        private List<BookingDetails> bkgDetailsList = new List<BookingDetails>();


        private int? facilityTransID;
        private int? facilityMemID;
        private string facilityMemName;
        private DateTime dtpBookingDatevalue;


        public ucBooking()
        {
            InitializeComponent();

            ctx = new SportsFacilitiesEntities();
            //List<String> facList = ctx.Facilities.OrderBy(x => x.facilityname).Select(y => y.facilityname).ToList();
            defaultCmbSports = "- Select sport -";
            //facList.Insert(0, defaultCmbSports);
            //cmbSports.DataSource = facList;

            //dtpBookingDate.MinDate = Convert.ToDateTime(DateTime.Now);

            cmbSports.Text = defaultCmbSports;

            dtpBookingDate.CustomFormat = "yyyy-MM-dd";
            dtpBookingDatevalue = dtpBookingDate.Value;

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

        private void btnBook_Click(object sender, EventArgs e)
        {

            MessageBox.Show(noSelected.ToString());
            if (noSelected == 0)
            {
                MessageBox.Show("You have not selected any booking slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int controlIndex = 0;
                foreach(Control c in collectionClickedButtons)
                {

                    
                    new BookingDetails() { subFacilityBooked = subfacilitiesListNames[controlIndex], slotBooked = Int32.Parse(collectionClickedButtons[controlIndex].Name.Substring(4,1)) };
                    


                }
                ucBookingDetails ucbd = new ucBookingDetails();
                ucbd.Show();
                ucbd.setTxtFacilityID(cmbSports.Text);
                ucbd.SetLbSelectedSlotSF(bkgDetailsList);
            }
            
        }

        private void ucBooking_Load(object sender, EventArgs e)
        {

        }

        private void cmbSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            //need to clear button collections                     con.Click += new System.EventHandler(this.con_Click);
            foreach(Control c in collectionVisibleButtons)
            {
                c.Click -= new System.EventHandler(this.con_Click);
            }

            collectionVisibleButtons.Clear(); //pls check collection of items stored per click change
            subfacilitiesListNames.Clear();
            ifBookedSubfacility.Clear();

            //get facility id of chosen facility in combobox
            if (cmbSports.Text != defaultCmbSports)
            {
                var facId = ctx.Facilities.First(x => x.facilityname == cmbSports.Text);
                int facId_ = facId.facilityid;
                noSubFacilities = ctx.SubFacilities.Count(x => x.facilityid == facId_); //to replace output with no of subfac belonging to selected facility
                
                //create array of subfacilities name belonging to selceted facility
                var qrySubFacilitiesName = from x in ctx.SubFacilities where x.facilityid == facId_ orderby x.subfacilityname select x.subfacilityname;
                subfacilitiesListNames = qrySubFacilitiesName.ToList<String>();
                

                //populate arrays for UI booking slots of selected date
                for (int slotRow = 1; slotRow <= 3; slotRow++)
                {
                    for (int slotCol = 1; slotCol <= 3; slotCol++)
                    {
                        try
                        {
                            facilityTransID = ctx.TransactionDetails.Where(x => x.facilityid == facId_ && x.subfacilityid == slotRow && x.timeslotid == slotCol && x.date == dtpBookingDatevalue).FirstOrDefault().transactionid;
                            facilityMemID = ctx.Transactions.Where(x => x.transactionid == facilityTransID).FirstOrDefault().memberid;
                            facilityMemName = ctx.Members.Where(x => x.memberid == facilityMemID).FirstOrDefault().name;
                        } catch(Exception)
                        {
                        }
                        

                        if (facilityTransID!=null)
                        {
                            arrayDaySlots[slotRow-1, slotCol-1] = 1;
                            arrayDaySlotsName[slotRow-1, slotCol-1] = facilityMemName; //get member details via Transaction table
                        }
                        else
                        {
                            arrayDaySlots[slotRow-1, slotCol-1] = 0;
                            arrayDaySlotsName[slotRow-1, slotCol-1] = facilityMemName;
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
                        Controls["lblRow" + noRows].Text = subfacilitiesListNames[noRows-1];
                        Controls["lblRow" + noRows].Visible = true;
                    } else
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

                                if (arrayDaySlots[noRows - 1, noRows - 1] == 1)
                                {
                                    //this slot is already booked
                                    A.Text = arrayDaySlotsName[noRows - 1, noRows - 1];
                                    A.BackColor = Color.Red;
                                }
                                else
                                {
                                    A.BackColor = Color.LightGreen;
                                }
                                

                                break;
                            case 2: //might need to hide if selected facility only has 1 subfacility

                                Control B = this.Controls["btnB" + noCols];

                                if (noSubFacilities > 1)
                                {
                                    B.Enabled = true;
                                    B.Visible = true;
                                    collectionVisibleButtons.Add(B);

                                    if (arrayDaySlots[noRows - 1, noRows - 1] == 1)
                                    {
                                        //this slot is already booked
                                        B.Text = arrayDaySlotsName[noRows - 1, noRows - 1];
                                        B.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        B.BackColor = Color.LightGreen;
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
                                    collectionVisibleButtons.Add(C);

                                    if (arrayDaySlots[noRows - 1, noRows - 1] == 1)
                                    {
                                        //this slot is already booked
                                        C.Text = arrayDaySlotsName[noRows - 1, noRows - 1];
                                        C.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        C.BackColor = Color.LightGreen;
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

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            dtpBookingDatevalue = dtpBookingDate.Value;
        }

        private void ucBooking_Load_1(object sender, EventArgs e)
        {
        }
    }
}
