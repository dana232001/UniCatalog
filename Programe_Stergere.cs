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
    public partial class Programe_Stergere : Form
    {
        public Programe_Stergere()
        {
            InitializeComponent();
        }

        private void button_ok_sterge_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {

                try
                {
                    string query = "DELETE FROM specializari WHERE ID_Program = '" + stergere_program_textbox.Text + "';";
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
