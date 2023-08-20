using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project_Group2
{
    public partial class frmScanEmployees : Form
    {

        public frmEmployeeEventSelect eventSelect = new frmEmployeeEventSelect();
        public frmMainMenu main = new frmMainMenu();
        public frmEmployeeMain empMain = new frmEmployeeMain();
        public double scanTemp;
        public int scanHealth;
        
        public frmScanEmployees()
        {
            InitializeComponent();
        }

        private void frmScanEmployees_Load(object sender, EventArgs e)
        {
            fillIDcb();
            fillStatusID();
            populateEventID();
            lblErrorMessage.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();

            //int selectEvent = eventSelect.getEventID();
            try
            {
                string showEvent = $"SELECT (Event_Num), (Event_Name) FROM EVENT WHERE Event_Num LIKE '%{eventSelect.cbSelect.SelectedValue}%'";

                main.conn.Close();
                main.conn.Open();
                main.command = new SqlCommand(showEvent, main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "EVENT");
                dgDisplay.DataSource = main.data;
                dgDisplay.DataMember = "EVENT";

                main.conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void fillIDcb()
        {
            string selectID = "SELECT Emp_ID FROM EMPLOYEE";

            try
            {
                main.conn.Open();
                main.command = new SqlCommand(selectID, main.conn);
                main.data = new DataSet();
                main.adapter = new SqlDataAdapter();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "EMPLOYEE");

                cbEmpID.DataSource = main.data.Tables["EMPLOYEE"];
                cbEmpID.DisplayMember = "Emp_ID";
                cbEmpID.ValueMember = "Emp_ID";
                cbEmpID.SelectedIndex = -1;

                empMain.conn.Close();

            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void fillStatusID()
        {
            string selectID = "SELECT Status_ID FROM COVID_STATUS";

            try
            {
                empMain.conn.Open();
                empMain.command = new SqlCommand(selectID, empMain.conn);
                empMain.data = new DataSet();
                empMain.adapter = new SqlDataAdapter();

                empMain.adapter.SelectCommand = empMain.command;
                empMain.adapter.Fill(empMain.data, "COVID_STATUS");

                cbEmpStatus.DataSource = empMain.data.Tables["COVID_STATUS"];
                cbEmpStatus.DisplayMember = "Status_ID";
                cbEmpStatus.ValueMember = "Status_ID";
                cbEmpStatus.SelectedIndex = -1;

                empMain.conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnScanEmp_Click(object sender, EventArgs e)
        {
            updateEmp();
            //scanEmp();
        }

        public void populateEventID()
        {
            main.conn.Close();
            try
            {
                main.conn.Open();

                //select sql
                string selectSql = $"SELECT Event_Num FROM EVENT";
                main.adapter = new SqlDataAdapter(selectSql, main.conn);
                main.data = new DataSet();

                main.adapter.Fill(main.data, "EVENT");

                cbEventID.DisplayMember = "Event_Num";
                cbEventID.ValueMember = "Event_Num";
                cbEventID.DataSource = main.data.Tables["EVENT"];

                main.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void updateEmp()
        {
            if(cbEmpID.SelectedValue != null)
            {
                if(txtEmpTemp.Text == "")
                {
                    lblErrorMessage.Show();
                    lblErrorMessage.Text = "Please enter a temperature";
                }
                else if(cbEmpStatus.SelectedValue == null)
                {
                    lblErrorMessage.Show();
                    lblErrorMessage.Text = "Select the employee's current health status";
                }
                else if(double.TryParse(txtEmpTemp.Text, out double scanTemp))
                {
                    try
                    {
                        lblErrorMessage.Hide();
                        string updateEmp = $"UPDATE EMPLOYEE SET Status_ID = {cbEmpStatus.SelectedValue}, Emp_Temp = {double.Parse(txtEmpTemp.Text)} WHERE Emp_ID = '" + cbEmpID.SelectedValue + "'";

                        empMain.conn.Open();
                        empMain.command = new SqlCommand(updateEmp, empMain.conn);

                        empMain.command.ExecuteNonQuery();
                        empMain.conn.Close();

                        MessageBox.Show("Employee successfully scanned");

                    }
                    catch(SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                
            }
            else
            {
                lblErrorMessage.Show();
                lblErrorMessage.Text = "Please select an Employee ID";
            }
        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHelp.Checked == true)
            {
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();

            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();

            }
        }

    }
}
