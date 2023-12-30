using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoFinalizers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class ControladorArquivos
    {
        StreamReader arquivo = null;

        int linha = 0;

        string leitor;

        public ControladorArquivos()
        {
            arquivo = new StreamReader(@"D:\texto.txt");

            while ((leitor = Console.ReadLine()) != null)
            {

                Console.WriteLine(leitor);

                linha++;

            }

        }

        public void Mensagem()
        {
            Console.WriteLine("Tem {0} linhas", linha);
        }


        ~ControladorArquivos()
        {

            arquivo.Close();

        }
    }
}
