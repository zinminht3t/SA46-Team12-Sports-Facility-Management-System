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
    public partial class FrmSubMembers : Form
    {
        public static int memberid;
        public FrmSubMembers()
        {
            InitializeComponent();
        }
        private void FrmSubMembers_Load(object sender, EventArgs e)
        {
            SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
            dgvMembers.DataSource = ctx.Members.Where(x => x.status == "Active").ToList();
        }
        private void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            memberid = Convert.ToInt32(dgvMembers.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
