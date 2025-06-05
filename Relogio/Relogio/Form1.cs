namespace Relogio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Atualizar a label do relógio
        void AtualizarRelogio()
        {
            DateTime agora = DateTime.Now;

            lbRelogio.Text = agora.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarRelogio();
        }
    }
}
