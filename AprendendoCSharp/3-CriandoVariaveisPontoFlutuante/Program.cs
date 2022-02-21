using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3. Criando variaveis ponto flutuante");

            double salario = 15000.55;
            Console.WriteLine(salario);

            double idade = 15.0 / 2.0;
            Console.WriteLine(idade);

            Console.WriteLine("Seu salario é de: " + salario + " e sua idade é de: " + idade + " anos!!");

            Console.ReadLine();
        }
    }
}
