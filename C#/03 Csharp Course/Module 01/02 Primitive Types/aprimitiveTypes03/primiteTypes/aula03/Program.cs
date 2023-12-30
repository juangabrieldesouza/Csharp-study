using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sbyte = int - o sbyte é menor que o int
            //  em questão de armazenamento de dados
            // 8 bits, 16 bits, 32 bits, 64 bits, 128bits
            // 30.000 
            // 127




            //Console.WriteLine(5.0 / 2); //colocamos o ".0" para que assim mostra o decimal


            //Console.WriteLine("a minha idade é de " + idade); // exemplo de concatenação

            //Console.WriteLine($"A sua idade é de {idade} anos"); // exemplo de interpolação de strings


            //VARIAVEIS IMPLICITAS



            //var idade = 10;
            //var nome = "Juan";
            //var cidade = "Vg";
            //var temperatura = 34.5;

            string nome = "Juan";
            int temperatura = 34;

            nome = (string)temperatura;


            Console.ReadLine();
        }
    }
}
