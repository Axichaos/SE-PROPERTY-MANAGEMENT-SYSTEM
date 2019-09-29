using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICT_Property_Management_System
{
    class inputValidation
    {
        //Alphabet Check
        public bool ACheck (string tbinput)
        {
            if(tbinput.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please input only letters for this textbox!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Number Check
        public bool NCheck (string tbinput)
        {
            if (tbinput.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please input only non-float numbers for this textbox!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Alphanumeric Check
        public bool ANCheck(string tbinput)
        {
            if (tbinput.All(char.IsLetterOrDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please input only alphanumeric characters for this textbox!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Float Check
        public bool FCheck(string tbinput)
        {
            float n;
            if (float.TryParse(tbinput,out n))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please input only numbers for this textbox!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Empty Textbox Check
        public bool EmptyCheck(Control.ControlCollection inputform)
        {
            int errorflag = 0;
            foreach (Control control in inputform)
            {
                string controltype = control.GetType().ToString();
                if (controltype == "System.Windows.Forms.TextBox")
                {
                    TextBox txtbox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtbox.Text))
                    {
                        errorflag = 1;
                    }
                }
            }           
            if (errorflag == 1)
            {
                MessageBox.Show("Empty field(s) found! Please fill them out!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool EmptyCheck(Control.ControlCollection inputform,int s)
        {
            int errorflag = 0;
            foreach (Control control in inputform)
            {
                string controltype = control.GetType().ToString();
                if (controltype == "System.Windows.Forms.TextBox" && control.Name != "txtSerial")
                {
                    TextBox txtbox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtbox.Text))
                    {
                        errorflag = 1;
                    }
                }
            }
            if (errorflag == 1)
            {
                MessageBox.Show("Empty field(s) found! Please fill them out!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
