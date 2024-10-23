using System;


namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o primeiro valor: ");
            double p1Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o segundo valor: ");
            double p2Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o operador artimétrico: ");
            string sinalA = Console.ReadLine();

            double resultado;

            if (sinalA == "+")
            {
                resultado = p1Valor + p2Valor;
                Console.WriteLine($"Resultado é: {resultado:F4}");
            }
            else if (sinalA == "-")
            {
                resultado = p1Valor - p2Valor;
                Console.WriteLine($"Resultado é: {resultado:F4}");
            }
            else if (sinalA == "*")
            {
                resultado = p1Valor * p2Valor;
                Console.WriteLine($"Resultado é: {resultado:F4}");
            }
            else if (sinalA == "/")
            {
                resultado = p1Valor / p2Valor;
                Console.WriteLine($"Resultado é: {resultado:F4}");
            }
            else
            {
                Console.WriteLine("Sinal não suportado!");
            }

            Console.ReadKey();
        }
    }
}