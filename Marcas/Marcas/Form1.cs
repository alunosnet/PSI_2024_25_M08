namespace Marcas
{
    public partial class Form1 : Form
    {
        //array de strings
        string[] marcas = { "Ford", "Mercedes", "Opel", "Renault" };
        //array vazio de 4 strings
        string[] teste = new string[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //evento é executado antes do formulário ser mostrado ao utilizador
            //Adicionar item a item
            //cbMarcas.Items.Add("Ford");
            // cbMarcas.Items.Add("Mercedes");
            //Adicionar o array de uma só vez
            //cbMarcas.Items.AddRange(marcas);
            //adicionar o array um de cada vez
            for (int i = 0; i < marcas.Length; i++)
                cbMarcas.Items.Add(marcas[i]);
            //bloquear a combobox para obrigar a escolher um da lista
            cbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //Evento que ocorre quando é escolhida uma marca
        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarcas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma marca.");
                return;
            }
            int posicao = cbMarcas.SelectedIndex;

            string marcaEscolhida = cbMarcas.Items[posicao].ToString();
            //MessageBox.Show(marcaEscolhida);
            //adicionar a marca à listbox
            lbEscolhidas.Items.Add(marcaEscolhida);
            //remover a marca escolhida da combobox
            cbMarcas.Items.RemoveAt(posicao);
        }
        // botão limpar
        private void button2_Click(object sender, EventArgs e)
        {
            //remover todos os items da listbox
            lbEscolhidas.Items.Clear();
            //repõe todos os items da combobox
            for (int i = 0; i < marcas.Length; i++)
                if (cbMarcas.Items.Contains(marcas[i])==false)
                    cbMarcas.Items.Add(marcas[i]);
        }
        //botão remover
        private void button1_Click(object sender, EventArgs e)
        {
            //caso não tenha nenhum item selecionado deve mostrar um aviso
            if (lbEscolhidas.SelectedIndex==-1)
            {
                MessageBox.Show("Tem de escolher um elemento.");
                return;
            }
            //remove o item selecionado da listbox
            lbEscolhidas.Items.RemoveAt(lbEscolhidas.SelectedIndex);
        }
    }
}
