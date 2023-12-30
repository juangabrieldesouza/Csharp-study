using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro Audi = new Carro();

            Carro Renault = new Carro(4500.34, 1100.85);

            Console.WriteLine(Audi.getInfoCarro());
            Console.WriteLine();
            Console.WriteLine(Renault.getInfoCarro());
            Console.WriteLine();

            Renault.setExtras(true, "Couro");

            Console.WriteLine(Renault.getExtras());
        }
    }

    partial class Carro
    {
        public Carro()
        {
            rodas = 4;

            largura = 1600;

            comprimento = 1000;

            tapecaria = "Malha";
        }

        public Carro(double lar, double com)
        {
            rodas = 4;

            largura = lar;

            comprimento = com;

            tapecaria = "Malha";
        }
    }
     
    partial class Carro {
        public string getInfoCarro()
        {

            return "Informação do carro\n" + $"Rodas: {rodas}\n" + $"Comprimento: {comprimento}\n" + $"Largura: {largura}";
        }


        public void setExtras (bool climatizador, string tapecaria)
        {
            this.climatizador = climatizador; //this demarca campo de classe

            this.tapecaria = tapecaria;
        }

        public string getExtras()
        {
            return "Extras do Carro;\n" + $"Tapeçaria: {tapecaria}\n" + $"Climatizador: {climatizador}"; 
        }


        private int rodas;
        private bool climatizador;
        private double largura;
        private double comprimento;
        private string tapecaria;
    }
}
