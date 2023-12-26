using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provando avião");

            Aviao MeuAviao = new Aviao();

            MeuAviao.ArrancarMotor("DRUUUUUUUUUM");
            MeuAviao.Decolar();
            MeuAviao.Conducao();
            MeuAviao.Aterrissar();
            MeuAviao.PararMotor("suuuur\n");

            

            Carro MeuCarro = new Carro();
            MeuCarro.ArrancarMotor("SDRUVRUUUUM");
            MeuCarro.Acelerar();
            MeuCarro.Conducao();
            MeuCarro.Freio();
            MeuCarro.PararMotor("DRIIIH");





        }
    }
}
