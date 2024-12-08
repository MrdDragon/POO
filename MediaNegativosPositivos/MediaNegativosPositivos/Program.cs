using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNegativosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorP = 0, contadorN = 0;
            double mediaP = 0.0, mediaN = 0.0, valoresP = 0.0, valoresN = 0.0, valorLido = 0;
       

            while (true)
            {
                Console.WriteLine("Introduza um valor real (Introduza \"fim\" para terminar): ");

                string dadosInt = Console.ReadLine();
               

                if (dadosInt.ToLower() == "fim")
                {
                    break;
                }

                if (double.TryParse(dadosInt, out valorLido))
                {
                    if (valorLido < 0)
                    {
                        valoresN += valorLido;
                        contadorN++;
                    }
                    else if (valorLido > 0)
                    {
                        valoresP += valorLido;
                        contadorP++;
                    }
                    else if (valorLido == 0)
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Dados inválidos! Tente novamente!");

                }
               
            }

            if (contadorP > 0)
            {
                mediaP = (double)valoresP / contadorP;
                Console.WriteLine($"A média dos valores positivos é de: {mediaP:F2}");
            }
            

            if (contadorN > 0)
            {
                mediaN = (double)valoresN / contadorN;
                Console.WriteLine("A média dos valores negativos é de: {0:F2}", mediaN);
            }
            
            
            Console.ReadKey();
        }
    }
}
