using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string cor = "Azul";

                switch(cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é o Vermelho!");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é o Amarelo!");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é o Azul!");
                    break;
                default:
                    Console.WriteLine("Sem cor kapakapa!");
                    break;
            }
                








            string produto1 = "Minecraft";
            string produto2 = "Counter Strike";
            string produto3 = "Dark souls";
            string produto4 = "Portal";

            string[] produtos = new string[5]{
                "Minecraft",
                "FIFA",
                "Dark Souls",
                "Portal",
                "FNAF"

            };

            produtos[1] = "FIFA 2023";

            Console.WriteLine(produtos[1]);


            Console.ReadLine();



        }
        static string Pedalar(string a, string b)
        {
            return a + b;
        }
    }
}
