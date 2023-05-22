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
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();

            // Gestionează evenimentul KeyPress pentru prima casetă de text
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);

            // Gestionează evenimentul KeyPress pentru a 2-a casetă de text
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);



            // Gestionează evenimentul KeyPress pentru a 4-a casetă de text
            textBox4.KeyPress += new KeyPressEventHandler(textBox4_KeyPress);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Error: Only Letters are allowed in this text box.", "Input Error");
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Error: Only Letters are allowed in this text box.", "Input Error");
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Error: Only numbers are allowed in this text box.", "Input Error");
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Verifica daca Email-ul Contine symbol-ul '@'
            if (textBox1.Text.Contains("@"))
            {
                label12.Text = "email validat !";
                label12.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label12.Text = "E-mailul trebuie să conțină simbolul '@'.";
                label12.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
