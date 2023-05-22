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
    public partial class SchimbValutar : Form
    {
        public SchimbValutar()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] { "USD", "EUR", "RON" });
            comboBox2.Items.AddRange(new string[] { "USD", "EUR", "RON" });

            // afiseaza o valoare random in combobox
            Random rnd = new Random();
            comboBox1.SelectedIndex = rnd.Next(comboBox1.Items.Count);
            comboBox2.SelectedIndex = rnd.Next(comboBox2.Items.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obțineți monedele de intrare și de ieșire din comboBox
            string inputCurrency = comboBox1.SelectedItem.ToString();
            string outputCurrency = comboBox2.SelectedItem.ToString();

            // Obțineți sumele de intrare și de ieșire din textBox
            decimal inputAmount = decimal.Parse(textBox1.Text);
            decimal outputAmount = 0;

            // verifica intrare si iesirea a valutei
            if (inputCurrency == "USD" && outputCurrency == "EUR")
            {
                // Converteste USD to EUR
                outputAmount = inputAmount * 0.84m;
            }
            else if (inputCurrency == "USD" && outputCurrency == "RON")
            {
                // Converteste USD to RON
                outputAmount = inputAmount * 4.38m;
            }
            else if (inputCurrency == "EUR" && outputCurrency == "USD")
            {
                // Converteste EUR to USD
                outputAmount = inputAmount * 1.19m;
            }
            else if (inputCurrency == "EUR" && outputCurrency == "RON")
            {
                // Converteste EUR to RON
                outputAmount = inputAmount * 5.28m;
            }
            else if (inputCurrency == "RON" && outputCurrency == "USD")
            {
                // Converteste RON to USD
                outputAmount = inputAmount * 0.23m;
            }
            else if (inputCurrency == "RON" && outputCurrency == "EUR")
            {
                // Converteste RON to EUR
                outputAmount = inputAmount * 0.19m;
            }
            else
            {
                // daca input ul si output ul sunt lafel , seteaza aceasi valoare
                outputAmount = inputAmount;
            }

            // afiseaza output ul in texbox-ul
            textBox2.Text = outputAmount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SchimbValutar_Load(object sender, EventArgs e)
        {

        }
    }
   
}
