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
    public partial class frmLO_Add : Form
    {
        P_Location con = new P_Location();
        Property_Location acc;
        inputValidation inpc = new inputValidation();
        public frmLO_Add(Property_Location temp)
        {
            InitializeComponent();
            acc = temp;
            cboProv.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (inpc.EmptyCheck(Controls))
            {
                con.locadd(txtLoc.Text, cboProv.Text, txtRoom.Text);
                acc.tblshow();
                this.Close();
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboProv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
