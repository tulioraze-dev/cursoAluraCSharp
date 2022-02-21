using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7");

            int idadeJoao = 16;
            int quantidadePessoas = 2;


            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade, pode passar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João é menor de idade, Mas está acompanhado pode entrar");
                }
                else
                {
                    Console.WriteLine("Joao é menor de idade, nao pode entrar!!");
                }
            }


            Console.ReadLine();
        }
    }
}
