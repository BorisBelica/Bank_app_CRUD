using System;
using System.Windows.Forms;
using System.Data.OleDb;        // microsoft access Database oleDb

namespace bank_ucet
{
    public partial class MainMenu : Form
    {
        private OleDbConnection connection = new OleDbConnection();             // deklaracia premmenej pre form1 connection

        public MainMenu()          // konstruktor form1
        {
            InitializeComponent();

            connection.ConnectionString =                                        // connection string pre pracu s access db
                    @"
                    Provider = Microsoft.ACE.OLEDB.12.0; 
                    Data Source = main_db.accdb;     
                    Persist Security Info=False;
                    ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();                                    // otvorenie pripojenia
                checkConnection.Text = "[DB]: OK";       // ak bude pripojenie uspesne
                connection.Close();                                 // ukoncenie pripojenia
            }

            catch (Exception ex)
            {
                MessageBox.Show("[DB]: ERROR" + ex);            // NIE SI PRIPOJENY NA DATABAZU
                // ak nebude pripojenie usepsne
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();                                    // otvorenie pripojenia

            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;                        // vytvorenie pripojenia
            command.CommandText = "SELECT * from bankovy_ucet where Username='" + txt_username.Text + "'and Password='" + txt_password.Text + "'"; // deklaracia query (bacha na medzeri)
            // vyberie z databazy "main_db" username a password

            OleDbDataReader reader = command.ExecuteReader();           // reader bude obsahovat data z query
            // ak chceme dostat nejake data z databazy (GET)

            int count = 0;      // pocitadlo premennych

            while (reader.Read())       // ak bude true bude citat data
            {
                count = count + 1;
            }

            if (count == 1)
            {
                // MessageBox.Show("Username and Password is CORRECT");
                // ak sa v db nachadza len jeden krat

                connection.Close();             // najprv uzatvorime pripojenie, pred otvorenim novej formy
                connection.Dispose();           // uvolnenie form1
                this.Hide();                    // skryje form1

                LoginAccess f2 = new LoginAccess();         // vyvorime objekt form2
                f2.ShowDialog();                // otvorenie form2, ak su udaje spravne

            }

            else if (count > 1)
            {
                MessageBox.Show("DUPLICATED USERNAME!");
            }
            // ak sa v db nachadza viac rovnakych zaznamov

            else
            {
                MessageBox.Show("USER NOT FOUND!");
            }
            connection.Close();                                    // uzatovrenie pripojenia
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            connection.Close();             // najprv uzatvorime pripojenie, pred otvorenim novej formy
            connection.Dispose();           // uvolnenie form1
            this.Hide();                    // skryje form1

            NewAccount f3 = new NewAccount();         // vyvorime objekt form2
            f3.ShowDialog();                // otvorenie form2, ak su udaje spravne
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            connection.Close();             // najprv uzatvorime pripojenie, pred otvorenim novej formy
            connection.Dispose();           // uvolnenie form1
            this.Hide();                    // skryje form1

            DeleteAccount f4 = new DeleteAccount();         // vyvorime objekt form2
            f4.ShowDialog();                // otvorenie form2, ak su udaje spravne
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            connection.Close();             // najprv uzatvorime pripojenie, pred otvorenim novej formy
            connection.Dispose();           // uvolnenie form1
            this.Hide();                    // skryje form1

            ChangeAccData f5 = new ChangeAccData();         // vyvorime objekt form2
            f5.ShowDialog();                // otvorenie form2, ak su udaje spravne
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();                                    // otvorenie pripojenia
                checkConnection.Text = "[DB]: OK";       // ak bude pripojenie uspesne
                connection.Close();                                 // ukoncenie pripojenia
            }

            catch (Exception ex)
            {
                MessageBox.Show("[DB]: ERROR" + ex);            // NIE SI PRIPOJENY NA DATABAZU
                // ak nebude pripojenie usepsne
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();                                    // otvorenie pripojenia
                checkConnection.Text = "[DB]: OK";       // ak bude pripojenie uspesne
                connection.Close();                                 // ukoncenie pripojenia
            }

            catch (Exception ex)
            {
                MessageBox.Show("[DB]: ERROR" + ex);            // NIE SI PRIPOJENY NA DATABAZU
                // ak nebude pripojenie usepsne
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Close();             // najprv uzatvorime pripojenie, pred otvorenim novej formy
            connection.Dispose();           // uvolnenie form1
            this.Hide();                    // skryje form1

            News f6 = new News();         // vyvorime objekt form2
            f6.ShowDialog(); 
        }
    }
}
