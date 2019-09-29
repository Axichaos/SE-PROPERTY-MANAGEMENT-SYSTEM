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
    public partial class frmEM_VLE : Form
    {
        P_Employee con = new P_Employee();
        public frmEM_VLE(string previd)
        {
            InitializeComponent();
            con.empinvlink(tblEmpLink, previd);
        }
       
    }
}
