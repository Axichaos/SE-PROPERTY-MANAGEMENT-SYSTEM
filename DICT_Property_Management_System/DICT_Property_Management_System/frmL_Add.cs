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
    public partial class frmL_Add : Form
    {
        string afid;
        Property_Log afclose;
        public frmL_Add(string tempd,Property_Log temp)
        {
            InitializeComponent();
            afclose = temp;
            afid = tempd;
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
