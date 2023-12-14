using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeNumeroAleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random numero = new Random();

            int numeroAleatorio = numero.Next(0,100);
            int contador = 2;
            int numeroconta;

            Console.WriteLine("advinhe o número de 0 a 100");
            numeroconta = Int32.Parse(Console.ReadLine());

            while (numeroconta != numeroAleatorio)
            {
                
                if (numeroconta < numeroAleatorio) Console.WriteLine("O número oculto é maior, tente denovo!");

                else if (numeroconta > numeroAleatorio) Console.WriteLine("O número o culto é menor tente denovo!");

                Console.WriteLine("Tente de novo: ");
                
                numeroconta = Int32.Parse(Console.ReadLine());
                
                if (numeroconta == numeroAleatorio) { Console.WriteLine("Acertou!"); Console.WriteLine($"Número de tentativas: "+ contador); }

                contador++;




            }
            Console.ReadLine();
        }
    }
}
