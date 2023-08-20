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
    public partial class frmEmployeeEventSelect : Form
    {
        public frmMainMenu main = new frmMainMenu();
        public int selectedID;
        public ComboBox cbSelect = new ComboBox();
        
        public frmEmployeeEventSelect()
        {
            InitializeComponent();
        }

        private void frmEmployeeEventSelect_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
            showEvent();
            fillEventCB();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        public void showEvent()
        {
            try
            {
                main.conn.Open();

                main.command = new SqlCommand(@"SELECT (Event_Num),(Event_Name),(Event_Date) FROM EVENT", main.conn);
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
        
        public void fillEventCB()
        {
            try
            {
                main.conn.Open();
                main.command = new SqlCommand(@"SELECT Event_Num FROM EVENT", main.conn);
                main.reader = main.command.ExecuteReader();

                while(main.reader.Read())
                {
                    cbEventID.Items.Add(main.reader.GetValue(0));
                }
                main.conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                main.conn.Close();
                main.conn.Open();

                main.command = new SqlCommand($"SELECT (Event_Num),(Event_Name),(Event_Date) FROM EVENT WHERE Event_Name LIKE '%{txtSearch.Text}%'", main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "EVENT");

                dgEvent.DataSource = main.data;
                dgEvent.DataMember = "EVENT";

                main.conn.Close();

            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSelectEvent_Click(object sender, EventArgs e)
        {
            if(cbEventID.SelectedIndex != -1)
            {
                getEventID();
                frmEmployeeMain empMain = new frmEmployeeMain();
                MessageBox.Show("The event you have booked is number: " + cbEventID.SelectedItem + " , use this number for the Event ID when scanning individuals");
                this.Hide();
                empMain.Show();
            }
            else
            {
                lblErrorMessage.Show();
                lblErrorMessage.Text = "Please select an Event ID before you can continue";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        public void getEventID()
        {
            cbSelect.SelectedValue = cbEventID.SelectedValue;
        }

        private void cbEventID_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedID = (int)cbEventID.SelectedItem;
        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHelp.Checked == true)
            {
                pictureBox2.Show();
                pictureBox3.Show();

            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();

            }
        }
    }
}
