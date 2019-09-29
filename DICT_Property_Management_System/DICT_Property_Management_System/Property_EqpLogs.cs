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
    public partial class Property_EqpLogs : Form
    {
        string cid;
        P_EqpCard con = new P_EqpCard();
        public Property_EqpLogs(string h1, string h2, string tempid)
        {
            InitializeComponent();
            cid = tempid;
            lblCN.Text = h1;
            lblCD.Text = String.Concat(lblCD.Text, h2);
            tblshowcurr();
        }
        public void tblshowcurr()
        {
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void Property_EqpLogs_Load(object sender, EventArgs e)
        {

        }
    }
}
