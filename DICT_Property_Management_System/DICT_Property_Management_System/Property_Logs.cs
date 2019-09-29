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
    public partial class Property_Logs : Form
    {
        P_Inventory PI = new P_Inventory();
        P_EqpCard PEC = new P_EqpCard();
        string invid;
        public Property_Logs()
        {
            InitializeComponent();
            propshow();
        }
        public void propshow()
        {
            PI.invshowlog(tblIndLog);
        }
        private void Property_Logs_Load(object sender, EventArgs e)
        {

        }

        private void tblIndLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblIndLog.SelectedItems.Count > 0 )
            {
                invid = tblIndLog.SelectedItems[0].SubItems[0].Text;
                PEC.logtblshow(tblLogs, invid);
            }
            else
            {
                tblLogs.Items.Clear();
            }
        }
    }
}
