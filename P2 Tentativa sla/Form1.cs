using System.DirectoryServices.ActiveDirectory;
using System;
using System.IO;
using System.Windows.Forms;

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
            validacao();
        }

        public void validacao()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string caminhoCsv = Path.Combine(Application.StartupPath, "usuarios.txt");
            
            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Todos os Campos devem ser preenchidos", "Erro", MessageBoxButtons.OK);
            }
            
            if (!File.Exists(caminhoCsv))
            {
                File.WriteAllText(caminhoCsv, "ADMIN,123" + Environment.NewLine);
                MessageBox.Show("infelizmente houve um erro, por favor tente de novo");
                return;
            }

            string[] linhas = File.ReadAllLines(caminhoCsv);
            bool VRmingo = false;

            foreach (string line in linhas)
            {
                string[] dados = line.Split(",");

                if (dados.Length == 2)
                {
                    string user = dados[0];
                    string sen = dados[1];

                    if (user == usuario && sen == senha)
                    {
                        VRmingo = true;
                    }
                }
            }

            if (VRmingo == true)
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
