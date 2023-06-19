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
    public partial class Meniu_Principal : Form
    {
        public Meniu_Principal()
        {
            InitializeComponent();
        }

        private void Cicluri_inv_buton_Click(object sender, EventArgs e)
        {
            Cicluri_main ciclu_invatamant = new Cicluri_main();
            ciclu_invatamant.Show();
        }

        private void Note_buton_Click(object sender, EventArgs e)
        {
            Note_Main note = new Note_Main();
            note.Show();
        }

        private void _studii_buton_Click(object sender, EventArgs e)
        {
            Programe_Main programe = new Programe_Main();
            programe.Show();
        }

        private void Anii_studiu_buton_Click(object sender, EventArgs e)
        {
            Anii_Studiu_Main anii_de_studiu = new Anii_Studiu_Main();
            anii_de_studiu.Show();
        }

        private void Studenti_buton_Click(object sender, EventArgs e)
        {
            Studenti_Main student = new Studenti_Main();
            student.Show();

        }
    }
}
