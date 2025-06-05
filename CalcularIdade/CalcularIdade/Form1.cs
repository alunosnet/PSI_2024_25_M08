namespace CalcularIdade
{
    public partial class Form1 : Form
    {
        //Construtor do form
        public Form1()
        {
            InitializeComponent();
            //definir como data máxima a data atual
            dtDataNasc.MaxDate = DateTime.Now;
        }
        //Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //terminar a aplicação
            Application.Exit();
        }
        //Sobre
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir o formulário sobre
            f_sobre form = new f_sobre();
            form.ShowDialog();
        }
        //Calcular idade
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataNascimento = dtDataNasc.Value;

            //calcular a diferença entre a data atual e a data nascimento
            TimeSpan tempo = dataAtual.Date - dataNascimento.Date;

            lbResultado.Text = ((int)(tempo.TotalDays / 365)).ToString();

            //verificar se o ano é bissexto
            if (DateTime.IsLeapYear(dataNascimento.Year))
            {
                lbResultado.Text += " anos.\nNasceu num ano bissexto.";
            }
            else
            {
                lbResultado.Text += " anos.\nNasceu num ano regular.";
            }
        }
    }
}
