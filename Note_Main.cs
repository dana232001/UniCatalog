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
    public partial class Note_Main : Form
    {
        public Note_Main()
        {
            InitializeComponent();
        }

        private void Note_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Catalog,ID_Student,ID_Disciplina,Nota FROM cataloage";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                int idCatalog = reader.GetInt32(0);
                                int idStudent = reader.GetInt32(1);
                                int idDisciplina = reader.GetInt32(2);
                                float Nota = reader.GetInt32(3);
                                dataGridView1.Rows.Add(idCatalog, idStudent, idDisciplina, Nota);
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

        private void button_adaugare_Click(object sender, EventArgs e)
        {
            Note_Adaugare adauga = new Note_Adaugare();
            adauga.FormClosing += new FormClosingEventHandler(this.Note_Load);
            adauga.ShowDialog();

        }


        private void button_salvare_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TSV File|*.tsv";
            saveFileDialog1.Title = "Save a TSV File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int[] ids = new int[125];
                int nrid = 0;
                TextWriter tsv = new StreamWriter(saveFileDialog1.FileName);
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        int nrs = 0;
                        try
                        {
                            string query = "SELECT DISTINCT ID_Student FROM cataloage";
                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int idst = reader.GetInt32(0);
                                    ids[nrid] = idst;
                                    nrid++;
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
                        tsv.WriteLine("Nume\tPrenume\tNote");
                        for (int i = 0; i < nrid; i++)
                        {
                            try
                            {
                                string query = "SELECT studenti.NumeStudent,studenti.PrenumeStudent, planuri.AcronimDisciplina, cataloage.Nota FROM `cataloage` INNER JOIN planuri ON cataloage.ID_Disciplina = planuri.ID_Disciplina INNER JOIN studenti ON cataloage.ID_Student = studenti.ID_Student WHERE cataloage.ID_Student =";
                                query += ids[i].ToString();
                                query += ";";
                                float media = 0;
                                float nr = 0;
                                int restantier = 0;
                                MySqlCommand command = new MySqlCommand(query, connection);
                                connection.Open();
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    int x = 0;
                                    while (reader.Read())
                                    {
                                        string nume = reader.GetString(0);
                                        string prenume = reader.GetString(1);
                                        string Disciplina = reader.GetString(2);
                                        float Nota = reader.GetFloat(3);
                                        if (Nota >= 0 && Nota <= 10)
                                        {
                                            media += Nota;
                                            nr++;
                                        }
                                        if (x == 0)
                                        {
                                            tsv.Write(nume + "\t" + prenume + "\t" + Nota.ToString());
                                        }
                                        else
                                        {
                                            tsv.Write("\t" + Nota);
                                        }
                                        if (Nota < 5)
                                        {
                                            restantier++;
                                        }
                                        x++;
                                    }
                                    media /= nr;
                                    tsv.Write("\t" + media.ToString());
                                    if (restantier == 0)
                                    {
                                        tsv.WriteLine("\tintegralist");
                                    }
                                    else
                                    {
                                        tsv.WriteLine("\trestantier");
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

                    }
                    else
                    {
                        MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                    }
                }
                tsv.Close();
                MessageBox.Show("Fisier salvat");
            }

        }
    }
}
