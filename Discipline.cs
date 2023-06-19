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
    public partial class Discipline : Form
    {
        public Discipline()
        {
            InitializeComponent();
        }

        private void Discipline_Load(object sender, EventArgs e)
        {
            using MySqlConnection connection = new MySqlConnection(Global.connectionString);
            if (connection != null)
            {
                try
                {
                    string query = "SELECT ID_Disciplina,NumeDisciplina,AcronimDisciplina,NumarCredite,ID_An FROM planuri";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        while (reader.Read())
                        {
                            string ID = reader.GetString(0);
                            string ND = reader.GetString(1);
                            string AD = reader.GetString(2);
                            string NRC = reader.GetString(3);
                            string IDA = reader.GetString(4);
                            dataGridView1.Rows.Add(ID, ND, AD, NRC, IDA);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secretar")
            {
                AdaugareDisciplina dia = new AdaugareDisciplina();
                dia.FormClosing += new FormClosingEventHandler(this.Discipline_Load);
                dia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                StergereDiscipline dis = new StergereDiscipline();
                dis.FormClosing += new FormClosingEventHandler(this.Discipline_Load);
                dis.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }
    }
}
