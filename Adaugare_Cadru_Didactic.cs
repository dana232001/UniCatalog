using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class Adaugare_Cadru_Didactic : Form
    {
        public Adaugare_Cadru_Didactic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buton_OK_Click(object sender, EventArgs e)
        {
            string IDCD = textBox1.Text;
            string NCD = textBox2.Text;
            string PCD = textBox3.Text;
            string MA = textBox4.Text;
            string TL = textBox5.Text;
            string PT = textBox6.Text;


            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                try
                {

                    string query = "INSERT INTO cadre (ID_CadruDidactic, NumeCadruDidactic,PrenumeCadruDidactic,MarcaAngajat   ,Titlu,Post) VALUES (@id, @nume, @prenume, @marcaangajat, @titlu, @post)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", IDCD);
                    command.Parameters.AddWithValue("@nume", NCD);
                    command.Parameters.AddWithValue("@prenume", PCD);
                    command.Parameters.AddWithValue("@marcaangajat", MA);
                    command.Parameters.AddWithValue("@titlu", TL);
                    command.Parameters.AddWithValue("@post", PT);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
                finally
                {
                    this.Close();

                }
            }
        }
    }
}
