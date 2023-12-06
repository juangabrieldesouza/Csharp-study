using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica4
{
    internal class Program
    {

        enum carro { celta, ferrari, corsa, malta }
        static void Main(string[] args)
        {
        

        carro carroFavorito = carro.celta;
        carro carroDoChefe = carro.ferrari;

        Console.WriteLine(carroFavorito);
            Console.WriteLine((int)carroFavorito);
        Console.WriteLine((carro)2);



            Console.ReadLine();
        }
    }
}
