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
    public partial class AdaugareDisciplina : Form
    {
        public AdaugareDisciplina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "" && textBox_ND.Text != "" && textBox_AD.Text != "" && textBox_NRC.Text != "" && textBox_IDA.Text != "")
            {
                string ID = textBox_ID.Text;
                string ND = textBox_ND.Text;
                string AD = textBox_AD.Text;
                string NRC = textBox_NRC.Text;
                string IDA = textBox_IDA.Text;
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "INSERT INTO `planuri` (ID_Disciplina,NumeDisciplina,AcronimDisciplina,NumarCredite,ID_An) VALUES ('";
                            query += ID + "','" + ND + "','" + AD + "','" + NRC + "','" + IDA + "');";
                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                            }
                            MessageBox.Show("Disciplina Adaugata");
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
                MessageBox.Show("Nu se poate adauga o disciplina cu date incomplete", "Eroare");
            }
        }
    }
}
