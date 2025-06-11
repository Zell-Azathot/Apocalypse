using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P2_Tentativa_sla
{
    public partial class Form5 : Form
    {

        string caminhoCsv = Path.Combine(Application.StartupPath, "produtos.txt");

        public Form5()
        {
            InitializeComponent();
            if (!File.Exists(caminhoCsv))
            {
                File.WriteAllText(caminhoCsv, "" + Environment.NewLine);
                return;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nome do Produto";
            dataGridView1.Columns[1].Name = "Preço do Produto";
            dataGridView1.Columns[2].Name = "Descrição do Produto";
            AtualizarGrid();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescrição_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines(caminhoCsv);
            string nome = txtNome.Text;

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length > 0 && partes[0] == nome)
                {
                    MessageBox.Show("Este produto já esta cadastrado em nosso sistema, por favor digite outro Nome.");
                    return;
                }
            }
            string lin = $"{txtNome.Text},{txtPreco.Text},{txtDescrição.Text}";
            File.AppendAllText(caminhoCsv, lin + Environment.NewLine);
            MessageBox.Show("Produto Salvo com sucesso!");
            AtualizarGrid();
            LimparCampos();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            var linhas = File.ReadAllLines(caminhoCsv);
            var novasLinhas = new List<string>();

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length >= 2 && partes[0] == nome)
                {
                    string nova = $"{txtNome.Text},{txtPreco},{txtDescrição}";
                    novasLinhas.Add(nova);
                }
                if (partes[0] == nome)
                {
                    MessageBox.Show("Este produto já esta cadastrado em nosso sistema, por favor digite outro Nome.");
                    return;
                }
                else
                {
                    novasLinhas.Add(linha);
                }
            }

            File.WriteAllLines(caminhoCsv, novasLinhas);
            MessageBox.Show("Produto atualizado!");
            AtualizarGrid();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            var linhas = File.ReadAllLines(caminhoCsv);
            var novasLinhas = new List<string>();

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length >= 2 && partes[0] != nome)
                {
                    novasLinhas.Add(linha);
                }
            }
            File.WriteAllLines(caminhoCsv, novasLinhas);
            MessageBox.Show("Produto excluído!");
            AtualizarGrid();
            LimparCampos();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text.Trim();
            var linhas = File.ReadAllLines(caminhoCsv);

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes[0] == name)
                {
                    txtNome.Text = partes[0];
                    txtPreco.Text = partes[1];
                    txtDescrição.Text = partes[2];
                }
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Você não digitou um Nome para ser buscado no sistema.");
                    return;
                }
                if (partes[0] != name)
                {
                    MessageBox.Show("O Produto digitado não está registrado no nosso sistema.");
                    return;
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtPreco.Text = "";
            txtDescrição.Text = "";
        }

        private void AtualizarGrid()
        {
            dataGridView1.Rows.Clear();

            if (!File.Exists(caminhoCsv)) return;

            string[] linhas = File.ReadAllLines(caminhoCsv);

            foreach (var linha in linhas)
            {
                string[] partes = linha.Split(',');

                if (partes.Length >= 3)
                    dataGridView1.Rows.Add(partes);
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPreco.Focus();
            }
        }

        private void txtPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtDescrição.Focus();
            }
        }
        // o botão de excluir não ta funcionando, e a confirmação para não escrever o mesmo nome tambem não.
    }
}
