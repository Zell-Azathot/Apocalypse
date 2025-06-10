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
            dataGridView1.ColumnCount = 11;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // text box do nome.

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
    }
}
