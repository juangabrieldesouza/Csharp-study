using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario F001 = new Funcionario("Juan");

            F001.SALARIO = 1200;

            Console.WriteLine("O salario do funcionario é: "+F001.SALARIO);


        }
    }

    class Funcionario
    {
        public Funcionario (String nome)
        {
            this.nome = nome;

        }

        /*public void SetSalario(double salario)
        {


            if (salario < 0)
            {
                Console.WriteLine("O salario não pode ser negativo. O sálario foi registrado como 0");

                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }

        }

        public double GetSalario()
        {
            return salario;
        }*/



        //MÉTODO DE COMPORTAMENTO DA PROPRIEDADE

        private double ConfereSalario(double salario)
        {

            if (salario < 0) return 0;

            else return salario;

        }
//---------------------------------------
        //CRIAÇÃO DA PROPRIEDADE

       /* public double SALARIO
        {
            get { return this.salario; }

            set { this.salario = ConfereSalario(value); }

        }*/
//---------------------------------------


        //SIMPLIFICAÇÃO - Lambda

        public double SALARIO
        {
            get => this.salario;

            set => this.salario = ConfereSalario(value);
        }

        private string nome;

        private double salario;

       
    }
}
