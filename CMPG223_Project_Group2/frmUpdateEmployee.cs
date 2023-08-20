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
    public partial class frmUpdateEmployee : Form
    {
        public frmMainMenu main = new frmMainMenu();
        public frmUpdateEmployee()
        {
            InitializeComponent();
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            showEmp();
            fillEmpCmb();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
        }

        private void btnUpdateLName_Click(object sender, EventArgs e)
        {
            string upLName = txtUpdateLName.Text;


            if (cbEmpID.SelectedIndex != -1)
            {

                if (upLName != "")
                {
                    try
                    {
                        main.conn.Open();

                        main.command = new SqlCommand($"UPDATE EMPLOYEE SET Emp_LName = '{upLName}' WHERE Emp_ID = '{cbEmpID.SelectedItem.ToString()}'", main.conn);
                        main.command.Parameters.AddWithValue("Emp_LName", upLName);
                        main.command.Parameters.AddWithValue("Emp_ID", cbEmpID.SelectedItem.ToString());

                        main.command.ExecuteNonQuery();

                        main.conn.Close();
                        showEmp();
                        lblE_ID.Text = "";
                        lblE_LName.Text = "";
                        txtUpdateLName.Clear();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    lblE_LName.Text = "Enter the new surname please";
                }
            }
            else
            {
                lblE_ID.Text = "Please select an Employee ID to update";
            }
        }

        //A method that fills the emp datagrid
        public void showEmp()
        {
            try
            {
                main.conn.Open();

                main.command = new SqlCommand(@"SELECT (Emp_ID),(Emp_FName),(Emp_LName),(Emp_PayRate),(Emp_Email) FROM EMPLOYEE", main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "EMPLOYEE");

                dgvEmp.DataSource = main.data;
                dgvEmp.DataMember = "EMPLOYEE";

                main.conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //A method that fills the combobox with all employee id's
        public void fillEmpCmb()
        {
            try
            {
                main.conn.Open();

                main.command = new SqlCommand(@"SELECT Emp_ID FROM EMPLOYEE", main.conn);
                main.reader = main.command.ExecuteReader();

                while (main.reader.Read())
                {
                    cbEmpID.Items.Add(main.reader.GetValue(0));
                }

                main.conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // searches through the database according to first name as you type and fills the datagrid 
            try
            {
                main.conn.Open();

                main.command = new SqlCommand($"SELECT (Emp_ID),(Emp_FName),(Emp_LName),(Emp_PayRate),(Emp_Email) FROM EMPLOYEE WHERE Emp_FName LIKE'%{txtSearch.Text}%'", main.conn);
                main.adapter = new SqlDataAdapter();
                main.data = new DataSet();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "EMPLOYEE");

                dgvEmp.DataSource = main.data;
                dgvEmp.DataMember = "EMPLOYEE";

                main.conn.Close();
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
        private void btnUpdatePay_Click(object sender, EventArgs e)
        {
            decimal payR;

            if (cbEmpID.SelectedIndex != -1)
            {
                if (decimal.TryParse(txtUpdatePay.Text, out payR))
                {
                    try
                    {
                        main.conn.Open();

                        main.command = new SqlCommand($"UPDATE EMPLOYEE SET Emp_PayRate = '{payR}' WHERE Emp_ID = '{cbEmpID.SelectedItem.ToString()}'", main.conn);
                        main.command.Parameters.AddWithValue("Emp_PayRate", payR);
                        main.command.Parameters.AddWithValue("Emp_ID", cbEmpID.SelectedItem.ToString());

                        main.command.ExecuteNonQuery();

                        main.conn.Close();
                        txtUpdatePay.Clear();

                        showEmp();

                        lblE_ID.Text = "";
                        lblE_Pay.Text = "";
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    lblE_Pay.Text = "Enter a valid decimal value";
                }
            }
            else
            {
                lblE_ID.Text = "Please select an Employee ID to update";
            }
        }

        private void btnUpdate_Email_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (cbEmpID.SelectedIndex != -1)
            {
                if (IsValidEmail(email) == true)
                {
                    try
                    {
                        main.conn.Open();

                        main.command = new SqlCommand($"UPDATE EMPLOYEE SET Emp_Email = '{email}' WHERE Emp_ID = '{cbEmpID.SelectedItem.ToString()}'", main.conn);
                        main.command.Parameters.AddWithValue("Emp_Email", email);
                        main.command.Parameters.AddWithValue("Emp_ID", cbEmpID.SelectedItem.ToString());

                        main.command.ExecuteNonQuery();

                        main.conn.Close();
                        txtUpdatePay.Clear();

                        showEmp();

                        lblE_ID.Text = "";
                        lblE_Email.Text = "";
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    lblE_Email.Text = "Please enter a valid email";
                }
            }
            else
            {
                lblE_ID.Text = "Please select an Employee ID to update";
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

            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();

            }
        }
    }
}

