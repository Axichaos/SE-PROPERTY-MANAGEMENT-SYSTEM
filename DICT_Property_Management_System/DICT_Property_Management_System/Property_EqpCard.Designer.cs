namespace DICT_Property_Management_System
{
    partial class Property_EqpCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Property_EqpCard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblEqpCard = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnCEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
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
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipment Card";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 59);
            this.panel1.TabIndex = 5;
            // 
            // tblEqpCard
            // 
            this.tblEqpCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.tblEqpCard.FullRowSelect = true;
            this.tblEqpCard.GridLines = true;
            this.tblEqpCard.Location = new System.Drawing.Point(12, 66);
            this.tblEqpCard.MultiSelect = false;
            this.tblEqpCard.Name = "tblEqpCard";
            this.tblEqpCard.Size = new System.Drawing.Size(599, 333);
            this.tblEqpCard.TabIndex = 6;
            this.tblEqpCard.UseCompatibleStateImageBehavior = false;
            this.tblEqpCard.View = System.Windows.Forms.View.Details;
            this.tblEqpCard.SelectedIndexChanged += new System.EventHandler(this.tblEqpCard_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Card ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Card Date";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Card Name";
            this.columnHeader3.Width = 435;
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(290, 405);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(103, 42);
            this.btnCAdd.TabIndex = 7;
            this.btnCAdd.Text = "Create Card";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnCEdit
            // 
            this.btnCEdit.Location = new System.Drawing.Point(399, 405);
            this.btnCEdit.Name = "btnCEdit";
            this.btnCEdit.Size = new System.Drawing.Size(103, 42);
            this.btnCEdit.TabIndex = 8;
            this.btnCEdit.Text = "Edit Card";
            this.btnCEdit.UseVisualStyleBackColor = true;
            this.btnCEdit.Click += new System.EventHandler(this.btnCEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(508, 405);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 42);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete Card";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(181, 405);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(103, 42);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Property_EqpCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCEdit);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.tblEqpCard);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Property_EqpCard";
            this.Text = "Property_EqpCard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView tblEqpCard;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnCEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnView;
    }
}