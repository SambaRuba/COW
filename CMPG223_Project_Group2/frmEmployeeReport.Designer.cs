
namespace CMPG223_Project_Group2
{
    partial class frmEmployeeReport
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
            this.btnDiplay = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbEventName = new System.Windows.Forms.ComboBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPayRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiplay
            // 
            this.btnDiplay.Location = new System.Drawing.Point(883, 1);
            this.btnDiplay.Name = "btnDiplay";
            this.btnDiplay.Size = new System.Drawing.Size(155, 45);
            this.btnDiplay.TabIndex = 0;
            this.btnDiplay.Text = "Display Data";
            this.btnDiplay.UseVisualStyleBackColor = true;
            this.btnDiplay.Click += new System.EventHandler(this.btnDiplay_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(883, 52);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(155, 45);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Filter Data";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(883, 103);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(155, 45);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Data";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.empFNameDataGridViewTextBoxColumn,
            this.empLNameDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.lProvinceDataGridViewTextBoxColumn,
            this.lCityDataGridViewTextBoxColumn,
            this.statusDescrDataGridViewTextBoxColumn,
            this.riskDescrDataGridViewTextBoxColumn,
            this.capacityLimitDataGridViewTextBoxColumn,
            this.tempLimitDataGridViewTextBoxColumn,
            this.empTempDataGridViewTextBoxColumn,
            this.empPayRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 397);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbProvince);
            this.groupBox1.Controls.Add(this.cmbEventName);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(15, 73);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(137, 26);
            this.dateTimePicker.TabIndex = 0;
            // 
            // cmbEventName
            // 
            this.cmbEventName.FormattingEnabled = true;
            this.cmbEventName.Location = new System.Drawing.Point(158, 73);
            this.cmbEventName.Name = "cmbEventName";
            this.cmbEventName.Size = new System.Drawing.Size(138, 28);
            this.cmbEventName.TabIndex = 1;
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(311, 71);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(145, 28);
            this.cmbProvince.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Event:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Province:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee Summary Report";
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "Event_Date";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "Event_Date";
            this.eventDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            this.eventDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // empFNameDataGridViewTextBoxColumn
            // 
            this.empFNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_FName";
            this.empFNameDataGridViewTextBoxColumn.HeaderText = "Emp_FName";
            this.empFNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empFNameDataGridViewTextBoxColumn.Name = "empFNameDataGridViewTextBoxColumn";
            this.empFNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // empLNameDataGridViewTextBoxColumn
            // 
            this.empLNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_LName";
            this.empLNameDataGridViewTextBoxColumn.HeaderText = "Emp_LName";
            this.empLNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empLNameDataGridViewTextBoxColumn.Name = "empLNameDataGridViewTextBoxColumn";
            this.empLNameDataGridViewTextBoxColumn.Width = 150;
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
            // empTempDataGridViewTextBoxColumn
            // 
            this.empTempDataGridViewTextBoxColumn.DataPropertyName = "Emp_Temp";
            this.empTempDataGridViewTextBoxColumn.HeaderText = "Emp_Temp";
            this.empTempDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empTempDataGridViewTextBoxColumn.Name = "empTempDataGridViewTextBoxColumn";
            this.empTempDataGridViewTextBoxColumn.Width = 150;
            // 
            // empPayRateDataGridViewTextBoxColumn
            // 
            this.empPayRateDataGridViewTextBoxColumn.DataPropertyName = "Emp_PayRate";
            this.empPayRateDataGridViewTextBoxColumn.HeaderText = "Emp_PayRate";
            this.empPayRateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empPayRateDataGridViewTextBoxColumn.Name = "empPayRateDataGridViewTextBoxColumn";
            this.empPayRateDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(CMPG223_Project_Group2.Employees);
            // 
            // frmEmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1050, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnDiplay);
            this.Name = "frmEmployeeReport";
            this.Text = "frmEmployeeReport";
            this.Load += new System.EventHandler(this.frmEmployeeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiplay;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbEventName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskDescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPayRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}