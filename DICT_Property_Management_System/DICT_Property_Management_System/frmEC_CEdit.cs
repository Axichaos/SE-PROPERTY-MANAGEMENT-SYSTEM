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
    public partial class frmEC_CEdit : Form
    {
        Property_EqpCard home = new Property_EqpCard();
        string cid;
        P_EqpCard con = new P_EqpCard();
        public frmEC_CEdit(string det1,string det2,Property_EqpCard temp,string id) 
        {
            InitializeComponent();
            home = temp;
            txtName.Text = det1;
            dtpRDate.Text = det2;
            cid = id;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.cedit(cid, txtName.Text, dtpRDate.Text);
            home.tblshow();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
