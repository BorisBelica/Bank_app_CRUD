using System;
using System.Windows.Forms;

namespace bank_ucet
{
    public partial class News : Form
    {
        public News()
        {
            InitializeComponent();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();                    // skryje form1

            MainMenu f1 = new MainMenu();         // vyvorime objekt form2
            f1.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
