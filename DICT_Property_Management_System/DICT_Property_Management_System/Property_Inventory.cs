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
    public partial class Property_Inventory : Form
    {
        P_Inventory PI = new P_Inventory();
        String id;
        public Property_Inventory()
        {
            InitializeComponent();
            tblshow();          
        }
        public void tblshow()
        {
            PI.invshow(tblInventory);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PropertyDetails newwind = new PropertyDetails(id);
                newwind.Show();
            }           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPI_Add newwind2 = new frmPI_Add(this);
            newwind2.ShowDialog();
        }

        private void tblInventory_DoubleClick(object sender, EventArgs e)
        {
            PropertyDetails newwind = new PropertyDetails(id);
            newwind.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmPI_Update newwind = new frmPI_Update(id, this);
                newwind.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PI.invdelete(id);
                tblshow();
            }
        }

        private void tblInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count > 0)
            {
                id = tblInventory.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No Entry Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to transfer this entry to disposal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    frmPI_Transfer wind = new frmPI_Transfer(id, this);
                    wind.ShowDialog();
                }
            }           
        }
    }
}
