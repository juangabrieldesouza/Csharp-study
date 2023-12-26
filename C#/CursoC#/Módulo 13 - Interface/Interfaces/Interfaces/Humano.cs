using projetoHeranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Humano : Mamiferos
    {

        public Humano(string nomeHumano) : base(nomeHumano)
        {


        }

        public override void Pensar()
        {
            Console.WriteLine("Pensamento racional");
        }


    }
}
