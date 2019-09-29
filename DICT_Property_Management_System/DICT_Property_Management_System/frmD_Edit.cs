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
    public partial class frmD_Edit : Form
    {
        String id;
        P_Disposal con = new P_Disposal();
        inputValidation inpc = new inputValidation();
        Property_Disposal dclose = new Property_Disposal(); 
        string[] darr = new string[3];
        public frmD_Edit(string fid,Property_Disposal temp)
        {
            InitializeComponent();
            id = fid;
            dclose = temp;
            con.displblshow(id, darr);
            dtpDDate.Text = darr[0];
            cboDMeth.Text = darr[1];
            txtRem.Text = darr[2];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (inpc.EmptyCheck(Controls))
            {
                con.dispedit(id, dtpDDate.Text, cboDMeth.Text, txtRem.Text);
                dclose.tblshow();
                dclose.lblreset();
                this.Close();
            }            
        }
    }
}
