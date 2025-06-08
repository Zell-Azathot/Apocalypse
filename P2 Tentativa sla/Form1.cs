using System.DirectoryServices.ActiveDirectory;
using System;
using System.IO;
using System.Windows.Forms;

namespace P2_Tentativa_sla
{
    public partial class Form1 : Form
    {
        string nome = "usuarios";
        public Form1()
        {
            InitializeComponent();
            string caminhoCsv = Path.Combine(Application.StartupPath, nome);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validacao();
        }

        public void validacao()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Todos os Campos devem ser preenchidos", "Erro", MessageBoxButtons.OK);
            }
            if (usuario == "ADMIN" || senha == "123")
            {
                Form2 frm = new Form2();
                frm.ShowDialog();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.PerformClick();
            }
        }
    }
}
