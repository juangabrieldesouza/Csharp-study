using projetoHeranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Gorila : Mamiferos, IMamiferosTerrestres
    {

        public Gorila(string nomeGorila) : base(nomeGorila)
        {

        }  

        public void Agarrar()
        {

            Console.WriteLine("Sou capaz de escalar arvores");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }
}
