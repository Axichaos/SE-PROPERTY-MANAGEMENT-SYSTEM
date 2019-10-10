namespace DICT_Property_Management_System
{
    partial class Property_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Property_Employee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblEmployee = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picEmp = new System.Windows.Forms.GroupBox();
            this.btnEmVLE = new System.Windows.Forms.Button();
            this.lblCont = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbEmp = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblJobT = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.picEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 59);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(62, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Property Employees";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 59);
            this.panel1.TabIndex = 5;
            // 
            // tblEmployee
            // 
            this.tblEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.tblEmployee.FullRowSelect = true;
            this.tblEmployee.GridLines = true;
            this.tblEmployee.HideSelection = false;
            this.tblEmployee.Location = new System.Drawing.Point(12, 65);
            this.tblEmployee.Name = "tblEmployee";
            this.tblEmployee.Size = new System.Drawing.Size(316, 309);
            this.tblEmployee.TabIndex = 6;
            this.tblEmployee.UseCompatibleStateImageBehavior = false;
            this.tblEmployee.View = System.Windows.Forms.View.Details;
            this.tblEmployee.SelectedIndexChanged += new System.EventHandler(this.tblEmployee_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Personnel ID";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 200;
            // 
            // picEmp
            // 
            this.picEmp.BackColor = System.Drawing.Color.SteelBlue;
            this.picEmp.Controls.Add(this.lblDept);
            this.picEmp.Controls.Add(this.label7);
            this.picEmp.Controls.Add(this.lblJobT);
            this.picEmp.Controls.Add(this.label5);
            this.picEmp.Controls.Add(this.btnEmVLE);
            this.picEmp.Controls.Add(this.lblCont);
            this.picEmp.Controls.Add(this.lblEmail);
            this.picEmp.Controls.Add(this.lblName);
            this.picEmp.Controls.Add(this.label4);
            this.picEmp.Controls.Add(this.label3);
            this.picEmp.Controls.Add(this.label2);
            this.picEmp.Controls.Add(this.pbEmp);
            this.picEmp.Location = new System.Drawing.Point(334, 65);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(619, 355);
            this.picEmp.TabIndex = 7;
            this.picEmp.TabStop = false;
            this.picEmp.Text = "Employee Details";
            // 
            // btnEmVLE
            // 
            this.btnEmVLE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmVLE.Location = new System.Drawing.Point(41, 279);
            this.btnEmVLE.Name = "btnEmVLE";
            this.btnEmVLE.Size = new System.Drawing.Size(151, 29);
            this.btnEmVLE.TabIndex = 12;
            this.btnEmVLE.Text = "View Linked Entries";
            this.btnEmVLE.UseVisualStyleBackColor = true;
            this.btnEmVLE.Click += new System.EventHandler(this.btnEmVLE_Click);
            // 
            // lblCont
            // 
            this.lblCont.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.Location = new System.Drawing.Point(228, 115);
            this.lblCont.Name = "lblCont";
            this.lblCont.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCont.Size = new System.Drawing.Size(375, 26);
            this.lblCont.TabIndex = 6;
            this.lblCont.Text = "?";
            this.lblCont.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(228, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmail.Size = new System.Drawing.Size(375, 26);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "?";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(228, 49);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(375, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "?";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // pbEmp
            // 
            this.pbEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEmp.BackgroundImage")));
            this.pbEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmp.InitialImage = null;
            this.pbEmp.Location = new System.Drawing.Point(11, 62);
            this.pbEmp.Name = "pbEmp";
            this.pbEmp.Size = new System.Drawing.Size(211, 211);
            this.pbEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmp.TabIndex = 0;
            this.pbEmp.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(119, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 40);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Employee";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(225, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Job Title:";
            // 
            // lblJobT
            // 
            this.lblJobT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobT.Location = new System.Drawing.Point(228, 247);
            this.lblJobT.Name = "lblJobT";
            this.lblJobT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblJobT.Size = new System.Drawing.Size(375, 26);
            this.lblJobT.TabIndex = 14;
            this.lblJobT.Text = "?";
            this.lblJobT.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblDept
            // 
            this.lblDept.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(228, 313);
            this.lblDept.Name = "lblDept";
            this.lblDept.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDept.Size = new System.Drawing.Size(375, 26);
            this.lblDept.TabIndex = 16;
            this.lblDept.Text = "?";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Department:";
            // 
            // Property_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(949, 435);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picEmp);
            this.Controls.Add(this.tblEmployee);
            this.Controls.Add(this.panel1);
            this.Name = "Property_Employee";
            this.Text = "Property_Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.picEmp.ResumeLayout(false);
            this.picEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView tblEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox picEmp;
        private System.Windows.Forms.PictureBox pbEmp;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEmVLE;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblJobT;
        private System.Windows.Forms.Label label5;
    }
}