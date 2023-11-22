namespace Lista4
{
    public class Questão2
    {
        public void Main()
        {
            int[] vet1 = { 1, 2, 3, 4, 5, 7, 8 };
            int[] vet2 = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int[] vet3 = new int[vet1.Length];

            vet3 = SomarVetores(vet1, vet2);
            MostrarVetor(vet1);
            MostrarVetor(vet2);
            MostrarVetor(vet3);
        }
        public static void MostrarVetor(int[] vet)
        {
            Console.Write("Array: ");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + ", ");
            }
        }
        public static int[] SomarVetores(int[] vet1, int[] vet2)
        {
            int[] vet3 = new int[vet1.Length];
            for (int i = 0; i < vet1.Length; i++)
            {
                vet3[i] = vet1[i] + vet2[i];

            }
            return vet3;
        }
    }
}