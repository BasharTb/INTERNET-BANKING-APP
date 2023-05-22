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
    public partial class CreareContPIN : Form
    {
        public CreareContPIN()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // valideaza input-ul in ambele boxe
            ValidateInput();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // valideaza input-ul in ambele boxe
            ValidateInput();
        }

        private void ValidateInput()
        {

        }

        private bool IsValidInput(string text)
        {
            // verifica daca text-ul contine doar 4 cifre exact 4
            return text.Length == 4 && text.All(char.IsDigit);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // preia text-ul din ambele casete
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            // Valideaza daca contine exact 4 cifre in ambele textBox-uri
            bool isValid1 = IsValidInput(text1);
            bool isValid2 = IsValidInput(text2);

            // Dacă introducerea în ambele textBox-uri este validă și conținutul textBox-uri se potrivește, seteaza label-ul gol
            if (isValid1 && isValid2 && text1 == text2)
            {
                label3.Text = "";
                ProgressBarProces2 progressBarProces2 = new ProgressBarProces2();
                progressBarProces2.ShowDialog();
            }
            // Dacă introducerea nu este validă sau conținutul textBox-uri nu se potrivește, seteaza label-ul la un mesaj de eroare
            else
            {
                label3.Text = "Eroare : Va rugam Introduceți exact 4 cifre " +
                    "\n și asigurați-vă că conținutul se potrivește.";
                label3.ForeColor = System.Drawing.Color.Red;
            }

            

        }
    }
}
