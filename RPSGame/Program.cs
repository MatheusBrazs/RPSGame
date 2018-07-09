using System;
using System.Collections.Generic;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementosJogo = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Armando", "P"),
                new Tuple<string, string>("Dave", "S")
            };

            var vencedor = new Jogo().RpsGameWinner(elementosJogo);
            GerarResultado(vencedor, "Rock-Paper-Scissors");

            var chavesTorneio = new List<List<List<Tuple<string, string>>>>
            {
                new List<List<Tuple<string,string>>>
                {
                    new List<Tuple<string,string>>
                    {
                        new Tuple<string, string>("Armando", "P"),
                        new Tuple<string, string>("Dave", "S")
                    },
                    new List<Tuple<string,string>>
                    {
                        new Tuple<string, string>("Richard", "R"),
                        new Tuple<string, string>("Michael", "S")
                    },
                },
                new List<List<Tuple<string,string>>>
                {
                    new List<Tuple<string,string>>
                    {
                        new Tuple<string, string>("Allen", "S"),
                        new Tuple<string, string>("Omer", "P")
                    },
                    new List<Tuple<string,string>>
                    {
                        new Tuple<string, string>("David E.", "R"),
                        new Tuple<string, string>("Richard X.", "P")
                    }
                }
            };

            vencedor = new Torneio().RpsTournamentWinner(chavesTorneio);
            GerarResultado(vencedor, "Rock-Paper-Scissors Tournament");
        }

        private static void GerarResultado(Tuple<string, string> vencedor, string titulo)
        {
            Console.WriteLine(titulo);
            Console.WriteLine($"Vencedor:[\"{vencedor.Item1}\", \"{vencedor.Item2}\"]");
            Console.ReadLine();
        }
    }
}
