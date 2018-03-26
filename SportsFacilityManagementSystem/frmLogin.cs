using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
                    password = EncryptPassword(password); //all passwords for the users are 1234
                    int result = 0;
                    result = ctx.Users.Where(x => x.userid == userid && x.password == password).Count();
                    if (result > 0) //if the user login success
                    {
                        user = ctx.Users.Where(x => x.userid == userid && x.password == password).First();
                        ChangeMemberStatus(); //check the expired members and update their status to "Inactive"
                        this.Hide();
                        facilitylist = ctx.Facilities.ToList();
                        frmMain main = new frmMain(); //call the main form
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your User ID or Password is wrong!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("User ID is Employee ID!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            ctx = new SportsFacilitiesEntities();
        }
        public void ChangeMemberStatus()
        {
            SportsFacilitiesEntities cxt = new SportsFacilitiesEntities();
            List<Member> lstmember = new List<Member>();
            lstmember = cxt.Members.Where(x => x.expirydate < DateTime.Today).ToList();
            int c = lstmember.Count;
            foreach (var member in lstmember)
            {
                cxt.Members.First(x => x.memberid == member.memberid).status = "Inactive";
            }
            cxt.SaveChanges();
            List<Member> inlstmember = new List<Member>();
            inlstmember = cxt.Members.Where(x => x.expirydate > DateTime.Today).ToList();
            int count = inlstmember.Count;
            foreach (var member in inlstmember)
            {
                cxt.Members.First(x => x.memberid == member.memberid).status = "Active";
            }

            cxt.SaveChanges();
        }
        public static string EncryptPassword(string password)
        {
            string key = "EvelynJaydenSandyZin";
            byte[] cbyptes = Encoding.Unicode.GetBytes(password);
            using (Aes aesencrypt = Aes.Create())
            {
                Rfc2898DeriveBytes kbyptes = new Rfc2898DeriveBytes(key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aesencrypt.Key = kbyptes.GetBytes(32);
                aesencrypt.IV = kbyptes.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aesencrypt.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cbyptes, 0, cbyptes.Length);
                        cs.Close();
                    }
                    password = Convert.ToBase64String(ms.ToArray());
                }
            }
            return password;
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
