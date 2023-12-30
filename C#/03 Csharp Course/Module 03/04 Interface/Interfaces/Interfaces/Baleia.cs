using projetoHeranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Baleia : Mamiferos
    {
        public Baleia (string nomeBaleia) : base (nomeBaleia)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Sou capaz de nadar");
        }
    }
}
