using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Carro: Veiculo
    {

        public void Acelerar()
        {

            Console.WriteLine("Acelerando");

        }

        public void Freio()
        {

            Console.WriteLine("Freiando");
        }

        public override void Conducao()
        {
            Console.WriteLine("Condução: direção carro");
        }

    }
}
