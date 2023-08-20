namespace CMPG223_Project_Group2
{
    partial class frmRemoveAttendee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveAttendee));
            this.dgAtt = new System.Windows.Forms.DataGridView();
            this.lblAttID = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.cbAttID = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtAttFName = new System.Windows.Forms.TextBox();
            this.btnRemoveAtt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cbHelp = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAtt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAtt
            // 
            this.dgAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtt.Location = new System.Drawing.Point(31, 97);
            this.dgAtt.Name = "dgAtt";
            this.dgAtt.RowHeadersWidth = 51;
            this.dgAtt.RowTemplate.Height = 24;
            this.dgAtt.Size = new System.Drawing.Size(709, 150);
            this.dgAtt.TabIndex = 0;
            // 
            // lblAttID
            // 
            this.lblAttID.AutoSize = true;
            this.lblAttID.Location = new System.Drawing.Point(14, 45);
            this.lblAttID.Name = "lblAttID";
            this.lblAttID.Size = new System.Drawing.Size(80, 16);
            this.lblAttID.TabIndex = 1;
            this.lblAttID.Text = "Attendee ID:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(229, 479);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(122, 16);
            this.lblErrorMessage.TabIndex = 2;
            this.lblErrorMessage.Text = "lblErrorMessage";
            // 
            // cbAttID
            // 
            this.cbAttID.FormattingEnabled = true;
            this.cbAttID.Location = new System.Drawing.Point(126, 42);
            this.cbAttID.Name = "cbAttID";
            this.cbAttID.Size = new System.Drawing.Size(121, 24);
            this.cbAttID.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(142, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(196, 25);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search by first name:";
            // 
            // txtAttFName
            // 
            this.txtAttFName.Location = new System.Drawing.Point(393, 34);
            this.txtAttFName.Name = "txtAttFName";
            this.txtAttFName.Size = new System.Drawing.Size(141, 22);
            this.txtAttFName.TabIndex = 5;
            this.txtAttFName.TextChanged += new System.EventHandler(this.txtAttFName_TextChanged);
            // 
            // btnRemoveAtt
            // 
            this.btnRemoveAtt.Location = new System.Drawing.Point(52, 101);
            this.btnRemoveAtt.Name = "btnRemoveAtt";
            this.btnRemoveAtt.Size = new System.Drawing.Size(207, 58);
            this.btnRemoveAtt.TabIndex = 7;
            this.btnRemoveAtt.Text = "Remove Attendee";
            this.btnRemoveAtt.UseVisualStyleBackColor = true;
            this.btnRemoveAtt.Click += new System.EventHandler(this.btnRemoveAtt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lblAttID);
            this.groupBox1.Controls.Add(this.btnRemoveAtt);
            this.groupBox1.Controls.Add(this.cbAttID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(232, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 182);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(256, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Make sure you select the attendee\'s ID before clicking the button");
            // 
            // cbHelp
            // 
            this.cbHelp.AutoSize = true;
            this.cbHelp.Location = new System.Drawing.Point(718, 12);
            this.cbHelp.Name = "cbHelp";
            this.cbHelp.Size = new System.Drawing.Size(58, 20);
            this.cbHelp.TabIndex = 9;
            this.cbHelp.Text = "Help";
            this.cbHelp.UseVisualStyleBackColor = true;
            this.cbHelp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(540, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Here you can search through all attendees by name");
            // 
            // frmRemoveAttendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAttFName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.dgAtt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveAttendee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Attendee";
            this.Load += new System.EventHandler(this.frmRemoveAttendee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAtt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAtt;
        private System.Windows.Forms.Label lblAttID;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ComboBox cbAttID;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtAttFName;
        private System.Windows.Forms.Button btnRemoveAtt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}