using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pratica2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string historia1 = persona("joao", "Belém", "Morador de rua");

            Console.WriteLine(historia1);

            Ideia();


            Console.ReadLine();
        }
        static void Ideia()
        {
            Console.WriteLine("Preciso arrumar a minha mesa");
            Console.WriteLine("Louvado seja Deus");
            Console.WriteLine("Preciso arrumar um laptop kkkk");
        }


        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int ValorFinal = 3 * precoAbs; 
            Console.WriteLine("O preço é: " + ValorFinal);
        }
        static string persona(string nome, string cidade, string historia) 
        {

            string identidade = ("Este é " + nome + ", Mora em " + cidade + ", e ele já foi um " + historia);
            return identidade;
        }
    }
}
