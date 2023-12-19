using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooClassesEInstancias
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Media minhaMedia; //Variavel do tipo Media, crianção de variavel/objeto
                                             //é como se fosse uma variavel qualquer, igual o int
                                            // porém o tipo Media, tem sua propria individualidade e função



            minhaMedia = new Media(); //iniciação de variavel/objeto de "tipo Media". Instancia de Classe
            //Exemplarização de classe. classe exemplar. intanciar 


            Console.WriteLine(minhaMedia.calculoMedia(5, 7));

            Media mediaDoJoao = new Media();

            mediaDoJoao.calculoDeTamanho(); 
        }
    }
    class Media
    {
        const double mediaBase = 2; //Propriedade da Classe. suas caracteristicas. Campo de Classe.

        public double calculoMedia(int nota1, int nota2) //comportamento do método - calculoMedia - ou função
        {
            return ((nota1+nota2)/mediaBase); 
        }

        public void calculoDeTamanho()
        {
            string leitura = "Digite a sua altura em centímetros";
            Console.WriteLine(leitura);
            double altura = int.Parse(Console.ReadLine());
            Console.WriteLine("A sua altura é: " + altura / 100 + "m");
        }

    }

        
}
