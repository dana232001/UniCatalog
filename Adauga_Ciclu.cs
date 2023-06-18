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
            string nume = textBox_nume.Text;
            string id = textBox_id.Text;
            int er = 0;

            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "INSERT INTO cicluri(ID_Ciclu,NumeCiclu) Values(" + id + "," + nume + ");";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

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
                        MessageBox.Show("Ciclu de invatamant adaugat!");
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
 
   
    
