using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario F001 = new Funcionario(1200, 100);

            F001.NovoSalario(F001, 200);

            Console.WriteLine(F001);
        }
    }

    public struct Funcionario
    {

        public double salarioBase, comissao;

        public Funcionario(int salarioBase, int comissao)
        {
            this.salarioBase = salarioBase;

            this.comissao = comissao;

        }

        public override string ToString()
        {
            return string.Format("Salario e comissão do funcionário ({0},{1})", this.salarioBase, this.comissao);
        }

        public void NovoSalario(Funcionario func, int adicional)
        {
            func.salarioBase += adicional;

            func.comissao += adicional;
        }
    }
}
