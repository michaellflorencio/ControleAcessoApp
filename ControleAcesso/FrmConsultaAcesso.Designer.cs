﻿namespace ControleAcesso
{
    partial class FrmConsultaAcesso
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
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Entrada = new DataGridViewTextBoxColumn();
            Saida = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Senha = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Entrada, Saida });
            dataGridView1.Location = new Point(221, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 194);
            dataGridView1.TabIndex = 7;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Entrada
            // 
            Entrada.HeaderText = "Entrada";
            Entrada.Name = "Entrada";
            // 
            // Saida
            // 
            Saida.HeaderText = "Saida";
            Saida.Name = "Saida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(272, 25);
            label1.MaximumSize = new Size(300, 100);
            label1.MinimumSize = new Size(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(246, 50);
            label1.TabIndex = 6;
            label1.Text = "Consulta de Acesso";
            label1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(341, 201);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(272, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI", 10F);
            Senha.Location = new Point(221, 91);
            Senha.Name = "Senha";
            Senha.Size = new Size(69, 19);
            Senha.TabIndex = 23;
            Senha.Text = "Filtrar por";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(221, 134);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 24;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(221, 168);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 25;
            label3.Text = "Nome";
            // 
            // FrmConsultaAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Senha);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FrmConsultaAcesso";
            Text = "FrmConsultaAcesso";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Entrada;
        private DataGridViewTextBoxColumn Saida;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label Senha;
        private Label label2;
        private Label label3;
    }
}