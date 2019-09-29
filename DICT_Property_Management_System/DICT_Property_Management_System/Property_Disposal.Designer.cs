namespace DICT_Property_Management_System
{
    partial class Property_Disposal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Property_Disposal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblDisposal = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDTransfer = new System.Windows.Forms.Button();
            this.btnDEdit = new System.Windows.Forms.Button();
            this.lblMeth = new System.Windows.Forms.Label();
            this.lblDDate = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
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
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disposed Property";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 59);
            this.panel1.TabIndex = 4;
            // 
            // tblDisposal
            // 
            this.tblDisposal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader11});
            this.tblDisposal.FullRowSelect = true;
            this.tblDisposal.GridLines = true;
            this.tblDisposal.Location = new System.Drawing.Point(9, 66);
            this.tblDisposal.MultiSelect = false;
            this.tblDisposal.Name = "tblDisposal";
            this.tblDisposal.Size = new System.Drawing.Size(294, 223);
            this.tblDisposal.TabIndex = 5;
            this.tblDisposal.UseCompatibleStateImageBehavior = false;
            this.tblDisposal.View = System.Windows.Forms.View.Details;
            this.tblDisposal.SelectedIndexChanged += new System.EventHandler(this.tblDisposal_SelectedIndexChanged);
            this.tblDisposal.DoubleClick += new System.EventHandler(this.tblDisposal_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Diposal No.";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Inventory No.";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Name";
            this.columnHeader11.Width = 126;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnDTransfer);
            this.groupBox1.Controls.Add(this.btnDEdit);
            this.groupBox1.Controls.Add(this.lblMeth);
            this.groupBox1.Controls.Add(this.lblDDate);
            this.groupBox1.Controls.Add(this.txtRem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(309, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 223);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disposal Info";
            // 
            // btnDTransfer
            // 
            this.btnDTransfer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDTransfer.Location = new System.Drawing.Point(192, 176);
            this.btnDTransfer.Name = "btnDTransfer";
            this.btnDTransfer.Size = new System.Drawing.Size(95, 31);
            this.btnDTransfer.TabIndex = 8;
            this.btnDTransfer.Text = "TRANSFER";
            this.btnDTransfer.UseVisualStyleBackColor = true;
            this.btnDTransfer.Click += new System.EventHandler(this.btnDTransfer_Click);
            // 
            // btnDEdit
            // 
            this.btnDEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEdit.Location = new System.Drawing.Point(91, 176);
            this.btnDEdit.Name = "btnDEdit";
            this.btnDEdit.Size = new System.Drawing.Size(95, 31);
            this.btnDEdit.TabIndex = 7;
            this.btnDEdit.Text = "EDIT";
            this.btnDEdit.UseVisualStyleBackColor = true;
            this.btnDEdit.Click += new System.EventHandler(this.btnDEdit_Click);
            // 
            // lblMeth
            // 
            this.lblMeth.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeth.Location = new System.Drawing.Point(173, 42);
            this.lblMeth.Name = "lblMeth";
            this.lblMeth.Size = new System.Drawing.Size(199, 22);
            this.lblMeth.TabIndex = 41;
            this.lblMeth.Text = "?";
            this.lblMeth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDDate
            // 
            this.lblDDate.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDate.Location = new System.Drawing.Point(173, 20);
            this.lblDDate.Name = "lblDDate";
            this.lblDDate.Size = new System.Drawing.Size(199, 22);
            this.lblDDate.TabIndex = 39;
            this.lblDDate.Text = "?";
            this.lblDDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDDate.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(169, 72);
            this.txtRem.Multiline = true;
            this.txtRem.Name = "txtRem";
            this.txtRem.ReadOnly = true;
            this.txtRem.Size = new System.Drawing.Size(200, 67);
            this.txtRem.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Disposal Remark: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Disposal Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Disposal Method:";
            // 
            // Property_Disposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(684, 295);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblDisposal);
            this.Controls.Add(this.panel1);
            this.Name = "Property_Disposal";
            this.Text = "Property_Disposal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView tblDisposal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDDate;
        private System.Windows.Forms.Label lblMeth;
        private System.Windows.Forms.Button btnDTransfer;
        private System.Windows.Forms.Button btnDEdit;
    }
}