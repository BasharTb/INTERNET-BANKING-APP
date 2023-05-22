namespace Proiect__IOC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login ob = new login();
            this.Hide();
            ob.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PasswordVerifyATM aTM = new PasswordVerifyATM();
            aTM.ShowDialog();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateCreareCont dateCreareCont = new DateCreareCont();
            dateCreareCont.ShowDialog();
        }
    }
}