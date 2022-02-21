using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12");

            double taxaInvestimento = 1.0036;
            double valorInvestido = 1000.00;


            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <=12; j++)
                {
                    valorInvestido = valorInvestido* taxaInvestimento;
                }

                taxaInvestimento += 0.0010;
            }

            Console.WriteLine("O valor total que voce recebera sera de R$" + valorInvestido);

            Console.ReadLine();
            
        }
    }
}
