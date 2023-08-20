using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project_Group2
{
    public partial class frmScanNewAttendee : Form
    {
        public frmEmployeeMain empMain = new frmEmployeeMain();
        public frmMainMenu main = new frmMainMenu();
        public frmEmployeeEventSelect eventSelect = new frmEmployeeEventSelect();
        public double scanTemp;
        public int scanHealth;
        
        
        public frmScanNewAttendee()
        {
            InitializeComponent();
        }

        private void frmScanNewAttendee_Load(object sender, EventArgs e)
        {
            lblExistError.Hide();
            lblNewError.Hide();
            fillAttID();
            fillStatusID();
            fillAttendees();
            populateEventID();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            int eventID = (int)cbEventID.SelectedValue;
            try
            {
                string showEvent = $"SELECT Event_Num, Event_Name FROM EVENT";

                empMain.conn.Close();
                empMain.conn.Open();
                empMain.command = new SqlCommand(showEvent, empMain.conn);
                empMain.adapter = new SqlDataAdapter();
                empMain.data = new DataSet();

                empMain.adapter.SelectCommand = empMain.command;
                empMain.adapter.Fill(empMain.data, "EVENT");
                dgEventView.DataSource = empMain.data;
                dgEventView.DataMember = "EVENT";

                empMain.conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void fillAttendees()
        {
            try
            {
                empMain.conn.Open();

                empMain.command = new SqlCommand(@"SELECT (Att_ID),(Att_FName),(Att_LName),(Att_Email) FROM ATENDEE", empMain.conn);
                empMain.adapter = new SqlDataAdapter();
                empMain.data = new DataSet();

                empMain.adapter.SelectCommand = empMain.command;
                empMain.adapter.Fill(empMain.data, "EMPLOYEE");

                dgAtt.DataSource = empMain.data;
                dgAtt.DataMember = "EMPLOYEE";

                empMain.conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void fillAttID()
        {
            try
            {
                empMain.conn.Open();
                empMain.command = new SqlCommand(@"SELECT Att_ID FROM ATENDEE", empMain.conn);
                empMain.reader = empMain.command.ExecuteReader();

                while (empMain.reader.Read())
                {
                    cbAttID.Items.Add(empMain.reader.GetValue(0));
                }

                empMain.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void fillStatusID()
        {
            string selectID = "SELECT Status_ID FROM COVID_STATUS";

            empMain.conn.Close();
            try
            {
                empMain.conn.Open();
                empMain.command = new SqlCommand(selectID, empMain.conn);
                empMain.data = new DataSet();
                empMain.adapter = new SqlDataAdapter();

                empMain.adapter.SelectCommand = empMain.command;
                empMain.adapter.Fill(empMain.data, "COVID_STATUS");

                cbUpdateStatus.DataSource = empMain.data.Tables["COVID_STATUS"];
                cbUpdateStatus.DisplayMember = "Status_ID";
                cbUpdateStatus.ValueMember = "Status_ID";
                cbUpdateStatus.SelectedIndex = -1;

                cbNewStatus.DataSource = empMain.data.Tables["COVID_STATUS"];
                cbNewStatus.DisplayMember = "Status_ID";
                cbNewStatus.ValueMember = "Status_ID";
                cbNewStatus.SelectedIndex = -1;

                empMain.conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                empMain.conn.Close();

                empMain.conn.Open();

                empMain.command = new SqlCommand($"SELECT (Att_ID),(Att_FName),(Att_LName),(Att_Email) FROM ATENDEE WHERE Att_FName LIKE '%{txtSearch.Text}%'", empMain.conn);
                empMain.adapter = new SqlDataAdapter();
                empMain.data = new DataSet();

                empMain.adapter.SelectCommand = empMain.command;
                empMain.adapter.Fill(empMain.data, "ATENDEE");

                dgAtt.DataSource = empMain.data;
                dgAtt.DataMember = "ATENDEE";

                empMain.conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public static bool IsValidEmail(string Email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)
                return true;
            else
                return false;
        }

        private void btnScanExist_Click(object sender, EventArgs e)
        {
            updateAtt();
        }

        private void updateAtt()
        {
            if (cbAttID.SelectedIndex != -1)
            {
                if (txtUpdateTemp.Text == "")
                {
                    lblExistError.Show();
                    lblExistError.Text = "Please enter a temperature";
                }
                else if (cbUpdateStatus.SelectedIndex == -1)
                {
                    lblExistError.Show();
                    lblExistError.Text = "Select the attendee's current health status";
                }
                else if (double.TryParse(txtUpdateTemp.Text, out double scanTemp))
                {
                    try
                    {
                        string updateAtt = $"UPDATE ATENDEE SET Status_ID = {cbUpdateStatus.SelectedValue}, Att_Temp = {double.Parse(txtUpdateTemp.Text)} WHERE Att_ID = '" + cbAttID.SelectedItem + "'";

                        empMain.conn.Open();
                        empMain.command = new SqlCommand(updateAtt, empMain.conn);

                        empMain.command.ExecuteNonQuery();
                        empMain.conn.Close();

                        MessageBox.Show("Attendee successfully scanned");

                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }

            }
            else
            {
                lblExistError.Show();
                lblExistError.Text = "Please select an Attendee ID";
            }
        }

        private void btnScanNew_Click(object sender, EventArgs e)
        {
            scanAtt();
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

        private void scanAtt()
        {
            if (txtFName.Text == "")
            {
                MessageBox.Show("Please enter the attendee's first name");
            }
            else if (txtLName.Text == "")
            {
                MessageBox.Show("Please enter the attendee's last name");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter the attendee's email address");
            }
            else if(cbNewStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the attendee's health status");
            }
            else if(txtNewTemp.Text == "")
            {
                MessageBox.Show("Please enter the attendee's temperature");
            }
            else
            {
                String Email = txtEmail.Text;
                String AttFName = txtFName.Text;
                String AttLName = txtLName.Text;
                if (IsValidEmail(Email) == true)
                {
                    empMain.conn.Close();
                    try
                    {
                        string addAtt = $"INSERT INTO ATENDEE (Att_FName, Att_LName, Att_Email, Status_ID, Att_Temp) VALUES ('{AttFName}','{AttLName}','{Email}',{cbNewStatus.SelectedValue},{double.Parse(txtNewTemp.Text)})";

                        empMain.conn.Open();
                        empMain.command = new SqlCommand(addAtt, empMain.conn);
                        empMain.adapter = new SqlDataAdapter();

                        empMain.adapter.InsertCommand = empMain.command;
                        empMain.adapter.InsertCommand.ExecuteNonQuery();

                        empMain.conn.Close();

                        MessageBox.Show("You have successfully scanned a new attendee");

                        fillAttendees();
                        fillAttID();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error connecting to database");
                    }
                }
                else
                {
                    lblNewError.Show();
                    lblNewError.Text = "Please enter a valid e-mail address";
                }
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
                pictureBox6.Show();
                pictureBox7.Show();
                pictureBox8.Show();
                pictureBox9.Show();
                pictureBox10.Show();
                pictureBox11.Show();
            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                pictureBox8.Hide();
                pictureBox9.Hide();
                pictureBox10.Hide();
                pictureBox11.Hide();
            }
        }
    }
}
