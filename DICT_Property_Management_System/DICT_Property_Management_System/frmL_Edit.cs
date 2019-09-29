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
    public partial class frmL_Edit : Form
    {
        string pid;
        string lid;
        Property_Log afclose;
        public frmL_Edit(string templid,string temppid, Property_Log temp)
        {
            InitializeComponent();
            pid = temppid;
            lid = templid;
            afclose = temp;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            afclose.tblshow();
            afclose.SubReset();
            this.Close();
        }
    }
}
