namespace Marcas
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            cbMarcas = new ComboBox();
            lbEscolhidas = new ListBox();
            button1 = new Button();
            button2 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 48);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Marcas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 0;
            label2.Text = "Escolhidas";
            // 
            // cbMarcas
            // 
            cbMarcas.FormattingEnabled = true;
            cbMarcas.Location = new Point(57, 68);
            cbMarcas.Margin = new Padding(3, 4, 3, 4);
            cbMarcas.Name = "cbMarcas";
            cbMarcas.Size = new Size(138, 28);
            cbMarcas.TabIndex = 1;
            toolTip1.SetToolTip(cbMarcas, "Escolha uma marca");
            cbMarcas.SelectedIndexChanged += cbMarcas_SelectedIndexChanged;
            // 
            // lbEscolhidas
            // 
            lbEscolhidas.FormattingEnabled = true;
            lbEscolhidas.Location = new Point(255, 68);
            lbEscolhidas.Margin = new Padding(3, 4, 3, 4);
            lbEscolhidas.Name = "lbEscolhidas";
            lbEscolhidas.Size = new Size(183, 144);
            lbEscolhidas.TabIndex = 2;
            toolTip1.SetToolTip(lbEscolhidas, "Marcas escolhidas.");
            // 
            // button1
            // 
            button1.Location = new Point(249, 237);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 3;
            button1.Text = "Remover";
            toolTip1.SetToolTip(button1, "Remove a marca selecionada.");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(347, 237);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(91, 31);
            button2.TabIndex = 3;
            button2.Text = "Limpar";
            toolTip1.SetToolTip(button2, "Remove todas as marcas.");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 319);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbEscolhidas);
            Controls.Add(cbMarcas);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Escolha as suas marcas favoritas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbMarcas;
        private ListBox lbEscolhidas;
        private Button button1;
        private Button button2;
        private ToolTip toolTip1;
    }
}
