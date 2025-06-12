using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace P2_Tentativa_sla
{
    public partial class Form7 : Form
    {
        string caminhoCsv = Path.Combine(Application.StartupPath, "pedidos.txt");

        public Form7()
        {
            InitializeComponent();
        }

        private void btnAtualziar_Click(object sender, EventArgs e)
        {
            string linhas = textBox1.Text;
            File.WriteAllLines(caminhoCsv, linhas);
            MessageBox.Show("Arquivo atualizado com sucesso!");
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
