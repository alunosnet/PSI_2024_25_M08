namespace Ementa
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
            chkVegi = new CheckBox();
            rbSobremesa = new RadioButton();
            rbPrato = new RadioButton();
            rbBebida = new RadioButton();
            lbOpcoes = new ListBox();
            lbMenu = new ListBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // chkVegi
            // 
            chkVegi.AutoSize = true;
            chkVegi.CheckAlign = ContentAlignment.MiddleRight;
            chkVegi.Location = new Point(16, 12);
            chkVegi.Name = "chkVegi";
            chkVegi.Size = new Size(108, 24);
            chkVegi.TabIndex = 0;
            chkVegi.Text = "Vegetariano";
            chkVegi.UseVisualStyleBackColor = true;
            chkVegi.CheckedChanged += chkVegi_CheckedChanged;
            // 
            // rbSobremesa
            // 
            rbSobremesa.AutoSize = true;
            rbSobremesa.CheckAlign = ContentAlignment.MiddleRight;
            rbSobremesa.Location = new Point(16, 100);
            rbSobremesa.Name = "rbSobremesa";
            rbSobremesa.Size = new Size(107, 24);
            rbSobremesa.TabIndex = 1;
            rbSobremesa.Text = "Sobremesas";
            rbSobremesa.UseVisualStyleBackColor = true;
            rbSobremesa.CheckedChanged += rbSobremesa_CheckedChanged;
            // 
            // rbPrato
            // 
            rbPrato.AutoSize = true;
            rbPrato.CheckAlign = ContentAlignment.MiddleRight;
            rbPrato.Checked = true;
            rbPrato.Location = new Point(16, 42);
            rbPrato.Name = "rbPrato";
            rbPrato.Size = new Size(62, 24);
            rbPrato.TabIndex = 1;
            rbPrato.TabStop = true;
            rbPrato.Text = "Prato";
            rbPrato.UseVisualStyleBackColor = true;
            rbPrato.CheckedChanged += rbPrato_CheckedChanged;
            // 
            // rbBebida
            // 
            rbBebida.AutoSize = true;
            rbBebida.CheckAlign = ContentAlignment.MiddleRight;
            rbBebida.Location = new Point(16, 72);
            rbBebida.Name = "rbBebida";
            rbBebida.Size = new Size(74, 24);
            rbBebida.TabIndex = 1;
            rbBebida.Text = "Bebida";
            rbBebida.UseVisualStyleBackColor = true;
            rbBebida.CheckedChanged += rbBebida_CheckedChanged;
            // 
            // lbOpcoes
            // 
            lbOpcoes.FormattingEnabled = true;
            lbOpcoes.Location = new Point(16, 171);
            lbOpcoes.Name = "lbOpcoes";
            lbOpcoes.Size = new Size(162, 144);
            lbOpcoes.TabIndex = 2;
            // 
            // lbMenu
            // 
            lbMenu.FormattingEnabled = true;
            lbMenu.Location = new Point(275, 171);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(159, 144);
            lbMenu.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(184, 215);
            button1.Name = "button1";
            button1.Size = new Size(70, 44);
            button1.TabIndex = 4;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 132);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 5;
            label1.Text = "As suas escolhas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 369);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lbMenu);
            Controls.Add(lbOpcoes);
            Controls.Add(rbBebida);
            Controls.Add(rbPrato);
            Controls.Add(rbSobremesa);
            Controls.Add(chkVegi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkVegi;
        private RadioButton rbSobremesa;
        private RadioButton rbPrato;
        private RadioButton rbBebida;
        private ListBox lbOpcoes;
        private ListBox lbMenu;
        private Button button1;
        private Label label1;
    }
}
