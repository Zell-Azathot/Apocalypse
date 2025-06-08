namespace P2_Tentativa_sla
{
    partial class Form4
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
            txtUser = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            dgvUsers = new DataGridView();
            label2 = new Label();
            btnAlterar = new Button();
            dgvCadastrar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(33, 73);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(331, 23);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(33, 155);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(331, 23);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "Novo Usuario:";
            label1.Click += label1_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(173, 200);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(191, 183);
            dgvUsers.TabIndex = 3;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 127);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Nova Senha:";
            label2.Click += label2_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(33, 200);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(127, 26);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar Informações";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // dgvCadastrar
            // 
            dgvCadastrar.Location = new Point(33, 264);
            dgvCadastrar.Name = "dgvCadastrar";
            dgvCadastrar.Size = new Size(134, 26);
            dgvCadastrar.TabIndex = 6;
            dgvCadastrar.Text = "Cadastrar Informações";
            dgvCadastrar.UseVisualStyleBackColor = true;
            dgvCadastrar.Click += dgvCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(33, 232);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(127, 26);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir Informações";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(405, 450);
            Controls.Add(btnExcluir);
            Controls.Add(dgvCadastrar);
            Controls.Add(btnAlterar);
            Controls.Add(label2);
            Controls.Add(dgvUsers);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtSenha;
        private Label label1;
        private DataGridView dgvUsers;
        private Label label2;
        private Button btnAlterar;
        private Button dgvCadastrar;
        private Button btnExcluir;
    }
}