using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticasMetodos06
{
    internal class Program
    {

        static void Main(string[] args)
        {
            mensagemNoConsole();  /* pra chamar um método só temos que escrever o seu nome
            chamada                 porém neste momento do curso temos que ter em conta que o 
           para o método            método main e o método "mensagemNoConsole" tem que ser static
                                    mais pra frente entenderemos o porque disso...
                                   */
            Console.WriteLine("Aopa baum?");
            /* observe também a ordem, o método "mensagemNoConsole" 
             * é executado primeiro, pois a ordem de
             execução é de cima pra baixa, mesmo que 
            estamos dentro do método principal, 
            ele vai executar o que está sendo pedido primeiro...
            */
        }


        static void mensagemNoConsole() // tudo que está dentro do método, será executado se chamada na main
        {
            Console.WriteLine("Mensagem no console confirmada");
            int nome = 1;
            int nome2 = 3;
            int nome3 = nome + nome2;
            Console.WriteLine(nome3);
        }
    }
}
