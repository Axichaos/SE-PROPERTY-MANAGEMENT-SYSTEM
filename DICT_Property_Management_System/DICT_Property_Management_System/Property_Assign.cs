using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICT_Property_Management_System
{
    public partial class Property_Assign : Form
    {
        P_Assign con = new P_Assign();
        P_Location con2 = new P_Location();
        P_Employee con3 = new P_Employee();
        public Property_Assign()
        {
            InitializeComponent();
            tblshow();
        }
        public void tblshow()
        {
            con.asishow(tblAsiProp);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tblAsiProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblAsiProp.SelectedItems.Count > 0)
            {
                string temploc = tblAsiProp.SelectedItems[0].SubItems[4].Text;
                string[] templocarr = new string[3];
                con2.loceditinfo(temploc, templocarr);
                lblLoc.Text = templocarr[0];
                lblProv.Text = templocarr[1];
                lblRoom.Text = templocarr[2];
                string tempemp = tblAsiProp.SelectedItems[0].SubItems[5].Text;
                string[] tempemparr = new string[6];
                con3.empselected(tempemp, tempemparr);
                lblEmpName.Text = tempemparr[0];
                lblEmpCont.Text = tempemparr[1];
                lblEmailAdd.Text = tempemparr[2];
                if (tempemparr[3] != "N/U")
                {
                    pbEmp.Image = new Bitmap(tempemparr[3]);
                }
                else
                {
                    pbEmp.Image = null;
                }
                lblJobT.Text = tempemparr[4];
                lblDept.Text = tempemparr[5];
            }
        }

        public void resetgb()
        {
            lblEmailAdd.Text = "?";
            lblEmpCont.Text = "?";
            lblEmpName.Text = "?";
            lblLoc.Text = "?";
            lblProv.Text = "?";
            lblRoom.Text = "?";
            lblJobT.Text = "?";
            lblDept.Text = "?";
            pbEmp.Image = null;
            foreach (ListViewItem check in tblAsiProp.CheckedItems)
            {
                check.Checked = false;
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (tblAsiProp.CheckedItems.Count > 0)
            {
                ListViewItem[] tempcol = new ListViewItem[tblAsiProp.CheckedItems.Count];
                int counter = 0;
                foreach (ListViewItem selprop in tblAsiProp.CheckedItems)
                {
                    tempcol[counter] = selprop;
                    counter++;
                }
                frmAS_Assign wind = new frmAS_Assign(tempcol, this);
                wind.ShowDialog();
            }
            else
            {
                MessageBox.Show("No properties selected! Please check the properties that you want to assign!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
