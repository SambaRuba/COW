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
    public partial class frmEmployeeMain : Form
    {
        
        
        public frmEmployeeMain()
        {
            InitializeComponent();
        }

        public SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\COW.mdf;Integrated Security = True");
        
        
        //public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BR3M97V;Initial Catalog=COW;Integrated Security=True");
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public DataSet data;



        private void frmEmployeeMain_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void scanEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmScanEmployees scanEmp = new frmScanEmployees();
            scanEmp.MdiParent = this;
            scanEmp.Show();
        }

        private void scanAttendeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmScanNewAttendee scanAtt = new frmScanNewAttendee();
            scanAtt.MdiParent = this;
            scanAtt.Show();
        }

        private void captureEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeEventSelect eventSelect = new frmEmployeeEventSelect();
            this.Enabled = false;
            this.Hide();
            MessageBox.Show("This event has been fully captured. Thank you!");
            eventSelect.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmHelp helpFrm = new frmHelp();
            this.Enabled = false;
            this.Hide();
            helpFrm.Show();
        }
    }
}
