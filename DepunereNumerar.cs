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
    public partial class DepunereNumerar : Form
    {
        public DepunereNumerar()
        {
            InitializeComponent();

            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);

            RON.Visible = false;
            USD.Visible = false;
            EUR.Visible = false;

            label9.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pentru introducerea doar cifre
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Gaseste Label-ul selectat
            Label selectedLabel = null;
            if (radioButton3.Checked)
            {
                selectedLabel = RON;
                RON.Visible = true;
                label9.Visible = true;
            }
            else if (radioButton1.Checked)
            {
                selectedLabel = USD;
                USD.Visible = true;
                label7.Visible = true;
            }
            else if (radioButton2.Checked)
            {
                selectedLabel = EUR;
                EUR.Visible = true;
                label8.Visible = true;
            }
            
            // preia input de la textbox
            int inputAmount = int.Parse(textBox1.Text);

            // preia valoarea label-ul selectat
            int currentValue = int.Parse(selectedLabel.Text);

            // Aduna cele doua numere 
            int newValue = currentValue + inputAmount;

            // Afiseaza soldul nou
            selectedLabel.Text = newValue.ToString();

            ProgressBarProcess PBP = new ProgressBarProcess();
            PBP.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
