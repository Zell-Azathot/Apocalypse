using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_Tentativa_sla
{
    public partial class Form4 : Form
    {
        public static class Sessao
        {
            public static string usuarioLog { get; set; } = string.Empty;
            public static bool ADMIN
            {
                get { return usuarioLog == "ADMIN"; }
            }
        }

        string caminhoCsv = Path.Combine(Application.StartupPath, "usuarios.txt");

        public Form4()
        {
            InitializeComponent();

            atualizardgv();

            if (Sessao.ADMIN)
            {
                this.Text = "Bem Vindo administrador";
            }
            else
            {
                this.Text = "Olá Abençado da Yggdrasil";
                label1.Text = "Nome de Usuario:";
                txtUser.Text = Sessao.usuarioLog;
                string[] linhas = File.ReadAllLines(caminhoCsv);
                foreach (string line in linhas)
                {
                    string[] partes = line.Split(",");
                    if (partes[0] == Sessao.usuarioLog)
                    {
                        txtSenha.Text = partes[1];
                    }
                }
                btnExcluir.Visible = false;
                dgvCadastrar.Visible = false;
                dgvUsers.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor não deixe os valores vazios, não gostamos deles aqui");
            }
            string[] linhas = File.ReadAllLines(caminhoCsv);
            List<string> novasLinhas = new List<string>();

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(",");
                if (partes.Length >= 2 && partes[0] == user)
                {
                    novasLinhas.Add($"{user},{senha}");
                }
                else
                {
                    novasLinhas.Add(linha);
                }
            }

            File.WriteAllLines(caminhoCsv, novasLinhas.ToArray());
            MessageBox.Show("Atualizado com sucesso!");
            atualizardgv();
            txtUser.Text = "";
            txtSenha.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();

            string[] linhas = File.ReadAllLines(caminhoCsv);
            List<string> novasLinhas = new List<string>();

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');

                if (partes.Length >= 2 && partes[0] != user)
                    novasLinhas.Add(linha);
            }

            File.WriteAllLines(caminhoCsv, novasLinhas.ToArray());
            MessageBox.Show("Usuário excluído com sucesso!");
            atualizardgv();
            txtUser.Text = "";
            txtSenha.Text = "";
        }

        private void dgvCadastrar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor não deixe os valores vazios, não gostamos deles aqui");
            }

            string[] linhas = File.ReadAllLines(caminhoCsv);
            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');

                if (partes.Length >= 2 && partes[0] == user)
                {
                    MessageBox.Show("Duas pessoas com o mesmo nome? Isso não vai dar certo, escolha outro.");
                }
                using (StreamWriter sw = File.AppendText(caminhoCsv))
                {
                    sw.WriteLine($"{user},{senha}");
                }

                MessageBox.Show("Usuário cadastrado com sucesso!");
            }

            atualizardgv();
            txtUser.Text = "";
            txtSenha.Text = "";
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                txtSenha.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtUser.Text = dgvUsers.Rows[e.RowIndex].Cells[0].Value?.ToString();
            }
        }
        private void atualizardgv()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Columns.Clear();
            dgvUsers.Columns.Add("Usuario", "Usuário");
            dgvUsers.Columns.Add("Senha", "Senha");
            string[] linhas = File.ReadAllLines(caminhoCsv);
            foreach (string line in linhas)
            {
                string[] partes = line.Split(",");
                if (partes.Length > 0)
                {
                    dgvUsers.Rows.Add(partes[0], partes[1]);
                }
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtSenha.Focus();
            }
        }
    }

}
