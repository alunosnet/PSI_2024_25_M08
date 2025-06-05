namespace Calcular_v2
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
            button1 = new Button();
            label1 = new Label();
            NU_Numero = new NumericUpDown();
            button2 = new Button();
            lbResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)NU_Numero).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(329, 39);
            button1.Name = "button1";
            button1.Size = new Size(158, 47);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 54);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Número";
            // 
            // NU_Numero
            // 
            NU_Numero.DecimalPlaces = 2;
            NU_Numero.Location = new Point(129, 50);
            NU_Numero.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NU_Numero.Name = "NU_Numero";
            NU_Numero.Size = new Size(153, 27);
            NU_Numero.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(329, 104);
            button2.Name = "button2";
            button2.Size = new Size(154, 53);
            button2.TabIndex = 3;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(51, 91);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 20);
            lbResultado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 226);
            Controls.Add(lbResultado);
            Controls.Add(button2);
            Controls.Add(NU_Numero);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NU_Numero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private NumericUpDown NU_Numero;
        private Button button2;
        private Label lbResultado;
    }
}
