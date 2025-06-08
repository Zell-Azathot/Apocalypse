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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string caminhoCsv = Path.Combine(Application.StartupPath, "clientes.txt");
        if (!File.Exists(caminhoCsv))
        {
                File.WriteAllText(caminhoCsv, "ADMIN,123" + Environment.NewLine);
        MessageBox.Show("infelizmente houve um erro, por favor tente de novo");
                return;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
