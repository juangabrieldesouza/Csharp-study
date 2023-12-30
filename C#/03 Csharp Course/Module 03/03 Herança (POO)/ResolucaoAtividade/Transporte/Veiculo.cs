using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Veiculo
    {
        public void ArrancarMotor(string somDoArranque)
        {
            Console.WriteLine($"Arranca o motor: {somDoArranque}");
        }

        public void PararMotor(string somAoParar) 
        {
            Console.WriteLine($"Parando o motor: {somAoParar}");
        }

        public virtual void Conducao()
        {
            Console.WriteLine("Condução padrão");
        }
    }
}
