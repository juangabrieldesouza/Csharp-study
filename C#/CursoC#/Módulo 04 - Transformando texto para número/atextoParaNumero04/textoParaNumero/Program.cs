using System;
namespace textoParaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PARA TRANSFORMAR UM TEXTO EM VALOR USAMOS " int num1 = int.Parse(Console.ReadLine); "

            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine("--------------------");
            Console.WriteLine($"A soma de {num1} com {num2} é igual a {soma}" );

            Console.WriteLine();
        }
    }
}
