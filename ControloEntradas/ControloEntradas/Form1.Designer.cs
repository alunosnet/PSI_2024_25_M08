namespace ControloEntradas
{
    partial class Form1
    {
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label lbAtual;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lbRelogio;
        private NumericUpDown nudPessoas;
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lbAtual = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lbRelogio = new Label();
            nudPessoas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPessoas).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 58);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Nº Pessoas";
            // 
            // lbAtual
            // 
            lbAtual.AutoSize = true;
            lbAtual.Location = new Point(180, 107);
            lbAtual.Name = "lbAtual";
            lbAtual.Size = new Size(0, 20);
            lbAtual.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(76, 181);
            button1.Name = "button1";
            button1.Size = new Size(103, 49);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(230, 181);
            button2.Name = "button2";
            button2.Size = new Size(103, 49);
            button2.TabIndex = 3;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(118, 236);
            button3.Name = "button3";
            button3.Size = new Size(174, 49);
            button3.TabIndex = 3;
            button3.Text = "Estatísticas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lbRelogio
            // 
            lbRelogio.AutoSize = true;
            lbRelogio.Location = new Point(12, 326);
            lbRelogio.Name = "lbRelogio";
            lbRelogio.Size = new Size(0, 20);
            lbRelogio.TabIndex = 4;
            // 
            // nudPessoas
            // 
            nudPessoas.Location = new Point(193, 58);
            nudPessoas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPessoas.Name = "nudPessoas";
            nudPessoas.Size = new Size(99, 27);
            nudPessoas.TabIndex = 5;
            nudPessoas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 365);
            Controls.Add(nudPessoas);
            Controls.Add(lbRelogio);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbAtual);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

       
    }
}
