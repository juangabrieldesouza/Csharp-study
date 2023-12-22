using System;


namespace conceitosPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //executarTarefa();
            var barcelona = new { jogador1 = "ronaldinho", jogador2 = "Kaca", idade1 = 26, idade2 = 31 };

            Console.WriteLine(barcelona.jogador1 + " " + barcelona.idade1);

            Console.WriteLine(barcelona.jogador2 +" " +barcelona.idade2);

        }

        static void executarTarefa()
        {
            Ponto origem = new Ponto();

            Ponto destino = new Ponto(12, -7);


            double distancia = origem.DistanciaPontos(destino);

            Console.WriteLine($"A distancia entre os pontos é: {distancia}");

            Console.WriteLine($"Número de objetos criados: {Ponto.ContadorDeObjetos()}");
        }

        
        
    }
}
