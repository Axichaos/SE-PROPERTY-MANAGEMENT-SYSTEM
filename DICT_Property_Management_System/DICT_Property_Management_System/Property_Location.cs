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
    public partial class Property_Location : Form
    {
        P_Location con = new P_Location();
        string tempid;
        public Property_Location()
        {
            InitializeComponent();
            tblshow();
        }
        public void tblshow()
        {
            con.locshow(tblLocation);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLO_Add wind = new frmLO_Add(this);
            wind.ShowDialog();
        }

        private void tblLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblLocation.SelectedItems.Count > 0)
            {
                tempid = tblLocation.SelectedItems[0].SubItems[0].Text;
                if(tempid == "1")
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (entrycheck())
            {
                frmLO_Edit wind = new frmLO_Edit(this, tempid);
                wind.ShowDialog();
            }          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (entrycheck())
            {
                if (con.loclistinvtoloc(tempid))
                {
                    MessageBox.Show("You cannot delete this location as it contains related record to properties!", "Property Record Detected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.locdelete(tempid);
                    tblshow();
                }                
            }          
        }

        private bool entrycheck ()
        {
            if(tblLocation.SelectedItems.Count > 0 )
            {
                return true;
            }
            else
            {
                MessageBox.Show("No Location Entry Selected!", "Location Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnVLE_Click(object sender, EventArgs e)
        {
            frmLO_VLE wind = new frmLO_VLE();
            wind.ShowDialog();
        }
    }
}
