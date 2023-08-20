namespace CMPG223_Project_Group2
{
    partial class frmScanRegisteredAttendee
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
            this.lblAttTemp = new System.Windows.Forms.Label();
            this.lblAttStatus = new System.Windows.Forms.Label();
            this.btnScanAtt = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.txtAttTemp = new System.Windows.Forms.TextBox();
            this.cbAttStatus = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAttID = new System.Windows.Forms.Label();
            this.cbAttID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttTemp
            // 
            this.lblAttTemp.AutoSize = true;
            this.lblAttTemp.Location = new System.Drawing.Point(21, 318);
            this.lblAttTemp.Name = "lblAttTemp";
            this.lblAttTemp.Size = new System.Drawing.Size(145, 16);
            this.lblAttTemp.TabIndex = 0;
            this.lblAttTemp.Text = "Attendee Temperature:";
            // 
            // lblAttStatus
            // 
            this.lblAttStatus.AutoSize = true;
            this.lblAttStatus.Location = new System.Drawing.Point(24, 370);
            this.lblAttStatus.Name = "lblAttStatus";
            this.lblAttStatus.Size = new System.Drawing.Size(104, 16);
            this.lblAttStatus.TabIndex = 1;
            this.lblAttStatus.Text = "Attendee Status:";
            // 
            // btnScanAtt
            // 
            this.btnScanAtt.Location = new System.Drawing.Point(85, 429);
            this.btnScanAtt.Name = "btnScanAtt";
            this.btnScanAtt.Size = new System.Drawing.Size(163, 44);
            this.btnScanAtt.TabIndex = 2;
            this.btnScanAtt.Text = "Scan Attendee";
            this.btnScanAtt.UseVisualStyleBackColor = true;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(116, 507);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(107, 16);
            this.lblErrorMessage.TabIndex = 3;
            this.lblErrorMessage.Text = "lblErrorMessage";
            // 
            // txtAttTemp
            // 
            this.txtAttTemp.Location = new System.Drawing.Point(197, 318);
            this.txtAttTemp.Name = "txtAttTemp";
            this.txtAttTemp.Size = new System.Drawing.Size(100, 22);
            this.txtAttTemp.TabIndex = 4;
            // 
            // cbAttStatus
            // 
            this.cbAttStatus.FormattingEnabled = true;
            this.cbAttStatus.Location = new System.Drawing.Point(197, 362);
            this.cbAttStatus.Name = "cbAttStatus";
            this.cbAttStatus.Size = new System.Drawing.Size(121, 24);
            this.cbAttStatus.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 188);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(131, 16);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search by first name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(197, 188);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 8;
            // 
            // lblAttID
            // 
            this.lblAttID.AutoSize = true;
            this.lblAttID.Location = new System.Drawing.Point(24, 275);
            this.lblAttID.Name = "lblAttID";
            this.lblAttID.Size = new System.Drawing.Size(80, 16);
            this.lblAttID.TabIndex = 9;
            this.lblAttID.Text = "Attendee ID:";
            // 
            // cbAttID
            // 
            this.cbAttID.FormattingEnabled = true;
            this.cbAttID.Location = new System.Drawing.Point(197, 266);
            this.cbAttID.Name = "cbAttID";
            this.cbAttID.Size = new System.Drawing.Size(121, 24);
            this.cbAttID.TabIndex = 10;
            // 
            // frmScanRegisteredAttendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 551);
            this.Controls.Add(this.cbAttID);
            this.Controls.Add(this.lblAttID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbAttStatus);
            this.Controls.Add(this.txtAttTemp);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnScanAtt);
            this.Controls.Add(this.lblAttStatus);
            this.Controls.Add(this.lblAttTemp);
            this.Name = "frmScanRegisteredAttendee";
            this.Text = "frmScanRegisteredAttendee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttTemp;
        private System.Windows.Forms.Label lblAttStatus;
        private System.Windows.Forms.Button btnScanAtt;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox txtAttTemp;
        private System.Windows.Forms.ComboBox cbAttStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAttID;
        private System.Windows.Forms.ComboBox cbAttID;
    }
}