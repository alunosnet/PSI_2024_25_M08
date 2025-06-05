namespace Calcular_v1
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
            NU_Num1 = new NumericUpDown();
            NU_Num2 = new NumericUpDown();
            NU_Num4 = new NumericUpDown();
            NU_Num3 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            lbResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)NU_Num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NU_Num2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NU_Num4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NU_Num3).BeginInit();
            SuspendLayout();
            // 
            // NU_Num1
            // 
            NU_Num1.DecimalPlaces = 2;
            NU_Num1.Location = new Point(199, 54);
            NU_Num1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NU_Num1.Name = "NU_Num1";
            NU_Num1.Size = new Size(120, 27);
            NU_Num1.TabIndex = 0;
            // 
            // NU_Num2
            // 
            NU_Num2.DecimalPlaces = 2;
            NU_Num2.Location = new Point(199, 103);
            NU_Num2.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NU_Num2.Name = "NU_Num2";
            NU_Num2.Size = new Size(120, 27);
            NU_Num2.TabIndex = 1;
            // 
            // NU_Num4
            // 
            NU_Num4.DecimalPlaces = 2;
            NU_Num4.Location = new Point(199, 201);
            NU_Num4.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NU_Num4.Name = "NU_Num4";
            NU_Num4.Size = new Size(120, 27);
            NU_Num4.TabIndex = 3;
            // 
            // NU_Num3
            // 
            NU_Num3.DecimalPlaces = 2;
            NU_Num3.Location = new Point(199, 152);
            NU_Num3.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NU_Num3.Name = "NU_Num3";
            NU_Num3.Size = new Size(120, 27);
            NU_Num3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 48);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 4;
            label1.Text = "Nº1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 101);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 5;
            label2.Text = "Nº2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 154);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 6;
            label3.Text = "Nº3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 207);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 7;
            label4.Text = "Nº4";
            // 
            // button1
            // 
            button1.Location = new Point(80, 253);
            button1.Name = "button1";
            button1.Size = new Size(239, 87);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(80, 365);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 20);
            lbResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(lbResultado);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NU_Num4);
            Controls.Add(NU_Num3);
            Controls.Add(NU_Num2);
            Controls.Add(NU_Num1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NU_Num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NU_Num2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NU_Num4).EndInit();
            ((System.ComponentModel.ISupportInitialize)NU_Num3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NU_Num1;
        private NumericUpDown NU_Num2;
        private NumericUpDown NU_Num4;
        private NumericUpDown NU_Num3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label lbResultado;
    }
}
