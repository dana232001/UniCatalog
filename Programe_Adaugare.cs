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
    public partial class Programe_Adaugare : Form
    {
        public Programe_Adaugare()
        {
            InitializeComponent();
        }

        private void button_salvare_adg_program_Click(object sender, EventArgs e)
        {
            string idp = id_program.Text;
            string nume = nume_program.Text;
            string idc=id_ciclu.Text;
            int er = 0;
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "INSERT INTO specializari(ID_Program,NumeProgram,ID_Ciclu) Values('" + idp + "','" + nume + "','"+idc+"');";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string idprogram = reader.GetString(0);
                                string numeprogram = reader.GetString(1);
                                string idciclu=reader.GetString(2);
                                string listItem = string.Format("ID Program: {0} - Nume: {1} - ID Ciclu: {2}", idprogram, numeprogram,idciclu);
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
                        MessageBox.Show("Program adaugat");
                        nume_program.Text = "";
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
