using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade02Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = somaTotal(2, 3);
            double total2 = dividir(2, 3);

            Console.WriteLine(total);
            Console.WriteLine(total2);

        }
        static double dividir(double num1, int num2) => num1 / num2; //simplificação CLEAN CODE
        static double somaTotal(double num1, int num2) 
        {
            return num1 / num2;
        }/*OBS: o int opera com o double, 
        mas double nunca opera com um int, se por
        acaso quisermos operar valores double
        temos que tornar pelo menos um dos valores
        double e colocar o retorno do método no double */

    }
}
