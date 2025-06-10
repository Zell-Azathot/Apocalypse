namespace P2_Tentativa_sla
{
    partial class Form3
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
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtNumero = new TextBox();
            txtLogadouro = new TextBox();
            txtCep = new TextBox();
            txtEstado = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtTelefone = new TextBox();
            txtWhatsapp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnBuscarcpf = new Button();
            btnBuscarcep = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(272, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyDown += txtNome_KeyDown;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 62);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(272, 23);
            txtCpf.TabIndex = 1;
            txtCpf.TextChanged += txtCpf_TextChanged;
            txtCpf.KeyDown += txtCpf_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(272, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 222);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(272, 23);
            txtNumero.TabIndex = 5;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyDown += txtNumero_KeyDown;
            // 
            // txtLogadouro
            // 
            txtLogadouro.Location = new Point(12, 182);
            txtLogadouro.Name = "txtLogadouro";
            txtLogadouro.Size = new Size(272, 23);
            txtLogadouro.TabIndex = 4;
            txtLogadouro.TextChanged += txtLogadouro_TextChanged;
            txtLogadouro.KeyDown += txtLogadouro_KeyDown;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(12, 142);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(272, 23);
            txtCep.TabIndex = 3;
            txtCep.TextChanged += txtCep_TextChanged;
            txtCep.KeyDown += txtCep_KeyDown;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(12, 340);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(272, 23);
            txtEstado.TabIndex = 8;
            txtEstado.TextChanged += txtEstado_TextChanged;
            txtEstado.KeyDown += txtEstado_KeyDown;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(12, 300);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(272, 23);
            txtCidade.TabIndex = 7;
            txtCidade.TextChanged += txtCidade_TextChanged;
            txtCidade.KeyDown += txtCidade_KeyDown;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(12, 260);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(272, 23);
            txtBairro.TabIndex = 6;
            txtBairro.TextChanged += txtBairro_TextChanged;
            txtBairro.KeyDown += txtBairro_KeyDown;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 378);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(272, 23);
            txtTelefone.TabIndex = 11;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            txtTelefone.KeyDown += txtTelefone_KeyDown;
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(12, 415);
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(272, 23);
            txtWhatsapp.TabIndex = 10;
            txtWhatsapp.TextChanged += txtWhatsapp_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(290, 65);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 13;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(290, 105);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 14;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(290, 225);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 17;
            label4.Text = "Numero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(290, 185);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 16;
            label5.Text = "Logradouro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
            label6.Location = new Point(290, 145);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 15;
            label6.Text = "CEP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.ForeColor = Color.White;
            label8.Location = new Point(290, 420);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 22;
            label8.Text = "WhatsApp:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.ForeColor = Color.White;
            label9.Location = new Point(290, 380);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 21;
            label9.Text = "Telefone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.ForeColor = Color.White;
            label10.Location = new Point(290, 340);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 20;
            label10.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.ForeColor = Color.White;
            label11.Location = new Point(290, 300);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 19;
            label11.Text = "Cidade:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Black;
            label12.ForeColor = Color.White;
            label12.Location = new Point(290, 263);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 18;
            label12.Text = "Bairro:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(373, 25);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(98, 22);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(373, 53);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(98, 22);
            btnAtualizar.TabIndex = 24;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(373, 81);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 22);
            btnExcluir.TabIndex = 25;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnBuscarcpf
            // 
            btnBuscarcpf.Location = new Point(373, 109);
            btnBuscarcpf.Name = "btnBuscarcpf";
            btnBuscarcpf.Size = new Size(98, 22);
            btnBuscarcpf.TabIndex = 26;
            btnBuscarcpf.Text = "Buscar CPF";
            btnBuscarcpf.UseVisualStyleBackColor = true;
            btnBuscarcpf.Click += btnBuscarcpf_Click;
            // 
            // btnBuscarcep
            // 
            btnBuscarcep.Location = new Point(373, 138);
            btnBuscarcep.Name = "btnBuscarcep";
            btnBuscarcep.Size = new Size(98, 22);
            btnBuscarcep.TabIndex = 27;
            btnBuscarcep.Text = "Buscar CEP";
            btnBuscarcep.UseVisualStyleBackColor = true;
            btnBuscarcep.Click += btnBuscarcep_ClickAsync;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(373, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(415, 272);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscarcep);
            Controls.Add(btnBuscarcpf);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(txtWhatsapp);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtNumero);
            Controls.Add(txtLogadouro);
            Controls.Add(txtCep);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Name = "Form3";
            Text = "Central de Clientes";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtNumero;
        private TextBox txtLogadouro;
        private TextBox txtCep;
        private TextBox txtEstado;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtTelefone;
        private TextBox txtWhatsapp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnBuscarcpf;
        private Button btnBuscarcep;
        private DataGridView dataGridView1;
    }
}