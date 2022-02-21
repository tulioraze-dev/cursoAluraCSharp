using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupança2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");

            double valorInvestido = 1000.00;

            for(int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + i + "você tera R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
