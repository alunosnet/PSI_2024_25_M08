namespace MasterMind
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            lb_tentativas = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 20);
            label1.TabIndex = 0;
            label1.Text = "Tente adivinhar a combinação de números";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 1;
            label2.Text = "Combinação secreta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 72);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 2;
            label3.Text = "****";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(398, 104);
            button1.Name = "button1";
            button1.Size = new Size(123, 52);
            button1.TabIndex = 4;
            button1.Text = "Testar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb_tentativas
            // 
            lb_tentativas.FormattingEnabled = true;
            lb_tentativas.Location = new Point(169, 167);
            lb_tentativas.Name = "lb_tentativas";
            lb_tentativas.Size = new Size(209, 144);
            lb_tentativas.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 314);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 6;
            label4.Text = "X - nº não existe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 334);
            label5.Name = "label5";
            label5.Size = new Size(275, 20);
            label5.TabIndex = 7;
            label5.Text = "E - Nº existe mas está na posição errada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 354);
            label6.Name = "label6";
            label6.Size = new Size(231, 20);
            label6.TabIndex = 8;
            label6.Text = "C - Nº está certo na posição certa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lb_tentativas);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private ListBox lb_tentativas;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
