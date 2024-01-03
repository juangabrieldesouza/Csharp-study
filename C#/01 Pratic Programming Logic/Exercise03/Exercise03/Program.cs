using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("SOMA DE DOIS NÚMEROS");
            Console.WriteLine("-----------------------");
            Console.Write("Insira o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.WriteLine("A soma dos dois números é "+(num1+num2));
        }
    }
}