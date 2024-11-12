using System;


namespace PHagua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtph = 0;
            double phagua;

            Console.Write("\nQuantidade de águas a analizar: ");
            qtph = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtph; i++)
            {
                Console.Write("\nIntroduza o PH a analizar: ");
                phagua = double.Parse(Console.ReadLine());

                if (phagua < 7)
                {
                    Console.WriteLine("A água é ácida!");
                }
                else if (phagua > 7)
                {
                    Console.WriteLine("A água é alcalina!");
                }
                else
                {
                    Console.WriteLine("A água é neutra!");
                }
            }

            Console.ReadKey();
        }
    }
}
