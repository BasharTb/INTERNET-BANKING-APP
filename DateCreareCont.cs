using Proiect__IOC_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect__IOC_
{
    public partial class DateCreareCont : Form
    {

        /*public string Email { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }*/
        public DateCreareCont()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bTtextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite doar litere
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bTtextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permite doar litere
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Check if email address contains an "@" symbol
            if (textBox1.Text.Contains("@"))
            {
                emailLabel.Text = "email validat !";
                emailLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                emailLabel.Text = "E-mailul trebuie să conțină simbolul '@'.";
                emailLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bTtextbox6_Load(object sender, EventArgs e)
        {

        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Verifica daca Email-ul Contine symbol-ul '@'
            if (textBox1.Text.Contains("@"))
            {
                emailLabel.Text = "email validat !";
                emailLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                emailLabel.Text = "E-mailul trebuie să conțină simbolul '@'.";
                emailLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*Email = textBox1.Text;
            Nume = bTtextbox6.Text;
            CreareContMeniuPrincipal CCM = new CreareContMeniuPrincipal();
            CCM.ReceivedData = Email;
            CCM.ReceivedData2 = Nume;
            CCM.ReceivedData3 = Prenume;*/

            if(textBox1.Text == "")
            {
                label10.Text = "Va rugam completati toate campurile !";
                label10.ForeColor = System.Drawing.Color.Red;
                
                // Verifica daca unu dintre radiobuttons este selectat
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    // Ascunde mesajul daca unul este selectat
                    messageLabel.Visible = false;
                }
                else
                {
                    // Afiseaza mesaj daca nu are niciunu selectat
                    messageLabel.Text = "Va rugum selectati sex-ul";
                    messageLabel.ForeColor = System.Drawing.Color.Red;
                    messageLabel.Visible = true;
                }
            }

            
            else
            {
                DateCreareCont2 dateCreareCont2 = new DateCreareCont2();
                dateCreareCont2.ShowDialog();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateCreareCont_Load(object sender, EventArgs e)
        {
            //CreareContMeniuPrincipal principal = new CreareContMeniuPrincipal(bTtextbox6.Text);
        }
        
    }
}
