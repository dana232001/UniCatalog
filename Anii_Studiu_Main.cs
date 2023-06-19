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
    public partial class Anii_Studiu_Main : Form
    {
        public Anii_Studiu_Main()
        {
            InitializeComponent();
        }
        private void Ani_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_An,NumeAn,ID_Program FROM ani";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                int id_an = reader.GetInt32(0);
                                string nume_an = reader.GetString(1);
                                int id_program = reader.GetInt32(2);
                                dataGridView1.Rows.Add(id_an, nume_an, id_program);
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

        private void adaugare_an_button_Click(object sender, EventArgs e)
        {
            Adaugare_Anii add_ani = new Adaugare_Anii();
            add_ani.FormClosing += new FormClosingEventHandler(this.Ani_Load);
            add_ani.ShowDialog();
        }

        private void stergere_an_button_Click(object sender, EventArgs e)
        {
            An_studiu_stergere sterge_an=new An_studiu_stergere();
            sterge_an.FormClosing += new FormClosingEventHandler(this.Ani_Load);
            sterge_an.ShowDialog();
        }
    }
}
