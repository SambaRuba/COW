using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace CMPG223_Project_Group2
{
    public partial class frmUpdateEvent : Form
    {
        public frmUpdateEvent()
        {
            InitializeComponent();
        }

        frmMainMenu main = new frmMainMenu();

        //Method to fill datagridview
        public void populateDataGrid()
        {
            main.conn.Close();
            try
            {

                main.conn.Open();

                main.command = new SqlCommand(@"SELECT Event_Num,Event_Name,Event_Date,Event_Email,Event_Capacity,Event_Duration,Thres_ID FROM EVENT", main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "EVENT");

                dgEvent.DataSource = main.data;
                dgEvent.DataMember = "EVENT";

                main.conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Method to populate Threshold
        public void populateThres()
        {
            main.conn.Close();
            try
            {

                main.conn.Open();

                //select sql
                string selectSql = $"SELECT Thres_ID FROM THRESHOLD_CRITERIA";
                main.adapter = new SqlDataAdapter(selectSql, main.conn);
                main.data = new DataSet();

                main.adapter.Fill(main.data, "THRESHOLD_CRITERIA");

                cbUpdateThresID.DisplayMember = "Thres_ID";
                cbUpdateThresID.ValueMember = "Thres_ID";
                cbUpdateThresID.DataSource = main.data.Tables["THRESHOLD_CRITERIA"];

                main.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Method to populate Threshold
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
                cbEventID.SelectedIndex = -1;

                main.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Method to enter existing data into controls
        public void insertData(int id)
        {
            main.conn.Close();
            try
            {
                main.conn.Open();

                //select sql
                string selectSql = $"SELECT  Event_Num,Event_Name,Event_Date,Event_Email,Event_Capacity,Event_Duration,Thres_ID FROM EVENT WHERE Event_Num = {id}";
                main.command = new SqlCommand(selectSql, main.conn);
                main.reader = main.command.ExecuteReader();

                main.reader.Read();

                //Values into controls
                txtUpdateEName.Text = main.reader.GetValue(1).ToString();
                //datePickerEvent.Value = (DateTime)main.reader.GetValue(2);
                txtUpdateEEmail.Text = main.reader.GetValue(3).ToString();
                cbUpdateThresID.SelectedValue = main.reader.GetValue(6);


                main.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Method used to chech validity of email address
        public static bool isValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }

            catch
            {
                valid = false;
            }

            return valid;
        }

        private void frmUpdateEvent_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            populateEventID();
            populateThres();
            cbEventID.SelectedIndex = -1;
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
        }

        private void cbEventID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEventID.SelectedIndex != -1)
            {
                int id = (int)cbEventID.SelectedValue;

                //Filter data according to search
                main.conn.Close();
                try
                {
                    main.conn.Open();

                    main.command = new SqlCommand($"SELECT Event_Num,Event_Name,Event_Date,Event_Email,Event_Capacity,Event_Duration,Thres_ID FROM EVENT WHERE Event_Num = {id}", main.conn);
                    main.adapter = new SqlDataAdapter();
                    main.data = new DataSet();

                    main.adapter.SelectCommand = main.command;
                    main.adapter.Fill(main.data, "EVENT");

                    dgEvent.DataSource = main.data;
                    dgEvent.DataMember = "EVENT";

                    main.conn.Close();


                    //Add data into controls
                    insertData(id);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (cbEventID.SelectedIndex != -1)
            {
                //Assign inputs to variables

                string name = txtUpdateEName.Text;

                int capacity = (int)spnboxCapacity.Value;
                decimal duration = spnboxDuration.Value;
                string email = txtUpdateEEmail.Text;
                int threshold = (int)cbUpdateThresID.SelectedValue;

                string newDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");



                //Retrieves thresholdID
                //Validate that data added
                //Test if email is valid
                if (name != "")
                {
                    if (isValid(email))
                    {
                        if (capacity != 0)
                        {
                            if (duration != 0)
                            {
                                if (cbEventID.SelectedIndex != -1)
                                {
                                    //Update Event Data
                                    main.conn.Close();
                                    try
                                    {
                                        main.conn.Open();

                                        //select sql
                                        string updateSql = $"UPDATE EVENT SET Event_Name = '{name}' ,Event_Date = '{newDate}' ,Event_Duration = {duration} ,Event_Capacity = {capacity} ,Event_Email = '{email}' ,Thres_ID = {threshold} WHERE Event_Num = {(int)cbEventID.SelectedValue}";
                                        main.adapter = new SqlDataAdapter();
                                        main.command = new SqlCommand(updateSql, main.conn);
                                        main.adapter.UpdateCommand = main.command;
                                        main.adapter.UpdateCommand.ExecuteNonQuery();

                                        main.conn.Close();

                                        //Display Sucesss Message
                                        MessageBox.Show("Event: " + name + " was succesfully updated");

                                        //Reset all input
                                        txtUpdateEName.Text = "";
                                        txtUpdateEEmail.Text = "";
                                        spnboxDuration.Value = 0;
                                        spnboxCapacity.Value = 0;
                                        //datePickerEvent.Value = DateTime.Today;
                                        cbUpdateThresID.SelectedIndex = -1;
                                        cbEventID.SelectedIndex = -1;
                                        populateDataGrid();
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please select the event ID to update");
                                    cbEventID.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter the updated event hours");
                                spnboxDuration.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter the updated event capacity");
                            spnboxCapacity.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a correct email address");
                        txtUpdateEEmail.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the updated event name");
                    txtUpdateEName.Focus();
                }


            }   
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void cHelp_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHelp.Checked == true)
            {
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Show();
                pictureBox7.Show();
                pictureBox8.Show();
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
            }
        }

        private void cbUpdateThresID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
