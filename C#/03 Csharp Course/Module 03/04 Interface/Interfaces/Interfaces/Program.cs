using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Baleia baleia = new Baleia("Filha do sirigueijo");
            Cavalo MeuCavalo = new Cavalo("Pé de pano");

            IAnimaisEsportes ICavalo = MeuCavalo;

            IMamiferosTerrestres ICavalo2 = MeuCavalo; 

            Console.WriteLine("Quantidade de patas para o pé de pano dar o salto: "+MeuCavalo.NumeroPatas());

            baleia.Nadar();


        }
    }

interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }

interface IAnimaisEsportes
    {
        string TipoEsporte();

        bool Olimpico();
    }

interface ISaltoComPatas
    {
        int NumeroPatas();
    }


    class Mamiferos
    {

        public Mamiferos(string nome)
        {
            NomeSerVivo = nome;
        }

        public void Respirar()
        {

            Console.WriteLine("Estou respirando!");
        }

        public void GetNome()
        {

            Console.WriteLine($"O nome do ser vivo é: {NomeSerVivo}");
        }

        public virtual void CuidarFilhotes()
        {
            Console.WriteLine("cuida de seus filhotes");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pesamento animal instintivo");
        }

        private string NomeSerVivo;

    }




   

    

    

    class Baleia : Mamiferos
    {
        public Baleia(string nomeBaleia) : base(nomeBaleia)
        {


        }

        public void Nadar()
        {

            Console.WriteLine("Estou nadando");
        }

    }
}
