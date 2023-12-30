using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o seu meio de transporte (avião, trem, carro)");

            string meioDeTransporte = Console.ReadLine();

            switch(meioDeTransporte)
            {
                case "avião":
                    Console.WriteLine("Você escolheu avião!");
                    break;
                case "trem":
                    Console.WriteLine("Muito bem, você escolheu trem!");
                    break;
                case "carro":
                    Console.WriteLine("Legal, você vai de carro!");
                    break;
                default:
                    Console.WriteLine("Esse meio de transporte não está permitido!");
                    break;
            }


        }
    }
}
