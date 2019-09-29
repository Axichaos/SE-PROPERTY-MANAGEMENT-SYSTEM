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
    public partial class frmR_Add : Form
    {
        Property_Record close = new Property_Record();
        public frmR_Add(Property_Record temp)
        {
            InitializeComponent();
            close = temp;
            cboRT.SelectedIndex = 0;
            cboIss.SelectedIndex = 1;
            cboSign.SelectedIndex = 1;
            cboSign.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            close.tblshow();
            this.Close();
        }

        private void cboIss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Equals(cboIss.Text,"No"))
            {
                cboSign.Text = "No";
                cboSign.Enabled = false;
            }
            else
            {
                cboSign.Enabled = true;
            }
        }
    }
}
