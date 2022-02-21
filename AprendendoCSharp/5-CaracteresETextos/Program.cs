using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 - Caracteres e Texto");


            char primeiraLetra = 'A';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Curso de Tecnologia " + 2022;
            Console.WriteLine(titulo);

            string cursos =
@"- .NET
- Java
- C#";
            
            Console.WriteLine(cursos); 

            Console.ReadLine();
        }
    }
}
