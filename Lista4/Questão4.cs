namespace Lista4
{
    internal class Questão4
    {
        //Faça um programa que leia uma sequência de números terminada pelo número zero e mostre apenas os números que forem maiores ou iguais à média dos elementos lidos. A sequência pode ter no máximo 20 números.
        public void Main()
        {
            const int TAMANHO = 5;
            bool FIM = true;
            int[] numeros = new int[TAMANHO];
            int quant = 0;
            double media = 0;

            while (FIM)
            {
                int num = LerNumero(quant);
                numeros[quant] = num;
                quant++;
                FIM = VerificarFim(num, quant);
            }
            media = CalcularMedia(numeros, quant);
            MostrarMedia(media);
            MostrarNumeros(numeros, quant, media);
        }
        public static int LerNumero(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Insira 5 numeros ou digite [0] para terminar");
            }
            Console.Write($"Numero [{num + 1}]: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        public static bool VerificarFim(int num, int quant)
        {
            if ((num == 0) || (quant == 5))
            {
                return false;
            }
            return true;
        }
        public static double CalcularMedia(int[] numeros, int quant)
        {
            int soma = 0;
            double media = 0;

            for (int i = 0; i < quant; i++)
            {
                soma += numeros[i];
            }
            media = (double)soma / quant;
            return media;
        }
        public static void MostrarNumeros(int[] numeros, int quant, double media)
        {
            Console.Write("Os numeros que são maiores que a media são: ");
            for (int i = 0; i < quant; i++)
            {
                if (numeros[i] >= media)
                {
                    Console.Write(numeros[i] + ", ");
                }
            }
        }
        public static void MostrarMedia(double media)
        {
            Console.WriteLine("A media dos numeros é: " + media);
        }
    }
}
