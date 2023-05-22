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
    public partial class frmTranzactii : Form
    {
        public frmTranzactii()
        {
            InitializeComponent();

            comboBox1.Items.Add("Ianuarie");
            comboBox1.Items.Add("Februarie");
            comboBox1.Items.Add("Martie");
            comboBox1.Items.Add("Aprilie");
            comboBox1.Items.Add("Mai");
            comboBox1.Items.Add("Iunie");
            comboBox1.Items.Add("Iulie");
            comboBox1.Items.Add("August");
            comboBox1.Items.Add("Septembrie");
            comboBox1.Items.Add("Octombrie");
            comboBox1.Items.Add("Noiembrie");
            comboBox1.Items.Add("Decembrie");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obțineți luna selectată din comboBox
            string selectedMonth = comboBox1.SelectedItem.ToString();

            // Seteaza valoarea care va fi returnată în funcție de luna selectată
            string value;
            switch (selectedMonth)
            {
                case "Ianuarie":
                    value = "\n-267 Lei Pepco" +
                            "\n-15 Lei carrefour" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+7000 Lei Salariu" +
                            "\n-430 Lei OMV Petrom";
                    break;
                case "Februarie":
                    value = "\n-69 Lei McDonald's" +
                            "\n-15 Lei Profi" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+6200 Lei Salariu" +
                            "\n-280 Lei Rom petrol"; 
                    break;
                case "Martie":
                    value = "\n-428 Lei Zara" +
                            "\n-157 Lei H&M" +
                            "\n-90 Lei sabon" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+5150 Lei Salariu" +
                            "\n-520 Lei OMV Petrom"; 
                    break;
                case "Aprilie":
                    value = "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+5150 Lei Salariu" +
                            "\n-520 Lei OMV Petrom" +
                            "\n-1000 Lei Tranzactie catre ****n";
                    break;
                case "Mai":
                    value = "\n-100 Lei KFC" +
                            "\n-328 Lei Sephora" +
                            "\n-90 Lei sabon" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+5150 Lei Salariu" +
                            "\n-720 Lei OMV Petrom";
                    break;
                case "Iunie":
                    value = "\n-67 Lei Pepco" +
                            "\n-15 Lei carrefour" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+7000 Lei Salariu" +
                            "\n-430 Lei OMV Petrom";
                    break;
                case "Iulie":
                    value = "\n-69 Lei McDonald's" +
                            "\n-15 Lei Profi" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+6200 Lei Salariu" +
                            "\n-280 Lei Rom petrol";
                    break;
                case "August":
                    value = "\n-428 Lei Zara" +
                            "\n-157 Lei H&M" +
                            "\n-90 Lei sabon" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-5150 Lei Salariu" +
                            "\n-520 Lei OMV Petrom";
                    break;
                case "Septembrie":
                    value = "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+5150 Lei Salariu" +
                            "\n-520 Lei OMV Petrom" +
                            "\n-1000 Lei Tranzactie catre ****n";
                    break;
                case "Octombrie":
                    value = "\n-100 Lei KFC" +
                            "\n-328 Lei Sephora" +
                            "\n-90 Lei sabon" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+5150 Lei Salariu" +
                            "\n-720 Lei OMV Petrom"; ;
                    break;
                case "Noiembrie":
                    value = "\n-129 Lei adidas" +
                            "\n-15 Lei carrefour" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+7000 Lei Salariu" +
                            "\n-430 Lei OMV Petrom"; ;
                    break;
                case "Decembrie":
                    value = "\n-69 Lei McDonald's" +
                            "\n-15 Lei Profi" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n-2.5 Lei Transport" +
                            "\n+6200 Lei Salariu" +
                            "\n-280 Lei Rom petrol"; ;
                    break;
                default:
                    value = "";
                    break;
            }

            // Afișează valoarea într-un MessageBox
            MessageBox.Show("Tranzactiile facute in luna selectata : " + value, "Luna Selectata", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
