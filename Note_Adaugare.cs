﻿using MySql.Data.MySqlClient;
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
    public partial class Note_Adaugare : Form
    {
        public Note_Adaugare()
        {
            InitializeComponent();
        }

        private void Note_Adaugare_Load(object sender, EventArgs e)
        {

        }

        private void button_adaugare_Click(object sender, EventArgs e)
        {

                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "INSERT INTO `cataloage` (`ID_Catalog`, `ID_Student`, `ID_Disciplina`, `Nota`) VALUES ('"+textBox_catalog.Text+"','"+textBox_student.Text+"','"+textBox_disciplina.Text+"','"+textBox_nota.Text+");";

                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
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

            

        }
    }
}
