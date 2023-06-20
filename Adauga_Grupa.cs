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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicatie
{
    public partial class Adauga_Grupa : Form
    {
        public Adauga_Grupa()
        {
            InitializeComponent();
        }

        private void buton_OK_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string numeGrupa = textBox2.Text;
                        int idgrupa = int.Parse(textBox1.Text);
                        int Id_An= int.Parse(textBox3.Text);
                        string insertQuery = "INSERT INTO grupe(ID_Grupa, NumeGrupa, ID_An) VALUE (@idgrupa, @numgrupa, @idan)";

                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@idgrupa", idgrupa);
                            cmd.Parameters.AddWithValue("@numegrupa", numeGrupa);
                            cmd.Parameters.AddWithValue("@idan", Id_An);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Date inserate");
                            }
                            else
                            {
                                MessageBox.Show("Date neinserate");
                            }
                        }
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }
        }
    }
}
