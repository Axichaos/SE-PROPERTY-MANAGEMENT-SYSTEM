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
    public partial class frmAS_Assign : Form
    {
        P_Assign con = new P_Assign();
        P_Location con5 = new P_Location();
        P_Employee con3 = new P_Employee();
        P_EqpCard con4 = new P_EqpCard();
        Property_Assign close;
        string empchanges = "\n \t Employee Changes: ";
        string locchanges = "\n \t Location Changes: ";
        string sentlog = "\n \t Sent Properties: ";
        string returnlog = "\n \t Returned Properties: ";
        public frmAS_Assign(ListViewItem[] tarr,Property_Assign tempfrm)
        {
            InitializeComponent();
            con5.loclblins(cboLoc);
            con3.empshow(cbEmpID);
            cbEmpID.SelectedIndex = 0;
            cboLoc.SelectedIndex = 0;
            close = tempfrm;
            foreach (ListViewItem tbli in tarr)
            {
                ListViewItem tempitem = new ListViewItem(tbli.SubItems[1].Text);
                tempitem.SubItems.Add(tbli.SubItems[2]);
                tempitem.SubItems.Add(tbli.SubItems[3]);
                tempitem.SubItems.Add(tbli.SubItems[4]);
                tempitem.SubItems.Add(tbli.SubItems[5]);
                tblSelProp.Items.Add(tempitem);
            }
        }

        private void cbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempemp = cbEmpID.Text.Substring(0,1);
            string[] tempemparr = new string[6];
            con3.empselected(tempemp, tempemparr);
            lblEmpName.Text = tempemparr[0];
            lblEmpCont.Text = tempemparr[1];
            lblEmailAdd.Text = tempemparr[2];
            if (tempemparr[3] != "N/U")
            {
                pbEmp.Image = new Bitmap(tempemparr[3]);
            }
            else
            {
                pbEmp.Image = null;
            }
            lblJobT.Text = tempemparr[4];
            lblDept.Text = tempemparr[5];
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temploc = cboLoc.Text.Substring(0,1);
            string[] templocarr = new string[3];
            con5.loceditinfo(temploc, templocarr);
            lblLoc.Text = templocarr[0];
            lblProv.Text = templocarr[1];
            lblRoom.Text = templocarr[2];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem proprec in tblSelProp.Items)
            {
                //Location Change Log
                if (!String.Equals(proprec.SubItems[3].Text, cboLoc.Text.Substring(0, 1)) && String.Equals(cboLoc.Text.Substring(0, 1), "1") && !String.Equals(proprec.SubItems[3].Text, "1"))
                {
                    returnlog = string.Concat(returnlog, " \n \t \t " + proprec.SubItems[0].Text + " returned to " + lblLoc.Text);
                }
                else if (!String.Equals(proprec.SubItems[3].Text, cboLoc.Text.Substring(0, 1)) && !String.Equals(cboLoc.Text.Substring(0, 1), "1") && String.Equals(proprec.SubItems[3].Text, "1"))
                {
                    sentlog = string.Concat(sentlog, " \n \t \t " + proprec.SubItems[0].Text + " sent to " + lblLoc.Text);
                }
                else if (!String.Equals(proprec.SubItems[3].Text, cboLoc.Text.Substring(0, 1)) && !String.Equals(cboLoc.Text.Substring(0, 1), "1") && !String.Equals(proprec.SubItems[3].Text, "1"))
                {
                    locchanges = string.Concat(locchanges, " \n \t \t " + proprec.SubItems[0].Text + " changed location to " + lblLoc.Text);
                }
                //Employee Change Log
                if (!String.Equals(proprec.SubItems[4].Text, cbEmpID.Text.Substring(0, 1)))
                {
                    empchanges = string.Concat(empchanges, " \n \t \t " + proprec.SubItems[0].Text + " assigned to " + lblEmpName.Text);
                }              
            }
            string wholelog = "These are the following changes: ";
            if (returnlog != "\n \t Returned Properties: ")
            {
                wholelog = string.Concat(wholelog,returnlog);
            }
            if (sentlog != "\n \t Sent Properties: ")
            {
                wholelog = string.Concat(wholelog, sentlog);
            }
            if (locchanges != "\n \t Location Changes: ")
            {
                wholelog = string.Concat(wholelog, locchanges);
            }
            if (empchanges != "\n \t Employee Changes: ")
            {
                wholelog = string.Concat(wholelog, empchanges);
            }
            if(MessageBox.Show(wholelog+"\n \n \t Is this ok?","Properties Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
            {
                foreach (ListViewItem proprec in tblSelProp.Items)
                {
                    con.asiupdate(proprec.SubItems[0].Text, cbEmpID.Text.Substring(0, 1), cboLoc.Text.Substring(0, 1));
                    //Location Logs
                    if (!String.Equals(proprec.SubItems[3].Text, cboLoc.Text.Substring(0, 1)) && String.Equals(cboLoc.Text.Substring(0, 1), "1") && !String.Equals(proprec.SubItems[3].Text, "1"))
                    {
                        con4.logcurset(proprec.SubItems[0].Text);
                        con4.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cboLoc.Text.Substring(2, cboLoc.Text.Length - 2), proprec.SubItems[0].Text, String.Concat("Property returned at  ", DateTime.Now.ToShortTimeString()), "RETURN", "0");
                    }
                    else if (!String.Equals(proprec.SubItems[3].Text, cboLoc.Text.Substring(0, 1)) && !String.Equals(cboLoc.Text.Substring(0, 1), "1") && String.Equals(proprec.SubItems[3].Text, "1"))
                    {
                        con4.logcurset(proprec.SubItems[0].Text);
                        con4.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cboLoc.Text.Substring(2, cboLoc.Text.Length - 2), proprec.SubItems[0].Text, String.Concat("Property sent/be sent at  ", DateTime.Now.ToShortTimeString()), "SENT", "0");
                    }
                    else if (!String.Equals(proprec.SubItems[3].Text, cboLoc.Text.Substring(0, 1)) && !String.Equals(cboLoc.Text.Substring(0, 1), "1") && !String.Equals(proprec.SubItems[3].Text, "1"))
                    {
                        con4.logcurset(proprec.SubItems[0].Text);
                        con4.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cboLoc.Text.Substring(2, cboLoc.Text.Length - 2), proprec.SubItems[0].Text, String.Concat("Location Changed at ", DateTime.Now.ToShortTimeString()), "CHANGE", "0");
                    }
                    //Employee Logs
                    if (!String.Equals(proprec.SubItems[4].Text, cbEmpID.Text.Substring(0, 1)))
                    {
                        con4.logcurset(proprec.SubItems[0].Text);
                        con4.logadd(DateTime.Now.ToShortDateString(), cbEmpID.Text.Substring(2, cbEmpID.Text.Length - 2) + "/" + cboLoc.Text.Substring(2, cboLoc.Text.Length - 2), proprec.SubItems[0].Text, String.Concat("Accountable Officer changed at ", DateTime.Now.ToShortTimeString()), "CHANGE", "0");
                    }
                }
                MessageBox.Show("Assignments Saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                empchanges = "\n \t Employee Changes: ";
                locchanges = "\n \t Location Changes: ";
                sentlog = "\n \t Sent Properties: ";
                returnlog = "\n \t Returned Properties: ";
            }
        }

        private void frmAS_Assign_FormClosed(object sender, FormClosedEventArgs e)
        {
            close.tblshow();
            close.resetgb();
        }
    }
}
