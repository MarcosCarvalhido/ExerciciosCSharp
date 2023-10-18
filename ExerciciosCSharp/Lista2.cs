using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    public class Lista2
    {
        public static void Questão1()
        { //Faça um programa que leia um número e mostre se o mesmo é positivo, negativo ou zero.
            Console.Write("Digite um numero: ");

            double numero = double.Parse(Console.ReadLine());

            if(numero > 0 )
            {
                Console.WriteLine("é positivo");
            }
            else if(numero < 0 )
            {
                Console.WriteLine("é negativo");
            }
            else
            {
                Console.WriteLine("é zero");
            }
        }
        public static void Questão2()
        { //Faça um programa que leia um número e mostre se o mesmo é par ou ímpar.

        }
    }
}
