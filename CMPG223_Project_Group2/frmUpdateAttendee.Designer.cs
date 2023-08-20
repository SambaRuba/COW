namespace CMPG223_Project_Group2
{
    partial class frmUpdateAttendee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateAttendee));
            this.dgAtt = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblUpdateAttLName = new System.Windows.Forms.Label();
            this.lblUpdateAttEmail = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtUpdateAttLName = new System.Windows.Forms.TextBox();
            this.txtUpdateAttEmail = new System.Windows.Forms.TextBox();
            this.lblAttID = new System.Windows.Forms.Label();
            this.cbAttID = new System.Windows.Forms.ComboBox();
            this.btnUppAttLName = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnUpAttEmail = new System.Windows.Forms.Button();
            this.cbHelp = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAtt
            // 
            this.dgAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtt.Location = new System.Drawing.Point(12, 114);
            this.dgAtt.Name = "dgAtt";
            this.dgAtt.RowHeadersWidth = 51;
            this.dgAtt.RowTemplate.Height = 24;
            this.dgAtt.Size = new System.Drawing.Size(758, 150);
            this.dgAtt.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(129, 50);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(196, 25);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search by first name:";
            // 
            // lblUpdateAttLName
            // 
            this.lblUpdateAttLName.AutoSize = true;
            this.lblUpdateAttLName.Location = new System.Drawing.Point(61, 387);
            this.lblUpdateAttLName.Name = "lblUpdateAttLName";
            this.lblUpdateAttLName.Size = new System.Drawing.Size(131, 16);
            this.lblUpdateAttLName.TabIndex = 2;
            this.lblUpdateAttLName.Text = "Updated Last Name:";
            // 
            // lblUpdateAttEmail
            // 
            this.lblUpdateAttEmail.AutoSize = true;
            this.lblUpdateAttEmail.Location = new System.Drawing.Point(61, 452);
            this.lblUpdateAttEmail.Name = "lblUpdateAttEmail";
            this.lblUpdateAttEmail.Size = new System.Drawing.Size(100, 16);
            this.lblUpdateAttEmail.TabIndex = 3;
            this.lblUpdateAttEmail.Text = "Updated Email:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(392, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtUpdateAttLName
            // 
            this.txtUpdateAttLName.Location = new System.Drawing.Point(212, 387);
            this.txtUpdateAttLName.Name = "txtUpdateAttLName";
            this.txtUpdateAttLName.Size = new System.Drawing.Size(135, 22);
            this.txtUpdateAttLName.TabIndex = 3;
            // 
            // txtUpdateAttEmail
            // 
            this.txtUpdateAttEmail.Location = new System.Drawing.Point(212, 452);
            this.txtUpdateAttEmail.Name = "txtUpdateAttEmail";
            this.txtUpdateAttEmail.Size = new System.Drawing.Size(135, 22);
            this.txtUpdateAttEmail.TabIndex = 4;
            // 
            // lblAttID
            // 
            this.lblAttID.AutoSize = true;
            this.lblAttID.Location = new System.Drawing.Point(186, 294);
            this.lblAttID.Name = "lblAttID";
            this.lblAttID.Size = new System.Drawing.Size(139, 16);
            this.lblAttID.TabIndex = 9;
            this.lblAttID.Text = "Select an Attendee ID:";
            // 
            // cbAttID
            // 
            this.cbAttID.FormattingEnabled = true;
            this.cbAttID.Location = new System.Drawing.Point(378, 291);
            this.cbAttID.Name = "cbAttID";
            this.cbAttID.Size = new System.Drawing.Size(121, 24);
            this.cbAttID.TabIndex = 2;
            // 
            // btnUppAttLName
            // 
            this.btnUppAttLName.Location = new System.Drawing.Point(407, 381);
            this.btnUppAttLName.Name = "btnUppAttLName";
            this.btnUppAttLName.Size = new System.Drawing.Size(222, 34);
            this.btnUppAttLName.TabIndex = 11;
            this.btnUppAttLName.Text = "Update Attendee Last Name";
            this.btnUppAttLName.UseVisualStyleBackColor = true;
            this.btnUppAttLName.Click += new System.EventHandler(this.btnUppAttLName_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(12, 525);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(122, 16);
            this.lblErrorMessage.TabIndex = 12;
            this.lblErrorMessage.Text = "lblErrorMessage";
            // 
            // btnUpAttEmail
            // 
            this.btnUpAttEmail.Location = new System.Drawing.Point(407, 448);
            this.btnUpAttEmail.Name = "btnUpAttEmail";
            this.btnUpAttEmail.Size = new System.Drawing.Size(222, 30);
            this.btnUpAttEmail.TabIndex = 13;
            this.btnUpAttEmail.Text = "Update Attendee Email";
            this.btnUpAttEmail.UseVisualStyleBackColor = true;
            this.btnUpAttEmail.Click += new System.EventHandler(this.btnUpAttEmail_Click);
            // 
            // cbHelp
            // 
            this.cbHelp.AutoSize = true;
            this.cbHelp.Location = new System.Drawing.Point(730, 12);
            this.cbHelp.Name = "cbHelp";
            this.cbHelp.Size = new System.Drawing.Size(58, 20);
            this.cbHelp.TabIndex = 14;
            this.cbHelp.Text = "Help";
            this.cbHelp.UseVisualStyleBackColor = true;
            this.cbHelp.CheckedChanged += new System.EventHandler(this.cbHelp_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(581, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Here you can search for any attendee by first name.");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(353, 444);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Make sure you\'ve correctly entered the attendee\'s new email address.");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(353, 378);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Make sure you fill in the attendee\'s new last name before updating.");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(510, 283);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Always pick the attendee\'s ID before updating");
            // 
            // frmUpdateAttendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbHelp);
            this.Controls.Add(this.btnUpAttEmail);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnUppAttLName);
            this.Controls.Add(this.cbAttID);
            this.Controls.Add(this.lblAttID);
            this.Controls.Add(this.txtUpdateAttEmail);
            this.Controls.Add(this.txtUpdateAttLName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUpdateAttEmail);
            this.Controls.Add(this.lblUpdateAttLName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgAtt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateAttendee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Attendee";
            this.Load += new System.EventHandler(this.frmUpdateAttendee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAtt;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblUpdateAttLName;
        private System.Windows.Forms.Label lblUpdateAttEmail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtUpdateAttLName;
        private System.Windows.Forms.TextBox txtUpdateAttEmail;
        private System.Windows.Forms.Label lblAttID;
        private System.Windows.Forms.ComboBox cbAttID;
        private System.Windows.Forms.Button btnUppAttLName;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnUpAttEmail;
        private System.Windows.Forms.CheckBox cbHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}