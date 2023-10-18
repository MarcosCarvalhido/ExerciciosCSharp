using System;

namespace ExerciciosCSharp
{
    public class Lista1
    {
        public static void Questão1()
        { //Faça um programa que troque o valor de duas variáveis. Por exemplo, o programa lê n1 igual a 3 e n2 a 17, e mostra n1 igual a 17 e n2 a 3.

            int numero1 = 3;
            int numero2 = 4;

            Console.WriteLine("-- Questão 1 --");

            Console.WriteLine($" N1 ={numero1}, N2 = n{numero2}");
            int numero3 = numero1;
            numero1 = numero2;
            numero2 = numero3;
            Console.WriteLine($" N1 ={numero1}, N2 = n{numero2}");

        }
        public static void Questão2()
        { // Faça um programa para calcular a média de duas notas digitadas pelo usuário
            Console.WriteLine("-- Questão 2 -- ");

            Console.WriteLine("Insira a primeira nota:");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota:");
            int nota2 = int.Parse(Console.ReadLine());

            int media = (nota1 + nota2) / 2;

            Console.WriteLine($"A media entre as notas {nota1} e {nota2} é: {media}");

        }
        public static void Questão3()
        { //Faça um programa para calcular a média de duas notas digitadas pelo usuário, sendo que a segunda nota tem peso dois.
            Console.WriteLine("-- Questão 3 -- ");

            Console.WriteLine("Insira a primeira nota:");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota:");
            int nota2 = int.Parse(Console.ReadLine());

            int media = (nota1 + (nota2 * 2)) / 2;

            Console.WriteLine($"A media entre as notas {nota1} e {nota2} é: {media}");
        }
        public static void Questão4()
        { // Faça um programa que calcule a gorjeta a ser paga de uma conta de restaurante. A gorjeta é calculada como sendo 10% do valor da conta, que deve ser informado pelo usuário.
            Console.Write("Insira o valor a pagar: ");

            int conta = int.Parse(Console.ReadLine());
            int corjetaPorcem = 10;
            int corjetaTotal = conta * corjetaPorcem / 100;

            Console.Write("Total de corjeta: ");
            Console.WriteLine(corjetaTotal);
        }
        public static void Questão5()
        { // Faça um programa que calcule o novo valor de um salário a partir de um valor percentual de reajuste. O valor atual do salário e o valor percentual do reajuste devem ser informados pelo usuário como, por exemplo, 7,3%.

            Console.Write("Insira os seu salario atual: ");
            float salario = float.Parse(Console.ReadLine());
            Console.Write("Insira o reajuste em porcentagem: ");
            float reajuste = float.Parse(Console.ReadLine());

            float total = salario + ((salario * reajuste) / 100);

            Console.WriteLine($" O seu novo sarario sera de: R${total}");
        }
        public static void Questão6()
        { // Faça um programa que calcule a área de um quadrado, sendo que o comprimento do lado é informado pelo usuário. A área do quadrado é calculada elevando - se o lado ao quadrado.
            Console.Write("Informe o lado do quadrado: ");
            double lado = double.Parse(Console.ReadLine());

            double quadrado = Math.Pow(lado, 2);

            Console.WriteLine($"Area do quadrado: {quadrado}");
        }
        public static void Questão7()
        { // Faça um programa que calcule a área de um retângulo, sendo que os comprimentos da altura e da base são informados pelo usuário. A área do retângulo é calculada multiplicando-se a altura pela base.
            Console.Write("Informe o lado  1 do retangulo: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o lado  2 do retangulo: ");
            double lado2 = double.Parse(Console.ReadLine());

            double retangulo = lado1 * lado2;

            Console.WriteLine($"A area do retangulo é: {retangulo}");

        }
        public static void Questão8()
        { //Faça um programa que calcule a área de um círculo, sendo que o comprimento do raio é informado pelo usuário. A área do círculo é calculada multiplicando-se Pi ao raio ao quadrado.
            Console.Write("Informe o raio do Circulo: ");
            double raio = double.Parse(Console.ReadLine());

            double circulo = Math.Pow(raio * Math.PI, 2);

            Console.WriteLine($"A area do Circulo é: {circulo}");
        }
        public static void Questão9()
        { // Faça um programa que calcule a área de uma esfera, sendo que o comprimento do raio é informado pelo usuário. A área da esfera é calculada multiplicando-se 4 vezes Pi ao raio ao quadrado.
            Console.Write("Informe o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            double esfera = (Math.Pow(raio * Math.PI, 2)) * 4;

            Console.WriteLine($"A area do Circulo é: {esfera}");

        }
        public static void Questão10()
        { //Faça um programa que calcule o volume de uma caixa d’ água cilíndrica, sendo que os comprimentos do raio e a altura são informados pelo usuário. O volume é calculado multiplicando-se Pi, ao raio ao quadrado, a altura.
           
            Console.Write("Informe a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Informe o raio do cilindro: ");
            double raio = double.Parse(Console.ReadLine());

            double cilindro = (Math.Pow(raio * Math.PI, 2) * altura);

            Console.WriteLine($"O volume do cilindro é: {cilindro}");

        }
    }
}
