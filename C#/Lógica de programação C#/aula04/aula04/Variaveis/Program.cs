using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 10;

            Console.WriteLine(num1 + " > " + num2 + " = " + (num1 > num2));
            Console.WriteLine(num1 + " < " + num2 + " = " + (num1 < num2));
            Console.WriteLine(num1 + " = " + num2 + " = " + (num1 == num2));
            Console.WriteLine(num1 + " >= " + num2 + " = " + (num1 >= num2));
            Console.WriteLine(num1 + " <= " + num2 + " = " + (num1 <= num2));
            Console.WriteLine(num1 + " != " + num2 + " = " + (num1 != num2));
            Console.ReadKey();
        }
    }
}
