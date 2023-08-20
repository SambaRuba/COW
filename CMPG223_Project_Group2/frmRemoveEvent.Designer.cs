namespace CMPG223_Project_Group2
{
    partial class frmRemoveEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveEvent));
            this.dgEvent = new System.Windows.Forms.DataGridView();
            this.lblEventID = new System.Windows.Forms.Label();
            this.cbEventID = new System.Windows.Forms.ComboBox();
            this.btnRemoveEvent = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbHelp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEvent
            // 
            this.dgEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvent.Location = new System.Drawing.Point(65, 99);
            this.dgEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgEvent.Name = "dgEvent";
            this.dgEvent.RowHeadersWidth = 51;
            this.dgEvent.RowTemplate.Height = 24;
            this.dgEvent.Size = new System.Drawing.Size(667, 171);
            this.dgEvent.TabIndex = 2;
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(276, 302);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(101, 16);
            this.lblEventID.TabIndex = 3;
            this.lblEventID.Text = "Select Event ID:";
            // 
            // cbEventID
            // 
            this.cbEventID.FormattingEnabled = true;
            this.cbEventID.Location = new System.Drawing.Point(398, 299);
            this.cbEventID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEventID.Name = "cbEventID";
            this.cbEventID.Size = new System.Drawing.Size(100, 24);
            this.cbEventID.TabIndex = 4;
            // 
            // btnRemoveEvent
            // 
            this.btnRemoveEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEvent.Location = new System.Drawing.Point(315, 383);
            this.btnRemoveEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEvent.Name = "btnRemoveEvent";
            this.btnRemoveEvent.Size = new System.Drawing.Size(183, 46);
            this.btnRemoveEvent.TabIndex = 5;
            this.btnRemoveEvent.Text = "Remove Event";
            this.btnRemoveEvent.UseVisualStyleBackColor = true;
            this.btnRemoveEvent.Click += new System.EventHandler(this.btnRemoveEvent_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(160, 52);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(217, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Limit Search by current event name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(398, 49);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(510, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Always select the desired event\'s ID before clicking the button.");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(597, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Here you can search for any event by its name.");
            // 
            // cbHelp
            // 
            this.cbHelp.AutoSize = true;
            this.cbHelp.Location = new System.Drawing.Point(730, 12);
            this.cbHelp.Name = "cbHelp";
            this.cbHelp.Size = new System.Drawing.Size(58, 20);
            this.cbHelp.TabIndex = 9;
            this.cbHelp.Text = "Help";
            this.cbHelp.UseVisualStyleBackColor = true;
            this.cbHelp.CheckedChanged += new System.EventHandler(this.cbHelp_CheckedChanged);
            // 
            // frmRemoveEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbHelp);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRemoveEvent);
            this.Controls.Add(this.cbEventID);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.dgEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRemoveEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Event";
            this.Load += new System.EventHandler(this.frmRemoveEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEvent;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.ComboBox cbEventID;
        private System.Windows.Forms.Button btnRemoveEvent;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbHelp;
    }
}