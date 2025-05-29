namespace CalcularNota
{
    partial class Form1
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
            label1 = new Label();
            button1 = new Button();
            tbNome = new TextBox();
            label2 = new Label();
            tbTeste = new TextBox();
            label3 = new Label();
            tbDesafio = new TextBox();
            label4 = new Label();
            tbProjeto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbMensagem = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // button1
            // 
            button1.Location = new Point(82, 211);
            button1.Name = "button1";
            button1.Size = new Size(228, 38);
            button1.TabIndex = 4;
            button1.Text = "Calcular Nota";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(100, 35);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(195, 23);
            tbNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 84);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "Teste";
            // 
            // tbTeste
            // 
            tbTeste.Location = new Point(100, 76);
            tbTeste.Name = "tbTeste";
            tbTeste.Size = new Size(195, 23);
            tbTeste.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 130);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Desafio";
            // 
            // tbDesafio
            // 
            tbDesafio.Location = new Point(100, 122);
            tbDesafio.Name = "tbDesafio";
            tbDesafio.Size = new Size(195, 23);
            tbDesafio.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 171);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "Projeto";
            // 
            // tbProjeto
            // 
            tbProjeto.Location = new Point(100, 163);
            tbProjeto.Name = "tbProjeto";
            tbProjeto.Size = new Size(195, 23);
            tbProjeto.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 79);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 0;
            label5.Text = "30%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 125);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 0;
            label6.Text = "30%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(315, 166);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 0;
            label7.Text = "40%";
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Location = new Point(36, 268);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(0, 15);
            lbMensagem.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(tbProjeto);
            Controls.Add(tbDesafio);
            Controls.Add(label4);
            Controls.Add(tbTeste);
            Controls.Add(label3);
            Controls.Add(tbNome);
            Controls.Add(lbMensagem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox tbNome;
        private Label label2;
        private TextBox tbTeste;
        private Label label3;
        private TextBox tbDesafio;
        private Label label4;
        private TextBox tbProjeto;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbMensagem;
    }
}
