﻿using System;
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
    public partial class MAIN_UI_DESIGN_TEMP : Form
    {
        string messagelog = "";
        public MAIN_UI_DESIGN_TEMP()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void MAIN_UI_DESIGN_TEMP_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(messagelog);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messagelog = String.Concat(messagelog, " \n new text");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            messagelog = String.Concat(messagelog, " \n \t new text2");
        }
    }
}
