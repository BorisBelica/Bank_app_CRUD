using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;        // microsoft access Database oleDb

namespace bank_ucet
{

    public partial class NewAccount : Form
    {
        private OleDbConnection connection = new OleDbConnection();             // deklaracia premmenej pre form1 connection

        public NewAccount()
        {
            InitializeComponent();

            connection.ConnectionString =                                        // connection string pre pracu s access db
                    @"
                    Provider = Microsoft.ACE.OLEDB.12.0; 
                    Data Source = main_db.accdb;       
                    Persist Security Info=False;
                    ";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();                                       // otvorenie pripojenia

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;                        // vytvorenie pripojenia

                string query = "SELECT * from bankovy_ucet";                          // vyberie vsetky stlpce v tabulke bankovy ucet

                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                connection.Close();
                // vzdy je potrebne ukoncit pripojenie k db
                // jedno pripojenie v realnóm case
            }

            catch (Exception ex)
            {
                MessageBox.Show("[ERROR] " + ex);
                // ak nebude pripojenie usepsne
            }
        }

        private void btn_save_data_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();                                    // otvorenie pripojenia

                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;                        // vytvorenie pripojenia


                command.CommandText = "INSERT into bankovy_ucet (Meno, Priezvisko, Zostatok) values('" + txt_name.Text + "','" + txt_surname.Text + "','" + txt_balance.Text + "')";
                // kam chceme vlozit data, a ake udaje - nazvy texboxov, do ktorych data ukladame



                // VKLADANIE DO query - proporties - nonquary(bacha na medzeri)                      
                // vyberie z databazy "main_db" username a password

                // PRI VKLADANI DAT - INSERT / UPADETE / DELETE / - NEPOTREBUJEME NIC CITAT 
                // OleDbDataReader reader = command.ExecuteReader();           // reader bude obsahovat data z query
                // ak chceme dostat nejake data z databazy (GET)

                // PRI VKLADANI DO DB
                command.ExecuteNonQuery();

                MessageBox.Show("DATA USPESNE VYTVORENE!");
                // ak nebude pripojenie usepsne

                connection.Close();
                // vzdy je potrebne ukoncit pripojenie k db
                // jedno pripojenie v realnóm case
            }

            catch (Exception ex)
            {
                MessageBox.Show("[ERROR] " + ex);
                // ak nebude pripojenie usepsne
            }
        }

        private void txt_balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();                    // skryje form1

            MainMenu f1 = new MainMenu();         // vyvorime objekt form2
            f1.ShowDialog();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
