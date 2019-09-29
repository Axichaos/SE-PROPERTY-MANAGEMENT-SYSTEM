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
        P_Location con3 = new P_Location();
        P_Employee con4 = new P_Employee();
        inputValidation inpc = new inputValidation();
        string[] fieldarr = new string[18];
        string rid;
        string comp1;
        string comp2;
        string comp3;
        public frmPI_Update(string id,Property_Inventory temp)
        {
            InitializeComponent();
            close = temp;
            con3.loclblins(cboLoc);
            con4.empshow(cbEmpID);
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
            comp2 = fieldarr[8];
            cboLoc.Text = con3.loclblins(fieldarr[8]);            
            txtSerial.Text = fieldarr[9];
            comp1 = fieldarr[10];
            cbEmpID.Text = con4.emplblshow(fieldarr[10]);
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
                con.invupdate(rid, txtName.Text, cboUnit.Text, cboType.Text, txtRemarks.Text, txtArticle.Text, txtCost.Text, txtDesc.Text, cboLoc.Text.Substring(0, 1), txtSerial.Text, cbEmpID.Text.Substring(0, 1), cboAcc.Text, cboSign.Text, cboRT.Text, cboIss.Text, dtpRDate.Text);
                //Location Change Check
                if (!String.Equals(comp3,txtCost.Text))
                {
                    con2.logbalchange(rid, txtCost.Text);
                    MessageBox.Show("Cost adjusted to Equipment Card", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!String.Equals(comp2, cboLoc.Text.Substring(0, 1)) && String.Equals(cboLoc.Text.Substring(0, 1), "1") && !String.Equals(comp2, "1"))
                {
                    con2.logcurset(rid);
                    con2.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cboLoc.Text.Substring(2, cboLoc.Text.Length - 2), rid, String.Concat("Property returned at  ", DateTime.Now.ToShortTimeString()), "RETURN", "0");
                    MessageBox.Show("Returned Entry Created", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!String.Equals(comp2, cboLoc.Text.Substring(0, 1)) && !String.Equals(cboLoc.Text.Substring(0, 1), "1") && String.Equals(comp2, "1"))
                {
                    con2.logcurset(rid);
                    con2.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cboLoc.Text.Substring(2, cboLoc.Text.Length - 2), rid, String.Concat("Property sent/be sent at  ", DateTime.Now.ToShortTimeString()), "SENT", "0");
                    MessageBox.Show("Sent Entry Created", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!String.Equals(comp2, cboLoc.Text.Substring(0, 1)) && !String.Equals(cboLoc.Text.Substring(0, 1), "1") && !String.Equals(comp2, "1"))
                {
                    con2.logcurset(rid);
                    con2.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cboLoc.Text.Substring(2, cboLoc.Text.Length - 2), rid, String.Concat("Location Changed at ", DateTime.Now.ToShortTimeString()), "CHANGE", "0");
                    MessageBox.Show("Location Change Entry Created", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Employee Change Check
                if (!String.Equals(comp1, cbEmpID.Text.Substring(0, 1)))
                {
                    con2.logcurset(rid);
                    con2.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cboLoc.Text.Substring(2, cboLoc.Text.Length - 2), rid, String.Concat("Accountable Officer changed at ", DateTime.Now.ToShortTimeString()), "CHANGE", "0");
                    MessageBox.Show("Employee Change Entry Created", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
