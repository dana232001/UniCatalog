namespace poo_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = userbox.Text;
            pass = passbox.Text;
            if (user == "1" && pass == "1")
            {
                MessageBox.Show("successful");

            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}