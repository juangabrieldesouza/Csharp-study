using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Soma dos números");
            Console.WriteLine("-----------------");
            somaDosNumeros("Que conta legal!", "Tente outra!",5,10);
        }
        static void somaDosNumeros(string dialogo1, string dialogo2, int num1, int num2)
        {
            Console.WriteLine($"O resultado é: {num1}+{num2}");
            Console.WriteLine(dialogo2);
            Console.WriteLine(dialogo1);
        }
    }
}
