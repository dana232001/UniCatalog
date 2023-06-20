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
    public partial class Cadre_didactice : Form
    {
        public Cadre_didactice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                Adaugare_Cadru_Didactic ADD_CadruD = new Adaugare_Cadru_Didactic();
                ADD_CadruD.FormClosing += new FormClosingEventHandler(this.Insert_FormClosing);
                ADD_CadruD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }

        private async void Insert_FormClosing(object sender, FormClosingEventArgs e)
        {
            await Task.Delay(2000);

            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_CadruDidactic, NumeCadruDidactic, PrenumeCadruDidactic, MarcaAngajat, Titlu, Post FROM cadredidactice";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();

                            while (reader.Read())
                            {
                                int IDCD = reader.GetInt32(0);
                                string NCD = reader.GetString(1);
                                string PCD = reader.GetString(2);
                                string MA = reader.GetString(3);
                                string TL = reader.GetString(4);
                                string PT = reader.GetString(5);

                                dataGridView1.Rows.Add(IDCD, NCD, PCD, MA, TL, PT);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }


        }


        private void Buton_Stergere_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                Stergere cD_DeleteDialog = new Stergere();
                cD_DeleteDialog.FormClosing += new FormClosingEventHandler(this.Insert_FormClosing);
                cD_DeleteDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }

        private void Cadre_didactice_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_CadruDidactic, NumeCadruDidactic, PrenumeCadruDidactic, MarcaAngajat, Titlu, Post FROM cadre";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();

                            while (reader.Read())
                            {
                                int IDCD = reader.GetInt32(0);
                                string NCD = reader.GetString(1);
                                string PCD = reader.GetString(2);
                                string MA = reader.GetString(3);
                                string TL = reader.GetString(4);
                                string PT = reader.GetString(5);

                                dataGridView1.Rows.Add(IDCD, NCD, PCD, MA, TL, PT);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
