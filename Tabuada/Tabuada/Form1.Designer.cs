namespace Tabuada
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
            cbNumero = new ComboBox();
            button1 = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // cbNumero
            // 
            cbNumero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumero.FormattingEnabled = true;
            cbNumero.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbNumero.Location = new Point(15, 44);
            cbNumero.Name = "cbNumero";
            cbNumero.Size = new Size(174, 23);
            cbNumero.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(212, 23);
            button1.Name = "button1";
            button1.Size = new Size(109, 63);
            button1.TabIndex = 1;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(17, 97);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(38, 15);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 450);
            Controls.Add(lbResultado);
            Controls.Add(button1);
            Controls.Add(cbNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbNumero;
        private Button button1;
        private Label lbResultado;
    }
}
