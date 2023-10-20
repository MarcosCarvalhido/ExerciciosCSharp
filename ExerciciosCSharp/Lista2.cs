using System;
using System.Text.RegularExpressions;

namespace ExerciciosCSharp
{
    public class Lista2
    {
        public static void Questão1()
        { //Faça um programa que leia um número e mostre se o mesmo é positivo, negativo ou zero.
            Console.Write("Digite um numero: ");

            double numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("é positivo");
            }
            else if (numero < 0)
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
            System.Console.Write("Insira um numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                System.Console.WriteLine($"O numero {numero} é par");
            }
            else
            {
                System.Console.WriteLine($"O numero {numero} é impar");
            }
        }
        public static void Questão3()
        { //Faça um programa que leia dois números e mostre o maior número.
            int numero1, numero2, resultado;

            System.Console.Write("Insira o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            System.Console.Write("Insira o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            resultado = Math.Max(numero1, numero2);

            System.Console.WriteLine($"Entre '{numero1}' e '{numero2}', {resultado} é maior!");
        }
        public static void Questão4()
        { //Faça um programa que leia três números e mostre o maior número
            int numero1, numero2, numero3, resultado1, resultado2;

            System.Console.Write("Insira o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());
            System.Console.Write("Insira o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            System.Console.Write("Insira o terceiro numero: ");
            numero3 = int.Parse(Console.ReadLine());

            resultado1 = Math.Max(numero1, numero2);
            resultado2 = Math.Max(resultado1, numero3);

            System.Console.WriteLine($"Entre '{numero1}', '{numero2}' e '{numero3}', {resultado2} é maior!");
        }
        public static void Questão5()
        { //Faça um programa que leia uma opção de um menu sendo [1] Soma, [2] Subtração, [3] Multiplicação e [4] Divisão. Se a opção for válida, o programa deverá ler os operandos, realizar a operação e mostrar o resultado. Caso contrário, o programa deverá exibir uma mensagem de operação inválida.
            double numero1, numero2, resultado;
            int operador;

            resultado = 0;

            System.Console.Write("Insira o primeiro numero: ");
            numero1 = double.Parse(Console.ReadLine());
            System.Console.Write("Insira o segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());
            System.Console.Write("Escolha um dos seguintes Operadores: ");
            System.Console.WriteLine("[1] Soma, [2] Subtração, [3] Multiplicação, [4] Divisão e [5] Potenciação");
            operador = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case 1: //"[1] Soma
                    {
                        resultado = numero1 + numero2;
                        break;
                    }
                case 2: //[2] Subtração
                    {
                        resultado = numero1 - numero2;
                        break;
                    }
                case 3: //[3] Multiplicação
                    {
                        resultado = numero1 * numero2;
                        break;
                    }
                case 4: //[4] Divisão
                    {
                        resultado = numero1 / numero2;
                        break;
                    }
                case 5: //[4] Potenciação
                    {
                        resultado = Math.Pow(numero2, numero2);
                        break;
                    }
                default: //error
                    {
                        Console.WriteLine("Entrada invalida, tente novamente!");
                        break;
                    }

            }

            Console.WriteLine("Resultado: " + resultado);

        }
        public static void Questão6()
        { //Faça um programa que leia um caractere e informe se o mesmo é uma vogal ou não.
            string letra;

            Console.Write("Insira uma letra: ");
            letra = Console.ReadLine();

            if (ehVogal(letra))
            {
                Console.WriteLine("é uma vogal");
            }
            else
            {
                Console.WriteLine("Não é uma vogal");
            }


        }
        static bool ehVogal(string letraTeste)
        {

            return Regex.IsMatch(letraTeste, "^[aeiouAEIOU]$");
        }
        public static void Questão7()
        {//Faça um programa que calcule e mostre o novo valor de um salário a partir das seguintes regras: salários de até R$ 1.000,00 inclusive recebem 30% de aumento, salários de até R$ 2.000,00 inclusive recebem 25%, salários de até R$ 3.000,00 inclusive recebem 20%, salários de até R$ 4.000,00 inclusive recebem 15% e salários acima de R$ 4.000,00 recebem apenas 10%.
            double salario;
            double novoSalario = 0;
            int reajuste = 0;

            Console.Write("Informe o seu salario: ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 1000)
            {
                reajuste = 30;
                novoSalario = salario + ((salario * reajuste) / 100);
            }
            else if (salario < 2000)
            {
                reajuste = 25;
                novoSalario = salario + ((salario * reajuste) / 100);
            }
            else if (salario < 3000)
            {
                reajuste = 20;
                novoSalario = salario + ((salario * reajuste) / 100);
            }
            else if (salario < 4000)
            {
                reajuste = 15;
                novoSalario = salario + ((salario * reajuste) / 100);
            }
            else if (salario > 4000)
            {
                reajuste = 10;
                novoSalario = salario + ((salario * reajuste) / 100);
            }

            Console.WriteLine($"Com um reajuste de {reajuste}%, seu novo salario será de: R${novoSalario}");
        }
        public static void Questão8()
        {//Os endereços IP versão 4 são divididos em cinco classes: A, B, C, D e E. Os endereços no intervalo de 0 a 127 são classe A, de 128 a 191 são classe B, de 192 a 223 são classe C, de 224 a 239 são classe D e a partir de 240 até 255 são classe E. Faça um programa que leia o primeiro octeto, no formato decimal, de um endereço IP e informe a sua classe.

        }
    }
}
