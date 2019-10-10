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
    public partial class Property_Employee : Form
    {
        P_Employee con = new P_Employee();
        string[] lbl = new string[6];
        string tempid;
        public Property_Employee()
        {
            InitializeComponent();
            tblshow();
        }
        public void tblshow()
        {
            con.empshow(tblEmployee,1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEM_Add wind = new frmEM_Add(this);
            wind.ShowDialog();
        }

        public void cleardetail()
        {
            lblName.Text = "?";
            lblCont.Text = "?";
            lblEmail.Text = "?";
            lblJobT.Text = "?";
            lblDept.Text = "?";
            pbEmp.Image = null;
        }

        private void tblEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblEmployee.SelectedItems.Count > 0)
            {
                tempid = tblEmployee.SelectedItems[0].SubItems[0].Text;
                con.empselected(tempid, lbl);
                lblName.Text = lbl[0];
                lblCont.Text = lbl[1];
                lblEmail.Text = lbl[2];
                lblJobT.Text = lbl[4];
                lblDept.Text = lbl[5];
                if (tempid == "1")
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
                if (lbl[3] != "N/U")
                {
                    pbEmp.Image = new Bitmap(lbl[3]);
                }
                else
                {
                    pbEmp.Image = null;
                }
            }
            else
            {
                cleardetail();
                btnDelete.Enabled = true;
            }
        }

        public bool errorcheck()
        {
            if (tblEmployee.SelectedItems.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No employee selected!", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (errorcheck())
            {
                frmEM_Edit wind = new frmEM_Edit(this, tempid);
                wind.ShowDialog();
            }          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (errorcheck())
            {
                if (con.empinvlink(tempid))
                {
                    MessageBox.Show("You cannot delete this employee as it contains related record to properties!", "Property Record Detected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleardetail();
                }
                else
                {
                    if (con.empdelete(tempid))
                    {
                        tblshow();
                        cleardetail();
                    }
                }               
            }
        }

        private void btnEmVLE_Click(object sender, EventArgs e)
        {
            if (errorcheck())
            {
                frmEM_VLE wind = new frmEM_VLE(tempid);
                wind.ShowDialog();
            }            
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
