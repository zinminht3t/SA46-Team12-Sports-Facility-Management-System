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
                SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
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
            txtGender.Text = m.gender;
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
            dtpDOB.MaxDate = DateTime.Today.AddYears(-13); // the member must be at least 13 years old.
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateData(resultmember);
        }
    }
}
