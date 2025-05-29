namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            if (cbNumero.SelectedIndex==-1)
            {
                MessageBox.Show("Tem de escolher um valor para a tabuada.");
                cbNumero.Focus();
                return;
            }
            numero = Convert.ToInt32(cbNumero.Text);
            lbResultado.Text = "";
            for(int i =1;i<=10;i++)
            {
                lbResultado.Text += $"{numero} X {i} = {numero * i}\n";
            }
        }
    }
}
