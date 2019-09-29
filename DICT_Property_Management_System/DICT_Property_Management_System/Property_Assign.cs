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
                string[] tempemparr = new string[4];
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
            pbEmp.Image = null;
        }
    }
}
