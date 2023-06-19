using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Aplicatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            
            string user = userbox.Text;
            string pass = passbox.Text;
            pictureBox_load.Visible = true;
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ProfilUtilizator FROM utilizatori WHERE NumeUtilizator='";
                        query += userbox.Text;
                        query += "'";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Global.utilizator = reader.GetString(0);
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

            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM utilizatori WHERE NumeUtilizator = @username AND ParolaUtilizator = @password";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", userbox.Text);
                    command.Parameters.AddWithValue("@password", passbox.Text);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Autentificare reușită
                        MessageBox.Show("Autentificare reușită!");
                        Meniu_Principal afterLogin = new Meniu_Principal();
                        afterLogin.Show();
                        this.Hide();
                        //this.Close();
                    }
                    else
                    {
                        // Autentificare eșuată
                        MessageBox.Show("Autentificare eșuată!");

                    }
                }
                catch (Exception ex)
                {
                    // Tratarea erorilor
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }

        }

    }
}


public static class Global
{
    public const string connectionString = "server=www.db4free.net;port=3306;database=poolms;user=admincatalog;password=poolms123;";
    public static string utilizator = "";
}