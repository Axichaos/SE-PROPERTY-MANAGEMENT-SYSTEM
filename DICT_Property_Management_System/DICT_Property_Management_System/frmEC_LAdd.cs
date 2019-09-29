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
    public partial class frmEC_LAdd : Form
    {
        P_Inventory con = new P_Inventory();
        frmEC_CAdd link;
        string invno;
        string name;
        public frmEC_LAdd(frmEC_CAdd temp)
        {          
            InitializeComponent();
            link = temp;
            tblshow();
        }
        public void tblshow()
        {
            con.invshowall(tblInventory);
        }

        private void tblInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count >0)
            {
                invno = tblInventory.SelectedItems[0].Text;
                name = tblInventory.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tblInventory.SelectedItems.Count > 0)
            {
                if (link.tblscan(invno))
                {
                    MessageBox.Show("This record is already added!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ListViewItem tbli = new ListViewItem(invno);
                    tbli.SubItems.Add(name);
                    link.tbladd(tbli);
                    this.Close();
                }              
            }
            else
            {
                MessageBox.Show("No Inventory Record Selected!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEC_LAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
