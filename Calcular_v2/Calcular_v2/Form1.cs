namespace Calcular_v2
{
    public partial class Form1 : Form
    {
        //vari�veis do formul�rio
        float maior = float.MinValue, menor = float.MaxValue, soma = 0, contar = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //Bot�o para calcular a m�dia, o maior e o menor
        private void button1_Click(object sender, EventArgs e)
        {
            float atual = (float)NU_Numero.Value;
            contar++;
            soma += atual;
            float media = soma / contar;
            if (atual < menor)
                menor = atual;
            if (atual > maior)
                maior = atual;
            lbResultado.Text = $"A m�dia dos valores � de {media.ToString("f2")}.\n" +
                $"O maior � {maior}.\nO menor � {menor}.";
        }
        //Bot�o para limpar
        private void button2_Click(object sender, EventArgs e)
        {
            maior = menor = soma = contar = 0;
            lbResultado.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem a certeza que pretende sair?",
                "Sair",
                MessageBoxButtons.YesNo);
            if (resposta == DialogResult.No)
                e.Cancel = true;
        }
    }
}
