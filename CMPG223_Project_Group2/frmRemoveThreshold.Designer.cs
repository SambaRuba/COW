namespace CMPG223_Project_Group2
{
    partial class frmRemoveThreshold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveThreshold));
            this.dgRemoveThresh = new System.Windows.Forms.DataGridView();
            this.lblThresID = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.cbThresID = new System.Windows.Forms.ComboBox();
            this.btnRemoveThres = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHelp = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgRemoveThresh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRemoveThresh
            // 
            this.dgRemoveThresh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRemoveThresh.Location = new System.Drawing.Point(29, 90);
            this.dgRemoveThresh.Name = "dgRemoveThresh";
            this.dgRemoveThresh.RowHeadersWidth = 51;
            this.dgRemoveThresh.RowTemplate.Height = 24;
            this.dgRemoveThresh.Size = new System.Drawing.Size(730, 150);
            this.dgRemoveThresh.TabIndex = 0;
            // 
            // lblThresID
            // 
            this.lblThresID.AutoSize = true;
            this.lblThresID.Location = new System.Drawing.Point(246, 272);
            this.lblThresID.Name = "lblThresID";
            this.lblThresID.Size = new System.Drawing.Size(87, 16);
            this.lblThresID.TabIndex = 1;
            this.lblThresID.Text = "Threshold ID:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(12, 451);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(122, 16);
            this.lblErrorMessage.TabIndex = 2;
            this.lblErrorMessage.Text = "lblErrorMessage";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbThresID
            // 
            this.cbThresID.FormattingEnabled = true;
            this.cbThresID.Location = new System.Drawing.Point(358, 269);
            this.cbThresID.Name = "cbThresID";
            this.cbThresID.Size = new System.Drawing.Size(121, 24);
            this.cbThresID.TabIndex = 3;
            // 
            // btnRemoveThres
            // 
            this.btnRemoveThres.Location = new System.Drawing.Point(290, 349);
            this.btnRemoveThres.Name = "btnRemoveThres";
            this.btnRemoveThres.Size = new System.Drawing.Size(200, 50);
            this.btnRemoveThres.TabIndex = 4;
            this.btnRemoveThres.Text = "Remove Threshold";
            this.btnRemoveThres.UseVisualStyleBackColor = true;
            this.btnRemoveThres.Click += new System.EventHandler(this.btnRemoveThres_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbHelp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 65);
            this.panel1.TabIndex = 5;
            // 
            // cbHelp
            // 
            this.cbHelp.AutoSize = true;
            this.cbHelp.Location = new System.Drawing.Point(732, 11);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-2, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 51);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(490, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Always select the corresponding threshold ID before clicking the button.");
            // 
            // frmRemoveThreshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoveThres);
            this.Controls.Add(this.cbThresID);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblThresID);
            this.Controls.Add(this.dgRemoveThresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveThreshold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove a Threshold";
            this.Load += new System.EventHandler(this.frmRemoveThreshold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRemoveThresh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRemoveThresh;
        private System.Windows.Forms.Label lblThresID;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ComboBox cbThresID;
        private System.Windows.Forms.Button btnRemoveThres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}