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
            var ming = textBox1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            File.WriteAllLines(caminhoCsv, ming);
            MessageBox.Show("Arquivo atualizado com sucesso!");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (File.Exists(caminhoCsv))
            {
                string[] linhas = File.ReadAllLines(caminhoCsv);
                textBox1.Lines = linhas;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
