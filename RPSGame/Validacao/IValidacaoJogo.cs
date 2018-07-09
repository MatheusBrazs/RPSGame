using System;
using System.Collections.Generic;

namespace RPSGame.Validacao
{
    public interface IValidacaoJogo
    {
        void Validar(IList<Tuple<string, string>> elementosJogo);
    }
}