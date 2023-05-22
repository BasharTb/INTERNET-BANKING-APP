using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Proiect__IOC_
{
    public partial class PasswordVerifyATM : Form
    {

        private const string PIN = "1234";
        public PasswordVerifyATM()
        {
            InitializeComponent();

            textBox2.MaxLength = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IncercariRamase = 3;
            // preia pin-ul introdus de la tastatura
            string PINintrodus = textBox2.Text;

            // verifica daca pin-ul este corect
            if (PINintrodus == PIN)
            {
                
                ATM aTM = new ATM();
                aTM.ShowDialog();
                this.Hide();
            }
            else
            {
                // daca pin-ul este incorect , afiseaza eroare
                label3.Text = "Eroare : PIN-ul este invalid, Va rugam mai incercati !";
                label3.ForeColor = System.Drawing.Color.Red;
                IncercariRamase--;

                //verifica daca user-ul mai are incercari
                if(IncercariRamase == 0)
                {
                    label3.Text = "Nu mai avet Incercari !";
                    label3.ForeColor = System.Drawing.Color.Red;
                    Application.Exit();
                }
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void PasswordVerifyATM_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica daca tasta apasata nu este o cifra sau un backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Daca nu este o cifra sau un backspace, anuleaza apasarea tastei
                e.Handled = true;
            }
        }
    }
}
