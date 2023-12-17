using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionGeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int numeroAleatorio = numero.Next(0, 100);
            int contador = 1;
            int numeroconta = 0;

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
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido! O valor inserido se igualou a 0!");
                    Console.WriteLine(e.Message);
                }
                /*catch (Exception ex) //A exceção geral compatibiliza com to erro porém é imprecisa
                                     //Logo não tem como informar qual foi o erro para o usuario
                {
                    Console.WriteLine("Número inserido inválido! O número inserido se igualou a 0!");
                }
                /*catch (Exception e) -> com esse comando nós podemos exibir o erro no console, porém  fica muito tecnico
                {
                    Console.WriteLine(e.Message);
                                                
                }*/


                contador++;

                if (numeroconta == numeroAleatorio) { Console.WriteLine("Acertou!"); Console.WriteLine($"Número de tentativas: {contador}"); }

            } while (numeroconta != numeroAleatorio);


            Console.WriteLine("Fim do jogo!");
        }
    }
}
