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
    public partial class frmCalendar : Form
    {
        public frmCalendar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obține data selectată din calendarul lunar
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;

            // Afișează un messagebox care arată tranzactia atribuită datei selectate
            MessageBox.Show("Tranzactia in asteptare in" + selectedDate.ToShortDateString() + ": \nApple Itunes 20 RON " +
                                                                                              " \nNetflix 80 60 RON");
        }
    }
}
