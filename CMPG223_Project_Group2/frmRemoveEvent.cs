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

namespace CMPG223_Project_Group2
{
    public partial class frmRemoveEvent : Form
    {
        public frmRemoveEvent()
        {
            InitializeComponent();
        }

        frmMainMenu main = new frmMainMenu();

        //Method to populate eventID combobox
        public void populateEventID()
        {
            cbEventID.Items.Clear();

            try
            {
                main.conn.Open();

                //select sql
                string selectSql = $"SELECT Event_Num FROM EVENT";
                main.command = new SqlCommand(selectSql, main.conn);
                main.reader = main.command.ExecuteReader();

                while (main.reader.Read())
                {
                    cbEventID.Items.Add(main.reader.GetValue(0));
                }

                main.conn.Close();

                //Select first value
                cbEventID.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Limit displayed event id method
        public void populateEventID(string name)
        {
            cbEventID.Items.Clear();

            try
            {
                main.conn.Open();

                //select sql
                string selectSql = $"SELECT Event_Num FROM EVENT WHERE Event_Name LIKE '%{name}%'";
                main.command = new SqlCommand(selectSql, main.conn);
                main.reader = main.command.ExecuteReader();

                while (main.reader.Read())
                {
                    cbEventID.Items.Add(main.reader.GetValue(0));
                }

                main.conn.Close();

                //Select first value
                //cbEventID.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Method to fill datagridview
        public void populateDataGrid()
        {
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

        //Limit what is displayed in datagridview
        public void populateDataGrid(string name)
        {
            string selectSql = $"SELECT Event_Num,Event_Name,Event_Date,Event_Email,Event_Capacity,Event_Duration,Thres_ID FROM EVENT WHERE Event_Name LIKE '%{name}%'";
            try
            {
                main.conn.Open();

                main.command = new SqlCommand(selectSql, main.conn);
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

        //Method to be called to delete event
        public void deleteEvent(int id)
        {
            string deleteSql = $"DELETE FROM EVENT WHERE Event_Num = {id}";

            try
            {
                main.conn.Open();
                main.command = new SqlCommand(deleteSql, main.conn);

                main.command.ExecuteNonQuery();

                main.conn.Close();

                //Delete EVENT in EMPLOYEE_ON_EVENT table

                deleteSql = $"DELETE FROM EMPLOYEE_ON_EVENT WHERE Event_Num = {id}";
                try
                {
                    main.conn.Open();
                    main.command = new SqlCommand(deleteSql, main.conn);

                    main.command.ExecuteNonQuery();

                    main.conn.Close();

                    //Delete EVENT in ATENDEE_ON_EVENT table
                    deleteSql = $"DELETE FROM ATENDEE_ON_EVENT WHERE Event_Num = {id}";
                    try
                    {
                        main.conn.Open();
                        main.command = new SqlCommand(deleteSql, main.conn);

                        main.command.ExecuteNonQuery();

                        main.conn.Close();

                        //Display successfull operations
                        MessageBox.Show("Event number: " + id + " was succesfully deleted");
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRemoveEvent_Load(object sender, EventArgs e)
        {
            //Populate comboboxes and datagridview
            populateDataGrid();
            populateEventID();
            pictureBox2.Hide();
            pictureBox2.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string eventName = txtSearch.Text;

            //If a name was added in search bar filter data
            if (eventName != null && eventName != "")
            {
                //Limit EventID and data present when text is added
                populateEventID(eventName);
                populateDataGrid(eventName);
            }

            //If no name was added unfilter all data
            else
            {
                populateDataGrid();
                populateEventID();
            }
        }

        private void btnRemoveEvent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbEventID.SelectedItem.ToString());

            //Ask user if they are sure they want to delete
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteEvent(id);

                //Reset Values
                populateDataGrid();
                populateEventID();
                txtSearch.Text = "";
            }
        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHelp.Checked == true)
            {
                pictureBox2.Show();
                pictureBox3.Show();
            }
            else
            {
                pictureBox2.Hide();
                pictureBox2.Hide();
            }
        }
    }
}
