using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int somaPares = 0;
            int somaImpares = 0;
 

            for (int i = 0; i <= 50; i++)
            {
                if(i % 2 == 0)
                {
                    somaPares = somaPares + i;
                    
                }
                else
                {
                    somaImpares = somaImpares + (i - 2);
                    
                }
            }

            Console.WriteLine("*   Soma dos Pares   *");
            Console.WriteLine("A soma dos pares é: " + somaPares);
            Console.WriteLine("\n");
            Console.WriteLine("*   Resultado da função matematica atribuida aos Impares   *");
            Console.WriteLine("Resultado dos Impares é: " + somaImpares);

            Console.ReadLine();
        }
    }
}
