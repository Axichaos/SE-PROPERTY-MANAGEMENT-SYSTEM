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
    public partial class frmEM_Edit : Form
    {
        P_Employee con = new P_Employee();
        inputValidation inpc = new inputValidation();
        Property_Employee clo = new Property_Employee();
        String ntemp;
        String cotemp;
        String emtemp;
        string emppk;
        string pics;
        string[] lblset = new string[6];
        public frmEM_Edit(Property_Employee tempfrm,string tempid)
        {
            InitializeComponent();
            emppk = tempid;
            clo = tempfrm;
            con.empselected(emppk, lblset);
            txtEName.Text = lblset[0];
            txtContact.Text = lblset[1];
            txtEmail.Text = lblset[2];
            pics = lblset[3];
            txtJobT.Text = lblset[4];
            cboDept.Text = lblset[5];
            if (lblset[3] != "N/U")
            {
                pbEmp.Image = new Bitmap(pics);
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbEmp.Image = new Bitmap(open.FileName);
                pics = open.FileName;
            }
        }

        private void btnRemPic_Click(object sender, EventArgs e)
        {
            pbEmp.Image = null;
            pics = "N/U";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(inpc.EmptyCheck(Controls))
            {
                con.empedit(txtEName.Text, txtContact.Text, txtEmail.Text, pics,txtJobT.Text,cboDept.Text, emppk);
                clo.tblshow();
                clo.cleardetail();
                this.Close();
            }          
        }

        private void txtEName_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEName.Text))
            {
                if (!inpc.ACheck(txtEName.Text))
                {
                    txtEName.Text = ntemp;
                }
            }
        }

        private void txtContact_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtContact.Text))
            {
                if (!inpc.NCheck(txtContact.Text))
                {
                    txtContact.Text = cotemp;
                }
                else if (inpc.NCheck(txtContact.Text) && txtContact.Text.Length != 10)
                {
                    MessageBox.Show("Contact Number must be at least 10 digits long!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContact.Text = "";
                }
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmail.Text))
            {               
                if (txtEmail.Text.IndexOf("@") == -1 || txtEmail.Text.IndexOf(".") == -1 || txtEmail.Text.IndexOf(".") < txtEmail.Text.IndexOf("@"))
                {
                    MessageBox.Show("Email Address must be in the correct format! (eg. John@mail.com", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = emtemp;
                }
            }
        }

        private void txtEName_Click(object sender, EventArgs e)
        {
            ntemp = txtEName.Text;
        }

        private void txtContact_Click(object sender, EventArgs e)
        {
            cotemp = txtContact.Text;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            emtemp = txtEmail.Text;
        }
    }
}
