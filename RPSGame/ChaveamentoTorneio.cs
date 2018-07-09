using RPSGame.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPSGame
{
    public class ChaveamentoTorneio : IChaveamentoTorneio
    {
        private readonly IValidacaoJogo _validacaoJogo;
        private readonly IJogo _jogo;

        public ChaveamentoTorneio()
        {
            _jogo = new Jogo();
            _validacaoJogo = new ValidacaoJogo();
        }

        public Tuple<string,string> ObterVencedorChave(List<List<Tuple<string,string>>> chave)
        {
            var vencedoresChaveInterna = new List<Tuple<string,string>>();

            foreach (var chaveInterna in chave)
            {
                _validacaoJogo.Validar(chaveInterna);
                vencedoresChaveInterna.Add(_jogo.ObterVencedor(chaveInterna));
            }

            if (vencedoresChaveInterna.Count > 1)
                return ObterVencedorChave(GerarNovaChave(vencedoresChaveInterna));

            return vencedoresChaveInterna.First();
        }

        public List<List<Tuple<string,string>>> GerarNovaChave(List<Tuple<string,string>> vencedoresChaveInterna)
        {
            var chave = new List<List<Tuple<string,string>>>();

            for (int i = 0; i < vencedoresChaveInterna.Count; i = i + 2)
                chave.Add(new List<Tuple<string,string>> { vencedoresChaveInterna[i], vencedoresChaveInterna[i + 1] });

            return chave;
        }
    }
}
