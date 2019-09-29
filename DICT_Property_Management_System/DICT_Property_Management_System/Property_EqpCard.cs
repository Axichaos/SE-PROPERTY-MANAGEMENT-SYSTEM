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
    public partial class Property_EqpCard : Form
    {
        string eid;
        P_EqpCard con = new P_EqpCard();
        public Property_EqpCard()
        {
            InitializeComponent();
            tblshow();
        }
        public void tblshow()
        {
            con.ctblshow(tblEqpCard);
        }
        private void btnCAdd_Click(object sender, EventArgs e)
        {
            frmEC_CAdd wind = new frmEC_CAdd(this);
            wind.ShowDialog();
        }

        private void btnCEdit_Click(object sender, EventArgs e)
        {
            if (tblEqpCard.SelectedItems.Count > 0)
            {
                string d1 = tblEqpCard.SelectedItems[0].SubItems[2].Text;
                string d2 = tblEqpCard.SelectedItems[0].SubItems[1].Text;
                frmEC_CEdit wind = new frmEC_CEdit(d1,d2,this,eid);
                wind.ShowDialog();
            }
        }

        private void tblEqpCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tblEqpCard.SelectedItems.Count > 0 )
            {
                eid = tblEqpCard.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(tblEqpCard.SelectedItems.Count > 0 )
            {
                if(MessageBox.Show("Are you sure you want to delete this record?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con.cdelete(eid);
                    tblshow();
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmEC_View wind = new frmEC_View(eid);
            wind.ShowDialog();
        }
    }
}
