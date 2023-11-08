using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3
{
    public static class Questão1
    {//Faça um programa que transfira o conteúdo do vetor {10, 20, 30, 40, 50, 60, 70, 80}
     //para um outro vetor do mesmo tipo e tamanho, e mostre o conteúdo do novo vetor na ordem inversa.

       public static void Numeros()
        {
            int[] ints1 = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int[] ints2 = new int[ints1.Length];

            foreach (int i in ints1)
            {
                Console.WriteLine(i);
               // ints2[i] = ints1[i];
            }
        }

    }
}
