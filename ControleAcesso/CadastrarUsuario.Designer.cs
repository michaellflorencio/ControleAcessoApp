﻿namespace ControleAcesso
{
    partial class CadastrarUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Senha = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(262, 415);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(706, 503);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 143);
            textBox1.MaximumSize = new Size(200, 100);
            textBox1.MinimumSize = new Size(35, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 30);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(262, 34);
            label1.MaximumSize = new Size(300, 100);
            label1.MinimumSize = new Size(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(228, 50);
            label1.TabIndex = 4;
            label1.Text = "Cadastrar Usuario";
            label1.UseWaitCursor = true;
            label1.Click += this.label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(410, 415);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 190);
            textBox3.MaximumSize = new Size(200, 100);
            textBox3.MinimumSize = new Size(35, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 30);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 248);
            textBox2.MaximumSize = new Size(200, 100);
            textBox2.MinimumSize = new Size(35, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 30);
            textBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(203, 152);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(203, 199);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 10;
            label3.Text = "CPF";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI", 12F);
            Senha.Location = new Point(203, 248);
            Senha.Name = "Senha";
            Senha.Size = new Size(53, 21);
            Senha.TabIndex = 11;
            Senha.Text = "Senha";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(290, 297);
            textBox4.MaximumSize = new Size(200, 100);
            textBox4.MinimumSize = new Size(35, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 30);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(203, 306);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
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
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "CadastrarUsuario";
            Text = "Form1";
            Load += this.CadastrarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label Senha;
        private TextBox textBox4;
        private Label label4;
    }
}
