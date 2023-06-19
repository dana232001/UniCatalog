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
    public partial class Studenti_Main : Form
    {
        public Studenti_Main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Student_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Student,NumarMatricol,NumeStudent,PrenumeStudent,InitialaTata,CNP,DataInscriere," +
                            "ID_Ciclu,MediaInscriere FROM studenti";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                string idstudent = reader.GetString(0);
                                int nrmatricol = reader.GetInt32(1);
                                string nume = reader.GetString(2);
                                string prenume = reader.GetString(3);
                                string initiala = reader.GetString(4);
                                string cnp = reader.GetString(5);
                                string data = reader.GetString(6);
                                string id_ciclu = reader.GetString(7);
                                int media = reader.GetInt32(8);

                                dataGridView1.Rows.Add(idstudent, nrmatricol, nume, prenume, initiala, cnp, data, id_ciclu, media);
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
        private void button1_Click(object sender, EventArgs e)
        {
            Adauga_studenti add_student = new Adauga_studenti();
            add_student.FormClosing += new FormClosingEventHandler(this.Student_Load);
            add_student.ShowDialog();
        }

        private void buton_sterge_Click(object sender, EventArgs e)
        {
            Stergere_studenti delete_student = new Stergere_studenti();
            delete_student.FormClosing += new FormClosingEventHandler(this.Student_Load);
            delete_student.ShowDialog();
        }
    }
}
