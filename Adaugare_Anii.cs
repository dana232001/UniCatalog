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
    public partial class Adaugare_Anii : Form
    {
        public Adaugare_Anii()
        {
            InitializeComponent();
        }

        private void buton_ok_adaugare_Click(object sender, EventArgs e)
        {
            string idan = textBox_id_an.Text;
            string nume = textBox_nume.Text;
            string id_program = textBox_idprogram.Text;
            int er = 0;
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "INSERT INTO ani(ID_An,NumeAn,ID_Program) Values('" + idan + "','"  + nume + "','" + id_program + "');";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string id_an = reader.GetString(0);
                                string numean = reader.GetString(1);
                                string idprogram = reader.GetString(2);

                                string listItem = string.Format("ID An: {0} - Nume: {1} - Id program: {2}", id_an, numean, idprogram);
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
                        MessageBox.Show("An adaugat");
                        textBox_nume.Text = "";
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
