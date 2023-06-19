using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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
    public partial class Stergere_studenti : Form
    {
        public Stergere_studenti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {

                try
                {
                    string query = "DELETE FROM studenti WHERE NumarMatricol = '" + textBox2.Text + "';";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Datele au fost sterse");
                    }
                    else
                    {
                        MessageBox.Show("Datele nu au fost sterse");
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
    }
    }

