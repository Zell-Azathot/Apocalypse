using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace P2_Tentativa_sla
{
    public partial class Form3 : Form
    {
        string caminhoCsv = Path.Combine(Application.StartupPath, "clientes.txt");

        public Form3()
        {
            InitializeComponent();

            if (!File.Exists(caminhoCsv))
            {
                File.WriteAllText(caminhoCsv, "" + Environment.NewLine);
                return;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "CPF";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "CEP";
            dataGridView1.Columns[4].Name = "Logradouro";
            dataGridView1.Columns[5].Name = "Número";
            dataGridView1.Columns[6].Name = "Bairro";
            dataGridView1.Columns[7].Name = "Cidade";
            dataGridView1.Columns[8].Name = "Estado";
            dataGridView1.Columns[9].Name = "Telefone";
            dataGridView1.Columns[10].Name = "WhatsApp";
            AtualizarGrid();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogadouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWhatsapp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text.Length != 11)
            {
                MessageBox.Show("Por favor digite um cpf valido");
                return;
            }
            string linha = $"{txtNome.Text},{txtCpf.Text},{txtEmail.Text},{txtCep.Text},{txtLogadouro.Text},{txtNumero.Text},{txtBairro.Text},{txtCidade.Text},{txtEstado.Text},{txtTelefone.Text},{txtWhatsapp.Text}";
            File.AppendAllText(caminhoCsv, linha + Environment.NewLine);
            MessageBox.Show("Cliente cadastrado com sucesso!");
            AtualizarGrid();
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text.Trim();
            var linhas = File.ReadAllLines(caminhoCsv);
            var novasLinhas = new List<string>();

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length >= 2 && partes[1] == cpf)
                {
                    string nova = $"{txtNome.Text},{txtCpf.Text},{txtEmail.Text},{txtCep.Text},{txtLogadouro.Text},{txtNumero.Text},{txtBairro.Text},{txtCidade.Text},{txtEstado.Text},{txtTelefone.Text},{txtWhatsapp.Text}";
                    novasLinhas.Add(nova);
                }
                else
                {
                    novasLinhas.Add(linha);
                }
            }

            File.WriteAllLines(caminhoCsv, novasLinhas);
            MessageBox.Show("Cliente atualizado!");
            AtualizarGrid();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text.Trim();
            var linhas = File.ReadAllLines(caminhoCsv);
            var novasLinhas = new List<string>();

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length >= 2 && partes[1] != cpf)
                {
                    novasLinhas.Add(linha);
                }
            }
            File.WriteAllLines(caminhoCsv, novasLinhas);
            MessageBox.Show("Cliente excluído!");
            AtualizarGrid();
            LimparCampos();
        }

        private void btnBuscarcpf_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text.Trim();
            var linhas = File.ReadAllLines(caminhoCsv);

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes[1] == cpf)
                {
                    txtNome.Text = partes[0];
                    txtCpf.Text = partes[1];
                    txtEmail.Text = partes[2];
                    txtCep.Text = partes[3];
                    txtLogadouro.Text = partes[4];
                    txtNumero.Text = partes[5];
                    txtBairro.Text = partes[6];
                    txtCidade.Text = partes[7];
                    txtEstado.Text = partes[8];
                    txtTelefone.Text = partes[9];
                    txtWhatsapp.Text = partes[10];
                }
                if (string.IsNullOrEmpty(cpf))
                {
                    MessageBox.Show("Você não digitou um cpf para ser buscado no sistema.");
                }
                if (partes[1] != cpf)
                {
                    MessageBox.Show("O cpf digitado não está registrado no nosso sistema.");
                }
            }
        }

        private async void btnBuscarcep_ClickAsync(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Trim();

            if (!string.IsNullOrWhiteSpace(cep))
            {
                var endereco = await BuscarEndereco(cep);
                if (endereco != null)
                {
                    txtLogadouro.Text = endereco.logradouro ?? "";
                    txtBairro.Text = endereco.bairro ?? "";
                    txtCidade.Text = endereco.localidade ?? "";
                    txtEstado.Text = endereco.uf ?? "";
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar o endereço para esse CEP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtNome.Text = row?.Cells[0]?.Value?.ToString() ?? "";
                txtCpf.Text = row?.Cells[1]?.Value?.ToString() ?? "";
                txtEmail.Text = row?.Cells[2]?.Value?.ToString() ?? "";
                txtCep.Text = row?.Cells[3]?.Value?.ToString() ?? "";
                txtLogadouro.Text = row?.Cells[4]?.Value?.ToString() ?? "";
                txtNumero.Text = row?.Cells[5]?.Value?.ToString() ?? "";
                txtBairro.Text = row?.Cells[6]?.Value?.ToString() ?? "";
                txtCidade.Text = row?.Cells[7]?.Value?.ToString() ?? "";
                txtEstado.Text = row?.Cells[8]?.Value?.ToString() ?? "";
                txtTelefone.Text = row?.Cells[9]?.Value?.ToString() ?? "";
                txtWhatsapp.Text = row?.Cells[10]?.Value?.ToString() ?? "";
            }
        }

        public class Endereco
        {
            public string logradouro { get; set; } = "";
            public string bairro { get; set; } = "";
            public string localidade { get; set; } = "";
            public string uf { get; set; } = "";
        }

        private async Task<Endereco?> BuscarEndereco(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string resposta = await client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
                    if (resposta.Contains("\"erro\": true"))
                    {
                        MessageBox.Show("CEP não encontrado. Verifique o número digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    var endereco = JsonConvert.DeserializeObject<Endereco>(resposta);

                    return endereco;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o endereço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void AtualizarGrid()
        {
            dataGridView1.Rows.Clear();

            if (!File.Exists(caminhoCsv)) return;

            string[] linhas = File.ReadAllLines(caminhoCsv);

            foreach (var linha in linhas)
            {
                string[] partes = linha.Split(',');

                if (partes.Length >= 11)
                    dataGridView1.Rows.Add(partes);
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtCep.Text = "";
            txtLogadouro.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtTelefone.Text = "";
            txtWhatsapp.Text = "";
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCpf.Focus();
            }
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCep.Focus();
            }
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtLogadouro.Focus();
            }
        }

        private void txtLogadouro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtNumero.Focus();
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtBairro.Focus();
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCidade.Focus();
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtEstado.Focus();
            }
        }

        private void txtEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtTelefone.Focus();
            }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtWhatsapp.Focus();
            }
        }
    }
}
