using System;


namespace ValorAPagar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o código do 1º artigo: ");
            string p1Codigo = Console.ReadLine();
            Console.WriteLine("Quantidade do 1º artigo: ");
            int p1Quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o valor do 1º artigo: ");
            double p1Valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o código do 2º artigo: ");
            string p2Codigo = Console.ReadLine();
            Console.WriteLine("Quantidade do 2º artigo: ");
            int p2Quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o valor do 2º artigo: ");
            double p2Valor = double.Parse(Console.ReadLine());

            double p1PrecoFinal = p1Quant * p1Valor;
            double p2PrecoFinal = p2Quant * p2Valor;
            double PrecoFinal = p1PrecoFinal + p2PrecoFinal;

            Console.WriteLine();
            Console.WriteLine("Total a ser pago: " + PrecoFinal);
            Console.ReadKey();
        }
    }
}
