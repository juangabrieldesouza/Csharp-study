using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Praticas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("PROGRAMA PARA SABER QUAL NÚMERO É MAIOR");
            Console.WriteLine("---------------------------------------");
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.Write("O maior número é ");
                Console.WriteLine(num1);
                Console.Write("E o menor número é ");
                Console.WriteLine(num2);
            }
                else if (num1 == num2)

                {
                Console.WriteLine("Os números são iguais ");
                }
            else
            {
                Console.Write("O maior número é ");
                Console.WriteLine(num2);
                Console.Write("E o menor número é ");
                Console.WriteLine(num1);
            }
            Console.ReadLine();
         
        }
    }
}
