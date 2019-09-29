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
    public partial class Property_Login : Form
    {
        P_User con =  new P_User();
        inputValidation inpc = new inputValidation();
        public Property_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (inpc.EmptyCheck(Controls))
            {
                if (con.logincheck(txtAccount.Text,txtPassword.Text))
                {
                    MessageBox.Show("Login Success", "Welcome to the system!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var wind = new frmDemo();
                    wind.Closed += (s, args) => this.Close();
                    wind.ShowDialog();
                }
            }
        }

        private void txtAccount_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAccount.Text))
            {
                if (!inpc.ANCheck(txtAccount.Text))
                {
                    txtAccount.Text = "";
                }
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassword.Text))
            {
                if (!inpc.ANCheck(txtPassword.Text))
                {
                    txtPassword.Text = "";
                }
            }
        }
    }
}
