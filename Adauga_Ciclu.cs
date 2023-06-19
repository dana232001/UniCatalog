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
    public partial class Adauga_Ciclu : Form
    {
        public Adauga_Ciclu()
        {
            InitializeComponent();
        }

        private void button_ok_ciclu_inv_Click(object sender, EventArgs e)
        {
            string idc = textBox_id.Text;
            string nume = textBox_nume.Text;
            int er = 0;
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "INSERT INTO cicluri(ID_Ciclu,NumeCiclu) Values('" + idc + "','" + nume + "');";

                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    string idCiclu = reader.GetString(0);
                                    string numec = reader.GetString(1);
                                    string listItem = string.Format("ID Ciclu: {0} - Nume: {1}", idCiclu, numec);
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
                            MessageBox.Show("Ciclu adaugat");
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
 
   
    
