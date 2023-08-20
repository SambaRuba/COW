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
using System.Drawing.Text;

namespace CMPG223_Project_Group2
{
    public partial class frmLogin : Form
    {
        
        
        public frmMainMenu main = new frmMainMenu();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
            pictureBox1.Hide();
            pictureBox2.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int empID;
            string empPW = txtLogUPassword.Text;
            bool foundFlag = false;
            

            if(txtLogUName.Text == "")
            {
                MessageBox.Show("Please enter your Employee ID");
                txtLogUName.Focus();
            }
            else if(txtLogUPassword.Text == "")
            {
                MessageBox.Show("Please enter your password");
                txtLogUPassword.Focus();
            }
            else
            {
                if(int.TryParse(txtLogUName.Text, out empID))
                {

                    try
                    {
                        main.conn.Close();
                        string searchExist = $"SELECT * FROM EMPLOYEE WHERE Emp_ID = {empID}";
                        main.command = new SqlCommand(searchExist, main.conn);

                        main.conn.Open();
                        main.reader = main.command.ExecuteReader();


                        if (main.reader.HasRows)
                        {
                            foundFlag = true;
                        }
                        else
                        {
                            foundFlag = false;
                            MessageBox.Show("Employee ID does not exist");
                            txtLogUName.Focus();
                            txtLogUPassword.Clear();
                        }

                        main.conn.Close();
                    }
                    catch(SqlException)
                    {
                        lblErrorMessage.Show();
                        lblErrorMessage.Text = "Error connecting to database";
                    }
                }
                else
                {
                    lblErrorMessage.Show();
                    lblErrorMessage.Text = "Please enter a valid employee ID digit";
                }

                if(foundFlag == true)
                {
                    try
                    {
                        string searchPW = $"SELECT * FROM EMPLOYEE WHERE Emp_ID = {empID} AND Emp_Password = '{empPW}'";
                        empPW = txtLogUPassword.Text;
                        main.command = new SqlCommand(searchPW, main.conn);
                        main.conn.Open();
                        main.reader = main.command.ExecuteReader();

                        if(main.reader.HasRows)
                        {
                            
                            //HARD CODE WHAT ADMIN ID AND PW NEEDS TO BE
                            if(((empID == 1) && (empPW == "adminBEN@19")) || ((empID == 2) && (empPW == "SYSadmin@7")))
                            {
                                this.Hide();
                                main.Show();
                            }
                            else
                            {
                                this.Hide();
                                frmEmployeeEventSelect selectEvent = new frmEmployeeEventSelect();
                                selectEvent.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password incorrect, please try again.");
                            txtLogUPassword.Focus();
                        }

                        main.conn.Close();
                    }
                    catch(SqlException)
                    {
                        MessageBox.Show("Password incorrect, please try again.");
                        txtLogUPassword.Focus();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtLogUPassword.PasswordChar = '*';
            pictureBox1.Hide();
            pictureBox2.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtLogUPassword.PasswordChar = '\0';
            pictureBox2.Hide();
            pictureBox1.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            this.Close();
            frmHelp.Show();
        }
    }
}
