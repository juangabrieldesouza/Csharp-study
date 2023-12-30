using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();

            av1.MostrarAvisos();

            AvisosTrafico av2 = new AvisosTrafico("Ayuntamiento", "Cine Yelmo", "02-03-2023");

            av2.MostrarAvisos();
        }
    }
}
