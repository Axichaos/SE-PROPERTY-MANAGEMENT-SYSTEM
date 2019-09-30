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
    public partial class frmAS_Assign : Form
    {
        P_Location con2 = new P_Location();
        P_Employee con3 = new P_Employee();
        Property_Assign close;
        public frmAS_Assign(ListViewItem[] tarr,Property_Assign tempfrm)
        {
            InitializeComponent();
            con2.loclblins(cboLoc);
            con3.empshow(cbEmpID);
            cbEmpID.SelectedIndex = 0;
            cboLoc.SelectedIndex = 0;
            close = tempfrm;
            foreach (ListViewItem tbli in tarr)
            {
                ListViewItem tempitem = new ListViewItem(tbli.SubItems[1].Text);
                tempitem.SubItems.Add(tbli.SubItems[2]);
                tempitem.SubItems.Add(tbli.SubItems[3]);
                tempitem.SubItems.Add(tbli.SubItems[3]);
                tempitem.SubItems.Add(tbli.SubItems[4]);
                tblSelProp.Items.Add(tempitem);
            }
        }

        private void cbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempemp = cbEmpID.Text.Substring(0,1);
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

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temploc = cboLoc.Text.Substring(0,1);
            string[] templocarr = new string[3];
            con2.loceditinfo(temploc, templocarr);
            lblLoc.Text = templocarr[0];
            lblProv.Text = templocarr[1];
            lblRoom.Text = templocarr[2];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            close.tblshow();
            close.resetgb();
            Close();
        }
    }
}
