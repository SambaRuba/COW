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
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace CMPG223_Project_Group2
{
    public partial class frmUpdateAttendee : Form
    {
        public frmMainMenu main = new frmMainMenu();
        
        public frmUpdateAttendee()
        {
            InitializeComponent();
        }

        private void frmUpdateAttendee_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
            showAtt();
            fillAttCB();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
        }

        private void btnUppAttLName_Click(object sender, EventArgs e)
        {
            string AttLName = txtUpdateAttLName.Text;

            if(cbAttID.SelectedIndex != -1)
            {
                if(AttLName != "")
                {
                    try
                    {
                        main.conn.Open();

                        main.command = new SqlCommand($"UPDATE ATENDEE SET Att_LName = '{AttLName}' WHERE Att_ID = '{cbAttID.SelectedItem.ToString()}'", main.conn);
                        main.command.ExecuteNonQuery();

                        main.conn.Close();
                        showAtt();
                        txtUpdateAttLName.Clear();
                    
                    }
                    catch(SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Enter a new surname");
                }
            }
            else
            {
                MessageBox.Show("Please select an Attendee ID to update their information");
            }

           
        }

        public void showAtt()
        {
            try
            {
                main.conn.Open();

                main.command = new SqlCommand(@"SELECT (Att_ID),(Att_FName),(Att_LName),(Att_Email) FROM ATENDEE", main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "ATENDEE");

                dgAtt.DataSource = main.data;
                dgAtt.DataMember = "ATENDEE";

                main.conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void fillAttCB()
        {
            try
            {
                main.conn.Open();
                main.command = new SqlCommand(@"SELECT Att_ID FROM ATENDEE", main.conn);
                main.reader = main.command.ExecuteReader();

                while(main.reader.Read())
                {
                    cbAttID.Items.Add(main.reader.GetValue(0));
                }

                main.Close();
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

                main.command = new SqlCommand($"SELECT (Att_ID),(Att_FName),(Att_LName),(Att_Email) FROM ATENDEE WHERE Att_FName Like '%{txtSearch.Text}%'", main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "ATENDEE");

                dgAtt.DataSource = main.data;
                dgAtt.DataMember = "ATENDEE";

                main.conn.Close();
            }
            catch(SqlException error)
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

        private void btnUpAttEmail_Click(object sender, EventArgs e)
        {
            string email = txtUpdateAttEmail.Text;
            if (cbAttID.SelectedIndex != -1)
            {
                if (IsValidEmail(email) == true)
                {
                    try
                    {
                        main.conn.Open();

                        main.command = new SqlCommand($"UPDATE ATENDEE SET Att_Email = '{email}' WHERE Att_ID = '{cbAttID.SelectedItem.ToString()}'", main.conn);
                        main.command.Parameters.AddWithValue("Att_Email", email);
                        main.command.Parameters.AddWithValue("Att_ID", cbAttID.SelectedItem.ToString());

                        main.command.ExecuteNonQuery();

                        main.conn.Close();
                        txtUpdateAttEmail.Clear();

                        showAtt();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address");
                }
            }
            else
            {
                MessageBox.Show("Please select an Attendee ID to update their information");
            }
        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHelp.Checked == true)
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
                pictureBox5.Hide();
            }
        }
    }
}
