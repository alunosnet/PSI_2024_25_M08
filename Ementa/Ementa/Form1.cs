namespace Ementa
{
    public partial class Form1 : Form
    {
        //variáveis globais da classe
        //propriedades
        string[] sobremesas = { "Mousse", "Gelado", "Bolo de bolacha" };
        string[] pratos = { "Arroz de pato", "Bife" };
        string[] pratos_vegi = { "Tofu", "Salada" };
        string[] bebidas = { "Água", "Sumo" };
        public Form1()
        {
            InitializeComponent();

        }
        //preenche a listbox com o array de opcoes
        void PreencheListBox(ListBox listbox, string[] opcoes)
        {
            listbox.Items.Clear();
            listbox.Items.AddRange(opcoes);
        }
        //Vegetariano
        private void chkVegi_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Prato
        private void rbPrato_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Bebida
        private void rbBebida_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBebida.Checked)
            {
                PreencheListBox(lbOpcoes, bebidas);
            }
        }
        //Sobremesa
        private void rbSobremesa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSobremesa.Checked)
                PreencheListBox(lbOpcoes, sobremesas);
        }
        //Adicionar ao menu
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
