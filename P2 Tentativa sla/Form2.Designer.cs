namespace P2_Tentativa_sla
{
    partial class Form2
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
            btnClientes = new Button();
            btnProdutos = new Button();
            btnUsuarios = new Button();
            btnPedidos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(33, 99);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(127, 32);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Cadastro de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            btnProdutos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutos.Location = new Point(33, 147);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(127, 32);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Cadastro de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(176, 99);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(127, 32);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Cadastro de Usuários";
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(176, 147);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(127, 32);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "Cadastro de Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(270, 50);
            label1.TabIndex = 4;
            label1.Text = "Bem Vindo a Yggdrasil escolha\r\no caminho a seguir.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(338, 229);
            Controls.Add(label1);
            Controls.Add(btnPedidos);
            Controls.Add(btnUsuarios);
            Controls.Add(btnProdutos);
            Controls.Add(btnClientes);
            ForeColor = Color.Black;
            Name = "Form2";
            Text = "Central de Portais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnProdutos;
        private Button btnUsuarios;
        private Button btnPedidos;
        private Label label1;
    }
}