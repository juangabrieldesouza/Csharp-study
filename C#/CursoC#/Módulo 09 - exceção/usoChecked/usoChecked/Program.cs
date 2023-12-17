using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoChecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.MaxValue;

            int resultado = checked(num + 20); //checked/unchecked especifico
                                               // só funcionam para int e long 
                                               /* unchecked funciona se as propriedades de overflow
                                               do programa estiverem atividas*/

            Console.WriteLine(resultado);

        }
    }
}
