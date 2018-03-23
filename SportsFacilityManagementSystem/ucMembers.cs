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
    public partial class ucMembers : UserControl
    {
        Member resultmember;
        SportsFacilitiesEntities ctx;
        public ucMembers()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmbSearchBy.SelectedItem is null || txtKeyword.Text == "")
            {
                if(cmbSearchBy.SelectedItem is null)
                {
                    lblWarningSearchBy.Visible = true;
                }
                if(txtKeyword.Text == "")
                {
                    lblWarningKeyword.Visible = true;
                }
            }
            else
            {
                lblWarningSearchBy.Visible = false;
                lblWarningKeyword.Visible = false;
                int count = 0;
                resultmember = new Member();
                switch(cmbSearchBy.SelectedItem.ToString())
                {
                    case "Name":
                        count = ctx.Members.Where(x => x.name == txtKeyword.Text).Count();
                        if(CheckSearchResult(count))
                        {
                            gbSearchResults.Visible = true;
                            lblWarningSearchResult.Visible = false;
                            resultmember = ctx.Members.First(x => x.name == txtKeyword.Text);
                            PopulateData(resultmember);
                        }
                        else
                        {
                            gbSearchResults.Visible = false;
                            lblWarningSearchResult.Visible = true;
                        }
                        break;
                    case "IC Number":
                        count = ctx.Members.Where(x => x.icno == txtKeyword.Text).Count();
                        if (CheckSearchResult(count))
                        {
                            gbSearchResults.Visible = true;

                            lblWarningSearchResult.Visible = false;
                            resultmember = ctx.Members.First(x => x.icno == txtKeyword.Text);
                            PopulateData(resultmember);
                        }
                        else
                        {
                            gbSearchResults.Visible = false;
                            lblWarningSearchResult.Visible = true;
                        }
                        break;
                    case "Mobile Number":
                        try
                        {
                            int keyword = Convert.ToInt32(txtKeyword.Text);
                            count = ctx.Members.Where(x => x.mobileno == keyword).Count();
                            if (CheckSearchResult(count))
                            {
                                gbSearchResults.Visible = true;

                                lblWarningSearchResult.Visible = false;
                                resultmember = ctx.Members.First(x => x.mobileno == keyword);
                                PopulateData(resultmember);
                            }
                            else
                            {
                                gbSearchResults.Visible = false;
                                lblWarningSearchResult.Visible = true;
                            }
                        }
                        catch
                        {
                            gbSearchResults.Visible = false;
                            lblWarningSearchResult.Visible = true;
                        }
                        break;
                    case "Email":
                        count = ctx.Members.Where(x => x.email == txtKeyword.Text).Count();
                        if (CheckSearchResult(count))
                        {
                            gbSearchResults.Visible = true;

                            lblWarningSearchResult.Visible = false;
                            resultmember = ctx.Members.First(x => x.email == txtKeyword.Text);
                            PopulateData(resultmember);
                        }
                        else
                        {
                            gbSearchResults.Visible = false;
                            lblWarningSearchResult.Visible = true;
                        }
                        break;
                }
            }
        }

        private void PopulateData(Member m)
        {
            txtName.Text = m.name;
            txtICNo.Text = m.icno;
            txtMobile.Text = m.mobileno.ToString();
            if(m.gender == "Male")
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
            txtEmail.Text = m.email;
            txtAddress.Text = m.address;
            if(m.status == "Active")
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.SelectedIndex = 1;
            }
            dtpDOB.Value = Convert.ToDateTime(m.dateofbirth);
            dtpJoin.Value = Convert.ToDateTime(m.joindate);
            dtpExpiry.Value = Convert.ToDateTime(m.expirydate);
        }

        private bool CheckSearchResult(int count)
        {
            if(count > 0)
            {
                return true;
            }
            return false;
        }

        private void ucMembers_Load(object sender, EventArgs e)
        {
            ctx = new SportsFacilitiesEntities();
            dtpDOB.MaxDate = DateTime.Today.AddYears(-13); // the member must be at least 13 years old.
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateData(resultmember);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtICNo.Text == "" || txtAddress.Text == "" || txtMobile.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("All fields are required to be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    UpdateMember();
                    PopulateData(resultmember);
                    MessageBox.Show("Update Member Information Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Some errors occurred. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void UpdateMember()
        {
            resultmember.name = txtName.Text;
            resultmember.icno = txtICNo.Text;
            resultmember.address = txtAddress.Text;
            resultmember.mobileno = Convert.ToInt32(txtMobile.Text);
            if (rdbFemale.Checked == true)
            {
                resultmember.gender = "Female";
            }
            else
            {
                resultmember.gender = "Male";
            }
            resultmember.email = txtEmail.Text;
            resultmember.dateofbirth = dtpDOB.Value;
            resultmember.joindate = dtpJoin.Value;
            resultmember.expirydate = dtpExpiry.Value;
            if (cmbStatus.SelectedItem.ToString() == "Active")
            {
                resultmember.status = "Active";
            }
            else
            {
                resultmember.status = "Inactive";
            }
            ctx.SaveChanges();
        }
    }
}
