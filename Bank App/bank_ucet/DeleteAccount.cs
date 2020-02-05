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
    public partial class DeleteAccount : Form
    {

        private OleDbConnection connection = new OleDbConnection();

        public DeleteAccount()
        {
            InitializeComponent();

            connection.ConnectionString =                                        // connection string pre pracu s access db
                    @"
                    Provider = Microsoft.ACE.OLEDB.12.0; 
                    Data Source = main_db.accdb;   
                    Persist Security Info=False;
                    ";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();                                       // otvorenie pripojenia

                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;                        // vytvorenie pripojenia

                // VYMAZANIE Dat v DB
                string query =

                    "DELETE from bankovy_ucet WHERE ID=" + txt_id.Text + "";

                // MessageBox.Show(query);                  // informativny vypis

                command.CommandText = query;

                // VKLADANIE DO query - proporties - nonquary(bacha na medzeri)                      
                // vyberie z databazy "main_db" username a password
                // PRI VKLADANI DAT - INSERT / UPADETE / DELETE / - NEPOTREBUJEME NIC CITAT 
                // OleDbDataReader reader = command.ExecuteReader();           // reader bude obsahovat data z query
                // ak chceme dostat nejake data z databazy (GET)
                // PRI VKLADANI DO DB

                command.ExecuteNonQuery();

                MessageBox.Show("DATA VYMAZANE!");
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

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();                                       // otvorenie pripojenia

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;                        // vytvorenie pripojenia

                string query = "SELECT * from bankovy_ucet";                          // vyberie vsetky stlpce v tabulke bankovy ucet

                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())              // nacita vsetky data
                {
                    combox_list.Items.Add(reader["Priezvisko"].ToString());   // vsetky nacitane data vlozime do combo boxu
                }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();                    // skryje form1

            MainMenu f1 = new MainMenu();         // vyvorime objekt form2
            f1.ShowDialog();
        }

        private void combox_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();                                       // otvorenie pripojenia

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;                        // vytvorenie pripojenia

                string query = "SELECT * from bankovy_ucet WHERE Priezvisko='" + combox_list.Text + "'";    // bude to porovnane s meno v db a nasledne vypise vysledok

                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())              // nacita vsetky data
                {
                    txt_id.Text = reader["ID"].ToString();
                    //txt_name.Text = reader["Meno"].ToString();
                    //txt_surname.Text = reader["Priezvisko"].ToString();
                    //txt_balance.Text = reader["Zostatok"].ToString();

                    // NAPLNENIE UDAJOV V TABULKE PROGRAMU z databazy do textovych poli zadanych vyssie
                }

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

        private void txt_zoznam_Click(object sender, EventArgs e)
        {

        }
    }
}
