namespace DICT_Property_Management_System
{
    partial class PropertyDetails
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
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRcpI = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSigned = new System.Windows.Forms.Label();
            this.lblRcpT = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccPerson = new System.Windows.Forms.Label();
            this.lblAccCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.gbDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetails
            // 
            this.gbDetails.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbDetails.Controls.Add(this.groupBox1);
            this.gbDetails.Controls.Add(this.txtRemarks);
            this.gbDetails.Controls.Add(this.txtDesc);
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Controls.Add(this.lblAccPerson);
            this.gbDetails.Controls.Add(this.lblAccCode);
            this.gbDetails.Controls.Add(this.lblDescription);
            this.gbDetails.Controls.Add(this.lblLocationID);
            this.gbDetails.Controls.Add(this.lblSerialNo);
            this.gbDetails.Controls.Add(this.lblCost);
            this.gbDetails.Controls.Add(this.lblArticle);
            this.gbDetails.Controls.Add(this.lblRemarks);
            this.gbDetails.Controls.Add(this.lblType);
            this.gbDetails.Controls.Add(this.lblUnit);
            this.gbDetails.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(0, 1);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(853, 304);
            this.gbDetails.TabIndex = 0;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Inventory No. : ";
            this.gbDetails.Enter += new System.EventHandler(this.gbDetails_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRcpI);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblSigned);
            this.groupBox1.Controls.Add(this.lblRcpT);
            this.groupBox1.Location = new System.Drawing.Point(620, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 139);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt Details";
            // 
            // lblRcpI
            // 
            this.lblRcpI.AutoSize = true;
            this.lblRcpI.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcpI.Location = new System.Drawing.Point(6, 85);
            this.lblRcpI.Name = "lblRcpI";
            this.lblRcpI.Size = new System.Drawing.Size(146, 25);
            this.lblRcpI.TabIndex = 15;
            this.lblRcpI.Text = "Receipt Issued: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date: ";
            // 
            // lblSigned
            // 
            this.lblSigned.AutoSize = true;
            this.lblSigned.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigned.Location = new System.Drawing.Point(6, 27);
            this.lblSigned.Name = "lblSigned";
            this.lblSigned.Size = new System.Drawing.Size(80, 25);
            this.lblSigned.TabIndex = 13;
            this.lblSigned.Text = "Signed: ";
            // 
            // lblRcpT
            // 
            this.lblRcpT.AutoSize = true;
            this.lblRcpT.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcpT.Location = new System.Drawing.Point(6, 58);
            this.lblRcpT.Name = "lblRcpT";
            this.lblRcpT.Size = new System.Drawing.Size(137, 25);
            this.lblRcpT.TabIndex = 12;
            this.lblRcpT.Text = "Receipt Type: ";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Enabled = false;
            this.txtRemarks.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(392, 156);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.Size = new System.Drawing.Size(222, 80);
            this.txtRemarks.TabIndex = 15;
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(392, 44);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(222, 80);
            this.txtDesc.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 25);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name: ";
            // 
            // lblAccPerson
            // 
            this.lblAccPerson.AutoSize = true;
            this.lblAccPerson.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccPerson.Location = new System.Drawing.Point(6, 223);
            this.lblAccPerson.Name = "lblAccPerson";
            this.lblAccPerson.Size = new System.Drawing.Size(245, 25);
            this.lblAccPerson.TabIndex = 11;
            this.lblAccPerson.Text = "Accountable Personnel ID: ";
            // 
            // lblAccCode
            // 
            this.lblAccCode.AutoSize = true;
            this.lblAccCode.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccCode.Location = new System.Drawing.Point(6, 248);
            this.lblAccCode.Name = "lblAccCode";
            this.lblAccCode.Size = new System.Drawing.Size(142, 25);
            this.lblAccCode.TabIndex = 10;
            this.lblAccCode.Text = "Account Code: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(387, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(121, 25);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description: ";
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationID.Location = new System.Drawing.Point(6, 165);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(125, 25);
            this.lblLocationID.TabIndex = 8;
            this.lblLocationID.Text = "Location ID: ";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNo.Location = new System.Drawing.Point(6, 196);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(159, 25);
            this.lblSerialNo.TabIndex = 7;
            this.lblSerialNo.Text = "Serial/Plate no. : ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(6, 140);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(61, 25);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost: ";
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticle.Location = new System.Drawing.Point(6, 113);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(79, 25);
            this.lblArticle.TabIndex = 4;
            this.lblArticle.Text = "Article: ";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(387, 127);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(98, 25);
            this.lblRemarks.TabIndex = 3;
            this.lblRemarks.Text = "Remarks: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(6, 85);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 25);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type: ";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(6, 54);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(61, 25);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "Unit: ";
            // 
            // PropertyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 275);
            this.Controls.Add(this.gbDetails);
            this.Name = "PropertyDetails";
            this.Text = "Property Details";
            this.Load += new System.EventHandler(this.Property_Inventory_Details_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccPerson;
        private System.Windows.Forms.Label lblAccCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRcpI;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSigned;
        private System.Windows.Forms.Label lblRcpT;
    }
}