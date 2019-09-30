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
    public partial class frmPI_Add : Form
    {
        P_Inventory con = new P_Inventory();
        P_EqpCard con2 = new P_EqpCard();
        P_Location con3 = new P_Location();
        P_Employee con4 = new P_Employee();
        inputValidation inpc = new inputValidation();
        Property_Inventory close = new Property_Inventory();
        string tempq;
        public frmPI_Add(Property_Inventory temp)
        {
            close = temp;
            InitializeComponent();
            con3.loclblins(cbLoc);
            con4.empshow(cbEmpID);
            cboRT.SelectedIndex = 0;
            cboIss.SelectedIndex = 0;
            cboSign.SelectedIndex = 0;
            cbEmpID.SelectedIndex = 0;
            cbLoc.SelectedIndex = 0;
            btnAddS.Enabled = false;
            btnRemove.Enabled = false;
            btnClrLvw.Enabled = false;
            cbEmpID.Enabled = false;
            cbLoc.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int tempn;
            int.TryParse(txtQuan.Text, out tempn);
            if (lvwSerial.Items.Count < tempn)
            {
                MessageBox.Show("Not enough serial numbers for the appropriate amount of quantity! Please add more serial numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sertemp;
                if (tempn == 1)
                {
                    if (inpc.EmptyCheck(groupBox1.Controls))
                    {
                        sertemp = txtSerial.Text;
                        con.invadd(txtInven.Text, txtName.Text, cboUnit.Text, cboType.Text, txtRemarks.Text, txtArticle.Text, txtCost.Text, txtDesc.Text, cbLoc.Text.Substring(0, 1), sertemp, cbEmpID.Text.Substring(0, 1), cboAcc.Text, cboSign.Text, cboRT.Text, cboIss.Text, dtpRDate.Text);
                        con2.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cbLoc.Text.Substring(2, cbLoc.Text.Length - 2), txtInven.Text, String.Concat("Property Record Created at ", DateTime.Now.ToShortTimeString()), "GENERATED", txtCost.Text);
                        MessageBox.Show("Log Entry Created", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        close.tblshow();
                        this.Close();
                    }                 
                }
                else
                {
                    if (inpc.EmptyCheck(groupBox1.Controls,1))
                    {
                        int counter = 0;
                        foreach (ListViewItem serno in lvwSerial.Items)
                        {
                            counter++;
                            Random rnd = new Random();
                            char randomchar = (char)rnd.Next('A', 'Z');
                            string tempinv = counter.ToString() + randomchar;
                            sertemp = serno.SubItems[0].Text;
                            con.invadd(String.Concat(txtInven.Text, tempinv), txtName.Text, cboUnit.Text, cboType.Text, txtRemarks.Text, txtArticle.Text, txtCost.Text, txtDesc.Text, cbLoc.Text.Substring(0, 1), sertemp, cbEmpID.Text.Substring(0, 1), cboAcc.Text, cboSign.Text, cboRT.Text, cboIss.Text, dtpRDate.Text);
                            con2.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cbLoc.Text.Substring(2, cbLoc.Text.Length - 2), String.Concat(txtInven.Text, tempinv), String.Concat("Property Record Created at ", DateTime.Now.ToShortTimeString()), "GENERATED", txtCost.Text);
                            MessageBox.Show("Log Entry Created", "Property Tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            close.tblshow();
                            this.Close();
                        }
                    }                  
                }
            }                
        }        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboIss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Equals(cboIss.Text, "No"))
            {
                cboSign.Text = "No";
                cboSign.Enabled = false;
            }
            else
            {
                cboSign.Enabled = true;
            }
        }

        private void txtCost_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCost.Text))
            {
                if (!inpc.FCheck(txtCost.Text))
                {
                    txtCost.Text = "";
                }
            }          
        }

        private void btnIQ_Click(object sender, EventArgs e)
        {
            int tempn;
            int.TryParse(txtQuan.Text,out tempn);
            tempn += 1;
            txtQuan.Text = tempn.ToString();
        }

        private void btnDQ_Click(object sender, EventArgs e)
        {
            int tempn;
            int.TryParse(txtQuan.Text, out tempn);
            if (tempn - 1 <= 0)
            {
                MessageBox.Show("Quantity must be bigger than 0!", "Quantity Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lvwSerial.Items.Count > 0)
                {
                    if(MessageBox.Show("Decreasing the quantity will clear all serial no.! Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        lvwSerial.Items.Clear();
                        tempn -= 1;
                        txtQuan.Text = tempn.ToString();
                    }
                }
                else
                {
                    tempn -= 1;
                    txtQuan.Text = tempn.ToString();
                }
            }           
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSerial.Text))
            {
                MessageBox.Show("Please input a Serial No.!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lvwSerial.Items.Count.ToString() == txtQuan.Text)
            {
                MessageBox.Show("Max number of serial numbers reached! Cannot add more!", "Max Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSerial.Text = "";
            }
            else
            {
                ListViewItem tempser = new ListViewItem(txtSerial.Text);
                lvwSerial.Items.Add(tempser);
                txtSerial.Text = "";
            }            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lvwSerial.Items.RemoveAt(lvwSerial.SelectedIndices[0]);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            lvwSerial.Items.Clear();
        }

        private void txtQuan_Validated(object sender, EventArgs e)
        {
            if (!inpc.NCheck(txtQuan.Text))
            {
                txtQuan.Text = tempq;
            }
            else if(String.IsNullOrWhiteSpace(txtQuan.Text))
            {
                MessageBox.Show("Quantity cannot be empty!", "Empty Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuan.Text = tempq;
            }
            else
            {
                int tempn;
                int prevq;
                int.TryParse(txtQuan.Text, out tempn);
                int.TryParse(tempq, out prevq);
                if (tempn <= 0)
                {
                    MessageBox.Show("Quantity must be bigger than 0!", "Quantity Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuan.Text = tempq;
                }
                else if(tempn < prevq)
                {
                    if (lvwSerial.Items.Count > 0)
                    {
                        if (MessageBox.Show("Decreasing the quantity will clear all serial no.! Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            lvwSerial.Items.Clear();
                        }
                        else
                        {
                            txtQuan.Text = tempq;
                        }
                    }
                }
                else if(tempn == 1)
                {
                    btnAddS.Enabled = false;
                    btnClrLvw.Enabled = false;
                }
                else
                {
                    btnAddS.Enabled = true;
                    btnClrLvw.Enabled = true;
                }
            }
        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {
            if (txtQuan.Text == "1")
            {
                btnAddS.Enabled = false;
                btnClrLvw.Enabled = false;

            }
            else
            {
                btnAddS.Enabled = true;
                btnClrLvw.Enabled = true;
            }
        }

        private void lvwSerial_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show(lvwSerial.Items.Count.ToString());
        }

        private void lvwSerial_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            MessageBox.Show(lvwSerial.Items.Count.ToString());
        }

        private void txtQuan_Click(object sender, EventArgs e)
        {
            tempq = txtQuan.Text;
        }

        private void lvwSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwSerial.SelectedItems.Count <= 0)
            {
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }
        }
    }
}
