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
    public partial class frmRemoveEmployee : Form
    {
        public frmMainMenu main = new frmMainMenu();
        public frmRemoveEmployee()
        {
            InitializeComponent();
        }

        private void frmRemoveEmployee_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
            showEmp();
            filEmpCmb();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // searches through the database according to first name as you type and fills the datagrid 
            try
            {
                main.conn.Open();

                main.command = new SqlCommand($"SELECT (Emp_ID),(Emp_FName),(Emp_LName),(Emp_Email) FROM EMPLOYEE WHERE Emp_FName LIKE'%{txtSearch.Text}%'", main.conn);
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
        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            cbEmpID.SelectedItem = "";
            if (cbEmpID.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove Employee number " + cbEmpID.SelectedItem.ToString(), "Remove", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    removeEmp();
                    lblErrorMessage.Show();
                    lblErrorMessage.Text = "You have succesfully deleted the employee";
                }
                else
                {
                    lblErrorMessage.Show();
                    lblErrorMessage.Text = "Select a other employee number to delete";
                }
            }
            else
            {
                lblErrorMessage.Show();
                lblErrorMessage.Text = "Please select an employee id to delete";
            }
        }
        //A method that fills the datagrid 
        public void showEmp()
        {
            try
            {
                main.conn.Open();

                main.command = new SqlCommand(@"SELECT (Emp_ID),(Emp_FName),(Emp_LName),(Emp_Email) FROM EMPLOYEE", main.conn);
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
        public void filEmpCmb()
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
        //A method to remove a employee from the data base
        public void removeEmp()
        {
            if (cbEmpID.SelectedIndex != -1)
            {
                try
                {
                    main.conn.Open();

                    main.command = new SqlCommand($"DELETE FROM EMPLOYEE WHERE Emp_ID = '{cbEmpID.SelectedItem.ToString()}'", main.conn);
                    main.command.Parameters.AddWithValue("Emp_ID", cbEmpID.SelectedItem.ToString());
                    main.command.ExecuteNonQuery();

                    main.conn.Close();
                    showEmp();
                    cbEmpID.Items.Clear();
                    filEmpCmb();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                lblErrorMessage.Show();
                lblErrorMessage.Text = "Please select an employee id to delete";
            }

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
