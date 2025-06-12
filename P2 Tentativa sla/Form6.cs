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
using System.Globalization;

namespace P2_Tentativa_sla
{
    public partial class Form6 : Form
    {
        List<string> listaProdutos = [];
        float totalPedido = 0;
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
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines(Caminho2);
            string cpf = txtCPF.Text;

            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Por Favor escreva algo no Cpf");
                return;
            }

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(",");
                bool v = partes.Length >= 2;
                if (v && partes[1] == cpf)
                {
                    txtNome.Text = partes[0];
                    return;
                }
            }

            MessageBox.Show("Desculpe, mas esse cliente não foi encontrado.");
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines(Caminho3);
            string nome = txtNomeProduto.Text;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Desculpe, mas só conseguimos achar um produto se você nos diser o nome dele.");
                return;
            }

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length > 2 && partes[0] == nome)
                {
                    txtPreco.Text = partes[1];
                    return;
                }
            }
            MessageBox.Show("Olá, Desculpe mas não encontramos esse produto em nosso sistema");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;

            if (string.IsNullOrEmpty (nome) || string.IsNullOrEmpty (cpf))
            {
                MessageBox.Show("Por favor não deixe espaços vazios");
                return;
            }
            if (listaProdutos.Count == 0)
            {
                MessageBox.Show("Por favor adicione ao menos um produto.");
                return;
            }
            List<string> linhasPedido = new List<string>();
            linhasPedido.Add($"Cliente: {nome}, CPF: {cpf}");
            foreach (string produto in listaProdutos)
            {
                string[] partes = produto.Split(',');
                linhasPedido.Add($"Produto: {partes[0]}, Preço Unitário: {partes[1]}, Quantidade: {partes[2]}, Total: {partes[3]}");
            }
            linhasPedido.Add($"Total do Pedido: {totalPedido.ToString("F2")}");
            linhasPedido.Add("-------------------------");

            File.AppendAllLines(Caminho1, linhasPedido);

            MessageBox.Show("Pedido gravado com sucesso!");
            Adicionarnotext();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Nome Do Cliente";
            dataGridView1.Columns[1].Name = "CPF Do Cliente";
            dataGridView1.Columns[2].Name = "Nome do Produto";
            dataGridView1.Columns[3].Name = "Quantidade do Produto";
            dataGridView1.Columns[4].Name = "Preço total do Produto";
            txtNome.ReadOnly = true;
            txtPreco.ReadOnly = true;
            txtPrecoTotal.ReadOnly = true;
            
        }

        private void Adicionarnotext()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtNomeProduto.Text = "";
            txtPreco.Text = "";
            txtPrecoTotal.Text = "";
            numericUpDown1.Value = 1;
            dataGridView1.Rows.Clear();
            listaProdutos.Clear();
            totalPedido = 0;
        }
        private void LimparCamposProduto()
        {
            txtNomeProduto.Text = "";
            txtPreco.Text = "";
            numericUpDown1.Value = 1;
        }
        
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text;
            string precoStr = txtPreco.Text;

            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(precoStr))
            {
                MessageBox.Show("Por favor digite o nome do produto, ou verifique se esse produto tem um preço");
                return;
            }
            float quantidade = (float)numericUpDown1.Value;
            float quantidade1 = float.Parse(precoStr, CultureInfo.InvariantCulture);
            float resultado = quantidade * quantidade1;
            totalPedido += resultado;
            txtPrecoTotal.Text = totalPedido.ToString("F2");

            listaProdutos.Add($"{nomeProduto},{precoStr},{quantidade},{resultado.ToString("F2")}");
            dataGridView1.Rows.Add(txtNome.Text, txtCPF.Text, nomeProduto, quantidade, resultado.ToString("F2"));
            LimparCamposProduto();
        }
    }
}
