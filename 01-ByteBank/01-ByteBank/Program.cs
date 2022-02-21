using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
       static void Main(string[] args)
       {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 86352;
            contaDaGabriela.saldo = 100;


            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: R$ " + contaDaGabriela.saldo + ",00");

            //ContaCorrente contaDoFernando = new ContaCorrente();

            //contaDoFernando.titular = "Fernando";
            //contaDoFernando.agencia = 863;
            //contaDoFernando.numero = 86353;
            //contaDoFernando.saldo = 1000;


            //Console.WriteLine(contaDoFernando.titular);


            Console.ReadLine();
        }
    }
}
