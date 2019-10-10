namespace DICT_Property_Management_System
{
    partial class frmEM_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEM_Add));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemPic = new System.Windows.Forms.Button();
            this.pbEmp = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtJobT = new System.Windows.Forms.TextBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 64);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::DICT_Property_Management_System.Properties.Resources.add_employee_edit;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            // 
            // btnAddPic
            // 
            this.btnAddPic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.Location = new System.Drawing.Point(69, 276);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(95, 31);
            this.btnAddPic.TabIndex = 8;
            this.btnAddPic.Text = "Add Picture";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // txtEName
            // 
            this.txtEName.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEName.Location = new System.Drawing.Point(129, 322);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(197, 20);
            this.txtEName.TabIndex = 47;
            this.txtEName.Validated += new System.EventHandler(this.txtEName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Name :";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(129, 351);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(197, 20);
            this.txtContact.TabIndex = 45;
            this.txtContact.Validated += new System.EventHandler(this.txtContact_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "Contact No. :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(129, 380);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Email Address :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(220, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 29);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(108, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 28);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemPic
            // 
            this.btnRemPic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemPic.Location = new System.Drawing.Point(173, 276);
            this.btnRemPic.Name = "btnRemPic";
            this.btnRemPic.Size = new System.Drawing.Size(95, 31);
            this.btnRemPic.TabIndex = 50;
            this.btnRemPic.Text = "Reset";
            this.btnRemPic.UseVisualStyleBackColor = true;
            this.btnRemPic.Click += new System.EventHandler(this.btnRemPic_Click);
            // 
            // pbEmp
            // 
            this.pbEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEmp.BackgroundImage")));
            this.pbEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEmp.InitialImage = null;
            this.pbEmp.Location = new System.Drawing.Point(83, 81);
            this.pbEmp.Name = "pbEmp";
            this.pbEmp.Size = new System.Drawing.Size(175, 164);
            this.pbEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmp.TabIndex = 7;
            this.pbEmp.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DICT_Property_Management_System.Properties.Resources.frame_icon;
            this.pictureBox2.Location = new System.Drawing.Point(72, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // txtJobT
            // 
            this.txtJobT.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobT.Location = new System.Drawing.Point(129, 409);
            this.txtJobT.Name = "txtJobT";
            this.txtJobT.Size = new System.Drawing.Size(197, 20);
            this.txtJobT.TabIndex = 53;
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Items.AddRange(new object[] {
            "Supply Monitoring Unit",
            "Administration",
            "Human Resources",
            "Security",
            "Tech4Ed",
            "Other",
            "N/A"});
            this.cboDept.Location = new System.Drawing.Point(129, 438);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(197, 21);
            this.cboDept.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Job Title :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Department:";
            // 
            // frmEM_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(350, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.txtJobT);
            this.Controls.Add(this.btnRemPic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.pbEmp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmEM_Add";
            this.Text = "frmEM_Add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEmp;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemPic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtJobT;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}