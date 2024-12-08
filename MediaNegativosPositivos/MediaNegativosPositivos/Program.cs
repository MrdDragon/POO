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
            int valoresP = 0, valoresN = 0, contadorP = 0, contadorN = 0, valorLido = 0;
            double mediaP = 0.0, mediaN = 0.0;
            

            while (valorLido != 999999)
            {
                Console.WriteLine("Introduza um valor real (Introduza 999999 para terminar): ");
                valorLido = int.Parse(Console.ReadLine());

                if (valorLido == 999999)
                {
                    break;
                }
                else if (valorLido < 0)
                {
                    valoresN += valorLido;
                    contadorN ++;
                }
                else if(valorLido > 0)
                {
                    valoresP += valorLido;
                    contadorP++;
                }
                else if (valorLido == 0)
                {
                }
            }
            if (contadorP == 0)
            {

            }
            else 
            {
                mediaP = (double)valoresP / contadorP;
                Console.WriteLine("A média dos valores positivos é de: {0:F2}", mediaP);
            }

            if (contadorN == 0)
            {

            }
            else
            {
                mediaN = (double)valoresN / contadorN;
                Console.WriteLine("A média dos valores negativos é de: {0:F2}", mediaN);
            }
            
            
            Console.ReadKey();
        }
    }
}
