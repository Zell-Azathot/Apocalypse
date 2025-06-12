namespace P2_Tentativa_sla
{
    partial class Form7
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
            btnAtualziar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnAtualziar
            // 
            btnAtualziar.Location = new Point(12, 412);
            btnAtualziar.Name = "btnAtualziar";
            btnAtualziar.Size = new Size(122, 26);
            btnAtualziar.TabIndex = 1;
            btnAtualziar.Text = "Atualizar Alterações";
            btnAtualziar.UseVisualStyleBackColor = true;
            btnAtualziar.Click += btnAtualziar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(794, 404);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnAtualziar);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAtualziar;
        private TextBox textBox1;
    }
}