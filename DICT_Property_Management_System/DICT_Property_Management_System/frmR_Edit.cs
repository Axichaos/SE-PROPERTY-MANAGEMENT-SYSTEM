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
    public partial class frmR_Edit : Form
    {
        Property_Record rclose = new Property_Record();
        string nid;
        string[] lbldet = new string[5];
        P_Record con = new P_Record();
        public frmR_Edit(Property_Record temp,string pid)
        {
            InitializeComponent();
            nid = pid;
            rclose = temp;
            con.receditret(nid,lbldet);
            cboIss.Text = lbldet[3];
            if (String.Equals(cboIss.Text,"No")) 
            {
                cboSign.Text = "No";
                cboSign.Enabled = false;
            }
            else
            {
                cboSign.Text = lbldet[1];
            }
            cboRT.Text = lbldet[2];
            dtpRDate.Text = lbldet[4];
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.recedit(nid, cboSign.Text, cboRT.Text, cboIss.Text, dtpRDate.Text);
            rclose.tblshow();
            this.Close();
        }
    }
}
