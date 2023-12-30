using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Aviao: Veiculo
    {

        public void Aterrissar()
        {
            Console.WriteLine("Aterrissando");
        }

        public void Decolar()
        {

            Console.WriteLine("Decolando");

        }
        public override void Conducao()
        {
            Console.WriteLine("Condução: modo avião");
        }

        
    }
}
