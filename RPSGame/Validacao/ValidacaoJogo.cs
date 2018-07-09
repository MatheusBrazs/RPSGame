using RockPaperScissors.Bll.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPSGame.Validacao
{
    public class ValidacaoJogo : IValidacaoJogo
    {
        public void Validar(IList<Tuple<string, string>> elementosJogo)
        {
            if (elementosJogo.Count != 2)
                throw new WrongNumberOfPlayersError("Número de jogadores deve ser 2!");

            var movimentos = new List<string> { "S", "P", "R" };
            if (elementosJogo.Select(e => e.Item2).Any(e => !movimentos.Contains(e.ToUpper())))
                throw new NoSuchStrategyError("Movimento inválido!");
        }
    }
}
