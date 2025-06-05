namespace Calcular_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n1, n2, n3, n4;
            float maior=0, menor=0;

            n1 = (float)NU_Num1.Value;
            n2 = (float)NU_Num2.Value;
            n3 = (float)NU_Num3.Value;
            n4 = (float)NU_Num4.Value;
            //média
            float media = (n1 + n2 + n3 + n4) / 4;
            //maior
            if (n1 > n2)
                maior = n1;
            else
                maior = n2;
            if (maior < n3)
                maior = n3;
            if (maior < n4)
                maior = n4;
            //menor
            if (n1 < n2)
                menor = n1;
            else
                menor = n2;
            if (menor > n3)
                menor = n3;
            if (menor > n4)
                menor = n4;
            lbResultado.Text = $"A média dos valores é de {media}.\n" +
                $"O maior é {maior}.\nO menor é {menor}.";
        }
    }
}
