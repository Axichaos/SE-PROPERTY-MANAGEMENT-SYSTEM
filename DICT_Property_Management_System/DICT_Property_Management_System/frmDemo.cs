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
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Property_Inventory wind = new Property_Inventory();
            wind.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Property_Record wind = new Property_Record();
            wind.ShowDialog();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            Property_Logs wind = new Property_Logs();
            wind.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Property_EqpCard wind = new Property_EqpCard();
            wind.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Property_Disposal wind = new Property_Disposal();
            wind.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Property_Location wind = new Property_Location();
            wind.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Property_Employee wind = new Property_Employee();
            wind.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var wind = new Property_Login();
            wind.Closed += (s, args) => this.Close();
            wind.ShowDialog();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Property_Assign wind = new Property_Assign();
            wind.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void bcc(Button b,int i)
        {
            if (i == 1)
            {
                b.BackColor = Color.FromArgb(0, 0, 192);
            }
            else
            {
                b.BackColor = Color.FromArgb(0, 0, 64);
            }
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            bcc((Button)sender, 1);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            bcc((Button)sender, 2);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            bcc(button1, 1);
        }
    }
}
