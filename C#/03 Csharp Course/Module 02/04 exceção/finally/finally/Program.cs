using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @finally
{
    internal class Program
    {
        static void Main(string[] args)
        {


            System.IO.StreamReader arquivo = null;

            try
            {
                string linha;

                int contador = 0;

                string path = @"D:\Documentos\Área de Trabalho\algo.txt";

                arquivo = new System.IO.StreamReader(path);

                while((linha = arquivo.ReadLine()) != null) {

                    Console.WriteLine(linha);

                    contador++;


                }


            } 
            catch (Exception e)
            {

                Console.WriteLine("Erro com a leitura do arquivo");

            }
            finally
            {
                if(arquivo != null)arquivo.Close();

                    Console.WriteLine("Recurso desligado!");
                
            }


        }
    }
}
