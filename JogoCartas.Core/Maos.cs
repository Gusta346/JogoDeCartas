using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core
{
    public readonly record struct Maos
    {
        private readonly List<CartaSorteada> _cartas;

        public IReadOnlyList<CartaSorteada> Cartas => _cartas;

        public Maos(List<CartaSorteada> cartas)
        {
            _cartas = cartas ?? new List<CartaSorteada>();
        }

        public Maos AdicionarCarta(CartaSorteada carta)
        {
            var novasCartas = _cartas.ToList();
            novasCartas.Remove(carta);

            return new Maos(novasCartas);
        }

    }
}
