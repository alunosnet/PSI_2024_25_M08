namespace CalcularNota
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //guardar os dados do windows form
                string nome = tbNome.Text;
                int teste = Convert.ToInt32(tbTeste.Text);
                int desafio = Convert.ToInt32(tbDesafio.Text);
                int projeto = Convert.ToInt32(tbProjeto.Text);
                //validação
                if (teste < 0 || teste > 20) 
                {
                    MessageBox.Show("A nota do teste não é válida. Deve ser um valor entre 0 e 20");
                    return;
                }
                //calcular a nota
                float nota_final;
                nota_final = (float)((teste * 0.3) + (desafio * 0.3) + (projeto * 0.4));
                //mostrar o resultado
                lbMensagem.Text = $"{nome} a tua nota final é {nota_final}";
                if (nota_final >= 10)
                {
                    lbMensagem.Text += "\nTens positiva.";
                    lbMensagem.ForeColor = Color.Green; //altera a cor do texto
                }
                else
                {
                    lbMensagem.Text += "\nTens negativa.";
                    lbMensagem.ForeColor=Color.Red;
                }
            }catch(Exception erro)  //se ocorrer um erro dentro do try
            {
                MessageBox.Show(erro.Message);
            }
        }
    }

}
