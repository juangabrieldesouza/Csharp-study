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

            Gorila gorila = new Gorila("Pai do tarzan");

            Cavalo cavalo = new Cavalo("Pé de pano");

            Humano humano = new Humano("Juan");

            Mamiferos Animal = new Gorila("gogoda");

            Repteis reptil1 = new Repteis("Cobra");


            humano.GetNome();

            reptil1.GetNome();



        }
    }

    abstract class Animais
    {
        public void Respirar()
        {
            Console.WriteLine("Estou respirando!");
        }

        public abstract void GetNome();
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }


    class Repteis : Animais
    {
        public Repteis(string nomeReptil)
        {
            this.nomeReptil = nomeReptil;

        }


        public override void GetNome()
        {
            Console.WriteLine($"O nome do reptil é: {nomeReptil}");
        }


        private string nomeReptil;
    }



    class Mamiferos : Animais
    {

        public Mamiferos(string nome)
        {
            NomeSerVivo = nome;
        }


        public override void GetNome()
        {

            Console.WriteLine($"O nome do Mamífero é: {NomeSerVivo}");
        }

        public virtual void Andar()
        {
            Console.WriteLine("eu ando");
        }

        private string NomeSerVivo;

    }




    class Cavalo : Mamiferos, IMamiferosTerrestres
    {

        public Cavalo(string nomeCavalo) : base(nomeCavalo)
        {

        }

        public override void Andar()
        {

            Console.WriteLine("Sou capaz de trotar como cavalo");

        }

        public int NumeroPatas()
        {
            return 4;
        }

    }

    class Humano : Mamiferos
    {

        public Humano(string nomeHumano) : base(nomeHumano)
        {


        }

        public override void Andar()
        {

            Console.WriteLine("Eu ando em duas pernas");
        }


    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {

        public Gorila(string nomeGorila) : base(nomeGorila)
        {


        }


        public void Agarrar()
        {

            Console.WriteLine("Sou capaz de escalar arvores");
        }

        public int NumeroPatas()
        {
            return 2;
        }
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
