using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Airplane
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            frmLine Line = new frmLine();
            Line.Show();
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            frmPassenger Passenger = new frmPassenger();
            Passenger.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            frmTicket Ticket = new frmTicket();
            Ticket.Show();
        }

    }
}
