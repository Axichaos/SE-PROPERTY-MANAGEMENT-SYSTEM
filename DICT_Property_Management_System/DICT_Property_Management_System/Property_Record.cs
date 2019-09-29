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
    public partial class Property_Record : Form
    {
        string propid;
        P_Record con = new P_Record();
        public Property_Record()
        {
            InitializeComponent();
            tblshow();
        }
        public void tblshow()
        {
            con.recordshow(tblRecord);
        }

        private void tblRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblRecord.SelectedItems.Count > 0)
            {
                propid = tblRecord.SelectedItems[0].SubItems[0].Text;
                con.recordinvshow(propid, tblRInv);
            }
            else
            {
                tblRInv.Items.Clear();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmR_Add wind = new frmR_Add(this);
            wind.ShowDialog();            
        }

        private void tblRInv_DoubleClick(object sender, EventArgs e)
        {
            PropertyDetails wind = new PropertyDetails(tblRInv.SelectedItems[0].SubItems[0].Text);
            wind.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tblRecord.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmR_Edit wind = new frmR_Edit(this, propid);
                wind.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tblRecord.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con.recdelete(propid);
                    this.tblshow();
                }               
            }
        }
    }
}
