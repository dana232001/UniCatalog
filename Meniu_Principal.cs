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
    }
}
