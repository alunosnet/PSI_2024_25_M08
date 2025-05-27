internal class Program
{
    private static void Main(string[] args)
    {
        //Variaveis();
        //LerDados();
        //OperadoresLogicos();
        Ciclos();
        Console.WriteLine(Soma(10, 20));
    }
    /// <summary>
    /// Soma para somar dois números
    /// </summary>
    /// <param name="x">Primeiro nº a somar</param>
    /// <param name="y">Segundo nº a somar</param>
    /// <returns>Um inteiro com o resultado da soma</returns>
    static int Soma(int x, int y)
    {
        return x + y;
    }
    private static void Ciclos()
    {
        int i = 0;
        //percorrer nº inteiros de 0 < 9
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        //percorrer nº inteiro de 9 a 0
        for (i = 9; i >= 0; i--)
            Console.WriteLine(i);
        /////////////////////////////////////////////
        //ciclo while
        i = 0;
    
        while(i<10)
        {
            Console.WriteLine(i);
            i++;
        }
        //////////foreach
        ///
        string texto = "Olá mundo";
        for (i = 0; i < texto.Length; i++) 
            Console.WriteLine(texto[i]);
        foreach (char c in texto)
            Console.WriteLine(c);

    }
    static void OperadoresLogicos()
    {
        int x = 10, y = 5;
        //mostrar mensagem se dois nº são maiores que 0
        //operador lógico E
        if (x > 0 && y > 0)
            Console.WriteLine("São os dois maiores que zero");
        //operado lógico OU
        if (x > 0 || y > 0)
            Console.WriteLine("Um dos dois é maior que zero");
    }
    static void LerDados()
    {
        string? texto;
        texto = Console.ReadLine();
        int numero;
        numero = Convert.ToInt32(texto);
        Console.WriteLine(numero);
    }
    public static void Variaveis()
    {
        //comentário de uma linha
        /*
         Comentário de várias linhas
         */
        Console.WriteLine("Hello, World!");
        //Variáveis
        bool verdadeiro_falso;
        verdadeiro_falso = true;
        int inteiro = 10;
        double mais_casas_decimais = 10.5;
        float menos_casa_decimais = 10.4f;
        char uma_letra = 'a';
        string um_nome = "Joaquim";
        var o_que_e_isto = 10.5;

        if (verdadeiro_falso == true)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }
}