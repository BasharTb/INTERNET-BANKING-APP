using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect__IOC_
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSettings frmS = new frmSettings();
            frmS.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDashboard frmD = new frmDashboard();
            frmD.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SchimbValutar schimbV = new SchimbValutar();
            schimbV.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepunereNumerar DN = new DepunereNumerar();
            DN.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetragereNumerar RN = new RetragereNumerar();
            RN.ShowDialog();
        }
    }
}
