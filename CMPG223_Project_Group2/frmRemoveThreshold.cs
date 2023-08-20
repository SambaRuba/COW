using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace CMPG223_Project_Group2
{
    public partial class frmRemoveThreshold : Form
    {
        public frmMainMenu main = new frmMainMenu();
        
        public frmRemoveThreshold()
        {
            InitializeComponent();
        }

        private void frmRemoveThreshold_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
            ViewAll();
            fillComboBoxes();
            pictureBox2.Hide();

        }

        public void ViewAll()
        {
            string selectAll = "SELECT Thres_ID, Temp_Limit, Capacity_Limit FROM THRESHOLD_CRITERIA";

            try
            {
                main.conn.Open();
                main.command = new SqlCommand(selectAll, main.conn);

                main.data = new DataSet();
                main.adapter = new SqlDataAdapter();
                main.adapter.SelectCommand = main.command;

                main.adapter.Fill(main.data, "THRESHOLD_CRITERIA");
                dgRemoveThresh.DataSource = main.data;
                dgRemoveThresh.DataMember = "THRESHOLD_CRITERIA";

                main.conn.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error loading Threshold database");
            }
        }

        public void fillComboBoxes()
        {
            string selectID = "SELECT Thres_ID FROM THRESHOLD_CRITERIA";

            try
            {
                main.conn.Open();
                main.command = new SqlCommand(selectID, main.conn);
                main.data = new DataSet();
                main.adapter = new SqlDataAdapter();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "THRESHOLD_CRITERIA");

                cbThresID.DataSource = main.data.Tables["THRESHOLD_CRITERIA"];
                cbThresID.DisplayMember = "Thres_ID";
                cbThresID.ValueMember = "Thres_ID";
                cbThresID.SelectedIndex = -1;

                main.conn.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Could not populate combo box");
            }
        }

        public void deleteThreshold()
        {
            if(cbThresID.SelectedIndex != -1)
            {
                string deleteThres = "DELETE FROM THRESHOLD_CRITERIA WHERE Thres_ID = '" + cbThresID.SelectedValue + "'";

                try
                {
                    main.conn.Open();
                    main.command = new SqlCommand(deleteThres, main.conn);

                    main.command.ExecuteNonQuery();

                    main.conn.Close();

                    ViewAll();
                    fillComboBoxes();

                    MessageBox.Show("Threshold sucessfully deleted");


                }
                catch (SqlException)
                {
                    MessageBox.Show("Error deleting Threshold");
                }
            }
            else
            {
                MessageBox.Show("Please select the Threshold ID you wish to remove");
                cbThresID.Focus();
            }
            
            
        }

        private void btnRemoveThres_Click(object sender, EventArgs e)
        {
            deleteThreshold();
        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHelp.Checked == true)
            {
                pictureBox2.Show();;
            }
            else
            {
                pictureBox2.Hide();
            }
        }
    }
}
