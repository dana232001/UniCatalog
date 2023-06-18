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
    public partial class Cicluri_main : Form
    {
        public Cicluri_main()
        {
            InitializeComponent();
        }

        private void Cicluri_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Ciclu,NumeCiclu FROM cicluri";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                int idciclu = reader.GetInt32(0);
                                string nume_ciclu = reader.GetString(1);
                                dataGridView1.Rows.Add(idciclu, nume_ciclu);
                            }
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
        private void button_cicluri_adaugare_Click(object sender, EventArgs e)
        {
            Adauga_Ciclu add_ciclu = new Adauga_Ciclu();
            add_ciclu.FormClosing += new FormClosingEventHandler(this.Cicluri_Load);
            add_ciclu.ShowDialog();
        }
    }
}
