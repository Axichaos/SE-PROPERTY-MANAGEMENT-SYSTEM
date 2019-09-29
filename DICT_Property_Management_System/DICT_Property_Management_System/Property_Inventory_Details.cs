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
    public partial class PropertyDetails : Form
    {
        string priid;
        P_Inventory PI = new P_Inventory();
        string[] lblarray = new string[19];
        public PropertyDetails(string previd)
        {
            InitializeComponent();
            priid = previd;
            PI.invshowd(priid, lblarray);
            gbDetails.Text = String.Concat(gbDetails.Text,lblarray[0]);
            lblName.Text = String.Concat(lblName.Text, lblarray[1]);
            lblUnit.Text = String.Concat(lblUnit.Text,lblarray[2]);
            lblType.Text = String.Concat(lblType.Text,lblarray[3]);
            txtRemarks.Text = lblarray[4];
            lblArticle.Text = String.Concat(lblArticle.Text,lblarray[5]);
            float c = float.Parse(lblarray[6]);
            lblarray[6] = String.Concat("₱", c.ToString("F"));
            lblCost.Text = String.Concat(lblCost.Text, lblarray[6]);
            txtDesc.Text = lblarray[7];
            lblLocationID.Text = String.Concat(lblLocationID.Text,lblarray[8]);
            lblSerialNo.Text = String.Concat(lblSerialNo.Text,lblarray[9]);
            lblAccPerson.Text = String.Concat(lblAccPerson.Text,lblarray[10]);
            lblAccCode.Text = String.Concat(lblAccCode.Text,lblarray[11]);
            lblSigned.Text = String.Concat(lblSigned.Text, lblarray[14]);
            lblRcpT.Text = String.Concat(lblRcpT.Text, lblarray[15]);
            lblRcpI.Text = String.Concat(lblRcpI.Text, lblarray[16]);
            lblDate.Text = String.Concat(lblDate.Text, lblarray[17]);
        }

        private void Property_Inventory_Details_Load(object sender, EventArgs e)
        {

        }

        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
