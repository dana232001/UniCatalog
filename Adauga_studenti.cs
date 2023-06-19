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
    public partial class Adauga_studenti : Form
    {
        public Adauga_studenti()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buton_ok_Click(object sender, EventArgs e)
        {
            string idstudent = id_student.Text;
            string nrmat = nr_matricol.Text;
            string nume = nume_student.Text;
            string prenume = prenume_student.Text;
            string initiala = initiala_t.Text;
            string cn_p = cnp.Text;
            string data = Data_inscriere.Text;
            string ciclu = id_ciclu.Text;
            string med = medie.Text;
            int er = 0;

            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "INSERT INTO studenti(ID_Student,NumarMatricol,NumeStudent,PrenumeStudent,InitialaTata,CNP,DataInscriere," +
                            "ID_Ciclu,MediaInscriere) Values('" + idstudent + "','" + nrmat + "','" + nume + "','" + prenume + "','" + initiala + "','" +
                            cn_p + "','" + data + "','" + ciclu + "','" + med + "');";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string idS = reader.GetString(0);
                                string nrm = reader.GetString(1);
                                string numS = reader.GetString(2);
                                string prenumeS = reader.GetString(3);
                                string init = reader.GetString(4);
                                string c_np = reader.GetString(5);
                                string dat = reader.GetString(6);
                                string idC = reader.GetString(7);
                                string medi = reader.GetString(8);

                                string listItem = string.Format("ID_Student: {0} - Numar: {1}- Nume: {2} - Prenume: {3} - Initiala: {4} - " +
                                    "CNP: {5}  -  Data: {6} - Ciclu: {7} - Medie: {8}", idS, nrm, numS, prenumeS, init, c_np, dat, idC, medi);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message);
                        er++;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    if (er == 0)
                    {
                        MessageBox.Show("Student adaugat");
                        nume_student.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }
        }
    }
}

