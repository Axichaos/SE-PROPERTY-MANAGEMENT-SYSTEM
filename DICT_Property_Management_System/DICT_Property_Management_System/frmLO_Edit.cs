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
    public partial class frmLO_Edit : Form
    {
        string eid;
        string[] inf = new string[3];
        P_Location con = new P_Location();
        Property_Location close;
        inputValidation inpc = new inputValidation();
        public frmLO_Edit(Property_Location temp,string temppk) 
        {
            InitializeComponent();
            eid = temppk;
            close = temp;
            con.loceditinfo(eid, inf);
            txtLoc.Text = inf[0];
            cboProv.Text = inf[1];
            txtRoom.Text = inf[2];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (inpc.EmptyCheck(Controls))
            {
                con.locedit(txtLoc.Text, cboProv.Text, txtRoom.Text, eid);
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
