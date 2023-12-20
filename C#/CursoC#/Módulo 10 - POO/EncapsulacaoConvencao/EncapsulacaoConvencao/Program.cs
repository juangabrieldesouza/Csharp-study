using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulacaoConvencao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Real conversao = new Real();

            conversao.Alteração(4.50);

            Console.WriteLine(conversao.Quantidade(70));



        }
    }
    class Media
    {
        const double mediaBase = 2; //Propriedade da Classe. suas caracteristicas. Campo de Classe.

        public double calculoMedia(int nota1, int nota2) //comportamento do método - calculoMedia - ou função
        {
            return ((nota1 + nota2) / mediaBase);
        }

        public void calculoDeTamanho()
        {
            string leitura = "Digite a sua altura em centímetros";
            Console.WriteLine(leitura);
            double altura = int.Parse(Console.ReadLine());
            Console.WriteLine("A sua altura é: " + altura / 100 + "m");
        }

    }

    class Real
    {
        private double real = 5.20;

        public double Quantidade(int quantidade)
        {
            return real * quantidade;
        }

        public void Alteração(double alt)
        {
            if (alt < 0) real = 5.20;

             else real = alt;

        }


    }
}

