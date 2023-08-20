using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace CMPG223_Project_Group2
{
    public partial class frmEmployeeReport : Form
    {
        public frmMainMenu main = new frmMainMenu();
        public frmEmployeeReport()
        {
            InitializeComponent();
        }

        private void btnDiplay_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(main.conn.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    String query = "SELECT e.Event_Num, eoe.Emp_ID, e.Event_Date, a.Emp_FName, a.Emp_LName, e.Event_Name, l.LProvince, l.LCity, cs.Status_Descr, r.Risk_Descr, tc.Capacity_Limit, tc.Temp_Limit, a.Emp_Temp" +
                                    " FROM[dbo].[EVENT] e INNER JOIN[dbo].[EMPLOYEE_ON_EVENT] eoe ON e.Event_Num = eoe.Event_Num INNER JOIN[dbo].EMPLOYEE a ON eoe.Emp_ID = a.Emp_ID INNER JOIN[dbo].[COVID_STATUS] cs ON a.Status_ID = cs.Status_ID INNER JOIN[dbo].[LOCATION] l ON e.Location_ID = l.Location_ID INNER JOIN[dbo].[RISK_RATING] r ON e.Risk_ID = r.Risk_ID INNER JOIN[dbo].[THRESHOLD_CRITERIA] tc ON e.Thres_ID = tc.Thres_ID" +
                                    $" WHERE e.Event_Date ='{dateTimePicker.Value}'" +
                                    " ORDER BY e.Event_Name Desc";
                    employeesBindingSource.DataSource = db.Query<Employees>(query, commandType: CommandType.Text);
                }
            }
        }

        private void frmEmployeeReport_Load(object sender, EventArgs e)
        {
            try
            {
                //Opening the connection to the database
                main.conn.Open();
                main.command = new SqlCommand(@"SELECT Distinct Event_Name FROM [dbo].[EVENT]", main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();
                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "EVENT");
                cmbEventName.DisplayMember = "Event_Name";
                cmbEventName.ValueMember = "Event_Name";
                cmbEventName.DataSource = main.data.Tables["EVENT"];

                main.command = new SqlCommand(@"SELECT [LProvince] FROM [dbo].[LOCATION]", main.conn);
                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "LOCATION");
                cmbProvince.DisplayMember = "LProvince";
                cmbProvince.ValueMember = "LProvince";
                cmbProvince.DataSource = main.data.Tables["LOCATION"];

                //Closing the connection to the database
                main.conn.Close();
                cmbEventName.SelectedIndex = -1;
                cmbProvince.SelectedIndex = -1;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); // error message to the user
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Employees emp = employeesBindingSource.Current as Employees;
            if (emp != null)
            {
                using (IDbConnection dbEmp = new SqlConnection(main.conn.ConnectionString))
                {
                    if (dbEmp.State == ConnectionState.Closed)
                        dbEmp.Open();
                    String query = "SELECT e.Event_Num, eoe.Emp_ID, e.Event_Date, a.Emp_FName, a.Emp_LName, e.Event_Name, l.LProvince, l.LCity, cs.Status_Descr, r.Risk_Descr, tc.Capacity_Limit, tc.Temp_Limit, a.Emp_Temp" +
                        " FROM [dbo].[EVENT] e INNER JOIN[dbo].[EMPLOYEE_ON_EVENT] eoe ON e.Event_Num = eoe.Event_Num INNER JOIN[dbo].EMPLOYEE a ON eoe.Emp_ID = a.Emp_ID INNER JOIN[dbo].[COVID_STATUS] cs ON a.Status_ID = cs.Status_ID INNER JOIN[dbo].[LOCATION] l ON e.Location_ID = l.Location_ID INNER JOIN[dbo].[RISK_RATING] r ON e.Risk_ID = r.Risk_ID INNER JOIN[dbo].[THRESHOLD_CRITERIA] tc ON e.Thres_ID = tc.Thres_ID" +
                        $" WHERE e.Event_Date ='{dateTimePicker.Value}' or e.Event_Name = '{cmbEventName.SelectedValue}' or l.LProvince ='{cmbProvince.SelectedValue}'" +
                        " ORDER BY e.Event_Name Desc";
                    List<Employees> list = dbEmp.Query<Employees>(query, commandType: CommandType.Text).ToList();
                    using (frmPrintEmployee frm = new frmPrintEmployee(emp, list))
                    {
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(main.conn.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    String query = "SELECT e.Event_Num, eoe.Emp_ID, e.Event_Date, a.Emp_FName, a.Emp_LName, e.Event_Name, l.LProvince, l.LCity, cs.Status_Descr, r.Risk_Descr, tc.Capacity_Limit, tc.Temp_Limit, a.Emp_Temp" +
                                    " FROM[dbo].[EVENT] e INNER JOIN[dbo].[EMPLOYEE_ON_EVENT] eoe ON e.Event_Num = eoe.Event_Num INNER JOIN[dbo].EMPLOYEE a ON eoe.Emp_ID = a.Emp_ID INNER JOIN[dbo].[COVID_STATUS] cs ON a.Status_ID = cs.Status_ID INNER JOIN[dbo].[LOCATION] l ON e.Location_ID = l.Location_ID INNER JOIN[dbo].[RISK_RATING] r ON e.Risk_ID = r.Risk_ID INNER JOIN[dbo].[THRESHOLD_CRITERIA] tc ON e.Thres_ID = tc.Thres_ID" +
                                    $" WHERE e.Event_Date ='{dateTimePicker.Value}' AND e.Event_Name = '{cmbEventName.SelectedValue}' AND l.LProvince ='{cmbProvince.SelectedValue}'" +
                                    " ORDER BY e.Event_Name Desc";
                    employeesBindingSource.DataSource = db.Query<Employees>(query, commandType: CommandType.Text);
                }
            }
        }
    }
}
