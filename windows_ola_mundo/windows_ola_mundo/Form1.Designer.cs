namespace windows_ola_mundo
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
            lbMensagem = new Label();
            tbNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Location = new Point(178, 134);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(0, 20);
            lbMensagem.TabIndex = 0;
            lbMensagem.Click += label1_Click;
            lbMensagem.MouseClick += label1_MouseClick;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(72, 45);
            tbNome.Multiline = true;
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(185, 27);
            tbNome.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(286, 38);
            button1.Name = "button1";
            button1.Size = new Size(100, 41);
            button1.TabIndex = 2;
            button1.Text = "Diz olá";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(416, 38);
            button2.Name = "button2";
            button2.Size = new Size(100, 41);
            button2.TabIndex = 3;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbNome);
            Controls.Add(lbMensagem);
            Name = "Form1";
            Text = "Olá Mundo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMensagem;
        private TextBox tbNome;
        private Button button1;
        private Button button2;
    }
}
