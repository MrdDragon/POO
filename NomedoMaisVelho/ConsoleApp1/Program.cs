using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Introduza o nome da primeira pessoa: ");
            string p1nome = Console.ReadLine();
       
            Console.WriteLine("Introduza a idade: ");
            int p1idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o nome da segunda pessoa: ");
            string p2nome = Console.ReadLine();

            Console.WriteLine("Introduza a idade: ");
            int p2idade = int.Parse(Console.ReadLine());

            if (p1idade < p2idade)
            {
                Console.WriteLine("A pessoa mais velha é : " + p2nome);
            }
            else if (p1idade > p2idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + p1nome);
            }
            else
            {
                Console.WriteLine("São da mesma idade!");
            }
           
            Console.ReadKey();

        }
    }
}
