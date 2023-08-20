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
    public partial class frmPrintAttendee : Form
    {
        List<Attendees> _list;
        Attendees _attend;
        public frmPrintAttendee(Attendees attend, List<Attendees> list)
        {
            InitializeComponent();
            _list = list;
            _attend = attend;
        }

        private void frmPrintAttendee_Load(object sender, EventArgs e)
        {
            cryAttendeeReport1.SetDataSource(_list);
            cryAttendeeReport1.SetParameterValue("pEventDate", _attend.Event_Date.ToString("dd/MM/yyyy"));
            crystalReportViewer1.ReportSource = cryAttendeeReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
