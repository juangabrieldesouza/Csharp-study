using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            executarTarefa();
                    
        }

        static void executarTarefa()
        {
            Ponto origem = new Ponto();

            Ponto destino = new Ponto(12, -7);


            double distancia = origem.DistanciaPontos(destino);

            Console.WriteLine($"A distancia entre os pontos é: {distancia}");
        }

        
        
    }
}
