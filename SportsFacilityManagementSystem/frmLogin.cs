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
    public partial class frmLogin : Form
    {
        SportsFacilitiesEntities ctx;
        public static User user;
        public static List<Facility> facilitylist;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter the User ID and Password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int userid = Convert.ToInt32(txtUserID.Text);
                    string password = txtPassword.Text;
                    int result = 0;
                    result = ctx.Users.Where(x => x.userid == userid && x.password == password).Count();

                    if (result > 0) //if the user login success
                    {
                        user = ctx.Users.Where(x => x.userid == userid && x.password == password).First();
                        ChangeExpiredMemberStatus(); //check the expired members and update their status to "Inactive"
                        this.Hide();

                        frmMain main = new frmMain(); //call the main form
                        main.Show();
                        facilitylist = ctx.Facilities.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Your User ID or Password is wrong!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("User ID is number only!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ctx = new SportsFacilitiesEntities();

        }

        private void ChangeExpiredMemberStatus()
        {
            List<Member> lstmember = new List<Member>();
            lstmember = ctx.Members.Where(x => x.expirydate < DateTime.Today).ToList();
            foreach (var member in lstmember)
            {
                ctx.Members.First(x => x.memberid == member.memberid).status = "Inactive";
            }
            ctx.SaveChanges();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
