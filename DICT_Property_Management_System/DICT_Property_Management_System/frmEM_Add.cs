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
    public partial class frmEM_Add : Form
    {
        P_Employee con = new P_Employee();
        Property_Employee close;
        inputValidation inpc = new inputValidation();
        string picsource = "N/U";
        public frmEM_Add(Property_Employee temp)
        {
            InitializeComponent();
            close = temp;
            cboDept.SelectedIndex = 0;
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(open.ShowDialog()==DialogResult.OK)
            {
                pbEmp.Image = new Bitmap(open.FileName);
                picsource = open.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (inpc.EmptyCheck(Controls))
            {
                con.empadd(txtEName.Text, txtContact.Text, txtEmail.Text, picsource,txtJobT.Text,cboDept.Text);
                close.tblshow();
                close.cleardetail();
                this.Close();
            }
        }

        private void btnRemPic_Click(object sender, EventArgs e)
        {
            pbEmp.Image = null;
            picsource = "N/U";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEName_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEName.Text))
            {
                if (!inpc.ACheck(txtEName.Text))
                {
                    txtEName.Text = "";
                }
            }
        }

        private void txtContact_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtContact.Text))
            {
                if (!inpc.NCheck(txtContact.Text))
                {
                    txtContact.Text = "";
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
                    txtEmail.Text = "";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
