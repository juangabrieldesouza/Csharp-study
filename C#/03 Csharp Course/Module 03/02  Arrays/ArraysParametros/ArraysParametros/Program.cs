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

            foreach (int i in numeros) //Array sendo exibida
            {
                Console.WriteLine(i);
            }


            int[] array2 = LerDados();

            foreach (int i in array2) Console.WriteLine(i);
        }

        static void ProcessaDados(int[] dados) //PARAMETRO QUE RECEBE ARRAY
        {
            for (int i = 0; i < 4; i++) //indice
            {
                dados[i] += 10; // somando + 10 em cada posição

            }
        }

        static int[] LerDados() // RECEBE VALORES E DEVOLVE ARRAY
        {

            Console.WriteLine("Quantos elementos você quer que o Array tenha?");

            int numeroArray = int.Parse(Console.ReadLine());

            int[] Elementos = new int[numeroArray]; 

            for(int i=0;i<Elementos.Length; i++)
            {
                Console.WriteLine($"Digite o valor da posição {i}: ");
                int resposta = int.Parse(Console.ReadLine());
                Elementos[i] = resposta;
            }

            return Elementos;
        }
    }
}
