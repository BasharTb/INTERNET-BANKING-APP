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
    public partial class DateCreareCont2 : Form
    {
        public DateCreareCont2()
        {
            InitializeComponent();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime selectedDate = dateTimePicker1.Value;

            
            label5.Text = "Data Nasterii: " + selectedDate.ToString("dd/MM/yyyy");
            label5.ForeColor = System.Drawing.Color.Gold;

            
        }

        private void DateCreareCont2_Load(object sender, EventArgs e)
        {
            // Add three options to the combo box
            comboBox1.Items.Add("Carte De Identitate");
            comboBox1.Items.Add("Pasaport");
            comboBox1.Items.Add("Permis De Conducere");

            // Display a random option in the combo box
            Random random = new Random();
            int index = random.Next(0, comboBox1.Items.Count);
            comboBox1.SelectedIndex = index;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica daca unul dintre optiunile din combo box este selectat
            if (comboBox1.SelectedIndex == -1)
            {
                label8.Text = "Va rugam Selectati tipul de act !";
                label8.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Afiseaza caseta de dialog Open File pentru a selecta o imagine
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Title = "Select a Picture";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Încărca poza selectată în caseta de imagine
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Afiseaza caseta de dialog Open File pentru a selecta o imagine 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Title = "Select a Picture";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Încărca poza selectată în caseta de imagine
                pictureBox2.ImageLocation = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite doar cifre
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // primeste numerele necesare
            string text = textBox1.Text;

            // valideaza text-ul sa fie exact 14 numere
            bool isValid = IsValidInput(text);

            // daca numarul este validat si contine 14 numere seteaza label-ul cu empty
            if (isValid)
            {
                label9.Text = "";
            }
            // daca numarul nu este validat afiseaza eroarea in label
            else
            {
                label9.Text = "Error: Va rugam introducati 14 cifre.";
                label9.ForeColor = System.Drawing.Color.Red;
            }
        }
        private bool IsValidInput(string text)
        {
            // Check that the text consists of exactly 14 digits
            return text.Length == 14 && text.All(char.IsDigit);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verifica daca este totul completat
            if (!string.IsNullOrEmpty(textBox1.Text) && pictureBox1.Image != null  && pictureBox2.Image != null && !string.IsNullOrEmpty(label5.Text))
            {
                
                CreareContPIN CCP = new CreareContPIN();
                CCP.ShowDialog();
                this.Hide();

                
                
            }
            else
            {
                // show error message if fields are incomplete
                MessageBox.Show("Va rugam completati toate campurile necesare ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
