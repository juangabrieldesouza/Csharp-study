using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasCondicionaisIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carteira;
            int idade;
            Console.WriteLine("------------------");
            Console.WriteLine("Prova de condução");
            Console.WriteLine("------------------");

            Console.Write("Insira sua idade: ");
            idade = Int32.Parse(Console.ReadLine());


            if (idade < 18) { Console.WriteLine("Você ainda não pode conducir!"); }
            else
            {
                Console.WriteLine("Você tem carteira de motorista?"); carteira = Console.ReadLine();


                if (carteira == "sim") { Console.WriteLine("Você pode conducir!!"); }

                else Console.WriteLine("Você não pode conducir!!");
            }

        }
            

    }
}
