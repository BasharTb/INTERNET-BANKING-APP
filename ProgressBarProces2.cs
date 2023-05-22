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
    public partial class ProgressBarProces2 : Form
    {
        public ProgressBarProces2()
        {
            InitializeComponent();
        }

        private void ProgressBarProces2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label2.Text = progressBar1.Value.ToString() + "%";
            }

            else
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreareContMeniuPrincipal creareContMeniuPrincipal = new CreareContMeniuPrincipal();
            creareContMeniuPrincipal.ShowDialog();
            this.Hide();
        }
    }
}
