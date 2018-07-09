using System;
using System.Collections.Generic;

namespace RPSGame
{
    public interface IChaveamentoTorneio
    {
        List<List<Tuple<string, string>>> GerarNovaChave(List<Tuple<string, string>> vencedoresChaveInterna);
        Tuple<string, string> ObterVencedorChave(List<List<Tuple<string, string>>> chave);
    }
}