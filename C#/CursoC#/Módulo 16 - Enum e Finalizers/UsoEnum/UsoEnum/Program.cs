using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoEnum
{ 

    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario F001 = new Funcionario(Bonus.medio, 1500);


            Console.WriteLine("O salario do funcionário é: "+ F001.getSalarioFuncionario());

        }

        class Funcionario
        {
            public Funcionario(Bonus Funcionario, double salario)
            {
                double BonusFunc = (double)Funcionario; //CASTING

                this.salario = salario;

                this.bonus = BonusFunc;
            }

            public double getSalarioFuncionario()
            {

                return salario + bonus;
            }

            private double bonus, salario;
        }
    }

    enum Bonus {basico = 500, medio = 1500, pro = 3000 };
}
