namespace ControloEntradas
{
    partial class Form2
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
            lbMensagem = new Label();
            SuspendLayout();
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Location = new Point(113, 72);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(50, 20);
            lbMensagem.TabIndex = 0;
            lbMensagem.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 419);
            Controls.Add(lbMensagem);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbMensagem;
    }
}