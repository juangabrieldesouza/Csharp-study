using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro Renault = new Carro(); //instanciando e dando um estado inicial
                                         //simultaneamente na declaração

            Carro Audi = new Carro(1.600, 1000, "2", true);

            

            Console.WriteLine(Audi.getInfoCarros());
        }
    }

    class Carro
    {
        public Carro()
        {
            Rodas = 4;

            Largura = 1600;

            Comprimento = 1000;


        }


        private int Rodas;
        private bool Climatizador;
        private double Largura;
        private double Comprimento;
        private string Tapecaria;
        public string status;

        public Carro(double lar, double com, string tap, bool clim)
        {
            Rodas = 4;

            if (lar < Largura) Largura = 1600; 
            
            else Largura = lar;

            if (com < Comprimento) Comprimento = 1000; 
                
            else Comprimento = com;

            

            if (clim == false)
            {

                Climatizador = false;
                status = "Não";

            }
            else if (clim == true) status = "Sim";


            
            switch (tap)
            {
                case "1":
                    tap = "Couro";
                    break;
                case "2":
                    tap = "Courvin";
                    break;
                case "3":
                    tap = "Taeres";
                    break;
                default:
                    tap = "Malha";
                    break;
            }
            Tapecaria = tap;         

        }
        public string getInfoCarros()
        {

            return "------------------------\n" + "Informações do Carro\n" + "------------------------\n" + "Rodas: 4\n" + $"Largura: {Largura}\n" + $"Comprimento: {Comprimento}\n" + $"Tapeçaria: {Tapecaria}\n" + $"Climatizador: {status}";  
        }


       
    }
}
