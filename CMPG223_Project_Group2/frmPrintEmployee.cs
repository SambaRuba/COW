using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project_Group2
{
    public partial class frmPrintEmployee : Form
    {
        List<Employees> _list;
        Employees _employ;
        public frmPrintEmployee(Employees employ, List<Employees> list)
        {
            InitializeComponent();
            _list = list;
            _employ = employ;
        }

        private void frmPrintEmployee_Load(object sender, EventArgs e)
        {
            cryEmployeeReport1.SetDataSource(_list);
            cryEmployeeReport1.SetParameterValue("pEventDate", _employ.Event_Date.ToString("dd/MM/yyyy"));
            crystalReportViewer1.ReportSource = cryEmployeeReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
