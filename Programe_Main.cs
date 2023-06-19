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
    public partial class Programe_Main : Form
    {
        public Programe_Main()
        {
            InitializeComponent();
        }

        private void Programe_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Program,NumeProgram,ID_Ciclu FROM specializari";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                int idprogram = reader.GetInt32(0);
                                string nume_program = reader.GetString(1);
                                int id_ciclu = reader.GetInt32(2);
                                dataGridView1.Rows.Add(idprogram, nume_program, id_ciclu);
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

        private void button_adaugare_program_studii_Click(object sender, EventArgs e)
        {
            Programe_Adaugare add_program = new Programe_Adaugare();
            add_program.FormClosing += new FormClosingEventHandler(this.Programe_Load);
            add_program.ShowDialog();
        }

        private void button_stergere_program_studii_Click(object sender, EventArgs e)
        {
            Programe_Stergere delete_program = new Programe_Stergere();
            delete_program.FormClosing += new FormClosingEventHandler(this.Programe_Load);
            delete_program.ShowDialog();
        }
    }
}
