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
    public partial class An_studiu_stergere : Form
    {
        public An_studiu_stergere()
        {
            InitializeComponent();
        }

        private void button_stergereAN_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {

                try
                {
                    string query = "DELETE FROM ani WHERE ID_An = '" + id_an.Text + "';";
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
