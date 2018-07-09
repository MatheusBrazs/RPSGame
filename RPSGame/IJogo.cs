using System;
using System.Collections.Generic;

namespace RPSGame
{
    public interface IJogo
    {
        Tuple<string, string> ObterVencedor(IList<Tuple<string, string>> elementosJogo);
        Tuple<string, string> RpsGameWinner(IList<Tuple<string, string>> elementosJogo);
    }
}