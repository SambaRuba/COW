
namespace CMPG223_Project_Group2
{
    partial class frmAttendeeReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.cmbEventName = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.attIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attIDDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.attFNameDataGridViewTextBoxColumn,
            this.attLNameDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.lProvinceDataGridViewTextBoxColumn,
            this.lCityDataGridViewTextBoxColumn,
            this.statusDescrDataGridViewTextBoxColumn,
            this.riskDescrDataGridViewTextBoxColumn,
            this.capacityLimitDataGridViewTextBoxColumn,
            this.tempLimitDataGridViewTextBoxColumn,
            this.attTempDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendeesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(983, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbProvince);
            this.groupBox1.Controls.Add(this.cmbEventName);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Province:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Event:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Date:";
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(319, 64);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(147, 28);
            this.cmbProvince.TabIndex = 2;
            // 
            // cmbEventName
            // 
            this.cmbEventName.FormattingEnabled = true;
            this.cmbEventName.Location = new System.Drawing.Point(166, 64);
            this.cmbEventName.Name = "cmbEventName";
            this.cmbEventName.Size = new System.Drawing.Size(147, 28);
            this.cmbEventName.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 64);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(147, 26);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(835, 0);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(136, 41);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(835, 90);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(136, 41);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Print Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attendees Summary Report";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(835, 47);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(136, 41);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter Data";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // attIDDataGridViewTextBoxColumn
            // 
            this.attIDDataGridViewTextBoxColumn.DataPropertyName = "Att_ID";
            this.attIDDataGridViewTextBoxColumn.HeaderText = "Att_ID";
            this.attIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attIDDataGridViewTextBoxColumn.Name = "attIDDataGridViewTextBoxColumn";
            this.attIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "Event_Date";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "Event_Date";
            this.eventDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            this.eventDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // attFNameDataGridViewTextBoxColumn
            // 
            this.attFNameDataGridViewTextBoxColumn.DataPropertyName = "Att_FName";
            this.attFNameDataGridViewTextBoxColumn.HeaderText = "Att_FName";
            this.attFNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attFNameDataGridViewTextBoxColumn.Name = "attFNameDataGridViewTextBoxColumn";
            this.attFNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // attLNameDataGridViewTextBoxColumn
            // 
            this.attLNameDataGridViewTextBoxColumn.DataPropertyName = "Att_LName";
            this.attLNameDataGridViewTextBoxColumn.HeaderText = "Att_LName";
            this.attLNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attLNameDataGridViewTextBoxColumn.Name = "attLNameDataGridViewTextBoxColumn";
            this.attLNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "Event_Name";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "Event_Name";
            this.eventNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            this.eventNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lProvinceDataGridViewTextBoxColumn
            // 
            this.lProvinceDataGridViewTextBoxColumn.DataPropertyName = "LProvince";
            this.lProvinceDataGridViewTextBoxColumn.HeaderText = "LProvince";
            this.lProvinceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lProvinceDataGridViewTextBoxColumn.Name = "lProvinceDataGridViewTextBoxColumn";
            this.lProvinceDataGridViewTextBoxColumn.Width = 150;
            // 
            // lCityDataGridViewTextBoxColumn
            // 
            this.lCityDataGridViewTextBoxColumn.DataPropertyName = "LCity";
            this.lCityDataGridViewTextBoxColumn.HeaderText = "LCity";
            this.lCityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lCityDataGridViewTextBoxColumn.Name = "lCityDataGridViewTextBoxColumn";
            this.lCityDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDescrDataGridViewTextBoxColumn
            // 
            this.statusDescrDataGridViewTextBoxColumn.DataPropertyName = "Status_Descr";
            this.statusDescrDataGridViewTextBoxColumn.HeaderText = "Status_Descr";
            this.statusDescrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDescrDataGridViewTextBoxColumn.Name = "statusDescrDataGridViewTextBoxColumn";
            this.statusDescrDataGridViewTextBoxColumn.Width = 150;
            // 
            // riskDescrDataGridViewTextBoxColumn
            // 
            this.riskDescrDataGridViewTextBoxColumn.DataPropertyName = "Risk_Descr";
            this.riskDescrDataGridViewTextBoxColumn.HeaderText = "Risk_Descr";
            this.riskDescrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.riskDescrDataGridViewTextBoxColumn.Name = "riskDescrDataGridViewTextBoxColumn";
            this.riskDescrDataGridViewTextBoxColumn.Width = 150;
            // 
            // capacityLimitDataGridViewTextBoxColumn
            // 
            this.capacityLimitDataGridViewTextBoxColumn.DataPropertyName = "Capacity_Limit";
            this.capacityLimitDataGridViewTextBoxColumn.HeaderText = "Capacity_Limit";
            this.capacityLimitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.capacityLimitDataGridViewTextBoxColumn.Name = "capacityLimitDataGridViewTextBoxColumn";
            this.capacityLimitDataGridViewTextBoxColumn.Width = 150;
            // 
            // tempLimitDataGridViewTextBoxColumn
            // 
            this.tempLimitDataGridViewTextBoxColumn.DataPropertyName = "Temp_Limit";
            this.tempLimitDataGridViewTextBoxColumn.HeaderText = "Temp_Limit";
            this.tempLimitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tempLimitDataGridViewTextBoxColumn.Name = "tempLimitDataGridViewTextBoxColumn";
            this.tempLimitDataGridViewTextBoxColumn.Width = 150;
            // 
            // attTempDataGridViewTextBoxColumn
            // 
            this.attTempDataGridViewTextBoxColumn.DataPropertyName = "Att_Temp";
            this.attTempDataGridViewTextBoxColumn.HeaderText = "Att_Temp";
            this.attTempDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attTempDataGridViewTextBoxColumn.Name = "attTempDataGridViewTextBoxColumn";
            this.attTempDataGridViewTextBoxColumn.Width = 150;
            // 
            // attendeesBindingSource
            // 
            this.attendeesBindingSource.DataSource = typeof(CMPG223_Project_Group2.Attendees);
            // 
            // frmAttendeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(983, 586);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAttendeeReport";
            this.Text = "frmAttendeeReport";
            this.Load += new System.EventHandler(this.frmAttendeeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbEventName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource attendeesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn attIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskDescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFilter;
    }
}