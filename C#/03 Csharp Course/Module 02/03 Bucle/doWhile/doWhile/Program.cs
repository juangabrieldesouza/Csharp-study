using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int numeroAleatorio = numero.Next(0, 100);
            int contador = 1;
            int numeroconta=-1;

            try
            {
                Console.WriteLine("advinhe o número de 0 a 100");
                numeroconta = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Número inserido inválido");
            }

            do
            {

                if (numeroconta < numeroAleatorio) Console.WriteLine("O número oculto é maior, tente denovo!");

                else if (numeroconta > numeroAleatorio) Console.WriteLine("O número o culto é menor tente denovo!");
                try
                {
                    Console.WriteLine("Tente de novo: ");

                    numeroconta = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Número inserido inválido!");
                }

                contador++;

                if (numeroconta == numeroAleatorio) { Console.WriteLine("Acertou!"); Console.WriteLine($"Número de tentativas: {contador}"); }

            } while (numeroconta != numeroAleatorio);


            Console.WriteLine("Fim del programa!");


        }
    }
}
