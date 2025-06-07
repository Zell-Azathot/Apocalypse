using System.DirectoryServices.ActiveDirectory;

namespace P2_Tentativa_sla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "ADM" && txtSenha.Text == "123")
            {
                Form2 frm = new Form2();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Senha ou usuario incorreto");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
