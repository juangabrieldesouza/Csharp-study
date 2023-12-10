using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.WriteLine("Programa para saber o nome do usuario!");
            Console.WriteLine("Olá, qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome + ", Seja bem vindo!");
            Console.ReadKey();
        }
    }
}
