using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaDeUmCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Programa para medir a área de um círculo");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite o diametro desse círculo: ");
            double diametro = double.Parse(Console.ReadLine());

            double raio = diametro / 2;

            double total = Math.Pow(raio, 2) * PI;

            Console.WriteLine("---------------------");
            Console.WriteLine("O resultado é {0}", total);




        }
    }
}
