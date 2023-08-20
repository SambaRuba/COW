namespace CMPG223_Project_Group2
{
    partial class frmUpdateEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateEmployee));
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblUpdateLName = new System.Windows.Forms.Label();
            this.lblUpdatePay = new System.Windows.Forms.Label();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.txtUpdatePay = new System.Windows.Forms.TextBox();
            this.btnUpdateLName = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbEmpID = new System.Windows.Forms.ComboBox();
            this.btnUpdatePay = new System.Windows.Forms.Button();
            this.gbLName = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblE_LName = new System.Windows.Forms.Label();
            this.gbPay = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblE_Pay = new System.Windows.Forms.Label();
            this.lblE_ID = new System.Windows.Forms.Label();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblE_Email = new System.Windows.Forms.Label();
            this.btnUpdate_Email = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbHelp = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.gbLName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gbEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(135, 122);
            this.dgvEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersWidth = 51;
            this.dgvEmp.RowTemplate.Height = 24;
            this.dgvEmp.Size = new System.Drawing.Size(756, 166);
            this.dgvEmp.TabIndex = 0;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(407, 299);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(88, 16);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblUpdateLName
            // 
            this.lblUpdateLName.AutoSize = true;
            this.lblUpdateLName.Location = new System.Drawing.Point(3, 31);
            this.lblUpdateLName.Name = "lblUpdateLName";
            this.lblUpdateLName.Size = new System.Drawing.Size(111, 17);
            this.lblUpdateLName.TabIndex = 2;
            this.lblUpdateLName.Text = "New Last Name:";
            // 
            // lblUpdatePay
            // 
            this.lblUpdatePay.AutoSize = true;
            this.lblUpdatePay.Location = new System.Drawing.Point(7, 34);
            this.lblUpdatePay.Name = "lblUpdatePay";
            this.lblUpdatePay.Size = new System.Drawing.Size(101, 17);
            this.lblUpdatePay.TabIndex = 3;
            this.lblUpdatePay.Text = "New Pay Rate:";
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.Location = new System.Drawing.Point(120, 28);
            this.txtUpdateLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(100, 23);
            this.txtUpdateLName.TabIndex = 5;
            // 
            // txtUpdatePay
            // 
            this.txtUpdatePay.Location = new System.Drawing.Point(114, 31);
            this.txtUpdatePay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdatePay.Name = "txtUpdatePay";
            this.txtUpdatePay.Size = new System.Drawing.Size(100, 23);
            this.txtUpdatePay.TabIndex = 6;
            // 
            // btnUpdateLName
            // 
            this.btnUpdateLName.Location = new System.Drawing.Point(11, 89);
            this.btnUpdateLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateLName.Name = "btnUpdateLName";
            this.btnUpdateLName.Size = new System.Drawing.Size(136, 48);
            this.btnUpdateLName.TabIndex = 7;
            this.btnUpdateLName.Text = "Update Employee Last Name";
            this.btnUpdateLName.UseVisualStyleBackColor = true;
            this.btnUpdateLName.Click += new System.EventHandler(this.btnUpdateLName_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(337, 81);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(131, 16);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search by first name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(505, 81);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(141, 22);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbEmpID
            // 
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.Location = new System.Drawing.Point(543, 295);
            this.cbEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.Size = new System.Drawing.Size(100, 24);
            this.cbEmpID.TabIndex = 11;
            // 
            // btnUpdatePay
            // 
            this.btnUpdatePay.Location = new System.Drawing.Point(18, 89);
            this.btnUpdatePay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdatePay.Name = "btnUpdatePay";
            this.btnUpdatePay.Size = new System.Drawing.Size(149, 48);
            this.btnUpdatePay.TabIndex = 12;
            this.btnUpdatePay.Text = "Update Pay Rate";
            this.btnUpdatePay.UseVisualStyleBackColor = true;
            this.btnUpdatePay.Click += new System.EventHandler(this.btnUpdatePay_Click);
            // 
            // gbLName
            // 
            this.gbLName.BackColor = System.Drawing.Color.White;
            this.gbLName.Controls.Add(this.pictureBox3);
            this.gbLName.Controls.Add(this.lblE_LName);
            this.gbLName.Controls.Add(this.btnUpdateLName);
            this.gbLName.Controls.Add(this.lblUpdateLName);
            this.gbLName.Controls.Add(this.txtUpdateLName);
            this.gbLName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLName.Location = new System.Drawing.Point(47, 354);
            this.gbLName.Margin = new System.Windows.Forms.Padding(4);
            this.gbLName.Name = "gbLName";
            this.gbLName.Padding = new System.Windows.Forms.Padding(4);
            this.gbLName.Size = new System.Drawing.Size(261, 161);
            this.gbLName.TabIndex = 13;
            this.gbLName.TabStop = false;
            this.gbLName.Text = "Update Last Name";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(161, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Be sure to enter the employee\'s new last name here.");
            // 
            // lblE_LName
            // 
            this.lblE_LName.AutoSize = true;
            this.lblE_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE_LName.Location = new System.Drawing.Point(8, 73);
            this.lblE_LName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE_LName.Name = "lblE_LName";
            this.lblE_LName.Size = new System.Drawing.Size(0, 17);
            this.lblE_LName.TabIndex = 14;
            // 
            // gbPay
            // 
            this.gbPay.BackColor = System.Drawing.Color.White;
            this.gbPay.Controls.Add(this.pictureBox5);
            this.gbPay.Controls.Add(this.lblE_Pay);
            this.gbPay.Controls.Add(this.btnUpdatePay);
            this.gbPay.Controls.Add(this.lblUpdatePay);
            this.gbPay.Controls.Add(this.txtUpdatePay);
            this.gbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPay.ForeColor = System.Drawing.Color.Black;
            this.gbPay.Location = new System.Drawing.Point(725, 354);
            this.gbPay.Margin = new System.Windows.Forms.Padding(4);
            this.gbPay.Name = "gbPay";
            this.gbPay.Padding = new System.Windows.Forms.Padding(4);
            this.gbPay.Size = new System.Drawing.Size(252, 161);
            this.gbPay.TabIndex = 14;
            this.gbPay.TabStop = false;
            this.gbPay.Text = "Update Pay Rate";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(174, 96);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Update the employee\'s rate per hour here (use whole numbers, not cents. Ex: 250)." +
        "");
            // 
            // lblE_Pay
            // 
            this.lblE_Pay.AutoSize = true;
            this.lblE_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE_Pay.Location = new System.Drawing.Point(11, 73);
            this.lblE_Pay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE_Pay.Name = "lblE_Pay";
            this.lblE_Pay.Size = new System.Drawing.Size(0, 17);
            this.lblE_Pay.TabIndex = 13;
            // 
            // lblE_ID
            // 
            this.lblE_ID.AutoSize = true;
            this.lblE_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE_ID.Location = new System.Drawing.Point(407, 330);
            this.lblE_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE_ID.Name = "lblE_ID";
            this.lblE_ID.Size = new System.Drawing.Size(0, 17);
            this.lblE_ID.TabIndex = 15;
            // 
            // gbEmail
            // 
            this.gbEmail.BackColor = System.Drawing.Color.White;
            this.gbEmail.Controls.Add(this.pictureBox4);
            this.gbEmail.Controls.Add(this.lblE_Email);
            this.gbEmail.Controls.Add(this.btnUpdate_Email);
            this.gbEmail.Controls.Add(this.label2);
            this.gbEmail.Controls.Add(this.txtEmail);
            this.gbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmail.Location = new System.Drawing.Point(363, 354);
            this.gbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Padding = new System.Windows.Forms.Padding(4);
            this.gbEmail.Size = new System.Drawing.Size(301, 161);
            this.gbEmail.TabIndex = 16;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Update Email";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(188, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Be sure to enter the employee\'s new email address here");
            // 
            // lblE_Email
            // 
            this.lblE_Email.AutoSize = true;
            this.lblE_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE_Email.Location = new System.Drawing.Point(8, 73);
            this.lblE_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE_Email.Name = "lblE_Email";
            this.lblE_Email.Size = new System.Drawing.Size(0, 17);
            this.lblE_Email.TabIndex = 14;
            // 
            // btnUpdate_Email
            // 
            this.btnUpdate_Email.Location = new System.Drawing.Point(15, 89);
            this.btnUpdate_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate_Email.Name = "btnUpdate_Email";
            this.btnUpdate_Email.Size = new System.Drawing.Size(157, 48);
            this.btnUpdate_Email.TabIndex = 7;
            this.btnUpdate_Email.Text = "Update Employee Last Name";
            this.btnUpdate_Email.UseVisualStyleBackColor = true;
            this.btnUpdate_Email.Click += new System.EventHandler(this.btnUpdate_Email_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 31);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbHelp);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 61);
            this.panel2.TabIndex = 52;
            // 
            // cbHelp
            // 
            this.cbHelp.AutoSize = true;
            this.cbHelp.Location = new System.Drawing.Point(946, 11);
            this.cbHelp.Name = "cbHelp";
            this.cbHelp.Size = new System.Drawing.Size(58, 20);
            this.cbHelp.TabIndex = 1;
            this.cbHelp.Text = "Help";
            this.cbHelp.UseVisualStyleBackColor = true;
            this.cbHelp.CheckedChanged += new System.EventHandler(this.cbHelp_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-1, 564);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 61);
            this.panel1.TabIndex = 53;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(653, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Here you can search for any employee by their first name.");
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(647, 290);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Always select the corresponding employee ID before using any of the update button" +
        "s.");
            // 
            // frmUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1017, 623);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbEmail);
            this.Controls.Add(this.lblE_ID);
            this.Controls.Add(this.gbPay);
            this.Controls.Add(this.gbLName);
            this.Controls.Add(this.cbEmpID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.dgvEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Employee";
            this.Load += new System.EventHandler(this.frmUpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.gbLName.ResumeLayout(false);
            this.gbLName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbPay.ResumeLayout(false);
            this.gbPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblUpdateLName;
        private System.Windows.Forms.Label lblUpdatePay;
        private System.Windows.Forms.TextBox txtUpdateLName;
        private System.Windows.Forms.TextBox txtUpdatePay;
        private System.Windows.Forms.Button btnUpdateLName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbEmpID;
        private System.Windows.Forms.Button btnUpdatePay;
        private System.Windows.Forms.GroupBox gbLName;
        private System.Windows.Forms.Label lblE_LName;
        private System.Windows.Forms.GroupBox gbPay;
        private System.Windows.Forms.Label lblE_Pay;
        private System.Windows.Forms.Label lblE_ID;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.Label lblE_Email;
        private System.Windows.Forms.Button btnUpdate_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox cbHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}