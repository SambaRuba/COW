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
    public partial class frmAttendeeReport : Form
    {
        public frmMainMenu main = new frmMainMenu();
        public frmAttendeeReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(main.conn.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    String query = "SELECT e.Event_Num, aoe.Att_ID, e.Event_Date, a.Att_FName, a.Att_LName, e.Event_Name, l.LProvince, l.LCity, cs.Status_Descr, r.Risk_Descr, tc.Capacity_Limit, tc.Temp_Limit, a.Att_Temp" +
                        " FROM [dbo].[EVENT] e INNER JOIN [dbo].[ATENDEE_ON_EVENT] aoe ON e.Event_Num = aoe.Event_Num INNER JOIN [dbo].[ATENDEE] a ON aoe.Att_ID = a.Att_ID INNER JOIN [dbo].[COVID_STATUS] cs ON a.Status_ID = cs.Status_ID INNER JOIN [dbo].[LOCATION] l ON e.Location_ID = l.Location_ID INNER JOIN [dbo].[RISK_RATING] r ON e.Risk_ID = r.Risk_ID INNER JOIN [dbo].[THRESHOLD_CRITERIA] tc ON e.Thres_ID = tc.Thres_ID" +
                        $" WHERE e.Event_Date ='{dateTimePicker.Value}'" +
                        "ORDER BY e.Event_Name Desc";
                    attendeesBindingSource.DataSource = db.Query<Attendees>(query, commandType: CommandType.Text);
                }
            }
        }

        private void frmAttendeeReport_Load(object sender, EventArgs e)
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            Attendees att = attendeesBindingSource.Current as Attendees;
            if (att != null)
            {
                using (IDbConnection db = new SqlConnection(main.conn.ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    String query = "SELECT e.Event_Num, aoe.Att_ID, e.Event_Date, a.Att_FName, a.Att_LName, e.Event_Name, l.LProvince, l.LCity, cs.Status_Descr, r.Risk_Descr, tc.Capacity_Limit, tc.Temp_Limit, a.Att_Temp" +
                        " FROM [dbo].[EVENT] e INNER JOIN [dbo].[ATENDEE_ON_EVENT] aoe ON e.Event_Num = aoe.Event_Num INNER JOIN [dbo].[ATENDEE] a ON aoe.Att_ID = a.Att_ID INNER JOIN [dbo].[COVID_STATUS] cs ON a.Status_ID = cs.Status_ID INNER JOIN [dbo].[LOCATION] l ON e.Location_ID = l.Location_ID INNER JOIN [dbo].[RISK_RATING] r ON e.Risk_ID = r.Risk_ID INNER JOIN [dbo].[THRESHOLD_CRITERIA] tc ON e.Thres_ID = tc.Thres_ID" +
                        $" WHERE e.Event_Date ='{dateTimePicker.Value}' AND e.Event_Name = '{cmbEventName.SelectedValue}' AND l.LProvince ='{cmbProvince.SelectedValue}'" +
                        "ORDER BY e.Event_Name Desc";
                    List<Attendees> list = db.Query<Attendees>(query, commandType: CommandType.Text).ToList();
                    using (frmPrintAttendee frm = new frmPrintAttendee(att, list))
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
                    String query = "SELECT e.Event_Num, aoe.Att_ID, e.Event_Date, a.Att_FName, a.Att_LName, e.Event_Name, l.LProvince, l.LCity, cs.Status_Descr, r.Risk_Descr, tc.Capacity_Limit, tc.Temp_Limit, a.Att_Temp" +
                        " FROM [dbo].[EVENT] e INNER JOIN [dbo].[ATENDEE_ON_EVENT] aoe ON e.Event_Num = aoe.Event_Num INNER JOIN [dbo].[ATENDEE] a ON aoe.Att_ID = a.Att_ID INNER JOIN [dbo].[COVID_STATUS] cs ON a.Status_ID = cs.Status_ID INNER JOIN [dbo].[LOCATION] l ON e.Location_ID = l.Location_ID INNER JOIN [dbo].[RISK_RATING] r ON e.Risk_ID = r.Risk_ID INNER JOIN [dbo].[THRESHOLD_CRITERIA] tc ON e.Thres_ID = tc.Thres_ID" +
                        $" WHERE e.Event_Date ='{dateTimePicker.Value}' AND e.Event_Name = '{cmbEventName.SelectedValue}' AND l.LProvince ='{cmbProvince.SelectedValue}'" +
                        "ORDER BY e.Event_Name Desc";
                    attendeesBindingSource.DataSource = db.Query<Attendees>(query, commandType: CommandType.Text);
                }
            }
        }
    }
}
