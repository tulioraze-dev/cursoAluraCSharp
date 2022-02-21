using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            //DOUBLE - suporta uma precisão muito maior depois da virgula
            double salario = 15000.55;

            //Suporta uma precisão menor depois da virgula 
            float altura = 1.80f;

            //INT é o mais usado e suporta 32 bits, aproximadadmente 2Bilhões 
            int salarioEmInteiro = (int)salario;

            //LONG é usado para numeros acima de 2 Bilhoes - 64 bits
            long idadeDoMundo = 13000000000;

            //SHORT valor maximo é 16.000 - 16 bits
            short quantidadeProduto = 150;

            Console.ReadLine(); 
        }
    }
}
