using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticas5Enum_Switch
{
    internal class Program
    {
        enum opcao { criar = 1, editar, atualizar, Deletar }
        static void Main(string[] args)
        {


            Console.WriteLine("Slecione uma opção: ");
            Console.WriteLine("1-CRIAR\n2-EDITAR\n3-ATUALIZAR\n4-DELETAR");
            int index = int.Parse(Console.ReadLine());
            opcao opcaoSelecionada = (opcao)index;

            switch (opcaoSelecionada)
            {
                case opcao.criar:
                    Console.WriteLine("Você quer criar algo");
                    break;
                case opcao.editar:
                    Console.WriteLine("Você quer fazer uma edição");
                    break;
                case opcao.atualizar:
                    Console.WriteLine("Tem certeza que quer fazer uma atualização?");
                    break;
                case opcao.Deletar:
                    Console.WriteLine("ATENÇÃO: tem certeza que deseja excluir?");
                    break;
                default:
                    Console.WriteLine("ERROR: opção demarcada não encontrada!");
                    break;

            }
                    



            Console.ReadLine();
        }
    }
}
