using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double capitalInvestido = 10000.00;
            double taxaDeJuros = 0.01;

            Console.WriteLine("Informe quanto tempo em meses de investimento:");
            int tempo = Convert.ToInt32(Console.ReadLine());

            double montanteAcumulado = capitalInvestido * Math.Pow((1 + taxaDeJuros), tempo);
            Console.WriteLine("O valor a receber será de : R$ " + montanteAcumulado);



            Console.ReadLine();
        }
    }
}
