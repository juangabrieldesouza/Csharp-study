using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            numeros[0] = 1;
            numeros[1] = 15;
            numeros[2] = 20;
            numeros[3] = 17;

            ProcessaDados(numeros); // método recebendo array

            foreach(int i in numeros) //Array sendo exibida
            {
                Console.WriteLine(i);
            }
        }

        static void ProcessaDados(int[] dados)
        {
            for(int i=0;i<4; i++) //indice
            {
                dados[i] += 10; // somando + 10 em cada posição

            }
        }
    }
}
