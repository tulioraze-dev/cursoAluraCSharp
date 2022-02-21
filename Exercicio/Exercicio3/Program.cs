using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*   Fatorial   *");

            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um numero inteiro e descubra seu fatorial: " + numeroDigitado);

            for (int i = numeroDigitado - 1; i >= numeroDigitado; i--)
            {
                numeroDigitado = numeroDigitado * i;
            }

            Console.WriteLine("Fatorial do numero digitado é : " + numeroDigitado);

            Console.ReadLine();
        }
    }
}
