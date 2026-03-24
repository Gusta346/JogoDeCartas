namespace JogoCartas.Core
{
    public readonly struct CartaSorteada
    {
        public Naipe Naipe { get; }
        public NumeracaoCarta Valor { get; }

        public CartaSorteada(Naipe naipe, NumeracaoCarta valor)
        {
            Naipe = naipe;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Valor} de {Naipe}";
        }
    }
}
