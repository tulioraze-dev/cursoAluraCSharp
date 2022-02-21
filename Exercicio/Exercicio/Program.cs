using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("*  DESCUBRA O MAIOR   *");
            Console.WriteLine("***********************");

            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            int numeroMaior;

            if(numero1 > numero2)
            {
                numeroMaior = numero1;
            }
            else
            {
                numeroMaior = numero2;
            }

            if(numero3 > numeroMaior)
            {
                numeroMaior = numero3;
            }
            else
            {

            }

            Console.WriteLine("Primeiro numero digitado: " + numero1);
            Console.WriteLine("Segundo numero digitado: " + numero2);
            Console.WriteLine("Terceiro numero digitado: " + numero3);
            Console.WriteLine("\n");
            Console.WriteLine("O maior entre os numero digitado é: " + numeroMaior);


            Console.ReadLine();

        }
    }
}
