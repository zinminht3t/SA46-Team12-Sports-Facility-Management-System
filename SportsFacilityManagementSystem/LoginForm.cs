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
    public partial class LoginForm : Form
    {
        SportsFacilitiesEntities ctx;
        public static User user;
        public LoginForm()
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
                int userid = Convert.ToInt32(txtUserID.Text);
                string password = txtPassword.Text;
                int result = 0;
                result = ctx.Users.Where(x => x.userid == userid && x.password == password).Count();
                if (result > 0)
                {
                    user = ctx.Users.Where(x => x.userid == userid && x.password == password).First();
                    frmMain main = new frmMain();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your User ID or Password is wrong!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ctx = new SportsFacilitiesEntities();
        }
    }
}
