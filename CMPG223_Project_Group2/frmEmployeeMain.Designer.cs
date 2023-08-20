namespace CMPG223_Project_Group2
{
    partial class frmEmployeeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scanEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanAttendeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanEmployeesToolStripMenuItem,
            this.scanAttendeesToolStripMenuItem,
            this.captureEventToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(998, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scanEmployeesToolStripMenuItem
            // 
            this.scanEmployeesToolStripMenuItem.Name = "scanEmployeesToolStripMenuItem";
            this.scanEmployeesToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.scanEmployeesToolStripMenuItem.Text = "Scan Employees";
            this.scanEmployeesToolStripMenuItem.Click += new System.EventHandler(this.scanEmployeesToolStripMenuItem_Click);
            // 
            // scanAttendeesToolStripMenuItem
            // 
            this.scanAttendeesToolStripMenuItem.Name = "scanAttendeesToolStripMenuItem";
            this.scanAttendeesToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.scanAttendeesToolStripMenuItem.Text = "Scan Attendees";
            this.scanAttendeesToolStripMenuItem.Click += new System.EventHandler(this.scanAttendeesToolStripMenuItem_Click);
            // 
            // captureEventToolStripMenuItem
            // 
            this.captureEventToolStripMenuItem.Name = "captureEventToolStripMenuItem";
            this.captureEventToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.captureEventToolStripMenuItem.Text = "Capture Event";
            this.captureEventToolStripMenuItem.Click += new System.EventHandler(this.captureEventToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(943, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "From this menu you will Scan both Employees and Attendees at the current event. \r" +
        "\n(click this icon for more help)");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 0;
            // 
            // frmEmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 598);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmployeeMain";
            this.Text = "Employee Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployeeMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scanEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanAttendeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}