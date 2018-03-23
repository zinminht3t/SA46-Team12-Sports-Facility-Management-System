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
                gbSearchResults.Visible = true;
                SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
                int count = 0;
                Member resultmember = new Member();
                switch(cmbSearchBy.SelectedItem.ToString())
                {
                    case "Name":
                        count = ctx.Members.Where(x => x.name == txtKeyword.Text).Count();
                        if(CheckSearchResult(count))
                        {
                            lblWarningSearchResult.Visible = false;
                            resultmember = ctx.Members.First(x => x.name == txtKeyword.Text);
                            PopulateData(resultmember);
                        }
                        else
                        {
                            lblWarningSearchResult.Visible = true;
                        }
                        break;
                    case "IC Number":
                        break;
                    case "Address":
                        break;
                    case "Mobile Number":
                        break;
                    case "Email":
                        break;
                }
            }
        }

        private void PopulateData(Member m)
        {

        }

        private bool CheckSearchResult(int count)
        {
            if(count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
