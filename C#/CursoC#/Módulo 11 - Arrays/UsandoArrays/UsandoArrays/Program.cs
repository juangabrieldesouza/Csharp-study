using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UsandoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS

            /*int[] matriz1;

            matriz1 = new int[5];

            matriz1[0] = 1;
            matriz1[1] = 15;
            matriz1[2] = 2;
            matriz1[3] = 16;
            matriz1[4] = 3;
            

            int[] matriz1 = new int[5]{ 1, 15, 2, 16, 3};
             
            Console.WriteLine(matriz1[2]);
            */

            //-------------------------------------------------------


            // ARRAYS IMPLICITOS


            //var dados = new[] { "Juan", "Jóse", "Ana", 15 }; //da erro

            var valores = new[] {30, 30.5, 15, 40}; //tudo para double

            //-------------------------------------------------------------

            // ARRAYS OBJETOS

            Funcionarios[] lista1 = new Funcionarios[3];
            Funcionarios funcionario3039 = new Funcionarios("Ana", 37);

            
            lista1[0] = new Funcionarios("José", 37);
            
            lista1[1] = new Funcionarios("Maria", 19);     
                    
            lista1[2] = funcionario3039;

            


            //--------------------------------------------------------------

            // Arrays tipo ou classe anónima


            var Pessoas = new[]
            {
                new{Nome = "José", Idade = 23},
                new{Nome = "Juan", Idade = 19},
                new{Nome = "Carla", Idade = 54}


            };

            //------------------------------------------

            // BUCLE FOR - COM OBJETOS



            /*for(int i = 0; i<lista1.Length; i++)
            {
                Console.WriteLine(lista1[i].getExtras());

            }*/

            //---------------------------------------------

            // Bucle Foreach

            /*foreach (Funcionarios variavel in lista1)
            {
                Console.WriteLine(variavel.getInfoFUNC()); // herdou o objeto
            }*/

            /*foreach (var variavel in Pessoas)
            {
                Console.WriteLine(variavel);
            }*/


        }
    }

    class Funcionarios
    {
        public Funcionarios(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }


        public void setFUNC(string Nome, int Idade)
        {
            this.nome = Nome; //this demarca campo de classe

            this.idade = Idade;
        }

        public string getInfoFUNC()
        {
            return "Funcionários: \n" +$"Nome: {nome}" + $" Idade: {idade}\n";
        }



        int idade;
        string nome;
    }
}
