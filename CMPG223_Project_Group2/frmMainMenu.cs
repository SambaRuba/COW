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
using System.Runtime.Remoting.Contexts;

namespace CMPG223_Project_Group2
{
    public partial class frmMainMenu : Form
    {
        

        public SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\COW.mdf;Integrated Security = True");

        //public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BR3M97V;Initial Catalog=COW;Integrated Security=True");
        //public SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=cow;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public DataSet data;

        
        
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmAddThreshold AddThreshForm = new frmAddThreshold();
            AddThreshForm.MdiParent = this;;
            AddThreshForm.Show();

        }

        private void removeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmRemoveThreshold RemoveThresh = new frmRemoveThreshold();
            RemoveThresh.MdiParent = this;
            RemoveThresh.Show();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmUpdateThreshold UpdateThres = new frmUpdateThreshold();
            UpdateThres.MdiParent = this;
            UpdateThres.Show();
        }
        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmAddEmployee addEmp = new frmAddEmployee();

            addEmp.MdiParent = this;
            addEmp.Show();
        }

        private void removeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmRemoveEmployee removeEmp = new frmRemoveEmployee();

            removeEmp.MdiParent = this;
            removeEmp.Show();
        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmUpdateEmployee updateEmp = new frmUpdateEmployee();

            updateEmp.MdiParent = this;
            updateEmp.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmAddAttendee addAtt = new frmAddAttendee();
            addAtt.MdiParent = this;
            addAtt.Show();
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmRemoveAttendee removeAtt = new frmRemoveAttendee();
            removeAtt.MdiParent = this;
            removeAtt.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmUpdateAttendee updateAtt = new frmUpdateAttendee();
            updateAtt.MdiParent = this;
            updateAtt.Show();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmAddEvent addEvent = new frmAddEvent();
            addEvent.MdiParent = this;
            addEvent.Show();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmRemoveEvent removeEvent = new frmRemoveEvent();
            removeEvent.MdiParent = this;
            removeEvent.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmUpdateEvent updateEvent = new frmUpdateEvent();
            updateEvent.MdiParent = this;
            updateEvent.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmHelp helpPage = new frmHelp();
            this.Enabled = false;
            this.Hide();
            helpPage.Show();
        }
    }
}
