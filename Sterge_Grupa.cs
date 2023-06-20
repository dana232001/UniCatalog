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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicatie
{
    public partial class Sterge_Grupa : Form
    {
        public Sterge_Grupa()
        {
            InitializeComponent();
        }

        private void buton_sterge_grupa_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {

                if (textBox1.Text != "")
                {
                    using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                    {
                        if (connection != null)
                        {
                            try
                            {
                                string query = "DELETE FROM grupe WHERE ID_Grupa=";
                                query += textBox1.Text;

                                MySqlCommand command = new MySqlCommand(query, connection);

                                connection.Open();

                                using (MySqlDataReader reader = command.ExecuteReader())
                                {

                                }
                                MessageBox.Show("Grupa stearsa");
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
                else
                {
                    MessageBox.Show("Introduceti ID Grupa");
                }
            }
        }
    }
}
