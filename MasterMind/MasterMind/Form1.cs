using System.Diagnostics;
using System.Drawing.Design;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        //variável da classe
        int[] codigo;
        public Form1()
        {
            InitializeComponent();
            codigo = GerarCodigo();
        }
        int[] GerarCodigo()
        {
            int[] numeros = new int[4];
            Random sortear = new Random();
            for(int i=0;i<4;i++)
            {
                //sortear um nº entre 0 e 9
                int n = sortear.Next(0, 10);
                if (numeros.Contains(n))
                {
                    i -= 1;
                    continue;
                }    
                numeros[i] = n;
            }

            return numeros;
        }
        //recebe oo codigo e a tentativa e devolve feedback
        //CCCC - significa que acertou nos nº todos
        string Testar(int[] codigo,string tentativa)
        {
            string resposta = "";

            for(int p=0;p<4;p++)
            {
                string letra = "";
                //está certo no local certo
                if (tentativa[p].ToString() == codigo[p].ToString())
                {
                    letra = "C";
                }
                //verificar se existe noutra posicao
                for (int i = 0; letra=="" && i < 4; i++)
                {
                    if (codigo[i].ToString() == tentativa[p].ToString())
                    {
                        letra = "E";
                        break;
                    }
                }
                if (letra == "")
                    letra = "X";
                //não existe no código
                resposta += letra;
            }

            return resposta;
        }
        //Botão para testar a combinação
        private void button1_Click(object sender, EventArgs e)
        {
            //retirar da tb a tentativa
            string tentativa = textBox1.Text;
            if (tentativa.Length!=4)
            {
                MessageBox.Show("Tem de indicar quatro números para o código secreto.");
                return;
            }
            //verificar se a tentativa tem nº repetidos
            for(int i=0;i<4;i++)
            {
                if (tentativa.IndexOf(tentativa[i]) != 
                    tentativa.LastIndexOf(tentativa[i]))
                {
                    MessageBox.Show("O código não tem números repetidos.");
                    return;
                }
            }
            // verificar
            string feedback = Testar(codigo, tentativa);

            //se ganhou mostrar uma messagebox a perguntar se quer jogar novamente
            if (feedback == "CCCC")
            {
                //acertou no código
                DialogResult resposta = MessageBox
                    .Show("Acertou no código secreto. Deseja jogar novamente?"
                    , "Game Over", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    codigo = GerarCodigo();
                    lb_tentativas.Items.Clear();
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }
            }
            //mostrar o feed back
            string linha = tentativa + " | " + feedback;
            //adicionar à listbox
            lb_tentativas.Items.Add(linha);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
