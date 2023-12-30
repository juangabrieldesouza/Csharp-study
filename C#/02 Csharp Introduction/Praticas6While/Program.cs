using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticas6While
{
    internal class Program

    {


        static string nome = "Juan Gabriel de Souza";
  
        static void Main(string[] args)
        {



            Console.WriteLine(nome);
            msg();

            //foreach
            string[] nomes = { "Ola pequeno aventureiro!", "eu gostaria de te apresentar a cidade, porém...", "Antes, precisamos salva-la", "Vem comigo!"};



            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }


            int caramba = 0;

            //while (caramba == 100)
            
                Console.WriteLine(caramba);
                caramba = caramba + 2;

            


            Console.ReadLine();

        }


        static void msg()
        {
            Console.WriteLine(nome);
        }
    }
}
