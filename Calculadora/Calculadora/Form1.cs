namespace Calculadora
{
    public partial class Form1 : Form
    {
        //variáveis da class
        string operacao;
        float primeiroNumero;

        public Form1()
        {
            InitializeComponent();
            tbPainel.Text = "0";
        }
        //Evento para todos os botões dos números
        private void button14_Click(object sender, EventArgs e)
        {
            //converter o sender num button
            Button bt = (Button)sender;
            tbPainel.Text += bt.Text;
        }
        //Botão operação
        private void button4_Click(object sender, EventArgs e)
        {
            //guardar a operação selecionada
            Button bt = (Button)sender;
            operacao = bt.Text;
            //guardar o nº atual
            primeiroNumero = Convert.ToSingle(tbPainel.Text);
            //limpar o painel
            tbPainel.Text = "0";
        }
        //Botão =
        private void button15_Click(object sender, EventArgs e)
        {
            //guardar o nº atual
            float segundoNumero = Convert.ToSingle(tbPainel.Text);
            float resultado = 0;
            //verificar qual é a operação
            switch (operacao)
            {
                //executar a operação
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case "/":
                    resultado = primeiroNumero / segundoNumero;
                    break;
                default:
                    MessageBox.Show("Operação não está definida");
                    break;
            }
            //limpar a operação
            operacao = "";
            //guardar o resultado no painel e na variável primeiroNumero
            tbPainel.Text = resultado.ToString();
            primeiroNumero = resultado;
        }
        //Botão limpar 
        private void button13_Click(object sender, EventArgs e)
        {
            operacao = "";
            tbPainel.Text = "0";
            primeiroNumero = 0;
        }
    }
}
