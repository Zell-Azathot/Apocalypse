using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace P2_Tentativa_sla
{
    public partial class Form6 : Form
    {
        string Caminho1 = Path.Combine(Application.StartupPath, "pedidos.txt");
        string Caminho2 = Path.Combine(Application.StartupPath, "clientes.txt");
        string Caminho3 = Path.Combine(Application.StartupPath, "produtos.txt");
        public Form6()
        {
            InitializeComponent();
            if (!File.Exists(Caminho1))
            {
                File.WriteAllText(Caminho1, "" + Environment.NewLine);
                return;
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoTotal_TextChanged(object sender, EventArgs e)
        {
            float val = float.Parse(txtPreco.Text);
            float val1 = (float)numericUpDown1.Value;

            float resul = val * val1;
            txtPrecoTotal.Text = resul.ToString();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines(Caminho2);
            string cpf = txtCPF.Text;

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(",");
                if (partes.Length > 2 && partes[1] == cpf)
                {
                    txtNome.Text = partes[0];
                    return;
                }
                if (string.IsNullOrEmpty(txtCPF.Text))
                {
                    MessageBox.Show("Por Favor escreva algo no Cpf");
                    return;
                }
                else
                {
                    MessageBox.Show("Desculpe, mas esse cliente não foi encontrado.");
                    return;
                }
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines(Caminho3);
            string nome = txtNomeProduto.Text;

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length > 2 && partes[0] == nome)
                {
                    txtPreco.Text = partes[1];
                    return;
                }
                if (string.IsNullOrEmpty(nome))
                {
                    MessageBox.Show("Desculpe, mas só conseguimos achar um produto se você nos diser o nome dele.");
                    return;
                }
                else
                {
                    MessageBox.Show("\"Olá, Descukoe mas não encontramos esse produto em nosso sistema\"");
                    return;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nome Do Cliente";
            dataGridView1.Columns[0].Name = "CPF Do Cliente";
            dataGridView1.Columns[0].Name = "Nome do Produto";
            dataGridView1.Columns[1].Name = "Preço do Produto";
            dataGridView1.Columns[2].Name = "Descrição do Produto";
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {

        }
    }
}
