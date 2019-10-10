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
    public partial class frmPI_Update : Form
    {
        P_EqpCard con2 = new P_EqpCard();
        Property_Inventory close;
        String ctemp;
        P_Inventory con = new P_Inventory();
        inputValidation inpc = new inputValidation();
        string[] fieldarr = new string[18];
        string rid;
        string comp3;
        public frmPI_Update(string id,Property_Inventory temp)
        {
            InitializeComponent();
            close = temp;
            label1.Text = id;
            con.invshowd(id, fieldarr);
            txtName.Text = fieldarr[1];
            cboUnit.Text = fieldarr[2];
            cboType.Text = fieldarr[3];
            txtRemarks.Text = fieldarr[4];
            txtArticle.Text = fieldarr[5];
            txtCost.Text = fieldarr[6];
            comp3 = fieldarr[6];
            txtDesc.Text = fieldarr[7];
            txtSerial.Text = fieldarr[9];
            cboAcc.Text = fieldarr[11];
            cboSign.Text = fieldarr[14];
            cboRT.Text = fieldarr[15];
            cboIss.Text = fieldarr[16];
            if (String.Equals(cboIss.Text, "No"))
            {
                cboSign.Text = "No";
                cboSign.Enabled = false;
            }
            else
            {
                cboSign.Text = fieldarr[1];
            }           
            dtpRDate.Text = fieldarr[17];
            rid = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (inpc.EmptyCheck(groupBox1.Controls))
            {
                con.invupdate(rid, txtName.Text, cboUnit.Text, cboType.Text, txtRemarks.Text, txtArticle.Text, txtCost.Text, txtDesc.Text, txtSerial.Text, cboAcc.Text, cboSign.Text, cboRT.Text, cboIss.Text, dtpRDate.Text);
                //Cost Change Check
                if (!String.Equals(comp3,txtCost.Text))
                {
                    con2.logbalchange(rid, txtCost.Text);
                    MessageBox.Show("Cost adjusted to Equipment Card", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }              
                close.tblshow();
                this.Close();
            }           
        }

        private void cboIss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Equals(cboIss.Text, "No"))
            {
                cboSign.Text = "No";
                cboSign.Enabled = false;
            }
            else
            {
                cboSign.Enabled = true;
            }
        }


        private void txtCost_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCost.Text))
            {
                if (!inpc.FCheck(txtCost.Text))
                {
                    txtCost.Text = ctemp;
                }
            }
        }

        private void txtCost_Click(object sender, EventArgs e)
        {
            ctemp = txtCost.Text;
        }
    }
}
