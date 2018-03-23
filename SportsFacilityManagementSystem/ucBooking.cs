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
        private List<String> subfacilitiesList = new List<String>();
        private string defaultCmbSports;
        private int noSubFacilities;
        private List<Control> collectionVisibleButtons = new List<Control>();
        private int noSelected = 0;
        private List<Control> collectionClickedButtons = new List<Control>();

        public ucBooking()
        {
            InitializeComponent();

            ctx = new SportsFacilitiesEntities();
            List<String> facList = ctx.Facilities.OrderBy(x => x.facilityname).Select(y => y.facilityname).ToList();
            defaultCmbSports = "- Select sport -";
            facList.Insert(0, defaultCmbSports);
            cmbSports.DataSource = facList;

            dtpBookingDate.MinDate = Convert.ToDateTime(DateTime.Now);

            cmbSports.Text = defaultCmbSports;
            
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
            if (noSelected == 0)
            {
                MessageBox.Show("You have not selected any booking slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ucBookingDetails ucbd = new ucBookingDetails();
                ucbd.Show();
                ucbd.setTxtFacilityID(cmbSports.Text);
            }
            
        }

        private void ucBooking_Load(object sender, EventArgs e)
        {

        }

        private void cmbSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            collectionVisibleButtons.Clear(); //pls check collection of items stored per click change
            subfacilitiesList.Clear();

            //get facility id of chosen facility in combobox
            if (cmbSports.Text != defaultCmbSports)
            {
                var facId = ctx.Facilities.First(x => x.facilityname == cmbSports.Text);
                int facId_ = facId.facilityid;
                noSubFacilities = ctx.SubFacilities.Count(x => x.facilityid == facId_); //to replace output with no of subfac belonging to selected facility
                //create array of subenetities name belonging to selceted facility
                var qry = from x in ctx.SubFacilities where x.facilityid == facId_ orderby x.subfacilityname select x.subfacilityname;
                subfacilitiesList = qry.ToList<String>();
                
                //popoulate visible buttons + handle the click events
                for (int slotsLabels = 1; slotsLabels <= 5; slotsLabels++)
                {
                    Controls["lblTime" + slotsLabels].Visible = true;

                }

                //for each relevant buttons, make buttons visisble + create collections of button click events + populate text with data
                for (int noRows = 1; noRows <= 3; noRows++)
                {
                    if (noRows <= noSubFacilities)
                    {
                        Controls["lblRow" + noRows].Text = subfacilitiesList[noRows-1];
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
                                A.Text = noCols.ToString(); //to repplace output as booking name
                                collectionVisibleButtons.Add(A);

                                break;
                            case 2: //might need to hide if selected facility only has 1 subfacility

                                Control B = this.Controls["btnB" + noCols];

                                if (noSubFacilities > 1)
                                {
                                    B.Enabled = true;
                                    B.Visible = true;
                                    B.Text = noCols.ToString(); //to repplace output as booking name
                                    collectionVisibleButtons.Add(B);
                                }
                                else
                                {
                                    B.Enabled = false;
                                    B.Visible = false;
                                    B.Text = noCols.ToString();
                                }

                                break;
                            case 3: //might need to hide if selected facility only has 1 subfacility

                                Control C = this.Controls["btnC" + noCols];

                                if (noSubFacilities > 2)
                                {
                                    C.Enabled = true;
                                    C.Visible = true;
                                    C.Text = noCols.ToString(); //to repplace output as booking name
                                    collectionVisibleButtons.Add(C);
                                }
                                else
                                {
                                    C.Enabled = false;
                                    C.Visible = false;
                                    C.Text = noCols.ToString(); //to repplace output as booking name
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
                //if default option, show only 1 row of subfacility slots
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
    }
}
