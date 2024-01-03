using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("PROGRAMA PARA TE RECEBER");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine($"Seja bem vindo {nome}, é um prazer te receber!");
        }
    }
}
