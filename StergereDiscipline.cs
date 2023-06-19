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
    public partial class StergereDiscipline : Form
    {
        public StergereDiscipline()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            if (textBox_IDD.Text != "")
            {
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "DELETE FROM planuri WHERE ID_Disciplina=";
                            query += textBox_IDD.Text;

                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                            }
                            MessageBox.Show("Disciplina stearsa");
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
                MessageBox.Show("Introduceti ID Disciplina");
            }
        }
    }
}
