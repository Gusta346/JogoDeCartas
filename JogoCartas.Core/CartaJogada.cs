using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core
{
    public readonly record struct CartaJogada
    {
        public Jogador Jogador { get; }
        public CartaSorteada Carta {  get; }

        public CartaJogada(Jogador jogador, CartaSorteada carta)
        {
            Jogador = jogador;
            Carta = carta;
        }
    }
}
