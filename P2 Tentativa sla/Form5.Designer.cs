namespace P2_Tentativa_sla
{
    partial class Form5
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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDescrição = new TextBox();
            dataGridView1 = new DataGridView();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(229, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyDown += txtNome_KeyDown;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(25, 101);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(229, 23);
            txtPreco.TabIndex = 1;
            txtPreco.TextChanged += txtPreco_TextChanged;
            txtPreco.KeyDown += txtPreco_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 83);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 3;
            label2.Text = "Preço do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 138);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 5;
            label3.Text = "Descrição do Produto:";
            // 
            // txtDescrição
            // 
            txtDescrição.Location = new Point(25, 156);
            txtDescrição.Name = "txtDescrição";
            txtDescrição.Size = new Size(229, 23);
            txtDescrição.TabIndex = 6;
            txtDescrição.TextChanged += txtDescrição_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(25, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(353, 191);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(273, 46);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(273, 75);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(105, 23);
            btnAlterar.TabIndex = 9;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(273, 104);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 23);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(273, 134);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar Nome";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(400, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnSalvar);
            Controls.Add(dataGridView1);
            Controls.Add(txtDescrição);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "Form5";
            Text = "Cadastro de Produto";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDescrição;
        private DataGridView dataGridView1;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnBuscar;
    }
}