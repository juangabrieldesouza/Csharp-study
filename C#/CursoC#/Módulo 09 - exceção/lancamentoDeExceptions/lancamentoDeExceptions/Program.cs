using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancamentoDeExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lANÇAMENTE DE EXCEÇÕES ABAIXO 
            try
            {

                Console.Write("Digite um nº de mês: ");
                int mes = int.Parse(Console.ReadLine());
                Console.WriteLine(meses(mes));
            }
            catch (Exception e)
            {
                Console.WriteLine("mês inválido");
                Console.WriteLine(e.Message);

            }
            Console.WriteLine("");
            Console.WriteLine("Programa continua normal");
        }

        public static string meses(int mes)
        {

            switch(mes) {
                case 1:
                    return "Janeiro";
                case 2:
                    return "Fevereiro";
                case 3:
                    return "Março";
                case 4:
                    return "Abril";
                case 5:
                    return "Maio";
                case 6:
                    return "Junho";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Setembro";
                case 10:
                    return "Outubro";
                case 11:
                    return "Novembro";
                case 12:
                    return "Dezembro";
                default:
                    throw new ArgumentOutOfRangeException(); // <---- LANÇAMENTO DE EXEÇÕES

            }

        }
    }
}
