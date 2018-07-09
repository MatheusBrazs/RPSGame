using RPSGame.Validacao;
using System;
using System.Collections.Generic;

namespace RPSGame
{
    public class Jogo : IJogo
    {
        private readonly IValidacaoJogo _validacaoJogo;

        public Jogo()
        {
            _validacaoJogo = new ValidacaoJogo();
        }

        public Tuple<string, string> RpsGameWinner(IList<Tuple<string, string>> elementosJogo)
        {
            _validacaoJogo.Validar(elementosJogo);

            return ObterVencedor(elementosJogo);
        }

        public Tuple<string,string> ObterVencedor(IList<Tuple<string, string>> elementosJogo)
        {
            var movimentoJogo1 = elementosJogo[0].Item2.ToUpper();
            var movimentoJogo2 = elementosJogo[1].Item2.ToUpper();
            var elementoVencedor = elementosJogo[0];

            if (movimentoJogo1.Equals(movimentoJogo2))
                return elementoVencedor;

            switch (movimentoJogo1)
            {
                case "P":
                    elementoVencedor = movimentoJogo2 == "R" ? elementosJogo[0] : elementosJogo[1];
                    break;
                case "R":
                    elementoVencedor = movimentoJogo2 == "S" ? elementosJogo[0] : elementosJogo[1];
                    break;
                case "S":
                    elementoVencedor = movimentoJogo2 == "P" ? elementosJogo[0] : elementosJogo[1];
                    break;
            }

            return elementoVencedor;
        }
    }
}
