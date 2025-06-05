namespace Palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            f_splash f = new f_splash();
            f.ShowDialog();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        //evento é executado sempre que o texto for alterado
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerificarPalindromo();
        }
        void VerificarPalindromo()
        {
            string palavra = textBox1.Text.ToLower().Trim();
            string palavra_invertida = "";

            //inverter a palavra
            for (int i = 0; i < palavra.Length; i++)
                palavra_invertida = palavra[i] + palavra_invertida;
            //comparar as duas palavras
            if (palavra == palavra_invertida)
                lbResultado.Text = "É um palindromo";
            else
                lbResultado.Text = "Não é um palindromo";
        }
    }
}
