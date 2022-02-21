using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            //int quantidadePessoas = 2;

            bool quantidadePessoas = true;

            //Usando o operador &&(AND) só é satisfeito se as 2 condições forem verdadeiras
            if (idadeJoao >= 18 && quantidadePessoas == true)
            {
                Console.WriteLine("Pode passar");
            }
            else
            {    
                    Console.WriteLine("Nao pode entrar!!"); 
            }

            //Usando operador ||(OR) ja é satisfeito com apenas 1 das condições sendo verdadeiras
            if (idadeJoao >= 18 && quantidadePessoas == true)
            {
                Console.WriteLine("Pode passar");
            }
            else
            {
                Console.WriteLine("Nao pode entrar!!");
            }


            Console.ReadLine();
        }
    }
}
