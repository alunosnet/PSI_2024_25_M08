namespace ControloEntradas
{
    public partial class Form1 : Form
    {
        //vari�veis
        //Nr atual de pessoas na loja
        int NrAtualPessoas = 0;
        //Maior nr de pessoas que entraram na loja
        int maior = 0;
        //Para calcular a m�dia de pessoas que entram
        int contar = 0, somaTotal = 0;
        //Guarda o n� mais elevado de pessoas na loja
        int maiorLotacao = 0;
        public Form1()
        {
            InitializeComponent();
            lbAtual.Text = "Pessoas na loja: 0";
        }
        //Bt entrar
        private void button1_Click(object sender, EventArgs e)
        {
            int PessoasParaEntrar = (int)nudPessoas.Value;
            if (NrAtualPessoas + PessoasParaEntrar > 100)
            {
                MessageBox.Show("N� de pessoas ultrapassa o limite de 100. Por favor volte mais tarde.");
                return;
            }
            NrAtualPessoas += PessoasParaEntrar;
            lbAtual.Text="Pessoas na loja: "+ NrAtualPessoas;
            nudPessoas.Value = 1;
            //verificar se � o maior nr de pessoas que entraram na loja
            if (PessoasParaEntrar > maior)
                maior = PessoasParaEntrar;
            //contar e somar a entrada
            contar += 1;
            somaTotal += PessoasParaEntrar;
            //Verificar se atingiu a maior lota��o
            if (NrAtualPessoas > maiorLotacao)
                maiorLotacao = NrAtualPessoas;
        }
        //Bt sair
        private void button2_Click(object sender, EventArgs e)
        {
            int PessoasParaSair = (int) nudPessoas.Value;
            if (NrAtualPessoas - PessoasParaSair < 0)
            {
                MessageBox.Show("N�o existe esse n� de pessoas para sair.");
                return;
            }
            NrAtualPessoas -= PessoasParaSair;
            lbAtual.Text = "Pessoas na loja: " + NrAtualPessoas;
            nudPessoas.Value = 1;
        }
        //Bt estatisticas
        private void button3_Click(object sender, EventArgs e)
        {
            float media = 0;

            media = (float)somaTotal / contar;

            //Criar um objeto do tipo Form2
            Form2 f = new Form2();

            string mensagem = "Maior n� de pessoas que entraram: " + maior;
            mensagem += "\nM�dia de pessoas que entraram: " + media;
            mensagem += "\nMaior lota��o: " + maiorLotacao;
            //alterar o modifier do label para public
            //para permitir fazer altera��es a partir de outro form
            f.lbMensagem.Text = mensagem;
            f.ShowDialog();

            //segundo m�todo que passa a mensagem pelo construtor
            Form3 f3 = new Form3(mensagem);
            f3.ShowDialog();
        }
        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;

            lbRelogio.Text = agora.ToString("HH:mm:ss");
        }
    }
}
