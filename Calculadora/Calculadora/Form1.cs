namespace Calculadora
{
    public partial class Form1 : Form
    {
        //vari�veis da class
        string operacao;
        float primeiroNumero;

        public Form1()
        {
            InitializeComponent();
            tbPainel.Text = "0";
        }
        //Evento para todos os bot�es dos n�meros
        private void button14_Click(object sender, EventArgs e)
        {
            //converter o sender num button
            Button bt = (Button)sender;
            tbPainel.Text += bt.Text;
        }
        //Bot�o opera��o
        private void button4_Click(object sender, EventArgs e)
        {
            //guardar a opera��o selecionada
            Button bt = (Button)sender;
            operacao = bt.Text;
            //guardar o n� atual
            primeiroNumero = Convert.ToSingle(tbPainel.Text);
            //limpar o painel
            tbPainel.Text = "0";
        }
        //Bot�o =
        private void button15_Click(object sender, EventArgs e)
        {
            //guardar o n� atual
            float segundoNumero = Convert.ToSingle(tbPainel.Text);
            float resultado = 0;
            //verificar qual � a opera��o
            switch (operacao)
            {
                //executar a opera��o
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
                    MessageBox.Show("Opera��o n�o est� definida");
                    break;
            }
            //limpar a opera��o
            operacao = "";
            //guardar o resultado no painel e na vari�vel primeiroNumero
            tbPainel.Text = resultado.ToString();
            primeiroNumero = resultado;
        }
        //Bot�o limpar 
        private void button13_Click(object sender, EventArgs e)
        {
            operacao = "";
            tbPainel.Text = "0";
            primeiroNumero = 0;
        }
    }
}
