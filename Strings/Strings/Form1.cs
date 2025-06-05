using System.Runtime.CompilerServices;

namespace Strings
{
    public partial class Form1 : Form
    {
        string[] palavras = new string[10];
        int contar = 0;
        public Form1()
        {
            InitializeComponent();
            f_splash f = new f_splash();

            f.ShowDialog();
        }

        int MaiorPalavra(string[] palavras)
        {
            int maior = 0;
            //TODO: Completar
            return maior;
        }
        int MaisVogais(string[] palavras)
        {
            int pos = 0;
            //TODO: Completar
            return pos;
        }
    }
}
