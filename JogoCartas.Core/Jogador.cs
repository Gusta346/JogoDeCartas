using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core
{
    public record Jogador
    {
        public string Nome { get; init; }
        public int Pontuacao { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
            Pontuacao = 0;
        }

        public void AdicionarPontos(int pontos)
        {
            Pontuacao += pontos;
        }
    }
}
