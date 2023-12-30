using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade03
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine(conta(4,4));


        }

        static double conta(double v1, int v2, int v3=0)
        {
            return v1 + v2 + v3;
        }
        static double conta(double v1, int v2) => v1 + v2; // retorna pelo número de parametros
                                                           // apesar que não estaria errado se
                                                           // escolhesse o primeiro método, porém
                                                           // tem que levar em conta a especificação


        //sobrecarga, se diferencia com a quantidade ou tipo para os métodos

    }
}
