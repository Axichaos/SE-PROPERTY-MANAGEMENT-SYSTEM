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
    public partial class frmEC_View : Form
    {
        P_EqpCard con = new P_EqpCard();
        string cid;
        public frmEC_View(string previd)
        {
            InitializeComponent();
            cid = previd;
            tblshow();
        }
        public void tblshow()
        {
            con.cshow(tblEqpCard, cid);
        }
    }
}
