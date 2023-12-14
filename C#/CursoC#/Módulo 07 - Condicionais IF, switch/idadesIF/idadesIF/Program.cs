using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idadesIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a sua idade: ");
            int idade = Int32.Parse(Console.ReadLine());

            if (idade < 18) Console.WriteLine("Você é uma criança");

            else if (idade < 30) Console.WriteLine("Você é jovem");

            else if (idade < 60) Console.WriteLine("Você é um idoso");

            else Console.WriteLine("Se cuida!");


        }
    }
}
