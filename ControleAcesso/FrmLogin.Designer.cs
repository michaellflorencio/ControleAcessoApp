namespace ControleAcesso
{
    partial class FrmLogin
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
            Senha = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI", 10F);
            Senha.Location = new Point(245, 192);
            Senha.Name = "Senha";
            Senha.Size = new Size(46, 19);
            Senha.TabIndex = 22;
            Senha.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(258, 128);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 21;
            label3.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(318, 181);
            textBox2.MaximumSize = new Size(200, 100);
            textBox2.MinimumSize = new Size(35, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 30);
            textBox2.TabIndex = 19;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(318, 123);
            textBox3.MaximumSize = new Size(200, 100);
            textBox3.MinimumSize = new Size(35, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 30);
            textBox3.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(436, 263);
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
            label1.Location = new Point(349, 28);
            label1.MaximumSize = new Size(300, 100);
            label1.MinimumSize = new Size(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(100, 50);
            label1.TabIndex = 16;
            label1.Text = "Login";
            label1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(273, 263);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 14;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(408, 225);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 15);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueci a senha";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(678, 417);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(100, 15);
            linkLabel2.TabIndex = 24;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Cadastrar Usuario";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(Senha);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Senha;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}