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
        private int noSubFacilities;
        private List<Control> collectionVisibleButtons = new List<Control>();
        private int noSelected = 0;
        private List<Control> collectionClickedButtons = new List<Control>();

        public ucBooking()
        {
            InitializeComponent();

            dtpBookingDate.MinDate = Convert.ToDateTime(DateTime.Now);
            noSubFacilities = 3; //to replace output with no of subfac belonging to selected facility


            //for each relevant buttons, make buttons visisble + create collections of button click events + populate text with data
            for (int noRows = 1; noRows <= noSubFacilities; noRows++)
            {
                Controls["lblRow" + noRows].Visible = true;

                for (int noCols = 1; noCols <= 5; noCols++)
                {
                    switch (noRows)
                    {
                        case 1:
                            Control A = this.Controls["btnA" + noCols];
                            A.Text = noCols.ToString(); //to repplace output as booking name
                            collectionVisibleButtons.Add(A);

                            break;
                        case 2:
                            Control B = this.Controls["btnB" + noCols];
                            B.Enabled = true;
                            B.Visible = true;
                            B.Text = noCols.ToString(); //to repplace output as booking name
                            collectionVisibleButtons.Add(B);

                            break;
                        case 3:
                            Control C = this.Controls["btnC" + noCols];
                            C.Enabled = true;
                            C.Visible = true;
                            C.Text = noCols.ToString(); //to repplace output as booking name
                            collectionVisibleButtons.Add(C);

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
    }
}
