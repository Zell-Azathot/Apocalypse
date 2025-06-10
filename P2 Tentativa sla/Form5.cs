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
            string linha = $"{txtNome.Text},{txtPreco},{txtDescrição}";
            File.AppendAllText(caminhoCsv, linha + Environment.NewLine);
            MessageBox.Show("Produto Salvo com sucesso!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            var linhas = File.ReadAllLines(caminhoCsv);
            var novasLinhas = new List<string>();

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length >= 2 && partes[1] == nome)
                {
                    string nova = $"{txtNome.Text},{txtPreco},{txtDescrição}";
                    novasLinhas.Add(nova);
                }
                else
                {
                    novasLinhas.Add(linha);
                }
            }

            File.WriteAllLines(caminhoCsv, novasLinhas);
            MessageBox.Show("Produto atualizado atualizado!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
