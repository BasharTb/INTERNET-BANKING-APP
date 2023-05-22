using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect__IOC_
{
    public partial class frmSettings : Form
    {
        private string PINinitial = "2456";
        public frmSettings()
        {
            InitializeComponent();

            // Ascunde a doua imagine inițial
            pictureBox2.Visible = false;
            // Setați panoul să fie invizibil inițial
            panel5.Visible = false;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Schimba vizibilitatea celor două imagini
            pictureBox1.Visible = !pictureBox1.Visible;
            pictureBox2.Visible = !pictureBox2.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Face panoul vizibil când se face clic pe butonul
            panel5.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /// preia pinul nou si pinul vechi de la utilizator
            string PINvechi = textBox1.Text;
            string PINnou = textBox2.Text;

            // verifica dava pinul vechi este corect
            if (PINvechi == PINinitial)
            {
                // schimba pinul initial la cel nou
                PINinitial = PINnou;

                
                MessageBox.Show("PIN schimbat cu succes !");
            }
            else
            {
                
                MessageBox.Show("PIN-ul vechi este incorect , mai incercati .");
            }

            
        }

            private void panel5_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        
    }
}

