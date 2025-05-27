namespace windows_ola_mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar uma variável para o nome
            string nome;

            //guardar o texto da tbNome
            nome = tbNome.Text;

            //alterar a mensagem do lbMensagem
            lbMensagem.Text = $"Olá, {nome}";

            //ativar o botão praa limpar
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbMensagem.Text = "";
            tbNome.Text = "";
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNome.Text = "Joaquim";
        }
    }
}
