using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Carro();
            Veiculo aviao = new Aviao();
            Carro ford = new Carro();
            Aviao militar = new Aviao();

            carro.setMotor("Carro Motor: Arrancada");
            aviao.setMotor("Avião Motor: Iniciada");
            ford.setMotor("Carro, Ford Motor: Turbo");
            militar.setMotor("Avião, Militar: Super Sonico");


            Veiculo[] veiculos = new Veiculo[4];
            veiculos[0] = carro;
            veiculos[1] = aviao;
            veiculos[2] = ford;
            veiculos[3] = militar;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Informação dos Meios de Transporte");
            

            for (int i = 0; i < veiculos.Length; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(veiculos[i].getInfoMotor());
                veiculos[i].Conducao();
            }

            Console.WriteLine("-----------------------------------");

        }

        
 
    }
    class Veiculo
    {

        public void setMotor(string motor)
        {
            this.motor = motor;
        }

        

        public string getInfoMotor()
        {
            return $"STATUS - {motor}";
        }
        
        private string motor;

        public virtual void Conducao()
        {
            Console.WriteLine("Modo de condução operante!");

        }
    }

    class Aviao:Veiculo
    {
        public override void Conducao()
        {
            Console.WriteLine("Condução de tráfego aeroespacial");

        }

    }

    class Carro:Veiculo
    {
        public override void Conducao()
        {
            Console.WriteLine("Condução de tráfego terreno");
        }
    }



}

