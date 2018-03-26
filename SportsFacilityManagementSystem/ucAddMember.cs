using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SportsFacilityManagementSystem
{
    public partial class ucAddMember : UserControl
    {
        public ucAddMember()
        {
            InitializeComponent();
        }

        private void TabStopChanged(object sender, EventArgs e)
        {
            ((RadioButton)rdbMale).TabStop = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // need to add status as active + member expiry (2years?) into database (jayden)
            SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
            if (txtName.Text == "" || txtICNo.Text == "" || txtMobile.Text == "" || txtEmail.Text == "" || txtAddress.Text == "")
            {
                if (txtName.Text == "")
                {
                    lblWarningName.Visible = true;
                }
                else
                {
                    lblWarningName.Visible = false;
                }

                if (txtICNo.Text == "")
                {
                    lblWarningIC.Visible = true;
                }
                else
                {
                    lblWarningIC.Visible = false;
                }

                if (txtMobile.Text == "")
                {
                    lblWarningMobile.Visible = true;
                }
                else
                {
                    lblWarningMobile.Visible = false;
                }

                if (txtEmail.Text == "")
                {
                    lblWarningEmail.Visible = true;
                }
                else
                {
                    lblWarningEmail.Visible = false;
                }
                if (txtAddress.Text == "")
                {
                    lblWarningAddress.Visible = true;
                }
                else
                {
                    lblWarningAddress.Visible = false;
                }
            }
            else
            {
                if(!CheckEmail(txtEmail.Text))
                {
                    lblWarningEmail.Text = "Please enter the valid email address";
                    lblWarningEmail.Visible = true;
                }
                else
                {
                    try
                    {
                        InsertData();
                        ResetAllFields();
                        MessageBox.Show("Add Member Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error Occurred. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void InsertData()
        {
            SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
            Member newmember = new Member();
            newmember.name = txtName.Text;
            newmember.icno = txtICNo.Text;
            if(rdbMale.Checked == true)
            {
                newmember.gender = rdbMale.Text;
            }
            else
            {
                newmember.gender = rdbFemale.Text;
            }
            newmember.address = txtAddress.Text;
            newmember.mobileno = Convert.ToInt32(txtMobile.Text);
            newmember.email = txtEmail.Text;
            newmember.dateofbirth = dtpDOB.Value;
            newmember.joindate = dtpJoindate.Value;
            newmember.expirydate = dtpJoindate.Value.AddYears(2);
            newmember.status = "Active";
            ctx.Members.Add(newmember);
            ctx.SaveChanges();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtMobile.Text, "[^0-9]"))
            {
                lblWarningMobile.Text = "Please enter only numbers.";
                lblWarningMobile.Visible = true;
                //txtMobile.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                lblWarningMobile.Text = "";
            }
        }

        public bool CheckEmail(string email)
        {
            string pattern;
            pattern = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, pattern))
            {
                if (Regex.Replace(email, pattern, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllFields();
        }

        private void ResetAllFields()
        {
            lblWarningName.Visible = false;
            lblWarningIC.Visible = false;
            lblWarningAddress.Visible = false;
            lblWarningGender.Visible = false;
            lblWarningMobile.Text = "Field cannot be blank";
            lblWarningMobile.Visible = false;
            lblWarningEmail.Text = "Field cannot be blank";
            lblWarningEmail.Visible = false;

            txtName.Text = "";
            txtICNo.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void ucAddMember_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today.AddYears(-13); // the member must be at least 13 years old.
            rdbMale.Checked = true;
        }
    }
}
