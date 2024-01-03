using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("FUNCIONÁRIOS STATUS");
            Console.WriteLine("--------------------------");
            Console.Write("Insira o nome do funcionário: ");
            string nameEmployee= Console.ReadLine();
            Console.Write("Insira o sálario do funcionário: ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Nome do Funcionário: "+nameEmployee);
            Console.WriteLine("Salário: "+salary+"R$");
            Console.WriteLine($"O nome do funcionário é {nameEmployee}, e seu salário é de {salary}R$ para se receber em fevereiro");
        }
    }
}
