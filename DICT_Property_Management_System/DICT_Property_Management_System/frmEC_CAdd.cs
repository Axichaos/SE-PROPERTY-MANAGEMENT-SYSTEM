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
    public partial class frmEC_CAdd : Form
    {
        P_EqpCard con = new P_EqpCard();
        Property_EqpCard home;
        public frmEC_CAdd(Property_EqpCard temp)
        {
            InitializeComponent();
            home = temp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEC_LAdd wind = new frmEC_LAdd(this);
            wind.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tblEqp.Items.RemoveAt(tblEqp.SelectedIndices[0]);
        }

        public void tbladd(ListViewItem ite)
        {
            tblEqp.Items.Add(ite);
        }

        public bool tblscan(string comp)
        {
            if (tblEqp.Items.Count > 0)
            {
                for (int x = 0; x < tblEqp.Items.Count; x++)
                {
                    if (String.Equals(comp, tblEqp.Items[x].Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.cgen(txtName.Text, dtpRDate.Text);
            if (tblEqp.Items.Count > 0)
            {
                string cpk = con.ctblshow();
                for (int x = 0;x<=(tblEqp.Items.Count-1);x++)
                {
                    con.linkadd(cpk,tblEqp.Items[x].Text);
                }
            }
            home.tblshow();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tblEqp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
