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

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
