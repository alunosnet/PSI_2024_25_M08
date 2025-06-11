using System.Diagnostics;
using System.Drawing.Design;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        //vari�vel da classe
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
                //sortear um n� entre 0 e 9
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
        //CCCC - significa que acertou nos n� todos
        string Testar(int[] codigo,string tentativa)
        {
            string resposta = "";

            for(int p=0;p<4;p++)
            {
                string letra = "";
                //est� certo no local certo
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
                //n�o existe no c�digo
                resposta += letra;
            }

            return resposta;
        }
        //Bot�o para testar a combina��o
        private void button1_Click(object sender, EventArgs e)
        {
            //retirar da tb a tentativa
            string tentativa = textBox1.Text;
            if (tentativa.Length!=4)
            {
                MessageBox.Show("Tem de indicar quatro n�meros para o c�digo secreto.");
                return;
            }
            //verificar se a tentativa tem n� repetidos
            for(int i=0;i<4;i++)
            {
                if (tentativa.IndexOf(tentativa[i]) != 
                    tentativa.LastIndexOf(tentativa[i]))
                {
                    MessageBox.Show("O c�digo n�o tem n�meros repetidos.");
                    return;
                }
            }
            // verificar
            string feedback = Testar(codigo, tentativa);

            //se ganhou mostrar uma messagebox a perguntar se quer jogar novamente
            if (feedback == "CCCC")
            {
                //acertou no c�digo
                DialogResult resposta = MessageBox
                    .Show("Acertou no c�digo secreto. Deseja jogar novamente?"
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
            //adicionar � listbox
            lb_tentativas.Items.Add(linha);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
