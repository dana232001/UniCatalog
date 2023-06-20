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
    public partial class Grupe_main : Form
    {
        public Grupe_main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grupe_main_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT grupe.Id_Grupa, grupe.NumeGrupa, studenti.ID_Student, grupe.ID_An FROM grupe INNER JOIN studenti ON grupe.ID_Grupa = studenti.ID_Grupa";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int IDG = reader.GetInt32(0);
                                string NG = reader.GetString(1);
                                int IDS = reader.GetInt32(2);
                                int IDA = reader.GetInt32(3);
                                dataGridView1.Rows.Add(IDG, NG, IDS, IDA);
                            }

                            dataGridView1.Refresh();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }
        }

        private void buton_grupe_adaugare_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                Adauga_Grupa adaugare = new Adauga_Grupa();
                adaugare.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }

        private void buton_grupe_modificare_Click(object sender, EventArgs e)
        {

        }

        private void buton_grupe_stergere_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                Sterge_Grupa edit = new Sterge_Grupa();
                edit.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                AdaugareStudGr edit = new AdaugareStudGr();
                edit.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }
    }
}
