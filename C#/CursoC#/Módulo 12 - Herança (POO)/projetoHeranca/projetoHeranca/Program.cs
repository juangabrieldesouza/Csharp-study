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


            Mamiferos animal = new Gorila("gogoda");

            gorila.Andar();

            humano.Andar();

            cavalo.Andar();

        }
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

        public void getNome()
        {

            Console.WriteLine($"O nome do ser vivo é: {NomeSerVivo}");
        }

        public virtual void Andar()
        {
            Console.WriteLine("eu ando");
        }

        private string NomeSerVivo;      
               
    }

    class Cavalo : Mamiferos
    {

        public Cavalo(string nomeCavalo) : base(nomeCavalo)
        {

        }

        public void Andar()
        {

            Console.WriteLine("Sou capaz de trotar como cavalo");

        }

    }

    class Humano : Mamiferos
    {

        public Humano(string nomeHumano): base(nomeHumano)
        {


        }

        public void Andar()
        {

            Console.WriteLine("Eu ando em duas pernas");
        }
    }
    
    class Gorila : Mamiferos
    {

        public Gorila(string nomeGorila) : base(nomeGorila)
        {


        }


        public void agarrar()
        {

            Console.WriteLine("Sou capaz de escalar arvores");
        }
    }
}
