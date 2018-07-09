using System;
using System.Collections.Generic;
using System.Linq;

namespace RPSGame
{
    public class Torneio
    {
        private readonly IChaveamentoTorneio _chaveamentoTorneio;

        public Torneio()
        {
            _chaveamentoTorneio = new ChaveamentoTorneio();
        }

        public Tuple<string,string> RpsTournamentWinner(List<List<List<Tuple<string, string>>>> chavesTorneio)
        {
            var vencedores = new List<Tuple<string,string>>();

            foreach (var chave in chavesTorneio)
                vencedores.Add(_chaveamentoTorneio.ObterVencedorChave(chave));

            if (vencedores.Count > 1)
            {
                var novaChave = _chaveamentoTorneio.GerarNovaChave(vencedores);
                return _chaveamentoTorneio.ObterVencedorChave(novaChave);
            }

            return vencedores.First();
        }
    }
}
