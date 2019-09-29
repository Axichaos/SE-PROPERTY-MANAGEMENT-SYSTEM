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
    }
}
