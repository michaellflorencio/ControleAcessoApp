namespace ControleAcesso
{
    partial class FrmCadastrar
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
            label4 = new Label();
            txtSenha1 = new TextBox();
            Senha = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            txtCpf = new TextBox();
            button2 = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            txtCadastrar = new Button();
            txtTipo = new ComboBox();
            txtId = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(183, 281);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 24;
            label4.Text = "Confirmar Senha";
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(300, 270);
            txtSenha1.MaximumSize = new Size(200, 100);
            txtSenha1.MinimumSize = new Size(35, 30);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.Size = new Size(180, 30);
            txtSenha1.TabIndex = 23;
            txtSenha1.UseSystemPasswordChar = true;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI", 10F);
            Senha.Location = new Point(248, 232);
            Senha.Name = "Senha";
            Senha.Size = new Size(46, 19);
            Senha.TabIndex = 22;
            Senha.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(261, 174);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 21;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(248, 127);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 20;
            label2.Text = "Nome";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(300, 221);
            txtSenha.MaximumSize = new Size(200, 100);
            txtSenha.MinimumSize = new Size(35, 30);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(180, 30);
            txtSenha.TabIndex = 19;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(300, 163);
            txtCpf.MaximumSize = new Size(200, 100);
            txtCpf.MinimumSize = new Size(35, 30);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(180, 30);
            txtCpf.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(417, 368);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 17;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(267, 35);
            label1.MaximumSize = new Size(300, 100);
            label1.MinimumSize = new Size(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(228, 50);
            label1.TabIndex = 16;
            label1.Text = "Cadastrar Usuario";
            label1.UseWaitCursor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(300, 116);
            txtNome.MaximumSize = new Size(200, 100);
            txtNome.MinimumSize = new Size(35, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 30);
            txtNome.TabIndex = 15;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCadastrar
            // 
            txtCadastrar.Location = new Point(243, 368);
            txtCadastrar.Name = "txtCadastrar";
            txtCadastrar.Size = new Size(100, 35);
            txtCadastrar.TabIndex = 14;
            txtCadastrar.Text = "Cadastrar";
            txtCadastrar.UseVisualStyleBackColor = true;
            txtCadastrar.Click += button1_Click;
            // 
            // txtTipo
            // 
            txtTipo.FormattingEnabled = true;
            txtTipo.Items.AddRange(new object[] { "Administrador", "Funcionário", "Visitante" });
            txtTipo.Location = new Point(359, 306);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(121, 23);
            txtTipo.TabIndex = 25;
            // 
            // txtId
            // 
            txtId.Location = new Point(486, 116);
            txtId.MaximumSize = new Size(200, 100);
            txtId.MinimumSize = new Size(35, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 30);
            txtId.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(519, 121);
            label5.Name = "label5";
            label5.Size = new Size(21, 19);
            label5.TabIndex = 27;
            label5.Text = "Id";
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(txtTipo);
            Controls.Add(label4);
            Controls.Add(txtSenha1);
            Controls.Add(Senha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(txtCpf);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtCadastrar);
            Name = "FrmCadastrar";
            Text = "FrmRegistroAcesso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtSenha1;
        private Label Senha;
        private Label label3;
        private Label label2;
        private TextBox txtSenha;
        private TextBox txtCpf;
        private Button button2;
        private Label label1;
        private TextBox txtNome;
        private Button txtCadastrar;
        private ComboBox txtTipo;
        private TextBox txtId;
        private Label label5;
    }
}