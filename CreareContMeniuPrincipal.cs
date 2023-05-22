using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect__IOC_
{
    public partial class CreareContMeniuPrincipal : Form
    {
       /* public string ReceivedData { get; set; }
        public string ReceivedData2 { get; set; }
        public string ReceivedData3 { get; set; }*/

        [DllImport("Gdi32.d11", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
         int nWidthEllipse,
        int nHeightEllipse
        );



        public CreareContMeniuPrincipal()
        {
            InitializeComponent();

            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = Height;
            pnlNav.Top = BtnDashboard.Top;
            pnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            frmDashboardNewAccount FrmDashboard_vrb = new frmDashboardNewAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreareContMeniuPrincipal_Load(object sender, EventArgs e)
        {
            /*label1.Text = ReceivedData;
            label2.Text = ReceivedData2;
            label7.Text = ReceivedData3;
            label8.Text = ReceivedData2;
            label9.Text = ReceivedData3;*/
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Setari";
            this.pnlFormLoader.Controls.Clear();
            frmSettings FrmDashboard_vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Height;
            pnlNav.Top = btnContact.Top;
            pnlNav.Left = btnContact.Left;
            btnContact.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Contact";
            this.pnlFormLoader.Controls.Clear();
            frmContact FrmDashboard_vrb = new frmContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Height;
            pnlNav.Top = btnCalendar.Top;
            pnlNav.Left = btnCalendar.Left;
            btnCalendar.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Calendar";
            this.pnlFormLoader.Controls.Clear();
            frmCalendar FrmDashboard_vrb = new frmCalendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Analytics";
            this.pnlFormLoader.Controls.Clear();
            frmAnalytics2 FrmDashboard_vrb = new frmAnalytics2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Height;
            pnlNav.Top = btnTransactions.Top;
            pnlNav.Left = btnTransactions.Left;
            btnTransactions.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Tranzactii";
            this.pnlFormLoader.Controls.Clear();
            frmTransactions2 FrmDashboard_vrb = new frmTransactions2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Height;
            pnlNav.Top = BtnDashboard.Top;
            pnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            frmDashboardNewAccount FrmDashboard_vrb = new frmDashboardNewAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }
    }
}
