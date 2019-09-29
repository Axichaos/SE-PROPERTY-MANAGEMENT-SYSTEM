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
    public partial class frmLO_VLE : Form
    {
        string locid1;
        P_Location con = new P_Location();
        public frmLO_VLE()
        {
            InitializeComponent();
            cboList.SelectedIndex = 0;
            con.loclist(tblList);
        }

        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboList.Text == "Locations")
            {
                con.loclist(tblList);
            }
            else
            {
                tblList.Items.Clear();
                ListViewItem prov = new ListViewItem("Basilan");
                tblList.Items.Add(prov);
                ListViewItem prov1 = new ListViewItem("Sulu");
                tblList.Items.Add(prov1);
                ListViewItem prov2 = new ListViewItem("Tawi-Tawi");
                tblList.Items.Add(prov2);
                ListViewItem prov3 = new ListViewItem("Zamboanga del Norte");
                tblList.Items.Add(prov3);
                ListViewItem prov4 = new ListViewItem("Zamboanga del Sur");
                tblList.Items.Add(prov4);
                ListViewItem prov5 = new ListViewItem("Zamboanga Sibugay");
                tblList.Items.Add(prov5);
            }
        }

        private void tblList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblList.SelectedItems.Count > 0)
            {
                if (cboList.Text == "Locations")
                {
                    locid1 = tblList.SelectedItems[0].SubItems[1].Text;
                    con.loclistinvtoloc(tblInvLink, locid1);
                }
                else if (cboList.Text == "Provinces")
                {
                    string pr = tblList.SelectedItems[0].SubItems[0].Text;
                    con.loclistinvtoprov(tblInvLink, pr);
                }                
            }
            else
            {
                tblInvLink.Items.Clear();
            }
        }
    }
}
