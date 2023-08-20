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
    public partial class frmRemoveAttendee : Form
    {
        public frmMainMenu main = new frmMainMenu();
        
        public frmRemoveAttendee()
        {
            InitializeComponent();
        }

        private void frmRemoveAttendee_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
            showAtt();
            fillAttCB();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void txtAttFName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchAtt = $"SELECT (Att_ID),(Att_FName),(Att_LName),(Att_Email) FROM ATENDEE WHERE Att_FName LIKE '%{txtAttFName.Text}%'";
                main.conn.Open();

                main.command = new SqlCommand(searchAtt, main.conn);
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "ATENDEE");

                dgAtt.DataSource = main.data;
                dgAtt.DataMember = "ATENDEE";

                main.conn.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error connecting to database");
            }
        }

        private void btnRemoveAtt_Click(object sender, EventArgs e)
        {
            //cbAttID.SelectedItem = "";
            if(cbAttID.SelectedIndex != 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this Attendee?", "Remove", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    removeAtt();
                }
                else
                {
                    MessageBox.Show("Attendee removal was cancelled");
                }
            }
            else
            {
                MessageBox.Show("Please select an Attendee ID to be removed");
            }
        }

        public void showAtt()
        {
            try
            {
                main.conn.Close();
                
                string viewAtt = "SELECT (Att_ID),(Att_FName),(Att_LName),(Att_Email) FROM ATENDEE";
                main.conn.Open();
                main.command = new SqlCommand(viewAtt, main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "ATENDEE");

                dgAtt.DataSource = main.data;
                dgAtt.DataMember = "ATENDEE";

                main.conn.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error populating the datagrid view");
            }
        }

        public void fillAttCB()
        {
            try
            {
                main.Close();
                string fillCB = $"SELECT Att_ID FROM ATENDEE";
                main.conn.Open();
                main.command = new SqlCommand(fillCB, main.conn);
                main.reader = main.command.ExecuteReader();

                while(main.reader.Read())
                {
                    cbAttID.Items.Add(main.reader.GetValue(0));
                }

                main.conn.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error populating Attendee ID combo box");
            }
        }

        public void removeAtt()
        {
            if(cbAttID.SelectedIndex != -1)
            {
                try
                {
                    string removeAtt = $"DELETE FROM ATENDEE WHERE Att_ID = '{cbAttID.SelectedItem.ToString()}'";
                    main.conn.Open();
                    main.command = new SqlCommand(removeAtt, main.conn);
                    main.command.ExecuteNonQuery();

                    main.Close();
                    showAtt();
                    cbAttID.Items.Clear();
                    fillAttCB();
                }
                catch(SqlException)
                {
                    MessageBox.Show("Error removing Attendee from database");
                }
            }
            else
            {
                MessageBox.Show("Please select an Attendee ID to delete");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHelp.Checked == true)
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
