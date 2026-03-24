using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core
{
    public record Rodada
    {
        public int Numero { get; init; }
        public IReadOnlyList<CartaJogada> Jogadas { get; init; }
        public Jogador? Vencedor { get; init; }

        public Rodada(int numero, List<CartaJogada> jogadas)
        {
            Numero = numero;
            Jogadas = jogadas;
            Vencedor = DeterminarVencedor (jogadas);
        }

        private Jogador? DeterminarVencedor(List<CartaJogada> jogadas)
        {
            if (jogadas == null || jogadas.Count == 0)
                return null;

            var melhorJogada = jogadas
                .OrderByDescending(j => j.Carta.Valor)
                .First();

            return melhorJogada.Jogador;
        }
    }
}
