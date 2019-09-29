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
    public partial class Property_Log : Form
    {
        string lid;
        string pid;
        public Property_Log()
        {
            InitializeComponent();
            tblshow();
        }
        public void tblshow()
        {
        }

        private void tblLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblLog.SelectedItems.Count > 0)
            {
                lid = tblLog.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                txtDesc.Text = "?";
            }
        }
        public void SubReset()
        {
            tblLog.Items.Clear();
            txtDesc.Text = "?";
        }
        private void tblInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count > 0)
            {
                pid = tblInventory.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                tblLog.Items.Clear();
                txtDesc.Text = "?";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Inventory Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmL_Add wind = new frmL_Add(pid, this);
                wind.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tblLog.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Log Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmL_Edit wind = new frmL_Edit(lid, pid, this);
                wind.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tblLog.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Log Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.tblshow();
                this.SubReset();
            }
        }

        private void tblLog_DoubleClick(object sender, EventArgs e)
        {
            PropertyDetails wind = new PropertyDetails(pid);
            wind.ShowDialog();
        }
    }
}
