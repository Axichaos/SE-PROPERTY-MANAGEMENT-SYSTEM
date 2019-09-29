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
    public partial class frmPI_Transfer : Form
    {
        string piid;
        string dispid = "";
        P_Disposal con1 = new P_Disposal();
        P_Inventory con = new P_Inventory();
        P_EqpCard con2 = new P_EqpCard();
        inputValidation inpc = new inputValidation();
        Property_Inventory close = new Property_Inventory();
        public frmPI_Transfer(string fid,Property_Inventory temp)
        {
            InitializeComponent();
            piid = fid;
            close = temp;
            cboDMeth.SelectedIndex = 0;
        }

        private void cboDMeth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (inpc.EmptyCheck(Controls))
            {
                con1.dispgen(piid, dtpDDate.Text, cboDMeth.Text, txtRem.Text);
                dispid = con1.dispidget(piid);
                con.intodi(piid, dispid);
                if (!con2.logtblshow(piid, 1))
                {
                    con2.logadd(DateTime.Now.ToShortDateString(), con2.loggetprevmr(piid), piid, String.Concat("Property Returned for Disposal at: ", DateTime.Now.ToShortTimeString()), "DRETURN", "0");
                    MessageBox.Show("Disposal Return Entry Created!", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con2.logcurset(piid);
                con2.logadd(DateTime.Now.ToShortDateString(), con2.loggetprevmr(piid), piid, String.Concat("Property Disposed at: ", DateTime.Now.ToShortTimeString()), "DISPOSAL", con.invretmr(piid, 3));
                MessageBox.Show("Disposal Entry Created!", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                close.tblshow();
                this.Close();
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
