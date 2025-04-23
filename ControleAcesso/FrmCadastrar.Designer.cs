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
            textBox4 = new TextBox();
            Senha = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(178, 309);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 24;
            label4.Text = "Confirmar Senha";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(295, 298);
            textBox4.MaximumSize = new Size(200, 100);
            textBox4.MinimumSize = new Size(35, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 30);
            textBox4.TabIndex = 23;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI", 10F);
            Senha.Location = new Point(243, 260);
            Senha.Name = "Senha";
            Senha.Size = new Size(46, 19);
            Senha.TabIndex = 22;
            Senha.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(256, 202);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 21;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(243, 155);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 20;
            label2.Text = "Nome";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 249);
            textBox2.MaximumSize = new Size(200, 100);
            textBox2.MinimumSize = new Size(35, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 30);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(295, 191);
            textBox3.MaximumSize = new Size(200, 100);
            textBox3.MinimumSize = new Size(35, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 30);
            textBox3.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(417, 368);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 17;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(295, 144);
            textBox1.MaximumSize = new Size(200, 100);
            textBox1.MinimumSize = new Size(35, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 30);
            textBox1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(243, 368);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 14;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmRegistroAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(Senha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FrmRegistroAcesso";
            Text = "FrmRegistroAcesso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox4;
        private Label Senha;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}