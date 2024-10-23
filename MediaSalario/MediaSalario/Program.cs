using System;

namespace MediaSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduza o nome de um funcionário: ");
            string p1Nome = Console.ReadLine();

            Console.WriteLine("Introduza o sálario: ");
            double p1Salario = double.Parse(Console.ReadLine());


            Console.WriteLine("Introduza o nome do segundo funcionário: ");
            string p2Nome = Console.ReadLine();

            Console.WriteLine("Introduza o sálario: ");
            double p2Salario = double.Parse(Console.ReadLine());

            double media = p1Salario + p2Salario ;

            Console.WriteLine();
            Console.WriteLine("A média dos salários é: " + media/2);

            Console.ReadKey();
        }
    }
}
