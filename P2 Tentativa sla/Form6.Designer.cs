namespace P2_Tentativa_sla
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCPF = new TextBox();
            btnCliente = new Button();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtNomeProduto = new TextBox();
            btnProduto = new Button();
            label4 = new Label();
            txtPreco = new TextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            txtPrecoTotal = new TextBox();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o Cpf do Cliente:\r\n";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(21, 34);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(269, 23);
            txtCPF.TabIndex = 1;
            txtCPF.TextChanged += txtCPF_TextChanged;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(296, 33);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(89, 22);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Buscar cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome do Cliente:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 93);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome do Produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(21, 147);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(269, 23);
            txtNomeProduto.TabIndex = 6;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // btnProduto
            // 
            btnProduto.Location = new Point(296, 148);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(108, 22);
            btnProduto.TabIndex = 7;
            btnProduto.Text = "Buscar Produto";
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(18, 188);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 8;
            label4.Text = "Preço do Produto:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(21, 206);
            txtPreco.Name = "txtPreco";
            txtPreco.ReadOnly = true;
            txtPreco.Size = new Size(269, 23);
            txtPreco.TabIndex = 9;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(16, 247);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 11;
            label5.Text = "Quantidade do Produto:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(21, 265);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(410, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(378, 411);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtPrecoTotal
            // 
            txtPrecoTotal.Location = new Point(21, 316);
            txtPrecoTotal.Name = "txtPrecoTotal";
            txtPrecoTotal.ReadOnly = true;
            txtPrecoTotal.Size = new Size(269, 23);
            txtPrecoTotal.TabIndex = 15;
            txtPrecoTotal.TextChanged += txtPrecoTotal_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(18, 298);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 14;
            label6.Text = "Preço Total do Produto:";
            // 
            // button1
            // 
            button1.Location = new Point(21, 369);
            button1.Name = "button1";
            button1.Size = new Size(108, 22);
            button1.TabIndex = 16;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPrecoTotal);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(txtPreco);
            Controls.Add(label4);
            Controls.Add(btnProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(btnCliente);
            Controls.Add(txtCPF);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCPF;
        private Button btnCliente;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtNomeProduto;
        private Button btnProduto;
        private Label label4;
        private TextBox txtPreco;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private TextBox txtPrecoTotal;
        private Label label6;
        private Button button1;
    }
}