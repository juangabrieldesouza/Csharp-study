using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Você quer entrar no bucle while?");
            string resposta = Console.ReadLine();

            while(resposta != "não")
            {
                Console.WriteLine("Você está dentro do bucle!");

                Console.WriteLine("enquanto responder (não), você não sairá do bucle");

                Console.WriteLine("Você quer sair do bucle?");

                resposta = Console.ReadLine();

            }

        }
    }
}
