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
        public static class sessao
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

            if (sessao.ADMIN)
            {
                this.Text = "Bem Vindo administrador";
            }
            else
            {
                this.Text = "Olá Abençado da Yggdrasil";
                label1.Text = "Nome de Usuario:";
                txtUser.Text = sessao.usuarioLog;
                string[] linhas = File.ReadAllLines(caminhoCsv);
                foreach (string line in linhas)
                {
                    string[] partes = line.Split(",");
                    if (partes[0] == sessao.usuarioLog)
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

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgvCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
