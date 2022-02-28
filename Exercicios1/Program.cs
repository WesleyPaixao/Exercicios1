using System;
using System.Globalization;

namespace Exercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
             código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            */

            int cd1, n1,cd2, n2;
            double v1, v2;

            Console.Write("Informe o codigo da peça: ");
            cd1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero de peças: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor unitario de cada peça: ");
            v1 = double.Parse(Console.ReadLine());

            var T1 = n1 * v1;

            Console.Write("Informe o codigo da segunda peça: ");
            cd2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero de peças: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor unitario de cada peça ");
            v2 = double.Parse(Console.ReadLine()); 

            var T2 = n2 * v2;

            var Total = T1 + T2;
            Console.Write("TOTAL A PAGAR R$: "+Total.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
             casas decimais
            */
            double raio = 0;
            double pi = 3.14159;
 
            Console.Write("Informe o valor do raio:");
            raio = double.Parse(Console.ReadLine());
            double area = pi * raio * raio;
            Console.WriteLine("O valor da da area é: "+area.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}
