using projetoHeranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Cavalo : Mamiferos, IMamiferosTerrestres, IAnimaisEsportes
    {
        public Cavalo(string nomeCavalo) : base(nomeCavalo)
        {

        }

        public string TipoEsporte()
        {
            return "Cavaleria";
        }

        public bool Olimpico()
        {
            return true;
        }

        public int NumeroPatas()
        {
            return 4;
        }
    }
}
