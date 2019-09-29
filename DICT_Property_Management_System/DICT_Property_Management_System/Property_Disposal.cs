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
    public partial class Property_Disposal : Form
    {
        string dispid;
        string invid;
        P_EqpCard con2 = new P_EqpCard();
        P_Inventory con1 = new P_Inventory();
        P_Disposal con = new P_Disposal();
        public Property_Disposal()
        {
            InitializeComponent();
            tblshow();
        }
        public void tblshow()
        {
            con.disptblshow(tblDisposal);
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tblDisposal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblDisposal.SelectedItems.Count > 0)
            {
                dispid = tblDisposal.SelectedItems[0].SubItems[0].Text;
                invid = tblDisposal.SelectedItems[0].SubItems[1].Text;
                con.displblshow(dispid, lblDDate, lblMeth, txtRem);
            }
            else
            {
                lblreset();
            }
        }

        private void tblDisposal_DoubleClick(object sender, EventArgs e)
        {
            PropertyDetails newwind = new PropertyDetails(invid);
            newwind.Show();
        }

        private void btnDEdit_Click(object sender, EventArgs e)
        {
            if (tblDisposal.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmD_Edit newwind = new frmD_Edit(dispid,this);
                newwind.Show();
            }
        }

        public void lblreset()
        {
            lblDDate.Text = ("?");
            lblMeth.Text = ("?");
            txtRem.Text = "";
        }

        private void btnDTransfer_Click(object sender, EventArgs e)
        {
            if (tblDisposal.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you want to transfer this property back to the inventory?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con1.ditoin(invid);
                    con.dispdelete(dispid);
                    tblshow();
                    lblreset();
                    con2.logdispodel(invid);
                    string tempid = con2.logtblshow(invid);
                    con2.logsetcurr(tempid);
                }             
            }
        }
    }
}
