using System;
using System.Globalization;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;

            Console.WriteLine("Introduza o raio do círculo: ");
            double raioC = double.Parse(Console.ReadLine());

            double area = pi * (raioC * raioC);

            Console.WriteLine();

            //Placeholders
            Console.WriteLine("Área do círculo: {0:F4}", area);
           /* 
            Outros metodos de usar variaveis e pôr 4 casas decimais:
            Interpolação
            Console.WriteLine($"Área do círculo: {area:F4}");
            Concatenação
            Console.WriteLine("Área do círculo: " + area.ToString("F4", CultureInfo.InvariantCulture));
           */

            Console.ReadKey();
        }
    }
}
