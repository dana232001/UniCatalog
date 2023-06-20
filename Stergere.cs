using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class Stergere : Form
    {
        public Stergere()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buton_OK_Click(object sender, EventArgs e)
        {
            string pattern = "^[0-9]+$";
            bool esteNumar = Regex.IsMatch(textBox1.Text, pattern);
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))

            {
                if (connection != null)
                {
                    if (esteNumar)
                    {
                        try
                        {
                            string idVerify = textBox1.Text;
                            string query = "DELETE FROM cadre WHERE ID_CadruDidactic = @ID_CD";

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID_CD", idVerify);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cadru Didactic șters cu succes!");
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a putut șterge.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("A apărut o eroare: " + ex.Message);
                        }
                        finally
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trebuie introdus un numar!");

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
