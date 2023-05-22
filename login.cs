using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect__IOC_
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            pinTextBox.MaxLength = 4;
            cnpTextBox.MaxLength = 6;
        }
        string cifreCNP = "142434";
        string cifrePIN = "2456";


        private void login_Load(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cifreCNP.Equals(cnpTextBox.Text) && cifrePIN.Equals(pinTextBox.Text))
                 {
                Dashboard f2 = new Dashboard();
                this.Hide();
                f2.ShowDialog();
                 }
            else
                 {
                label4.Text = "Error: Nu ati introdus PIN-ul sau CNP-ul corect";
                label4.ForeColor = System.Drawing.Color.Red;
                Form1 f1 = new Form1();
                f1.ShowDialog();
                 }
        }

        private void cnpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite doar cifre
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite doar cifre
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
