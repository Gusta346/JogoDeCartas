using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JogoCartas.Core
{
    public record Partida
    {
        public IReadOnlyList<Jogador> Jogadores { get; init; }
        public IReadOnlyList<Rodada> Rodadas { get; init; }
        public int NumeroRodadaAtual { get; init; }

        public Partida(List<Jogador> jogadores)
        {
            Jogadores = jogadores;
            Rodadas = new List<Rodada>();
            NumeroRodadaAtual = 1;
        }

        private Partida(
            IReadOnlyList<Jogador> jogadores,
            IReadOnlyList<Rodada> rodadas,
            int numeroRodadaAtual)
        {
            Jogadores = jogadores;
            Rodadas = rodadas;
            NumeroRodadaAtual = numeroRodadaAtual;
        }

        public Partida JogarRodada(List<CartaJogada> jogadas)
        {
            var novaRodada = new Rodada(NumeroRodadaAtual, jogadas);

            var novasRodadas = Rodadas.ToList();
            novasRodadas.Add(novaRodada);

            var jogadoresAtualizados = AtualizarPontuacao(Jogadores.ToList(), novaRodada);

            return new Partida(
                jogadoresAtualizados,
                novasRodadas,
                NumeroRodadaAtual + 1
            );
        }

        private List<Jogador> AtualizarPontuacao(List<Jogador> jogadores, Rodada rodada)
        {
            if (rodada.Vencedor == null)
                return jogadores;

            return jogadores
                .Select(j =>
                {
                    if (j == rodada.Vencedor)
                    {
                        var novo = j with { };
                        novo.AdicionarPontos(1);
                        return novo;
                    }

                    return j;
                })
                .ToList();
        }
    }
}


